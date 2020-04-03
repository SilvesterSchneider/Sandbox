using System;
using PatternProject.MVC.Controller;
using PatternProject.MVC.Models;

namespace PatternProject.MVC.Views
{
    public class BenutzerView
    {
        private readonly BenutzerManager _benutzerManager;
        private BenutzerModel _model;
        private readonly BenutzerController _benutzerController;

        public BenutzerView(BenutzerManager benutzerManager, BenutzerController controller)
        {
            _benutzerController = controller;
            _benutzerManager = benutzerManager;
            _benutzerManager.GetSignedInUser().Register(this);
        }

        public void OnEvent()
        {
            _benutzerController.DoSomething();
        }

        public void Update()
        {
            Console.WriteLine("Model has updated");
            _model = _benutzerManager.GetSignedInUser();
            Console.WriteLine(_model.CallMeByMyName());
        }
    }
}