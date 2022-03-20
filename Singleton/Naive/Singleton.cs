using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Naive
{
    public sealed class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance { get { return _instance ?? (_instance = new Singleton()); } }

        //alternative method to create instance
        //public static Singleton Instance
        //{
        //    get {
        //        if (_instance == null)
        //        {
        //            _instance = new Singleton();
        //        }
        //        return _instance;
        //    }
        //}

        private Singleton()
        {
           
        }
    }
}
