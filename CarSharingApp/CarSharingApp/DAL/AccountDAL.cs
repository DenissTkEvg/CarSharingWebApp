using CarSharingApp.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingApp.DAL
{
    public static class AccountDAL
    {
        public static bool CheckUser(string login, string password)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string pass = Convert.ToBase64String(hash);

            User existing_user = null;

            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                var users = db.GetCollection<User>("users");
                var users_list = users.FindAll().ToList();
                existing_user = users_list.FirstOrDefault(u=>u.Login.ToUpper()==login.ToUpper() && u.Password==pass);
            }
            if (existing_user != null)
            {
                return true;
            }
            else return false;
        }
        public static bool CheckAdminLoginIsExist(string login)
        {
            User existing_user = null;

            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                var users = db.GetCollection<User>("users");
                var users_list = users.FindAll().ToList();
                existing_user = users_list.FirstOrDefault(u => u.Login.ToUpper() == login.ToUpper());
            }
            if (existing_user != null)
            {
                return true;
            }
            else return false;
        }
        public static void AddNewUser(LoginModel model)
        {
            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                byte[] encodedPassword = new UTF8Encoding().GetBytes(model.Password);
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                string hash_pass = Convert.ToBase64String(hash);

                var users = db.GetCollection<User>("users");
                var users_lst = users.FindAll().ToList();
                int new_user_id = users_lst.Max<User>(user => user.Id)+1;

                User new_user = new User {
                    Id = new_user_id,
                    Full_name = model.Full_name,
                    Login = model.Login,
                    Password = hash_pass,
                    Email = model.Login,
                    PhoneNumber = model.Phone,
                    IsAdmin = 0
                };
                users.Insert(new_user);
            }
        }
    }
}
