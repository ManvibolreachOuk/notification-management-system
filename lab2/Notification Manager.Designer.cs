
namespace lab2
{
    partial class Notification
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
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_publish = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(43, 89);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(189, 69);
            this.btn_manage.TabIndex = 0;
            this.btn_manage.Text = "Manage Subscription";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_publish
            // 
            this.btn_publish.Location = new System.Drawing.Point(301, 92);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(174, 63);
            this.btn_publish.TabIndex = 1;
            this.btn_publish.Text = "Publish Subscription";
            this.btn_publish.UseVisualStyleBackColor = true;
            this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(567, 92);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 63);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 251);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_publish);
            this.Controls.Add(this.btn_manage);
            this.Name = "Notification";
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.Button btn_exit;
    }
}

