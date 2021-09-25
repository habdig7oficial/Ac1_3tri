
namespace splashScreen
{
    partial class Calorias
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
            this.txtPESO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radEmagecer = new System.Windows.Forms.RadioButton();
            this.radEngoradar = new System.Windows.Forms.RadioButton();
            this.radManter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPESO
            // 
            this.txtPESO.Location = new System.Drawing.Point(75, 250);
            this.txtPESO.Name = "txtPESO";
            this.txtPESO.Size = new System.Drawing.Size(100, 20);
            this.txtPESO.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radEmagecer
            // 
            this.radEmagecer.AutoSize = true;
            this.radEmagecer.Location = new System.Drawing.Point(84, 109);
            this.radEmagecer.Name = "radEmagecer";
            this.radEmagecer.Size = new System.Drawing.Size(76, 17);
            this.radEmagecer.TabIndex = 3;
            this.radEmagecer.TabStop = true;
            this.radEmagecer.Text = "Emagreçer";
            this.radEmagecer.UseVisualStyleBackColor = true;
            // 
            // radEngoradar
            // 
            this.radEngoradar.AutoSize = true;
            this.radEngoradar.Location = new System.Drawing.Point(84, 178);
            this.radEngoradar.Name = "radEngoradar";
            this.radEngoradar.Size = new System.Drawing.Size(87, 17);
            this.radEngoradar.TabIndex = 4;
            this.radEngoradar.TabStop = true;
            this.radEngoradar.Text = "Ganhar Peso";
            this.radEngoradar.UseVisualStyleBackColor = true;
            // 
            // radManter
            // 
            this.radManter.AutoSize = true;
            this.radManter.Location = new System.Drawing.Point(84, 143);
            this.radManter.Name = "radManter";
            this.radManter.Size = new System.Drawing.Size(85, 17);
            this.radManter.TabIndex = 5;
            this.radManter.TabStop = true;
            this.radManter.Text = "Manter Peso";
            this.radManter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calculador de Calorias";
            // 
            // Calorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(250, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radManter);
            this.Controls.Add(this.radEngoradar);
            this.Controls.Add(this.radEmagecer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPESO);
            this.Name = "Calorias";
            this.Text = "Calorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPESO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radEmagecer;
        private System.Windows.Forms.RadioButton radEngoradar;
        private System.Windows.Forms.RadioButton radManter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}