namespace ProgressTracker
{
    public class Tracker
    {
        private DateTime WorkTimeStart;
        private string? activity1;

        
        public void WorkTime()
        {
            try {

            WorkTimeStart = DateTime.Now;
            Console.WriteLine("Time Now: ");
            Console.WriteLine(WorkTimeStart);
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();

            Console.WriteLine("What do you want to do? ");
            activity1 = Console.ReadLine();

            Console.WriteLine("\nHow many minutes do you want to {0}: ", activity1);
            double Time = Convert.ToDouble(Console.ReadLine());

            int ConvertToMillis = (int)Millis(Time);

            Thread.Sleep(ConvertToMillis);
            Console.Beep();

            Console.WriteLine("\nTime for {0} has elasped", activity1);
            DateTime WorkTimeEnd = DateTime.Now;
            Console.WriteLine("{0} ended by {1} ", activity1, WorkTimeEnd);

        }
        catch (Exception e){
        Console.WriteLine("Message: {0}",e.Message);
        Console.WriteLine("Method: {0}", e.TargetSite);
        Console.WriteLine("Calls: {0}", e.StackTrace);
        Console.WriteLine("Source: {0}", e.Source);
        Console.WriteLine("Previous exception: {0}", e.InnerException);
            }
}

        public double Millis(double minutes)
        {
            double MinsToMillis = (minutes * 60000);

            return MinsToMillis;
        }

        public void RestTime()
        {
            try { 
            Console.WriteLine("Time Now:");
            DateTime TimeRestStart = DateTime.Now;
            Console.WriteLine(TimeRestStart);

            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();

            Console.WriteLine("What do you want to do? ");
            string? activity2 = Console.ReadLine();

            Console.WriteLine("\nHow many minutes do you want to {0}: ", activity2);
            double Time2 = Convert.ToDouble(Console.ReadLine());

            int ConvertToMillis2 = (int)Millis(Time2);

            Thread.Sleep(ConvertToMillis2);
            Console.Beep();

            Console.WriteLine("\nTime for {0} has elasped", activity2);
            DateTime RestTimeEnd = DateTime.Now;
            Console.WriteLine("{0} ended by {1} ", activity2, RestTimeEnd);

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Calls: {0}", e.StackTrace);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Previous exception: {0}", e.InnerException);
            }

        }



        public void next()
        {
            try { 
            int sessions = 0;

            do
            {
                Console.WriteLine("This is Progress tracker App!");
                Console.WriteLine("To get Started, Enter START, to quit, Enter END ");
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
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Calls: {0}", e.StackTrace);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Previous exception: {0}", e.InnerException);
            }
        }

        public void StartTracker()
        {

            next();

        }

    }
            
}
