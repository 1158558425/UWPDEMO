using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using dome1.Models;
using dome1.controls;
using Windows.UI.Popups;
// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace dome1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class RegisterPage : Page
    {
        string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "my.sqlite");    //建立数据库  
        SQLiteConnection conn;
        public RegisterPage()
        {
            this.InitializeComponent();
            conn = new SQLiteConnection(new SQLitePlatformWinRT(), path);
            //建表    
            conn.CreateTable<user>(); //默认表名同范型参数    
            //以下等效上面的建表    
        }

        private  void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            
            //string userid = id.Text;
            //string userpassword = password.Password;
            conn.Insert(new user() { Username = id.Text, Password = password.Password });
            var dialog = new MessageDialog("注册成功！", "提示");
            dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
            dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));
            //设置默认按钮，不设置的话默认的确认按钮是第一个按钮
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;
            var result = await dialog.ShowAsync();


        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                id.Text = $"{e.Parameter.ToString()}";
            }

            base.OnNavigatedTo(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
       

    }
}
