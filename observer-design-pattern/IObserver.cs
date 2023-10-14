using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_design_pattern
{
    public interface IObserver
    {
        void Subscribe(ISubscriber subscriber);

        void Unsubscribe(ISubscriber subscriber);

        void Notify();
    }
}
