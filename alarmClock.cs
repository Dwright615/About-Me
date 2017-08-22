// Author: David Wright
// Alarm Clock
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_Clock
{
    class Program
    {
        static void Main(string[] args)
        {

            AlarmClock clock1 = new AlarmClock();
            AlarmClock clock2 = new AlarmClock();
            

            // Set Alarm
            clock1.setAlarmClock(9, 50, "PM");
            clock2.setAlarmClock(6, 00, "AM");

            // Display the clocks
            clock1.displayClock();
            clock2.displayClock();

            Console.ReadLine();

        }

        class AlarmClock
        {
            private int alarmHour { get; set; }
            private int alarmMinute { get; set; }
            private string meridian { get; set; }
            private DateTime currentTime = DateTime.Now;
         //   private DateTime alarmTime = new DateTime(9,50,00);    
       
            public void setAlarmClock(int h, int m, string mer)
            {
                alarmHour = h;
                alarmMinute = m;
                meridian = mer;
            }

            public void displayClock()
            {
                Console.WriteLine("Time now is: {0}", currentTime.ToShortTimeString());
                Console.WriteLine("Alarm is set: {0}:{1} {2}",alarmHour,alarmMinute.ToString("D2"), meridian);
                if (meridian == "PM")
                    alarmHour += 12;
                if (alarmMinute == 00)
                    alarmMinute = 60;
                Console.WriteLine("Alarm set for {0} hours and {1} minutes from now.",Math.Abs(alarmHour - currentTime.Hour), Math.Abs(alarmMinute - currentTime.Minute));
                Console.WriteLine(" ");
            }
             
        }
    }
}
