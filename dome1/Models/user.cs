using SQLite.Net.Attributes;
using System;
namespace dome1.Models
{
    [Table("user")]
    public class user
    {
        private int id;
        private string username;
        private string password;
        [PrimaryKey,AutoIncrement]
        public int Id { get => id; set => id = value; }
        public string Username
        {
            get => username;
            set{username = value;}
        }
        public string Password
        {
            get => password;
            set { password= value; }
        }

    }
}