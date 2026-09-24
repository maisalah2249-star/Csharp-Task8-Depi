using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Task8_Depi
{
    class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        // Constructor: Hours, Minutes, Seconds
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }


        // Constructor: Total Seconds
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;

            int remainingSeconds = totalSeconds % 3600;

            Minutes = remainingSeconds / 60;

            Seconds = remainingSeconds % 60;
        }


        // ToString
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }

            return $"Minutes: {Minutes}, Seconds: {Seconds}";
        }


        // Equals
        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours &&
                       Minutes == other.Minutes &&
                       Seconds == other.Seconds;
            }

            return false;
        }


        // GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }


        // Duration + Duration
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds1 =
                d1.Hours * 3600 +
                d1.Minutes * 60 +
                d1.Seconds;

            int totalSeconds2 =
                d2.Hours * 3600 +
                d2.Minutes * 60 +
                d2.Seconds;

            return new Duration(totalSeconds1 + totalSeconds2);
        }


        // Duration + Seconds
        public static Duration operator +(Duration d, int seconds)
        {
            int totalSeconds =
                d.Hours * 3600 +
                d.Minutes * 60 +
                d.Seconds;

            return new Duration(totalSeconds + seconds);
        }


        // Seconds + Duration
        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }


        // ++ Increase One Minute
        public static Duration operator ++(Duration d)
        {
            return new Duration(
                d.Hours,
                d.Minutes + 1,
                d.Seconds
            );
        }


        // -- Decrease One Minute
        public static Duration operator --(Duration d)
        {
            int totalSeconds =
                d.Hours * 3600 +
                d.Minutes * 60 +
                d.Seconds;

            totalSeconds -= 60;

            if (totalSeconds < 0)
            {
                totalSeconds = 0;
            }

            return new Duration(totalSeconds);
        }


        // Duration - Duration
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 =
                d1.Hours * 3600 +
                d1.Minutes * 60 +
                d1.Seconds;

            int totalSeconds2 =
                d2.Hours * 3600 +
                d2.Minutes * 60 +
                d2.Seconds;

            int result = totalSeconds1 - totalSeconds2;

            if (result < 0)
            {
                result = 0;
            }

            return new Duration(result);
        }


        // >
        public static bool operator >(Duration d1, Duration d2)
        {
            int totalSeconds1 =
                d1.Hours * 3600 +
                d1.Minutes * 60 +
                d1.Seconds;

            int totalSeconds2 =
                d2.Hours * 3600 +
                d2.Minutes * 60 +
                d2.Seconds;

            return totalSeconds1 > totalSeconds2;
        }


        // <
        public static bool operator <(Duration d1, Duration d2)
        {
            int totalSeconds1 =
                d1.Hours * 3600 +
                d1.Minutes * 60 +
                d1.Seconds;

            int totalSeconds2 =
                d2.Hours * 3600 +
                d2.Minutes * 60 +
                d2.Seconds;

            return totalSeconds1 < totalSeconds2;
        }


        // <=
        public static bool operator <=(Duration d1, Duration d2)
        {
            int totalSeconds1 =
                d1.Hours * 3600 +
                d1.Minutes * 60 +
                d1.Seconds;

            int totalSeconds2 =
                d2.Hours * 3600 +
                d2.Minutes * 60 +
                d2.Seconds;

            return totalSeconds1 <= totalSeconds2;
        }


        // >=
        public static bool operator >=(Duration d1, Duration d2)
        {
            int totalSeconds1 =
                d1.Hours * 3600 +
                d1.Minutes * 60 +
                d1.Seconds;

            int totalSeconds2 =
                d2.Hours * 3600 +
                d2.Minutes * 60 +
                d2.Seconds;

            return totalSeconds1 >= totalSeconds2;
        }


        // true
        public static bool operator true(Duration d)
        {
            return d.Hours != 0 ||
                   d.Minutes != 0 ||
                   d.Seconds != 0;
        }


        // false
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 &&
                   d.Minutes == 0 &&
                   d.Seconds == 0;
        }
    }
}

