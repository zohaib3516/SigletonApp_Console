using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    sealed class Singleton
    {
        //private static int counter = 0;

        private static Singleton instance = null;
        
        //private constructor because no direct insance can be created
        private Singleton()
        {
            //counter++;
        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        //public void Print(string message)
        //{
        //    Console.WriteLine(counter + " : " + message);
        //}
    }
}
