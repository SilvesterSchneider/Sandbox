using System;
using PatternProject.MVC;
using PatternProject.MVC.Controller;
using PatternProject.MVC.Models;
using PatternProject.MVC.Views;
using PatternProject.Observer;
using PatternProject.Singleton;

namespace PatternProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // DoSingletonPattern();

            // DoObserverPattern();

            // DoMVCPattern();

            DoMVCPatternExecise();
        }

        private static void DoMVCPatternExecise()
        {
            Console.WriteLine("#####################################################");
            Console.WriteLine("Start MVC Pattern");
            Console.WriteLine();

            var controller = new BenutzerController(new BenutzerManager());

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                var readLine = Console.ReadLine();
                Console.WriteLine();
                controller.GetView().OnEvent();
            }

            Console.WriteLine();
            Console.WriteLine("End MVC Pattern");
        }

        private static void DoMVCPattern()
        {
            Console.WriteLine("#####################################################");
            Console.WriteLine("Start MVC Pattern");
            Console.WriteLine();
            var model = new UserModel();

            var controller = new UserController(model);
            var view = new UserView(controller, model);

            Console.WriteLine("Press ESC to stop");

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                var readLine = Console.ReadLine();
                Console.WriteLine();
                if (readLine == "u")
                {
                    Console.WriteLine("enter new name");
                    var line = Console.ReadLine();
                    view.OnForeNameUpdate(line);
                }
            }

            view.OnForeNameUpdate("Silva");

            Console.WriteLine();
            Console.WriteLine("End MVC Pattern");
        }

        private static void DoObserverPattern()
        {
            Console.WriteLine("#####################################################");
            Console.WriteLine("Start Observer Pattern");
            Console.WriteLine();

            Netflix theNetflix = new Netflix();

            Watcher coachPotato1 = new Watcher(theNetflix, "hans");
            Watcher coachPotato2 = new Watcher(theNetflix, "eva");

            Watcher coachPotato3 = new Watcher(theNetflix, "egon");
            Watcher test = new Watcher();

            theNetflix.Remove(test);

            theNetflix.SetOffer("Braking Bad");

            coachPotato1.Die();

            theNetflix.SetOffer("Star Wars");

            Console.WriteLine();
            Console.WriteLine("End Observer Pattern");
        }

        private static void DoSingletonPattern()
        {
            Console.WriteLine("#####################################################");
            Console.WriteLine("Start Singleton Pattern");
            Console.WriteLine();

            MyWareHouseSingleton myWareHouse = MyWareHouseSingleton.GetInstance();
            myWareHouse.DecreaseToiletPaper();

            myWareHouse.IncreaseToiletPaper();
            myWareHouse.IncreaseToiletPaper();
            myWareHouse.IncreaseToiletPaper();

            myWareHouse.LogToiletPaper();

            MyWareHouseSingleton myWareHouse2 = MyWareHouseSingleton.GetInstance();
            myWareHouse2.IncreaseToiletPaper();
            myWareHouse2.IncreaseToiletPaper();
            myWareHouse2.IncreaseToiletPaper();
            myWareHouse2.IncreaseToiletPaper();

            myWareHouse.LogToiletPaper();

            Console.WriteLine();
            Console.WriteLine("End Singleton Pattern");
        }
    }
}