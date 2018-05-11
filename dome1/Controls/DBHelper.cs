using dome1.Models;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using SQLite.Net.Attributes;

namespace dome1.controls
{
    public class DBHelper
    {
        //string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "mydb.sqlite");    //建立数据库  
        //SQLiteConnection conn;









        /*private static string DbFilename = "Dome1.db";
        private static string DBPath;
        public static string DbFilename1 { get => DbFilename; set => DbFilename = value; }
        


        public static void SetDBFilename(string Filename)
        {
            if (string.IsNullOrEmpty(Filename) && string.IsNullOrWhiteSpace(Filename))
            {
                throw new ArgumentException("操作数据库名称不合法");
            }
            else
            {
                DbFilename1 = Filename;
                DBPath = Path.Combine(ApplicationData.Current.LocalCacheFolder.Path, DbFilename1);
            }
        }
        ///
        /// 初始化数据库
        ///
        public static void InitDB(string DBFilename)
        {
            //数据库名
            SetDBFilename(DBFilename);
            //路径
            if (!File.Exists(DBPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), DBPath))
                {
                    conn.CreateTable<user>();//对应的是dome1.models中的user类；
                    List<user> l_user = new List<user>
                    {
                        new user()
                        {
                            Id = 1,
                            Username = "zhanglina",
                            Password = "123456"
                        }
                    };
                    InsertListuser(l_user);
                //调用插入操作
                }
            }
        }
        //返回所有用户
        public static List<user> GetUsers()
        {
            List<user> r;
            using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), DBPath))
            {
                r = conn.Table<user>().ToList<user>();
            }
            return r;

        }
        public static user GetUserById(int id)
        {
            user l;
            using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), DBPath))
            {
                try
                {
                    l = conn.Table<user>().Where(v => v.Id == id).ToList<user>()[0];
                }
                catch
                {
                    l = new user();
                }
            }
            return l;
        }
        public static int InsertOneUser(user user)
        {
            int result = -1;
            using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), DBPath))
            {
                result = conn.Insert(user);
            }
            return result;
        }
        public static int InsertListuser(List<user> users)
        {
            int result = -1;
            using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), DBPath))
            {
                result = conn.InsertAll(users);
            }
            return result;
        }*/








    }
}