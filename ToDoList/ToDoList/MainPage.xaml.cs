using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Application.Current.UserAppTheme = OSAppTheme.Light;
        }

        private void ibtnThemeSwitcher_Clicked(object sender, EventArgs e)
        {

        }

        private void btnNewTask_Clicked(object sender, EventArgs e)
        {

        }
    }
}
