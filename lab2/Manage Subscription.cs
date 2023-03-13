using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Manage : Form
    {
        private List<SendViaEmail> subscribedEmails = new List<SendViaEmail>();
        private List<SendViaMobile> subscribedMobiles = new List<SendViaMobile>();

        public Manage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check_mobile.Enabled = false;
            txt_mobile.Enabled = false;
            txt_mobile.Text = "";
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_subscribe_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string mobile = txt_mobile.Text;

            if (!string.IsNullOrEmpty(email))
            {
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email address.");
                    return;
                }

                if (!subscribedEmails.Any(sub => sub.Email == email))
                {
                    subscribedEmails.Add(new SendViaEmail(email));
                    MessageBox.Show("Subscribed to email updates.");
                }
                else
                {
                    MessageBox.Show("Email address is already subscribed.");
                }
            }

            if (!string.IsNullOrEmpty(mobile))
            {
                if (!IsValidMobile(mobile))
                {
                    MessageBox.Show("Invalid mobile number.");
                    return;
                }

                if (!subscribedMobiles.Any(sub => sub.Mobile == mobile))
                {
                    subscribedMobiles.Add(new SendViaMobile(mobile));
                    MessageBox.Show("Subscribed to mobile updates.");
                }
                else
                {
                    MessageBox.Show("Mobile number is already subscribed.");
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            // Check for a valid email address using a regular expression.
            // This is just one way to validate an email address, and may not be perfect.
            return System.Text.RegularExpressions.Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsValidMobile(string mobile)
        {
            // Check for a valid mobile number using a regular expression.
            // This is just one way to validate a mobile number, and may not be perfect.
            return System.Text.RegularExpressions.Regex.IsMatch(mobile,
                @"^\d{10}$");
        }

        private void btn_unsubscribe_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string mobile = txt_mobile.Text;

            if (!string.IsNullOrEmpty(email))
            {
                var subscription = subscribedEmails.FirstOrDefault(sub => sub.Email == email);

                if (subscription != null)
                {
                    subscribedEmails.Remove(subscription);
                    MessageBox.Show("Unsubscribed from email updates.");
                }
                else
                {
                    MessageBox.Show("Email address is not subscribed.");
                }
            }

            if (!string.IsNullOrEmpty(mobile))
            {
                var subscription = subscribedMobiles.FirstOrDefault(sub => sub.Mobile == mobile);

                if (subscription != null)
                {
                    subscribedMobiles.Remove(subscription);
                    MessageBox.Show("Unsubscribed from mobile updates.");
                }
                else
                {
                    MessageBox.Show("Mobile number is not subscribed.");
                }
            }
        }

        private void check_mobile_CheckedChanged(object sender, EventArgs e)
        {
            check_email.Enabled = false;
            txt_email.Enabled = false;
            txt_email.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            check_email.Enabled = true;
            txt_email.Enabled = true;
            check_mobile.Enabled = true;
            txt_mobile.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
