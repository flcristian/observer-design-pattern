namespace observer_design_pattern
{
    public class Publisher : IObserver
    {
        private List<ISubscriber> _subscribers;

        #region CONSTRUCTORS

        public Publisher()
        {
            _subscribers = new List<ISubscriber>(); 
        }

        public Publisher(List<ISubscriber> subscribers)
        {
            _subscribers = subscribers;
        }

        #endregion

        public List<ISubscriber> Subscribers
        {
            get { return _subscribers; }
            set { _subscribers = value; }
        }

        public void Notify()
        {
            foreach(ISubscriber subscriber in _subscribers)
            {
                subscriber.Alert("You just got a new message!");
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }
}
