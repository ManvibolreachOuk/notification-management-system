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
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage manageForm = new Manage();
            manageForm.Show();
            btn_publish.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Application.Exit();
            btn_publish.Enabled = true;
            btn_manage.Enabled = true;
        }

        private void btn_publish_Click(object sender, EventArgs e)
        {
            Publish publishForm = new Publish();
            publishForm.Show();
            btn_manage.Enabled = false;
        }
    }
}
