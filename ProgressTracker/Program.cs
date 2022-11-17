using System;
using System.Timers;

namespace ProgressTracker
{
    public class Tracker
    {


        private static System.Timers.Timer timer;

        public static void Main()
        {
            Tracker tracker = new Tracker();
          
            Console.Write("Enter work time in minutes : ");
            int workingTime = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter rest time in minutes : ");
            int restingTime = Convert.ToInt32(Console.ReadLine());

            displayWorkTime(workingTime);
            RestTime(restingTime);
            Console.ReadLine();


            static void displayWorkTime(int workTime)
            {
                
                timer = new System.Timers.Timer(workTime * 60000);
                Console.WriteLine("Work time started {0:HH:mm:ss}", DateTime.Now, workTime);

                
                timer.Elapsed += Work;
                timer.AutoReset = false;
                timer.Enabled = true;
            }

            static void RestTime(int restTime)
            {
                
                timer = new System.Timers.Timer(restTime * 60000);
                Console.WriteLine("Rest time started {0:HH:mm:ss}", DateTime.Now, restTime);

                
                timer.Elapsed += Rest;
                timer.AutoReset = false;
                timer.Enabled = true;
            }

            static void Work(Object source, ElapsedEventArgs e)
            {
                Console.Write("");
            }

            static void Rest(Object source, ElapsedEventArgs e)
            {
                Console.Write("");
            }

        }
    }



}