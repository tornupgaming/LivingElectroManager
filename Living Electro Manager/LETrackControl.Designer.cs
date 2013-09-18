namespace Living_Electro_Manager {
    partial class LETrackControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.image_CoverArt = new System.Windows.Forms.PictureBox();
            this.lbl_TrackName = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_CoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // image_CoverArt
            // 
            this.image_CoverArt.Location = new System.Drawing.Point(3, 3);
            this.image_CoverArt.Name = "image_CoverArt";
            this.image_CoverArt.Size = new System.Drawing.Size(144, 144);
            this.image_CoverArt.TabIndex = 0;
            this.image_CoverArt.TabStop = false;
            // 
            // lbl_TrackName
            // 
            this.lbl_TrackName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TrackName.AutoSize = true;
            this.lbl_TrackName.Location = new System.Drawing.Point(43, 150);
            this.lbl_TrackName.Name = "lbl_TrackName";
            this.lbl_TrackName.Size = new System.Drawing.Size(58, 13);
            this.lbl_TrackName.TabIndex = 1;
            this.lbl_TrackName.Text = "Track Title";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Location = new System.Drawing.Point(62, 163);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(30, 13);
            this.lbl_Artist.TabIndex = 1;
            this.lbl_Artist.Text = "Artist";
            this.lbl_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(3, 179);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(144, 23);
            this.btn_Download.TabIndex = 2;
            this.btn_Download.Text = "Queue Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            // 
            // LETrackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_TrackName);
            this.Controls.Add(this.image_CoverArt);
            this.Name = "LETrackControl";
            this.Size = new System.Drawing.Size(150, 206);
            ((System.ComponentModel.ISupportInitialize)(this.image_CoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_CoverArt;
        private System.Windows.Forms.Label lbl_TrackName;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Button btn_Download;
    }
}
