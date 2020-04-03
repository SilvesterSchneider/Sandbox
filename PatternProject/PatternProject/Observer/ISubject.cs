namespace PatternProject.Observer
{
    public interface ISubject
    {
        public void Register(IObserver observer);

        public void Remove(IObserver observer);

        public void Notify();
    }
}