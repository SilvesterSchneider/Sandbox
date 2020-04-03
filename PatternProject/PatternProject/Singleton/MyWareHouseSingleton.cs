using System;

namespace PatternProject.Singleton
{
    public class MyWareHouseSingleton
    {
        private static MyWareHouseSingleton Instance { get; set; }
        private int _toiletPaper;

        private MyWareHouseSingleton()
        {
            _toiletPaper = 0;
        }

        public static MyWareHouseSingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new MyWareHouseSingleton();
            }

            return Instance;
        }

        public void IncreaseToiletPaper()
        {
            _toiletPaper += 1;
        }

        public void DecreaseToiletPaper()
        {
            if (_toiletPaper > 0)
            {
                _toiletPaper -= 1;
            }
            else
            {
                Console.WriteLine("Sorry no toilet paper");
            }
        }

        public void LogToiletPaper()
        {
            Console.WriteLine(_toiletPaper);
        }
    }
}