namespace CodePet
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
            this.btnMangia = new System.Windows.Forms.Button();
            this.btnGioca = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.lblFame = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.lblFelicità = new System.Windows.Forms.Label();
            this.pbPet = new System.Windows.Forms.PictureBox();
            this.pixelProgressBar1 = new CodePet.PixelProgressBar();
            this.pixelProgressBar2 = new CodePet.PixelProgressBar();
            this.pixelProgressBar3 = new CodePet.PixelProgressBar();
            this.btnDormi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMangia
            // 
            this.btnMangia.Location = new System.Drawing.Point(31, 463);
            this.btnMangia.Name = "btnMangia";
            this.btnMangia.Size = new System.Drawing.Size(59, 65);
            this.btnMangia.TabIndex = 1;
            this.btnMangia.Text = "Mangia";
            this.btnMangia.UseVisualStyleBackColor = true;
            this.btnMangia.Click += new System.EventHandler(this.btnMangia_Click);
            // 
            // btnGioca
            // 
            this.btnGioca.Location = new System.Drawing.Point(118, 463);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(59, 65);
            this.btnGioca.TabIndex = 2;
            this.btnGioca.Text = "Gioca";
            this.btnGioca.UseVisualStyleBackColor = true;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(297, 463);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(59, 65);
            this.btnPulisci.TabIndex = 4;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // lblFame
            // 
            this.lblFame.AutoSize = true;
            this.lblFame.Location = new System.Drawing.Point(31, 22);
            this.lblFame.Name = "lblFame";
            this.lblFame.Size = new System.Drawing.Size(33, 13);
            this.lblFame.TabIndex = 8;
            this.lblFame.Text = "Fame";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Location = new System.Drawing.Point(28, 50);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(43, 13);
            this.lblEnergia.TabIndex = 9;
            this.lblEnergia.Text = "Energia";
            // 
            // lblFelicità
            // 
            this.lblFelicità.AutoSize = true;
            this.lblFelicità.Location = new System.Drawing.Point(31, 79);
            this.lblFelicità.Name = "lblFelicità";
            this.lblFelicità.Size = new System.Drawing.Size(40, 13);
            this.lblFelicità.TabIndex = 10;
            this.lblFelicità.Text = "Felicità";
            // 
            // pbPet
            // 
            this.pbPet.ErrorImage = null;
            this.pbPet.InitialImage = null;
            this.pbPet.Location = new System.Drawing.Point(34, 138);
            this.pbPet.Name = "pbPet";
            this.pbPet.Size = new System.Drawing.Size(300, 300);
            this.pbPet.TabIndex = 0;
            this.pbPet.TabStop = false;
            // 
            // pixelProgressBar1
            // 
            this.pixelProgressBar1.Location = new System.Drawing.Point(91, 22);
            this.pixelProgressBar1.Name = "pixelProgressBar1";
            this.pixelProgressBar1.PixelColor = System.Drawing.Color.LimeGreen;
            this.pixelProgressBar1.Size = new System.Drawing.Size(86, 15);
            this.pixelProgressBar1.TabIndex = 11;
            this.pixelProgressBar1.Text = "pixelProgressBar1";
            this.pixelProgressBar1.Value = 50;
            // 
            // pixelProgressBar2
            // 
            this.pixelProgressBar2.Location = new System.Drawing.Point(91, 50);
            this.pixelProgressBar2.Name = "pixelProgressBar2";
            this.pixelProgressBar2.PixelColor = System.Drawing.Color.LimeGreen;
            this.pixelProgressBar2.Size = new System.Drawing.Size(86, 15);
            this.pixelProgressBar2.TabIndex = 12;
            this.pixelProgressBar2.Text = "pixelProgressBar2";
            this.pixelProgressBar2.Value = 50;
            // 
            // pixelProgressBar3
            // 
            this.pixelProgressBar3.Location = new System.Drawing.Point(91, 79);
            this.pixelProgressBar3.Name = "pixelProgressBar3";
            this.pixelProgressBar3.PixelColor = System.Drawing.Color.LimeGreen;
            this.pixelProgressBar3.Size = new System.Drawing.Size(86, 15);
            this.pixelProgressBar3.TabIndex = 13;
            this.pixelProgressBar3.Text = "pixelProgressBar3";
            this.pixelProgressBar3.Value = 50;
            // 
            // btnDormi
            // 
            this.btnDormi.Location = new System.Drawing.Point(206, 463);
            this.btnDormi.Name = "btnDormi";
            this.btnDormi.Size = new System.Drawing.Size(59, 65);
            this.btnDormi.TabIndex = 3;
            this.btnDormi.Text = "Dormi";
            this.btnDormi.UseVisualStyleBackColor = true;
            this.btnDormi.Click += new System.EventHandler(this.btnDormi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pixelProgressBar3);
            this.Controls.Add(this.pixelProgressBar2);
            this.Controls.Add(this.pixelProgressBar1);
            this.Controls.Add(this.lblFelicità);
            this.Controls.Add(this.lblEnergia);
            this.Controls.Add(this.lblFame);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnDormi);
            this.Controls.Add(this.btnGioca);
            this.Controls.Add(this.btnMangia);
            this.Controls.Add(this.pbPet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPet;
        private System.Windows.Forms.Button btnMangia;
        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Button btnDormi;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Label lblFame;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label lblFelicità;
        private PixelProgressBar pixelProgressBar1;
        private PixelProgressBar pixelProgressBar2;
        private PixelProgressBar pixelProgressBar3;
    }
}

