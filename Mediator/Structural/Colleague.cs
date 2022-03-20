using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Structural
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        public Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

        public virtual void Send(string message)
        {
            this.Mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}
