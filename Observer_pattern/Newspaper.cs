using System.Collections.Generic;

namespace Observer_pattern
{
    internal class Newspaper : INewsPublisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        private double _currentrating;

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Publish(double rating)
        {
            _currentrating = rating;
            Console.WriteLine($"\nNewspapper posted new rating: {rating:F2}");
            Notify();
        }

        public void Notify()
        {
            foreach(ISubscriber subscriber in _subscribers)
            {
                subscriber.Update(_currentrating);
            }
        }

    }
}
