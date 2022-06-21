
namespace TechnologyMarket
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_contact = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_homepage = new System.Windows.Forms.Button();
            this.pc_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kontrolHP1 = new TechnologyMarket.KontrolHP();
            this.kontrolAbout1 = new TechnologyMarket.KontrolAbout();
            this.kontrolContact1 = new TechnologyMarket.KontrolContact();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_contact);
            this.panel2.Controls.Add(this.btn_about);
            this.panel2.Controls.Add(this.btn_homepage);
            this.panel2.Controls.Add(this.pc_logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 632);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Merhaba, üye girişi yapın";
            // 
            // btn_contact
            // 
            this.btn_contact.BackColor = System.Drawing.Color.White;
            this.btn_contact.FlatAppearance.BorderSize = 0;
            this.btn_contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contact.ForeColor = System.Drawing.Color.Gray;
            this.btn_contact.Image = global::TechnologyMarket.Properties.Resources.tel1;
            this.btn_contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contact.Location = new System.Drawing.Point(0, 332);
            this.btn_contact.Margin = new System.Windows.Forms.Padding(0);
            this.btn_contact.Name = "btn_contact";
            this.btn_contact.Size = new System.Drawing.Size(206, 56);
            this.btn_contact.TabIndex = 8;
            this.btn_contact.Text = "    Iletisim";
            this.btn_contact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_contact.UseVisualStyleBackColor = false;
            this.btn_contact.Click += new System.EventHandler(this.btn_contact_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.White;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.Gray;
            this.btn_about.Image = global::TechnologyMarket.Properties.Resources.hakkımızda;
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(0, 249);
            this.btn_about.Margin = new System.Windows.Forms.Padding(0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(206, 56);
            this.btn_about.TabIndex = 7;
            this.btn_about.Text = "    Hakkımızda";
            this.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_homepage
            // 
            this.btn_homepage.BackColor = System.Drawing.Color.White;
            this.btn_homepage.FlatAppearance.BorderSize = 0;
            this.btn_homepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_homepage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homepage.ForeColor = System.Drawing.Color.Gray;
            this.btn_homepage.Image = global::TechnologyMarket.Properties.Resources.home4;
            this.btn_homepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_homepage.Location = new System.Drawing.Point(0, 161);
            this.btn_homepage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_homepage.Name = "btn_homepage";
            this.btn_homepage.Size = new System.Drawing.Size(206, 56);
            this.btn_homepage.TabIndex = 4;
            this.btn_homepage.Text = "    Ana sayfa";
            this.btn_homepage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_homepage.UseVisualStyleBackColor = false;
            this.btn_homepage.Click += new System.EventHandler(this.btn_homepage_Click);
            // 
            // pc_logo
            // 
            this.pc_logo.Image = global::TechnologyMarket.Properties.Resources.logo;
            this.pc_logo.Location = new System.Drawing.Point(25, 12);
            this.pc_logo.Name = "pc_logo";
            this.pc_logo.Size = new System.Drawing.Size(166, 52);
            this.pc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_logo.TabIndex = 0;
            this.pc_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 632);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_Customer);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(221, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 62);
            this.panel3.TabIndex = 3;
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Location = new System.Drawing.Point(792, 14);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(150, 38);
            this.btn_Customer.TabIndex = 11;
            this.btn_Customer.Text = "Üye Giriş";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(65, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "...Hızlı ve güvenilir alışveriş";
            // 
            // kontrolHP1
            // 
            this.kontrolHP1.BackColor = System.Drawing.Color.White;
            this.kontrolHP1.Location = new System.Drawing.Point(282, 71);
            this.kontrolHP1.Name = "kontrolHP1";
            this.kontrolHP1.Size = new System.Drawing.Size(807, 525);
            this.kontrolHP1.TabIndex = 5;
            // 
            // kontrolAbout1
            // 
            this.kontrolAbout1.BackColor = System.Drawing.Color.White;
            this.kontrolAbout1.Location = new System.Drawing.Point(306, 84);
            this.kontrolAbout1.Name = "kontrolAbout1";
            this.kontrolAbout1.Size = new System.Drawing.Size(807, 525);
            this.kontrolAbout1.TabIndex = 6;
            // 
            // kontrolContact1
            // 
            this.kontrolContact1.BackColor = System.Drawing.Color.White;
            this.kontrolContact1.Location = new System.Drawing.Point(291, 84);
            this.kontrolContact1.Name = "kontrolContact1";
            this.kontrolContact1.Size = new System.Drawing.Size(807, 525);
            this.kontrolContact1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 632);
            this.Controls.Add(this.kontrolContact1);
            this.Controls.Add(this.kontrolAbout1);
            this.Controls.Add(this.kontrolHP1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_homepage;
        private System.Windows.Forms.PictureBox pc_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_contact;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Label label2;
        private KontrolHP kontrolHP1;
        private KontrolAbout kontrolAbout1;
        private KontrolContact kontrolContact1;
    }
}

