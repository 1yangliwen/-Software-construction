﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    //定义爬虫类
    class Crawler
    {
        //定义委托类型
        public event Action<Crawler, string> PageDownloaded;

        //定义哈希表存储URL及其状态
        public Hashtable urls = new Hashtable();
        private int count = 0;
        static public string startUrl = "";
        static public string startWith = "";

        //定义爬行方法
        public void Crawl()
        {
            //正则表达式匹配URL中的域名
            string str = @"(www\.){0,1}.*?\..*?/";
            Regex r = new Regex(str);
            Match m = r.Match(startUrl);
            startWith = m.Value;

            //循环爬行
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 20) break;
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                PageDownloaded(this, current);
                Parse(html, current);//解析,并加入新的链接
            }
        }

        //定义下载方法
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        //定义解析方法
        private void Parse(string html, string oldUrl)
        {
            //匹配不含相对路径,且包含html的网址
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'](http|https)[^""'#>]+..html.*?[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0)
                    continue;
                //仅包含起始网站上的网页
                if (url.Contains(startWith))
                {
                    if (urls[url] == null)
                        urls[url] = false;
                }
            }

            //匹配相对路径,且包含html的网址
            strRef = @"(href|HREF)[ ]*=[ ]*[""'][^(http|https)][^""'#>]+..html.*?[""']";
            matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                Uri baseUri = new Uri(oldUrl);
                Uri absoluteUri = new Uri(baseUri,url);
                Console.WriteLine("相对:" + url);
                Console.WriteLine("绝对:" + absoluteUri.ToString());
                if (urls[absoluteUri.ToString()] == null)
                    urls[absoluteUri.ToString()] = false;
            }
        }
    }
}

