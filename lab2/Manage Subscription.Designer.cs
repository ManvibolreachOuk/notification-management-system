
namespace lab2
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_email = new System.Windows.Forms.CheckBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.check_mobile = new System.Windows.Forms.CheckBox();
            this.btn_subscribe = new System.Windows.Forms.Button();
            this.btn_unsubscribe = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check_email
            // 
            this.check_email.AutoSize = true;
            this.check_email.Location = new System.Drawing.Point(72, 75);
            this.check_email.Name = "check_email";
            this.check_email.Size = new System.Drawing.Size(215, 24);
            this.check_email.TabIndex = 0;
            this.check_email.Text = "Notification Sent by Email";
            this.check_email.UseVisualStyleBackColor = true;
            this.check_email.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(370, 73);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(258, 26);
            this.txt_email.TabIndex = 1;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(370, 163);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(258, 26);
            this.txt_mobile.TabIndex = 2;
            // 
            // check_mobile
            // 
            this.check_mobile.AutoSize = true;
            this.check_mobile.Location = new System.Drawing.Point(72, 163);
            this.check_mobile.Name = "check_mobile";
            this.check_mobile.Size = new System.Drawing.Size(211, 24);
            this.check_mobile.TabIndex = 3;
            this.check_mobile.Text = "Notification Sent by SMS";
            this.check_mobile.UseVisualStyleBackColor = true;
            this.check_mobile.CheckedChanged += new System.EventHandler(this.check_mobile_CheckedChanged);
            // 
            // btn_subscribe
            // 
            this.btn_subscribe.Location = new System.Drawing.Point(72, 275);
            this.btn_subscribe.Name = "btn_subscribe";
            this.btn_subscribe.Size = new System.Drawing.Size(114, 57);
            this.btn_subscribe.TabIndex = 4;
            this.btn_subscribe.Text = "Subscribe";
            this.btn_subscribe.UseVisualStyleBackColor = true;
            this.btn_subscribe.Click += new System.EventHandler(this.btn_subscribe_Click);
            // 
            // btn_unsubscribe
            // 
            this.btn_unsubscribe.Location = new System.Drawing.Point(236, 275);
            this.btn_unsubscribe.Name = "btn_unsubscribe";
            this.btn_unsubscribe.Size = new System.Drawing.Size(113, 57);
            this.btn_unsubscribe.TabIndex = 5;
            this.btn_unsubscribe.Text = "Unsunscribe";
            this.btn_unsubscribe.UseVisualStyleBackColor = true;
            this.btn_unsubscribe.Click += new System.EventHandler(this.btn_unsubscribe_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(527, 275);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(101, 57);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(527, 370);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 57);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_unsubscribe);
            this.Controls.Add(this.btn_subscribe);
            this.Controls.Add(this.check_mobile);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.check_email);
            this.Name = "Manage";
            this.Text = "Manage_Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.CheckBox check_mobile;
        private System.Windows.Forms.Button btn_subscribe;
        private System.Windows.Forms.Button btn_unsubscribe;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_exit;
    }
}