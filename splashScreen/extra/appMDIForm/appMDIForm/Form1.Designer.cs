namespace appMDIForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1ToolStripMenuItem,
            this.exercício2ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // exercício1ToolStripMenuItem
            // 
            this.exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            this.exercício1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem.Text = "Exercício 1";
            this.exercício1ToolStripMenuItem.Click += new System.EventHandler(this.exercício1ToolStripMenuItem_Click);
            // 
            // exercício2ToolStripMenuItem
            // 
            this.exercício2ToolStripMenuItem.Name = "exercício2ToolStripMenuItem";
            this.exercício2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício2ToolStripMenuItem.Text = "Exercício 2";
            this.exercício2ToolStripMenuItem.Click += new System.EventHandler(this.exercício2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

