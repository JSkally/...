using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Fuck_the_Weather
{
    public partial class Form3 : Form
    {

        public SmtpClient client = new SmtpClient();

        public MailMessage msg = new MailMessage();

        public System.Net.NetworkCredential smptCreds = new System.Net.NetworkCredential("liveinja@gmail.com", "not_passw0rd"); 


        public Form3()
        {
            InitializeComponent();
        }

        public void sendEmail(string sendTO, string sendFrom, string subject, string body)
        {

            try
            {

                // set up smtp host 

                client.Host = ("smtp.gmail.com") ; 
                client.Port = 587 ; 
                client.UseDefaultCredentials = false ;
                client.Credentials = smptCreds;
                client.EnableSsl = true; 

                // convert string to mail message 

                MailAddress to = new MailAddress(sendTO);
                MailAddress from = new MailAddress(sendFrom); 

                // Message settings 

                msg.To.Add("")
                msg.Subject = subject;
                msg.Body = body;
                msg.From = from;
                msg.To.Add(to); 

                // send email!!!!!

                client.Send(msg); 








            }

            catch(Exception ex ) 
            {

                MessageBox.Show(ex.Message ,  "error");


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            sendEmail("jason.mascott@gmail.com", "jason.mascott@gmail.com", "Hey this actualy works!!!", " :) ");


         
 
             
            
            
            Form4 f4 = new Form4();
            f4.Show();





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
