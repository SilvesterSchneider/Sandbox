using System;
using PatternProject.MVC.Models;

namespace PatternProject.MVC
{
    public class BenutzerManager
    {
        private BenutzerModel _angemeldeterBenutzer;

        public BenutzerModel GetSignedInUser()
        {
            return _angemeldeterBenutzer;
        }

        public void SignIn(BenutzerModel benutzerModel)
        {
            _angemeldeterBenutzer = benutzerModel;
        }

        public void DoSomething()
        {
            Console.WriteLine("update model");
            _angemeldeterBenutzer.OnUpdate();
        }
    }
}