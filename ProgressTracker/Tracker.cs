using System.Diagnostics;

namespace ProgressTracker
{
    public class Tracker
    {
        public void WorkTime()
        {
            try
            {
                DateTime WorkTimeStart;
                WorkTimeStart = DateTime.Now;
                Console.WriteLine($"Time Now: {WorkTimeStart.ToLongTimeString()} \nPress any key to Continue");
                Console.ReadKey();

                Console.WriteLine("What do you want to do? ");
                var activity1 = Console.ReadLine();
                if (int.TryParse(activity1, out int option1))
                {
                    Console.WriteLine("Numerical inputs are not accepted!");
                    WorkTime();
                    
                }
                else
                {
                    Console.WriteLine("How many minutes do you want to {0}: ", activity1);
                    double Time = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Time is counting down for {Time} minutes....");

                    int ConvertToMillis = (int)Millis(Time);

                    Task.Delay(ConvertToMillis).Wait();
                    Console.Beep();

                    Console.WriteLine("\nTime for {0}ing has elasped", activity1);
                    DateTime WorkTimeEnd = DateTime.Now;
                    Console.WriteLine("{0}ing ended by {1} ", activity1, WorkTimeEnd.ToLongTimeString());

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}\nMethod: {e.TargetSite}\nCalls: {e.StackTrace}\nSource: {e.Source}");
            }
}

        public double Millis(double minutes)
        {
            double MinsToMillis = (minutes * 60000);

            return MinsToMillis;
        }

        public void RestTime()
        {
            try 
            {
            DateTime TimeRestStart = DateTime.Now;
            Console.WriteLine($"Time Now: {TimeRestStart.ToLongTimeString()}\nPress any key to Continue");
            Console.ReadKey();

            Console.WriteLine("What do you want to do? ");
            var activity2 = Console.ReadLine();

            if(int.TryParse (activity2, out int option2))
                {
                    Console.WriteLine("Numerical inputs are not accepted!");
                    RestTime();
                    
                }
                else
                {
                    Console.WriteLine("How many minutes do you want to {0}: ", activity2);
                    double Time2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Time is counting down for {Time2} minutes.....");

                    int ConvertToMillis2 = (int)Millis(Time2);

                    Task.Delay(ConvertToMillis2).Wait();
                    Console.Beep();

                    Console.WriteLine("\nTime for {0}ing has elasped", activity2);
                    DateTime RestTimeEnd = DateTime.Now;
                    Console.WriteLine("{0}ing ended by {1} ", activity2, RestTimeEnd.ToLongTimeString());
                }
            

            }
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}\nMethod: {e.TargetSite}\nCalls: {e.StackTrace}\nSource: {e.Source}");
            }

        }



        public void next()
        {
            try { 
            int sessions = 0;

            do
            {
                Console.WriteLine("Press any key to start");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("This is Progress tracker App!\nTo get Started, Enter START, to quit, Enter END");
                string programStart = Console.ReadLine().ToUpper();

                if (programStart == "START")
                {
                    WorkTime();
                    RestTime();
                    sessions++;
                    Console.WriteLine($"\nNumber of sessions: {sessions}");
                }
                else if (programStart == "END")
                {
                    Console.WriteLine("This is the end of this session. Thank You!");
                    break;
                }
                else
                {
                    Console.WriteLine("Pls enter START or END: ");

                }

            }

            while (true);


            }
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}\nMethod: {e.TargetSite}\nCalls: {e.StackTrace}\nSource: {e.Source}");
            }
        }

        public void StartTracker()
        {

            next();

        }

    }
            
}
