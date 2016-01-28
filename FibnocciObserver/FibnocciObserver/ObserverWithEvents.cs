using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibnocciObserver
{
    class Observable
    {
        public event EventHandler SomethingHappened;

        public void DoSomething()
        {
            EventHandler handler = SomethingHappened;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }

    class Observer
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Fibnocci Hit... " + sender);
        }
    }
    public class FibnocciDelegate
    {
        public event EventHandler<FibnocciEventArgs> FibnocciTicker;

        protected virtual void OnNewFibnocci(long fibnocciNumber, DateTime dateRecieved)
        {
            if (FibnocciTicker != null)
            {
                FibnocciTicker(this, new FibnocciEventArgs(fibnocciNumber, dateRecieved));
            }
        }

        public void SetFibnocci(Fibnocci fibnocci)
        {
            OnNewFibnocci(fibnocci.FibnocciNumber, fibnocci.DateRecieved);
        }
    }


    public class FibnocciEventArgs : EventArgs
    {
        public FibnocciEventArgs(long fibnocciNumber, DateTime dateRecieved)
        {
            this.FibnocciNumber = fibnocciNumber;
            this.DateRecieved = dateRecieved;
        }

        public DateTime DateRecieved { get; set; }
        public long FibnocciNumber { get; set; }
    }

    public class Fibnocci
    {

        public long FibnocciNumber { get; set; }
        public DateTime DateRecieved { get; set; }
    }
}
