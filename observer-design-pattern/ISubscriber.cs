using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_design_pattern
{
    public interface ISubscriber
    {
        void Alert(String message);
    }
}
