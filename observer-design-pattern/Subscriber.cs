using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_design_pattern
{
    public class Subscriber : ISubscriber
    {
        public void Alert(String message)
        {
            Console.WriteLine(message);
        }
    }
}
