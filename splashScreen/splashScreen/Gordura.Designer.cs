
namespace splashScreen
{
    partial class Gordura
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radMASCULINO = new System.Windows.Forms.RadioButton();
            this.radFEMININO = new System.Windows.Forms.RadioButton();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtIDADE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Percentual de Gordura";
            // 
            // radMASCULINO
            // 
            this.radMASCULINO.AutoSize = true;
            this.radMASCULINO.Location = new System.Drawing.Point(85, 100);
            this.radMASCULINO.Name = "radMASCULINO";
            this.radMASCULINO.Size = new System.Drawing.Size(73, 17);
            this.radMASCULINO.TabIndex = 2;
            this.radMASCULINO.TabStop = true;
            this.radMASCULINO.Text = "Masculino";
            this.radMASCULINO.UseVisualStyleBackColor = true;
            // 
            // radFEMININO
            // 
            this.radFEMININO.AutoSize = true;
            this.radFEMININO.Location = new System.Drawing.Point(85, 137);
            this.radFEMININO.Name = "radFEMININO";
            this.radFEMININO.Size = new System.Drawing.Size(67, 17);
            this.radFEMININO.TabIndex = 3;
            this.radFEMININO.TabStop = true;
            this.radFEMININO.Text = "Feminino";
            this.radFEMININO.UseVisualStyleBackColor = true;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(77, 223);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(100, 20);
            this.txtIMC.TabIndex = 4;
            // 
            // txtIDADE
            // 
            this.txtIDADE.Location = new System.Drawing.Point(77, 292);
            this.txtIDADE.Name = "txtIDADE";
            this.txtIDADE.Size = new System.Drawing.Size(100, 20);
            this.txtIDADE.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "IMC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "IDADE";
            // 
            // Gordura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDADE);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.radFEMININO);
            this.Controls.Add(this.radMASCULINO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Gordura";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gordura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radMASCULINO;
        private System.Windows.Forms.RadioButton radFEMININO;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtIDADE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}