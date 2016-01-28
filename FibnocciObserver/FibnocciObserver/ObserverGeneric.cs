using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibnocciObserver
{
    interface IObserver
    {
        void Update();
    }

    public class FibnocciObserver : IObserver
    {
        public string ObserverName { get; private set; }
        public FibnocciObserver(string name)
        {
            this.ObserverName = name;
        }
        public void Update()
        {
            Console.WriteLine("{0}: A new fibnocci has been hit......", this.ObserverName);
        }
    }

    interface ISubject
    {
        void Subscribe(FibnocciObserver observer);
        void Unsubscribe(FibnocciObserver observer);
        void Notify();
    }
    public class Subject : ISubject
    {
        private List<FibnocciObserver> observers = new List<FibnocciObserver>();
        private int _int;
        public int FibnocciHit
        {
            get
            {
                return _int;
            }
            set
            {
                // Just to make sure that if there is an increase in inventory then only we are notifying   the observers.
                if (value > _int)
                    Notify();
                _int = value;
            }
        }
        public void Subscribe(FibnocciObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(FibnocciObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }
    }

}
