using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.Thread_Safe.Singleton.Instance.ToString();

        }
    }
}
