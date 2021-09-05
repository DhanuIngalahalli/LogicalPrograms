using System;

namespace StopWatch
{
    class Program
    {
        public class Stopwatches
        {
            public Stopwatches()
            {
                Stopwatch stopwatch = new Stopwatch();

            validation1:
                Console.WriteLine("To start the stopwatch enter S or s.");
                char start = Convert.ToChar(Console.ReadLine());
                stopwatch.Start();
                if (start == 's' || start == 'S')
                {
                validation2:
                    Console.WriteLine("To stop the stopwatch enter Q or q.");
                    char end = Convert.ToChar(Console.ReadLine());
                    if (end == 'q' || end == 'Q')
                    {
                        stopwatch.Stop();
                        Console.WriteLine("stopwatch stopped, the time:" + stopwatch.Elapsed);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                        goto validation2;
                    }
                }
                else
                {
                    stopwatch.Stop();
                    Console.WriteLine("Wrong Input");
                    goto validation1;
                }
            }
        }
    }


