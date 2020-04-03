using System.Collections.Generic;

namespace PatternProject.Observer
{
    public class Netflix : ISubject
    {
        private List<IObserver> _observers;
        private string _offer;

        public Netflix()
        {
            _observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
            if (!string.IsNullOrEmpty(_offer))
            {
                observer.Refresh(_offer);
            }
        }

        public void Remove(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Refresh(_offer);
            }
        }

        public void SetOffer(string offer)
        {
            _offer = offer;
            Notify();
        }
    }
}