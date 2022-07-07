

using System;

namespace InterviewQuestions
{
    /*
    Singleton design pattern in C# is one of the most popular design patterns. In this pattern, a class has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.
    */

    #region No Thread Safe SingleTon Design Pattern

    public sealed class SingletonClass
    {
        private SingletonClass()
        {

        }
        private static SingletonClass _instance = null;

        public static SingletonClass GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonClass();
                return _instance;
            }
        }
        public void GetMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    #endregion

    #region Thread Safety Singleton

    public sealed class ThreadSafeSingleton
    {
        ThreadSafeSingleton() { }
        private static readonly object l = new object();
        private static ThreadSafeSingleton instance = null;
        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (l)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }
    }

    #endregion

    #region Thread Safety Singleton using Double-Check Locking

    public sealed class Singleton3
    {
        Singleton3() { }
        private static readonly object l = new object ();  
        private static Singleton3 instance = null;
        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (l)
                        {
                            if (instance == null)
                            {
                                instance = new Singleton3();
                            }
                        }
                }
                return instance;
            }
        }
    }

    #endregion

    #region Thread Safe Singleton without using locks and no lazy instantiation
    public sealed class StaticInstanceSingleton
    {
        private static readonly StaticInstanceSingleton instance = new StaticInstanceSingleton();
        static StaticInstanceSingleton()
        {
        }
        private StaticInstanceSingleton()
        {
        }
        public static StaticInstanceSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
    #endregion
}
