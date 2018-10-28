namespace ChatRoom
{
    partial class ChatForm
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
            this.btnProfil = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Status_button_online = new System.Windows.Forms.Button();
            this.Status_button_inactive = new System.Windows.Forms.Button();
            this.Status_button_offline = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(519, 8);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(64, 64);
            this.btnProfil.TabIndex = 5;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(185, 30);
            this.searchBox.TabIndex = 7;
            // 
            // Status_button_online
            // 
            this.Status_button_online.BackColor = System.Drawing.Color.Lime;
            this.Status_button_online.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status_button_online.Location = new System.Drawing.Point(589, 12);
            this.Status_button_online.Name = "Status_button_online";
            this.Status_button_online.Size = new System.Drawing.Size(16, 16);
            this.Status_button_online.TabIndex = 8;
            this.Status_button_online.Text = "_";
            this.Status_button_online.UseVisualStyleBackColor = false;
            // 
            // Status_button_inactive
            // 
            this.Status_button_inactive.BackColor = System.Drawing.Color.Yellow;
            this.Status_button_inactive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status_button_inactive.Location = new System.Drawing.Point(589, 34);
            this.Status_button_inactive.Name = "Status_button_inactive";
            this.Status_button_inactive.Size = new System.Drawing.Size(16, 16);
            this.Status_button_inactive.TabIndex = 9;
            this.Status_button_inactive.Text = "_";
            this.Status_button_inactive.UseVisualStyleBackColor = false;
            // 
            // Status_button_offline
            // 
            this.Status_button_offline.BackColor = System.Drawing.Color.Red;
            this.Status_button_offline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status_button_offline.Location = new System.Drawing.Point(589, 56);
            this.Status_button_offline.Name = "Status_button_offline";
            this.Status_button_offline.Size = new System.Drawing.Size(16, 16);
            this.Status_button_offline.TabIndex = 10;
            this.Status_button_offline.Text = "_";
            this.Status_button_offline.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessagetextBox.Location = new System.Drawing.Point(203, 412);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(364, 30);
            this.MessagetextBox.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(573, 410);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(32, 32);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Sent";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Status_button_offline);
            this.Controls.Add(this.Status_button_inactive);
            this.Controls.Add(this.Status_button_online);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnProfil);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button Status_button_online;
        private System.Windows.Forms.Button Status_button_inactive;
        private System.Windows.Forms.Button Status_button_offline;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button btnSend;
    }
}