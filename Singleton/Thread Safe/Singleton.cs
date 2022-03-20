using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Thread_Safe
{
    public sealed class Singleton
    {
        private static Singleton _instance;

        private static readonly Object padlock = new object();

        //public static Singleton Instance { get { return _instance ?? (_instance = new Singleton()); } }

        //alternative method to create instance
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("inside get");
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if(_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        private Singleton()
        {
            Console.WriteLine("inside constructor");
        }
    }
}
