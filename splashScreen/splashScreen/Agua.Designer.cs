
namespace splashScreen
{
    partial class Agua
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
            this.txtPESO = new System.Windows.Forms.TextBox();
            this.txtagua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadência de Água";
            // 
            // txtPESO
            // 
            this.txtPESO.Location = new System.Drawing.Point(81, 133);
            this.txtPESO.Name = "txtPESO";
            this.txtPESO.Size = new System.Drawing.Size(100, 20);
            this.txtPESO.TabIndex = 2;
            // 
            // txtagua
            // 
            this.txtagua.Location = new System.Drawing.Point(81, 225);
            this.txtagua.Name = "txtagua";
            this.txtagua.Size = new System.Drawing.Size(100, 20);
            this.txtagua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade tomada (1 dia)";
            // 
            // Agua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtagua);
            this.Controls.Add(this.txtPESO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Agua";
            this.Text = "Agua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPESO;
        private System.Windows.Forms.TextBox txtagua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}