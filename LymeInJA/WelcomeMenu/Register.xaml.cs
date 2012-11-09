using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
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

namespace LymeInJA
{
	/// <summary>
	/// Interaction logic for Register.xaml
	/// </summary>
	public partial class Register : UserControl
	{
		public Register()
		{
			this.InitializeComponent();
		}

		private void backButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Switcher.Switch2(new Login());
		}

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            var usrEmail = eBox.Text;
            var usrName = usrBox.Text;
            var usrPassword = pwBox.Password;

            try
            {

                MailMessage mail = new MailMessage();

              SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");



            mail.From = new MailAddress("lymeinja@gmail.com");

                mail.To.Add(usrEmail);

                mail.Subject = "Welcome to LymeInJA";

                mail.Body = "You have been successfully registered. Your username is '" + usrName +"' and your password is '" + usrPassword + "' \r\n \r\n" +
                    "We hope you enjoy it";



              SmtpServer.Port = 587;

            SmtpServer.Credentials = new System.Net.NetworkCredential("lymeinja", "not_passw0rd");

            SmtpServer.EnableSsl = true;



            SmtpServer.Send(mail);

            MessageBox.Show(usrName + "," + usrPassword + "," + usrEmail);

            }

            catch (Exception ex)
            {

                            MessageBox.Show(ex.ToString());

                      }
        }
	}
}