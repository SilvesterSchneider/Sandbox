using System;
using System.Collections.Generic;
using System.Text;
using PatternProject.MVC.Models;

namespace PatternProject.MVC.Controller
{
    public class UserController
    {
        private readonly UserModel _userModel;

        public UserController(UserModel userModel)
        {
            _userModel = userModel;
        }

        public void ChangeForename(string newForeName)
        {
            _userModel.SetForename(newForeName);
        }
    }
}