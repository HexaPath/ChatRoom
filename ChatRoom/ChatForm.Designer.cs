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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnProfil = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Status_button_online = new System.Windows.Forms.Button();
            this.Status_button_inactive = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(404, 376);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(180, 339);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(495, 12);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(107, 27);
            this.btnProfil.TabIndex = 5;
            this.btnProfil.Text = "Uredi Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBox.Location = new System.Drawing.Point(12, 45);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(180, 30);
            this.searchBox.TabIndex = 7;
            // 
            // Status_button_online
            // 
            this.Status_button_online.BackColor = System.Drawing.Color.Lime;
            this.Status_button_online.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status_button_online.Location = new System.Drawing.Point(12, 12);
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
            this.Status_button_inactive.Location = new System.Drawing.Point(42, 12);
            this.Status_button_inactive.Name = "Status_button_inactive";
            this.Status_button_inactive.Size = new System.Drawing.Size(24, 24);
            this.Status_button_inactive.TabIndex = 9;
            this.Status_button_inactive.Text = "_";
            this.Status_button_inactive.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(72, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;

            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Status_button_inactive);
            this.Controls.Add(this.Status_button_online);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button Status_button_online;
        private System.Windows.Forms.Button Status_button_inactive;
        private System.Windows.Forms.Button button2;
    }
}