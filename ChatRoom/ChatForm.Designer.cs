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
            this.SuspendLayout();
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(463, 12);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(52, 52);
            this.btnProfil.TabIndex = 5;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBox.Location = new System.Drawing.Point(214, 408);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(391, 30);
            this.searchBox.TabIndex = 7;
            // 
            // Status_button_online
            // 
            this.Status_button_online.BackColor = System.Drawing.Color.Lime;
            this.Status_button_online.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status_button_online.Location = new System.Drawing.Point(521, 26);
            this.Status_button_online.Name = "Status_button_online";
            this.Status_button_online.Size = new System.Drawing.Size(24, 24);
            this.Status_button_online.TabIndex = 8;
            this.Status_button_online.Text = "_";
            this.Status_button_online.UseVisualStyleBackColor = false;
            // 
            // Status_button_inactive
            // 
            this.Status_button_inactive.BackColor = System.Drawing.Color.Yellow;
            this.Status_button_inactive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status_button_inactive.Location = new System.Drawing.Point(551, 26);
            this.Status_button_inactive.Name = "Status_button_inactive";
            this.Status_button_inactive.Size = new System.Drawing.Size(24, 24);
            this.Status_button_inactive.TabIndex = 9;
            this.Status_button_inactive.Text = "_";
            this.Status_button_inactive.UseVisualStyleBackColor = false;
            // 
            // Status_button_offline
            // 
            this.Status_button_offline.BackColor = System.Drawing.Color.Red;
            this.Status_button_offline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status_button_offline.Location = new System.Drawing.Point(581, 26);
            this.Status_button_offline.Name = "Status_button_offline";
            this.Status_button_offline.Size = new System.Drawing.Size(24, 24);
            this.Status_button_offline.TabIndex = 10;
            this.Status_button_offline.Text = "_";
            this.Status_button_offline.UseVisualStyleBackColor = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
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
    }
}