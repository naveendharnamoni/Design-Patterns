using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Lazy
{
    public sealed class Singleton
    {
        private static Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return _lazy.Value;
            }
        }

        private Singleton()
        {

        }
    }
}
