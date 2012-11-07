using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LymeInJA;

namespace LymeInJA
{
	/// <summary>
	/// Interaction logic for Login.xaml
	/// </summary>
	public partial class Login : UserControl, ISwitchable
	{
		public Login()
		{
			this.InitializeComponent();
		}

		private void backButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Switcher.Switch1(new MainMenu());
		}

        #region ISwitchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        
        
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login Successful", "Welcome, " + usernameTextBox.Text);
            
            MainPage w1 = new MainPage();

            Window parent = Window.GetWindow(this);
            parent.Close();
                       
            w1.Show();


            
        
        }
    }
}