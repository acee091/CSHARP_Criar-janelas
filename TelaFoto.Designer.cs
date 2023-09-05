namespace Aula_05_09
{
    partial class TelaFoto
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
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEscolherImagem.Location = new System.Drawing.Point(157, 143);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(107, 74);
            this.btnEscolherImagem.TabIndex = 0;
            this.btnEscolherImagem.Text = "ESCOLHER IMAGEM";
            this.btnEscolherImagem.UseVisualStyleBackColor = true;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictImagem
            // 
            this.pictImagem.Location = new System.Drawing.Point(353, 114);
            this.pictImagem.Name = "pictImagem";
            this.pictImagem.Size = new System.Drawing.Size(335, 259);
            this.pictImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictImagem.TabIndex = 1;
            this.pictImagem.TabStop = false;
            // 
            // TelaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictImagem);
            this.Controls.Add(this.btnEscolherImagem);
            this.Name = "TelaFoto";
            this.Text = "TelaFoto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaFoto_FormClosed);
            this.Load += new System.EventHandler(this.TelaFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEscolherImagem;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictImagem;
    }
}