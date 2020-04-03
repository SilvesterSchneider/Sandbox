using System;
using System.Collections.Generic;
using System.Text;
using PatternProject.MVC.Views;

namespace PatternProject.MVC.Models
{
    public class UserModel
    {
        private string _forename;

        private List<UserView> _views = new List<UserView>();

        public UserModel()
        {
            _forename = "Silvester";
        }

        public string GetForeName()
        {
            return _forename;
        }

        public void SetForename(string newForename
        )
        {
            _forename = newForename;
            Notify();
        }

        public void Notify()
        {
            foreach (var userView in _views)
            {
                userView.OnUpdateView();
            }
        }

        public void Register(UserView view)
        {
            _views.Add(view);
        }

        public UserModel GetUser()
        {
            return this;
        }
    }
}