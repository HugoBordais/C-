namespace TPFichierImage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveGG = new System.Windows.Forms.Button();
            this.btnLoadGG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(482, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Picture";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSaveGG
            // 
            this.btnSaveGG.Location = new System.Drawing.Point(482, 64);
            this.btnSaveGG.Name = "btnSaveGG";
            this.btnSaveGG.Size = new System.Drawing.Size(98, 23);
            this.btnSaveGG.TabIndex = 2;
            this.btnSaveGG.Text = "Save format GG";
            this.btnSaveGG.UseVisualStyleBackColor = true;
            this.btnSaveGG.Click += new System.EventHandler(this.btnSaveGG_Click);
            // 
            // btnLoadGG
            // 
            this.btnLoadGG.Location = new System.Drawing.Point(482, 103);
            this.btnLoadGG.Name = "btnLoadGG";
            this.btnLoadGG.Size = new System.Drawing.Size(98, 23);
            this.btnLoadGG.TabIndex = 3;
            this.btnLoadGG.Text = "Load format GG";
            this.btnLoadGG.UseVisualStyleBackColor = true;
            this.btnLoadGG.Click += new System.EventHandler(this.btnLoadGG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 337);
            this.Controls.Add(this.btnLoadGG);
            this.Controls.Add(this.btnSaveGG);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveGG;
        private System.Windows.Forms.Button btnLoadGG;
    }
}

