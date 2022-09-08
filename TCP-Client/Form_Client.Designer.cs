namespace TCP_Client
{
    partial class Form_Client
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_clearMessage = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.label_attachFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.txt_remotePort = new System.Windows.Forms.TextBox();
            this.txt_remoteIP = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_attachFile = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Enabled = false;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(144, 91);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(78, 37);
            this.btn_remove.TabIndex = 23;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_clearMessage
            // 
            this.btn_clearMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clearMessage.AutoSize = true;
            this.btn_clearMessage.Enabled = false;
            this.btn_clearMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearMessage.Location = new System.Drawing.Point(27, 346);
            this.btn_clearMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearMessage.Name = "btn_clearMessage";
            this.btn_clearMessage.Size = new System.Drawing.Size(143, 36);
            this.btn_clearMessage.TabIndex = 22;
            this.btn_clearMessage.Text = "Clear message";
            this.btn_clearMessage.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(502, 45);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(106, 37);
            this.btn_send.TabIndex = 21;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // label_attachFile
            // 
            this.label_attachFile.AutoSize = true;
            this.label_attachFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_attachFile.Location = new System.Drawing.Point(234, 100);
            this.label_attachFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_attachFile.Name = "label_attachFile";
            this.label_attachFile.Size = new System.Drawing.Size(179, 20);
            this.label_attachFile.TabIndex = 19;
            this.label_attachFile.Text = "No file attached curently";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Msg";
            // 
            // lb_message
            // 
            this.lb_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 20;
            this.lb_message.Location = new System.Drawing.Point(27, 144);
            this.lb_message.Margin = new System.Windows.Forms.Padding(2);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(566, 184);
            this.lb_message.TabIndex = 18;
            // 
            // txt_message
            // 
            this.txt_message.Enabled = false;
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(118, 52);
            this.txt_message.Margin = new System.Windows.Forms.Padding(2);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(371, 26);
            this.txt_message.TabIndex = 15;
            // 
            // txt_remotePort
            // 
            this.txt_remotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remotePort.Location = new System.Drawing.Point(419, 4);
            this.txt_remotePort.Margin = new System.Windows.Forms.Padding(2);
            this.txt_remotePort.Name = "txt_remotePort";
            this.txt_remotePort.Size = new System.Drawing.Size(71, 26);
            this.txt_remotePort.TabIndex = 16;
            // 
            // txt_remoteIP
            // 
            this.txt_remoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remoteIP.Location = new System.Drawing.Point(118, 5);
            this.txt_remoteIP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_remoteIP.Name = "txt_remoteIP";
            this.txt_remoteIP.Size = new System.Drawing.Size(177, 26);
            this.txt_remoteIP.TabIndex = 17;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disconnect.AutoSize = true;
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.Location = new System.Drawing.Point(487, 345);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(106, 37);
            this.btn_disconnect.TabIndex = 12;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            // 
            // btn_attachFile
            // 
            this.btn_attachFile.Enabled = false;
            this.btn_attachFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attachFile.Location = new System.Drawing.Point(33, 91);
            this.btn_attachFile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_attachFile.Name = "btn_attachFile";
            this.btn_attachFile.Size = new System.Drawing.Size(106, 37);
            this.btn_attachFile.TabIndex = 13;
            this.btn_attachFile.Text = "Attach file";
            this.btn_attachFile.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(502, -2);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(130, 37);
            this.btn_connect.TabIndex = 14;
            this.btn_connect.Text = "Connect Start";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Remote port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remote IP";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 410);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_clearMessage);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label_attachFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_remotePort);
            this.Controls.Add(this.txt_remoteIP);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_attachFile);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_clearMessage;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label_attachFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.TextBox txt_remotePort;
        private System.Windows.Forms.TextBox txt_remoteIP;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_attachFile;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}