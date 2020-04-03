using System;

namespace PatternProject.Observer
{
    internal class Watcher : IObserver
    {
        private ISubject _subject;
        private string _name;

        public Watcher()
        {
        }

        public Watcher(ISubject subject, string name)
        {
            _subject = subject;
            _name = name;
            _subject.Register(this);
        }

        public void Refresh(string offer)
        {
            Console.WriteLine(_name + " : I wanna watch " + offer);
        }

        public void Die()
        {
            _subject.Remove(this);
        }
    }
}