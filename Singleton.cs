using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    internal class Singleton
    {
        private static Singleton instance;
        int Id = 0;

        private Singleton()
        {
            Id = new Random().Next(1, 100);
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public override string? ToString()
        {
            return base.ToString() + Id;
        }
    }
}
