using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PatternProject.MVC.Views;

namespace PatternProject.MVC.Models
{
    public class BenutzerModel
    {
        private string _forename;
        private int counter = 0;
        private List<BenutzerView> _views = new List<BenutzerView>();

        public BenutzerModel()
        {
            _forename = "Silvester";
        }

        public void Register(BenutzerView view)
        {
            _views.Add(view);
        }

        public void OnUpdate()
        {
            counter += 1;
            _forename += counter;
            Notify();
        }

        public string CallMeByMyName()
        {
            return _forename;
        }

        public void UnRegister(BenutzerView view)
        {
            if (_views.Contains(view))
            {
                _views.Remove(view);
            }
        }

        public void Notify()
        {
            foreach (var view in _views)
            {
                view.Update();
            }
        }
    }
}