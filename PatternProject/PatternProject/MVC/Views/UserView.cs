using System;
using System.Collections.Generic;
using System.Text;
using PatternProject.MVC.Controller;
using PatternProject.MVC.Models;

namespace PatternProject.MVC.Views
{
    public class UserView
    {
        private UserModel _userModel;
        private readonly UserController _userController;

        public UserView(UserController userController, UserModel userModel
        )
        {
            _userModel = userModel;
            _userModel.Register(this);
            _userController = userController;
            ShowUser();
        }

        public void OnForeNameUpdate(string newForeName)
        {
            _userController.ChangeForename(newForeName);
        }

        public void OnUpdateView()
        {
            Console.WriteLine("Something has changed in the model");
            _userModel = _userModel.GetUser();
            ShowUser();
        }

        private void ShowUser()
        {
            Console.WriteLine("New Model: ");
            Console.WriteLine(_userModel.GetForeName()); ;
        }
    }
}