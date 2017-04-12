﻿namespace TestProject
{
    public class ProjectTest
    {
        private Bridge bridge;

        public ProjectTest()
        {
            this.bridge = Driver.getBridge();
          
        }
        public object register(string username, string password)
        {
           return  this.bridge.register(username,password);
        }
        public object login(string username, string password)
        {
           return this.bridge.login(username, password);
        }
        public object getUserbyName(string username)
        {
            return this.bridge.getUserbyName(username);
        }
        public bool isUserExist(string username, string password)
        {
            return this.isUserExist(username, password);
        }
        public bool checkActiveGame(string statusGame)
        {
            return this.checkActiveGame(statusGame);
        }
        public bool logoutUser(string game, string user)
        {
            return this.logoutUser(game, user);
        }
        public object editProfile(string username)
        {
            return this.editProfile(username);
        }
        public bool editImage(string img)
        {
            return this.editImage(img);
        }
        public bool editName(string name)
        {
            return this.editName(name);
        }
        public bool editEmail(string email)
        {
            return this.editEmail(email);
        }




    }

}