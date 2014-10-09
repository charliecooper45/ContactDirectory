namespace ContactDirectory
{
    partial class DirectoryForm
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
            this._imgBike = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._imgBike)).BeginInit();
            this.SuspendLayout();
            // 
            // _imgBike
            // 
            this._imgBike.Image = global::ContactDirectory.Properties.Resources.Canyon_Aeroad;
            this._imgBike.Location = new System.Drawing.Point(245, 12);
            this._imgBike.Name = "_imgBike";
            this._imgBike.Size = new System.Drawing.Size(148, 93);
            this._imgBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imgBike.TabIndex = 0;
            this._imgBike.TabStop = false;
            this._imgBike.Click += new System.EventHandler(this.OnShowAboutBox);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 262);
            this.Controls.Add(this._imgBike);
            this.Name = "DirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Directory";
            ((System.ComponentModel.ISupportInitialize)(this._imgBike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _imgBike;
    }
}

