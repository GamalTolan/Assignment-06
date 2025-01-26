using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    public abstract class Duration
    {
        public abstract int Hours { get; set; }
        public abstract int Minutes { get; set; }
        public abstract int Seconds { get; set; }

        public abstract void TheTime();

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            return $"Seconds: {Seconds}";
        }


        public class Time : Duration
        {
            public override int Hours { get; set; }
            public override int Minutes { get; set; }
            public override int Seconds { get; set; }

            public Time(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public Time(int Seconds)
            {
                Hours = Seconds / 3600;
                Minutes = (Seconds % 3600) / 60;
                Seconds = Seconds % 60;
            }
            public override void TheTime()
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
                Hours += Minutes / 60;
                Minutes %= 60;
            }

            public static Time operator +(Time t1, Time t2)
            {
                return new Time ( t1.Hours + t2.Hours, t1.Minutes + t2.Minutes, t1.Seconds + t2.Seconds );
            }

            public static Time operator +(Time t, int Seconds)
            {
               return new Time(t.Hours*3600+ t.Minutes*60+ t.Seconds + Seconds);
            }

            public static Time operator +(int Seconds, Time t)
            {
                return new Time(t.Hours * 3600 + t.Minutes * 60 + t.Seconds + Seconds);
            }

            public static Time operator ++(Time t)
            {
                return new Time(t.Hours, t.Minutes + 1, t.Seconds );
            }

            public static Time operator --(Time t)
            {
                return new Time(t.Hours, t.Minutes - 1, t.Seconds);
            }

            public static Time operator -(Time t1, Time t2)
            {
                return new Time(t1.Hours - t2.Hours, t1.Minutes - t2.Minutes, t1.Seconds - t2.Seconds);
            }

            public static bool operator > (Time t1, Time t2)
            {
                if (t1.Hours > t2.Hours)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes > t2.Minutes)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds > t2.Seconds)
                    return true;
                else
                return false;
            }

            public static bool operator <(Time t1, Time t2)
            {
                if (t1.Hours < t2.Hours)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes < t2.Minutes)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds < t2.Seconds)
                    return true;
                else
                    return false;
            }

            public static bool operator <=(Time t1, Time t2)
            {
                if (t1.Hours < t2.Hours)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes < t2.Minutes)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds < t2.Seconds)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds == t2.Seconds)
                    return true;
                else
                    return false;
            }

            public static bool operator >=(Time t1, Time t2)
            {
                if (t1.Hours > t2.Hours)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes > t2.Minutes)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds > t2.Seconds)
                    return true;
                else if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds == t2.Seconds)
                    return true;
                else
                    return false;
            }

            
        }
    }

    
}
