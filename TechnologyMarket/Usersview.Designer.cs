
namespace TechnologyMarket
{
    partial class Usersview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usersview));
            this.dataProductView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProductView
            // 
            this.dataProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductView.Location = new System.Drawing.Point(26, 33);
            this.dataProductView.Name = "dataProductView";
            this.dataProductView.RowHeadersWidth = 51;
            this.dataProductView.RowTemplate.Height = 24;
            this.dataProductView.Size = new System.Drawing.Size(690, 292);
            this.dataProductView.TabIndex = 0;
            // 
            // Usersview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 501);
            this.Controls.Add(this.dataProductView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usersview";
            this.RightToLeftLayout = true;
            this.Text = "Kullanıcı Listesi";
            this.Load += new System.EventHandler(this.Usersview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProductView;
    }
}