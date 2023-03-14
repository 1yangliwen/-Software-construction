using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clock
{
    public delegate void ClockHandler(object sender, Time now);
    public class Time
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public Time (int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
    public class Clock
    {   
        Time time = new Time(0, 0, 0);
        public event ClockHandler  TimePass;
        public void ClockRun() { 
            for (; time.hour < 24; time.hour++)
            {
                for (time.minute = 0; time.minute < 60; time.minute = time.minute + 30)
                {   
                    for (time.second = 0; time.second < 60; time.second++)
                    {
                       
                    }
                    TimePass(this, time);
                }
                TimePass(this, time);
            }
        }
    }
    public class Simulation
    {
        public Clock alarm = new Clock();
        public void RunTime()
        {
            alarm.TimePass += new ClockHandler(AlarmRing);
        }
        public void StopTime() { }
        void AlarmRing(object sender, Time now) {
            if (now.hour == 12)
            {
                Console.WriteLine("clock alarm: it's 12:00 now !");
            }
            Console.WriteLine("TICK");
        }
    }
    public class program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.RunTime();
            simulation.alarm.ClockRun();
        }
    }
}
