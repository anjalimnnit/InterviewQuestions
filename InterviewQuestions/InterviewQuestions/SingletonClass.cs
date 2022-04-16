

using System;

namespace InterviewQuestions
{
    public sealed class SingletonClass
    {
        private SingletonClass()
        {

        }
        private static SingletonClass _instance = null;

        public static SingletonClass GetInstance
        {
            get {
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
}
