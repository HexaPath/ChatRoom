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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.UserProfileBtn = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.RDockPanel = new System.Windows.Forms.Panel();
            this.contactsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StatusPanel_1 = new System.Windows.Forms.Panel();
            this.User_status_offlineBtn = new System.Windows.Forms.Button();
            this.User_status_onlineBtn = new System.Windows.Forms.Button();
            this.User_status_inactiveBtn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.StatusPanel_2 = new System.Windows.Forms.Panel();
            this.Contact_status_offlineBtn = new System.Windows.Forms.Button();
            this.Contact_status_onlineBtn = new System.Windows.Forms.Button();
            this.Contact_status_inactiveBtn = new System.Windows.Forms.Button();
            this.ContactInfoLabel = new System.Windows.Forms.Label();
            this.ContactProfileBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RDockPanel.SuspendLayout();
            this.StatusPanel_1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            this.StatusPanel_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserProfileBtn
            // 
            this.UserProfileBtn.Location = new System.Drawing.Point(6, 4);
            this.UserProfileBtn.Name = "UserProfileBtn";
            this.UserProfileBtn.Size = new System.Drawing.Size(64, 64);
            this.UserProfileBtn.TabIndex = 5;
            this.UserProfileBtn.Text = "Profil";
            this.UserProfileBtn.UseVisualStyleBackColor = true;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchtextBox.Location = new System.Drawing.Point(76, 24);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(239, 38);
            this.searchtextBox.TabIndex = 7;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessagetextBox.Location = new System.Drawing.Point(327, 545);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(670, 45);
            this.MessagetextBox.TabIndex = 12;
            this.MessagetextBox.TextChanged += new System.EventHandler(this.MessagetextBox_TextChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(1003, 545);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(61, 45);
            this.SendBtn.TabIndex = 13;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // RDockPanel
            // 
            this.RDockPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.RDockPanel.Controls.Add(this.UserProfileBtn);
            this.RDockPanel.Controls.Add(this.contactsPanel);
            this.RDockPanel.Controls.Add(this.StatusPanel_1);
            this.RDockPanel.Controls.Add(this.searchtextBox);
            this.RDockPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RDockPanel.Location = new System.Drawing.Point(0, 0);
            this.RDockPanel.Name = "RDockPanel";
            this.RDockPanel.Size = new System.Drawing.Size(321, 593);
            this.RDockPanel.TabIndex = 14;
            // 
            // contactsPanel
            // 
            this.contactsPanel.AutoScroll = true;
            this.contactsPanel.Location = new System.Drawing.Point(3, 70);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(318, 520);
            this.contactsPanel.TabIndex = 16;
            this.contactsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contactsPanel_Paint);
            // 
            // StatusPanel_1
            // 
            this.StatusPanel_1.Controls.Add(this.User_status_offlineBtn);
            this.StatusPanel_1.Controls.Add(this.User_status_onlineBtn);
            this.StatusPanel_1.Controls.Add(this.User_status_inactiveBtn);
            this.StatusPanel_1.Location = new System.Drawing.Point(76, 4);
            this.StatusPanel_1.Name = "StatusPanel_1";
            this.StatusPanel_1.Size = new System.Drawing.Size(54, 18);
            this.StatusPanel_1.TabIndex = 24;
            // 
            // User_status_offlineBtn
            // 
            this.User_status_offlineBtn.BackColor = System.Drawing.Color.Red;
            this.User_status_offlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_status_offlineBtn.Location = new System.Drawing.Point(39, 3);
            this.User_status_offlineBtn.Name = "User_status_offlineBtn";
            this.User_status_offlineBtn.Size = new System.Drawing.Size(12, 12);
            this.User_status_offlineBtn.TabIndex = 22;
            this.User_status_offlineBtn.Text = "Profil";
            this.User_status_offlineBtn.UseVisualStyleBackColor = false;
            this.User_status_offlineBtn.Click += new System.EventHandler(this.User_status_offlineBtn_Click);
            // 
            // User_status_onlineBtn
            // 
            this.User_status_onlineBtn.BackColor = System.Drawing.Color.Lime;
            this.User_status_onlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_status_onlineBtn.Location = new System.Drawing.Point(3, 3);
            this.User_status_onlineBtn.Name = "User_status_onlineBtn";
            this.User_status_onlineBtn.Size = new System.Drawing.Size(12, 12);
            this.User_status_onlineBtn.TabIndex = 11;
            this.User_status_onlineBtn.Text = "Profil";
            this.User_status_onlineBtn.UseVisualStyleBackColor = false;
            this.User_status_onlineBtn.Click += new System.EventHandler(this.User_status_onlineBtn_Click);
            // 
            // User_status_inactiveBtn
            // 
            this.User_status_inactiveBtn.BackColor = System.Drawing.Color.Yellow;
            this.User_status_inactiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_status_inactiveBtn.Location = new System.Drawing.Point(21, 3);
            this.User_status_inactiveBtn.Name = "User_status_inactiveBtn";
            this.User_status_inactiveBtn.Size = new System.Drawing.Size(12, 12);
            this.User_status_inactiveBtn.TabIndex = 21;
            this.User_status_inactiveBtn.Text = "Profil";
            this.User_status_inactiveBtn.UseVisualStyleBackColor = false;
            this.User_status_inactiveBtn.Click += new System.EventHandler(this.User_status_inactiveBtn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.TopPanel.Controls.Add(this.UserInfoPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(321, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(749, 68);
            this.TopPanel.TabIndex = 15;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(693, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitBtn.Size = new System.Drawing.Size(50, 50);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UserInfoPanel.Controls.Add(this.StatusPanel_2);
            this.UserInfoPanel.Controls.Add(this.ContactInfoLabel);
            this.UserInfoPanel.Controls.Add(this.ContactProfileBtn);
            this.UserInfoPanel.Location = new System.Drawing.Point(6, 0);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(329, 68);
            this.UserInfoPanel.TabIndex = 14;
            this.UserInfoPanel.Visible = false;
            // 
            // StatusPanel_2
            // 
            this.StatusPanel_2.Controls.Add(this.Contact_status_offlineBtn);
            this.StatusPanel_2.Controls.Add(this.Contact_status_onlineBtn);
            this.StatusPanel_2.Controls.Add(this.Contact_status_inactiveBtn);
            this.StatusPanel_2.Location = new System.Drawing.Point(75, 44);
            this.StatusPanel_2.Name = "StatusPanel_2";
            this.StatusPanel_2.Size = new System.Drawing.Size(19, 18);
            this.StatusPanel_2.TabIndex = 27;
            // 
            // Contact_status_offlineBtn
            // 
            this.Contact_status_offlineBtn.BackColor = System.Drawing.Color.Red;
            this.Contact_status_offlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Contact_status_offlineBtn.Location = new System.Drawing.Point(3, 3);
            this.Contact_status_offlineBtn.Name = "Contact_status_offlineBtn";
            this.Contact_status_offlineBtn.Size = new System.Drawing.Size(12, 12);
            this.Contact_status_offlineBtn.TabIndex = 22;
            this.Contact_status_offlineBtn.Text = "Profil";
            this.Contact_status_offlineBtn.UseVisualStyleBackColor = false;
            // 
            // Contact_status_onlineBtn
            // 
            this.Contact_status_onlineBtn.BackColor = System.Drawing.Color.Lime;
            this.Contact_status_onlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Contact_status_onlineBtn.Location = new System.Drawing.Point(3, 3);
            this.Contact_status_onlineBtn.Name = "Contact_status_onlineBtn";
            this.Contact_status_onlineBtn.Size = new System.Drawing.Size(12, 12);
            this.Contact_status_onlineBtn.TabIndex = 11;
            this.Contact_status_onlineBtn.Text = "Profil";
            this.Contact_status_onlineBtn.UseVisualStyleBackColor = false;
            // 
            // Contact_status_inactiveBtn
            // 
            this.Contact_status_inactiveBtn.BackColor = System.Drawing.Color.Yellow;
            this.Contact_status_inactiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Contact_status_inactiveBtn.Location = new System.Drawing.Point(3, 3);
            this.Contact_status_inactiveBtn.Name = "Contact_status_inactiveBtn";
            this.Contact_status_inactiveBtn.Size = new System.Drawing.Size(12, 12);
            this.Contact_status_inactiveBtn.TabIndex = 21;
            this.Contact_status_inactiveBtn.Text = "Profil";
            this.Contact_status_inactiveBtn.UseVisualStyleBackColor = false;
            // 
            // ContactInfoLabel
            // 
            this.ContactInfoLabel.AutoSize = true;
            this.ContactInfoLabel.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactInfoLabel.Location = new System.Drawing.Point(67, 8);
            this.ContactInfoLabel.Name = "ContactInfoLabel";
            this.ContactInfoLabel.Size = new System.Drawing.Size(92, 44);
            this.ContactInfoLabel.TabIndex = 26;
            this.ContactInfoLabel.Text = "label1";
            // 
            // ContactProfileBtn
            // 
            this.ContactProfileBtn.Location = new System.Drawing.Point(3, 2);
            this.ContactProfileBtn.Name = "ContactProfileBtn";
            this.ContactProfileBtn.Size = new System.Drawing.Size(64, 64);
            this.ContactProfileBtn.TabIndex = 11;
            this.ContactProfileBtn.Text = "Profil";
            this.ContactProfileBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.MediumBlue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(327, 74);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(734, 465);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1070, 593);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.RDockPanel);
            this.Controls.Add(this.MessagetextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForm";
            this.RDockPanel.ResumeLayout(false);
            this.RDockPanel.PerformLayout();
            this.StatusPanel_1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.StatusPanel_2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UserProfileBtn;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Panel RDockPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button User_status_onlineBtn;
        private System.Windows.Forms.Panel StatusPanel_1;
        private System.Windows.Forms.Button User_status_offlineBtn;
        private System.Windows.Forms.Button User_status_inactiveBtn;
        private System.Windows.Forms.FlowLayoutPanel contactsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Label ContactInfoLabel;
        private System.Windows.Forms.Button ContactProfileBtn;
        private System.Windows.Forms.Panel StatusPanel_2;
        private System.Windows.Forms.Button Contact_status_offlineBtn;
        private System.Windows.Forms.Button Contact_status_onlineBtn;
        private System.Windows.Forms.Button Contact_status_inactiveBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}