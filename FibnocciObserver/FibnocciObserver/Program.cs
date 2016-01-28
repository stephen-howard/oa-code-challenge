using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibnocciObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            FibnocciGenerator.CreateFibnocci();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            for (sw.Start(); sw.Elapsed.Seconds < 600; sw.Elapsed.Add(new TimeSpan(00, 00, 01)))
            {
                long timeElapsed = (long)sw.Elapsed.TotalSeconds;
                if (FibnocciGenerator.GetFibnocciNumbers().Contains(timeElapsed))
                {
                    if (sw.Elapsed.TotalSeconds > 600)
                    {
                        sw.Stop();
                        break;
                    }
                    //Method 1
                    Console.WriteLine("");
                    // Create a reference to the delegate object
                    var fibnocciDelegate1 = new FibnocciDelegate();
                    var fibnocciDelegate2 = new FibnocciDelegate();
                    // Subscribe to the FibnocciTicker event
                    fibnocciDelegate1.FibnocciTicker += (s, e) => Console.WriteLine("Delegate 1 - " + "  Time Elapsed: " + timeElapsed + " - Fibnocci Hit..{0}, Time {1}",
                             e.FibnocciNumber, e.DateRecieved.TimeOfDay);
                    fibnocciDelegate2.FibnocciTicker += (s, e) => Console.WriteLine("Delegate 2 - " + "  Time Elapsed: " + timeElapsed + " - Fibnocci Hit..{0}, Time {1}",
                           e.FibnocciNumber, e.DateRecieved.TimeOfDay);
                    // An event has been triggered...
                    fibnocciDelegate1.SetFibnocci(new Fibnocci { FibnocciNumber = timeElapsed, DateRecieved = DateTime.Now });
                    fibnocciDelegate2.SetFibnocci(new Fibnocci { FibnocciNumber = timeElapsed, DateRecieved = DateTime.Now });

                    //Method 2
                    Console.WriteLine("");
                    Subject subject = new Subject();
                    // FibnocciObserver takes a subscription
                    FibnocciObserver observer1 = new FibnocciObserver("From Subscriber 1 - " + " : Time Elapsed " + timeElapsed);
                    FibnocciObserver observer2 = new FibnocciObserver("From Subscriber 2 - " + " : Time Elapsed " + timeElapsed);

                    subject.Subscribe(observer1);
                    subject.Subscribe(observer2);

                    // An event has been triggered...
                    subject.FibnocciHit++;

                    System.Threading.Thread.Sleep(1000);

                }
            }
            Console.ReadLine();
        }
    }
}
