namespace Observer_pattern
{
    public interface INewsPublisher
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void Notify();
    }
}
