namespace Aula_05_09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrirJanela = new System.Windows.Forms.Button();
            this.janela = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janela.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirJanela
            // 
            this.btnAbrirJanela.Location = new System.Drawing.Point(297, 178);
            this.btnAbrirJanela.Name = "btnAbrirJanela";
            this.btnAbrirJanela.Size = new System.Drawing.Size(124, 50);
            this.btnAbrirJanela.TabIndex = 0;
            this.btnAbrirJanela.Text = "Abrir JANELA";
            this.btnAbrirJanela.UseVisualStyleBackColor = true;
            this.btnAbrirJanela.Click += new System.EventHandler(this.button1_Click);
            // 
            // janela
            // 
            this.janela.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.janela.Location = new System.Drawing.Point(0, 0);
            this.janela.Name = "janela";
            this.janela.Size = new System.Drawing.Size(800, 24);
            this.janela.TabIndex = 1;
            this.janela.Text = "mnuJanelas";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarFotoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // carregarFotoToolStripMenuItem
            // 
            this.carregarFotoToolStripMenuItem.Name = "carregarFotoToolStripMenuItem";
            this.carregarFotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carregarFotoToolStripMenuItem.Text = "Carregar Foto";
            this.carregarFotoToolStripMenuItem.Click += new System.EventHandler(this.carregarFotoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirJanela);
            this.Controls.Add(this.janela);
            this.MainMenuStrip = this.janela;
            this.Name = "Form1";
            this.Text = "Form1";
            this.janela.ResumeLayout(false);
            this.janela.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAbrirJanela;
        private MenuStrip janela;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem carregarFotoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}