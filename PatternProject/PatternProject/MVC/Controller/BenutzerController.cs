using System;
using System.Collections.Generic;
using System.Text;
using PatternProject.MVC.Models;
using PatternProject.MVC.Views;

namespace PatternProject.MVC.Controller
{
    public class BenutzerController
    {
        private BenutzerView view;
        private BenutzerManager _benutzerManager;

        public BenutzerController(BenutzerManager benutzerManager)
        {
            _benutzerManager = benutzerManager;
            var model = new BenutzerModel();
            benutzerManager.SignIn(model);

            view = new BenutzerView(benutzerManager, this);
        }

        public BenutzerView GetView()
        {
            return view;
        }

        public void DoSomething()
        {
            _benutzerManager.DoSomething();
        }
    }
}