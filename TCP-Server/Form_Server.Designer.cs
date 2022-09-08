namespace TCP_Server
{
    partial class Form_Server
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
            this.lb_message = new System.Windows.Forms.ListBox();
            this.btn_clearmessage = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_listen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_message
            // 
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 12;
            this.lb_message.Location = new System.Drawing.Point(23, 54);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(246, 124);
            this.lb_message.TabIndex = 11;
            // 
            // btn_clearmessage
            // 
            this.btn_clearmessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clearmessage.AutoSize = true;
            this.btn_clearmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearmessage.Location = new System.Drawing.Point(23, 183);
            this.btn_clearmessage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearmessage.Name = "btn_clearmessage";
            this.btn_clearmessage.Size = new System.Drawing.Size(128, 38);
            this.btn_clearmessage.TabIndex = 10;
            this.btn_clearmessage.Text = "Clear msge";
            this.btn_clearmessage.UseVisualStyleBackColor = true;
            this.btn_clearmessage.Click += new System.EventHandler(this.btn_clearmessage_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(274, 19);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(142, 220);
            this.listBox1.TabIndex = 9;
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Enabled = false;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(111, 19);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(66, 30);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // btn_listen
            // 
            this.btn_listen.AutoSize = true;
            this.btn_listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listen.Location = new System.Drawing.Point(23, 19);
            this.btn_listen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(75, 30);
            this.btn_listen.TabIndex = 7;
            this.btn_listen.Text = "Start";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 259);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_clearmessage);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_listen);
            this.Name = "Form_Server";
            this.Text = "Form_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.Button btn_clearmessage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_listen;
    }
}