using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Media;

namespace ProgressTracker
{
    public class Tracker
    {
        
        public Tracker() 
        { 
        
        }
        static void Main(string[] args)
        {   
                Console.WriteLine("Hours or Minutes or Seconds?");
               string _userInput = Console.ReadLine().ToLower().Trim();

            if (_userInput == "seconds") 
            {
                Console.WriteLine("You choosed Seconds, how many seconds?");
                var noOfSeconds = Console.ReadLine(); 

                for (int i = Convert.ToInt32(noOfSeconds); i > 0; i--) 
                { 
                    Thread.Sleep(1000);
                }
                 
            }
            else
            {
                Console.WriteLine("Try again later!");
            }

            Console.Read();
        }

        public static void Beep() 
        { 
            while(true) 
            {

                Console.WriteLine("Successful!");
            }
        }
    }
    
}