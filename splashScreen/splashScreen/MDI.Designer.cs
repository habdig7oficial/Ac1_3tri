
namespace splashScreen
{
    partial class MDI
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoIdealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percentualDeGorduraCorporalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadênciaIdealDeÁguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantidadeDeGorduraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblData,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "Heathy & Happy (0.01)";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 17);
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaConsultaToolStripMenuItem,
            this.outrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaConsultaToolStripMenuItem
            // 
            this.novaConsultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMCToolStripMenuItem,
            this.pesoIdealToolStripMenuItem,
            this.percentualDeGorduraCorporalToolStripMenuItem,
            this.cadênciaIdealDeÁguaToolStripMenuItem,
            this.quantidadeDeGorduraToolStripMenuItem});
            this.novaConsultaToolStripMenuItem.Name = "novaConsultaToolStripMenuItem";
            this.novaConsultaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.novaConsultaToolStripMenuItem.Text = "Nova Consulta";
            // 
            // iMCToolStripMenuItem
            // 
            this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            this.iMCToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.iMCToolStripMenuItem.Text = "IMC";
            this.iMCToolStripMenuItem.Click += new System.EventHandler(this.iMCToolStripMenuItem_Click);
            // 
            // pesoIdealToolStripMenuItem
            // 
            this.pesoIdealToolStripMenuItem.Name = "pesoIdealToolStripMenuItem";
            this.pesoIdealToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.pesoIdealToolStripMenuItem.Text = "Peso Ideal";
            this.pesoIdealToolStripMenuItem.Click += new System.EventHandler(this.pesoIdealToolStripMenuItem_Click);
            // 
            // percentualDeGorduraCorporalToolStripMenuItem
            // 
            this.percentualDeGorduraCorporalToolStripMenuItem.Name = "percentualDeGorduraCorporalToolStripMenuItem";
            this.percentualDeGorduraCorporalToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.percentualDeGorduraCorporalToolStripMenuItem.Text = "Percentual de Gordura Corporal";
            this.percentualDeGorduraCorporalToolStripMenuItem.Click += new System.EventHandler(this.percentualDeGorduraCorporalToolStripMenuItem_Click);
            // 
            // cadênciaIdealDeÁguaToolStripMenuItem
            // 
            this.cadênciaIdealDeÁguaToolStripMenuItem.Name = "cadênciaIdealDeÁguaToolStripMenuItem";
            this.cadênciaIdealDeÁguaToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.cadênciaIdealDeÁguaToolStripMenuItem.Text = "Cadência Ideal de Água";
            this.cadênciaIdealDeÁguaToolStripMenuItem.Click += new System.EventHandler(this.cadênciaIdealDeÁguaToolStripMenuItem_Click);
            // 
            // quantidadeDeGorduraToolStripMenuItem
            // 
            this.quantidadeDeGorduraToolStripMenuItem.Name = "quantidadeDeGorduraToolStripMenuItem";
            this.quantidadeDeGorduraToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.quantidadeDeGorduraToolStripMenuItem.Text = "Quantidade de calorias";
            this.quantidadeDeGorduraToolStripMenuItem.Click += new System.EventHandler(this.quantidadeDeGorduraToolStripMenuItem_Click);
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.outrosToolStripMenuItem.Text = "Outros";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 347);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "frmTeste";
            this.Load += new System.EventHandler(this.frmTeste_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoIdealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percentualDeGorduraCorporalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadênciaIdealDeÁguaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantidadeDeGorduraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}