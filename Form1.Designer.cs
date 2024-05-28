namespace ResoluçãoProblemas
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
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnProblemaA = new System.Windows.Forms.Button();
            this.btnProblemaB = new System.Windows.Forms.Button();
            this.btnProblemaC = new System.Windows.Forms.Button();
            this.btnProblemaD = new System.Windows.Forms.Button();
            this.btnProblemaE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultado.Location = new System.Drawing.Point(315, 76);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultado.Size = new System.Drawing.Size(415, 229);
            this.textBoxResultado.TabIndex = 0;
            // 
            // btnProblemaA
            // 
            this.btnProblemaA.BackColor = System.Drawing.Color.HotPink;
            this.btnProblemaA.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblemaA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProblemaA.Location = new System.Drawing.Point(101, 76);
            this.btnProblemaA.Name = "btnProblemaA";
            this.btnProblemaA.Size = new System.Drawing.Size(115, 35);
            this.btnProblemaA.TabIndex = 1;
            this.btnProblemaA.Text = "Resultado A";
            this.btnProblemaA.UseVisualStyleBackColor = false;
            this.btnProblemaA.Click += new System.EventHandler(this.btnProblemaA_Click);
            // 
            // btnProblemaB
            // 
            this.btnProblemaB.BackColor = System.Drawing.Color.HotPink;
            this.btnProblemaB.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblemaB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProblemaB.Location = new System.Drawing.Point(101, 127);
            this.btnProblemaB.Name = "btnProblemaB";
            this.btnProblemaB.Size = new System.Drawing.Size(115, 35);
            this.btnProblemaB.TabIndex = 2;
            this.btnProblemaB.Text = "Resultado B";
            this.btnProblemaB.UseVisualStyleBackColor = false;
            this.btnProblemaB.Click += new System.EventHandler(this.btnProblemaB_Click);
            // 
            // btnProblemaC
            // 
            this.btnProblemaC.BackColor = System.Drawing.Color.HotPink;
            this.btnProblemaC.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblemaC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProblemaC.Location = new System.Drawing.Point(101, 174);
            this.btnProblemaC.Name = "btnProblemaC";
            this.btnProblemaC.Size = new System.Drawing.Size(115, 35);
            this.btnProblemaC.TabIndex = 3;
            this.btnProblemaC.Text = "Resultado C";
            this.btnProblemaC.UseVisualStyleBackColor = false;
            this.btnProblemaC.Click += new System.EventHandler(this.btnProblemaC_Click);
            // 
            // btnProblemaD
            // 
            this.btnProblemaD.BackColor = System.Drawing.Color.HotPink;
            this.btnProblemaD.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblemaD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProblemaD.Location = new System.Drawing.Point(101, 220);
            this.btnProblemaD.Name = "btnProblemaD";
            this.btnProblemaD.Size = new System.Drawing.Size(115, 35);
            this.btnProblemaD.TabIndex = 4;
            this.btnProblemaD.Text = "Resultado D";
            this.btnProblemaD.UseVisualStyleBackColor = false;
            this.btnProblemaD.Click += new System.EventHandler(this.btnProblemaD_Click);
            // 
            // btnProblemaE
            // 
            this.btnProblemaE.BackColor = System.Drawing.Color.HotPink;
            this.btnProblemaE.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblemaE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProblemaE.Location = new System.Drawing.Point(101, 270);
            this.btnProblemaE.Name = "btnProblemaE";
            this.btnProblemaE.Size = new System.Drawing.Size(115, 35);
            this.btnProblemaE.TabIndex = 5;
            this.btnProblemaE.Text = "Resultado E";
            this.btnProblemaE.UseVisualStyleBackColor = false;
            this.btnProblemaE.Click += new System.EventHandler(this.btnProblemaE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProblemaE);
            this.Controls.Add(this.btnProblemaD);
            this.Controls.Add(this.btnProblemaC);
            this.Controls.Add(this.btnProblemaB);
            this.Controls.Add(this.btnProblemaA);
            this.Controls.Add(this.textBoxResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnProblemaA;
        private System.Windows.Forms.Button btnProblemaB;
        private System.Windows.Forms.Button btnProblemaC;
        private System.Windows.Forms.Button btnProblemaD;
        private System.Windows.Forms.Button btnProblemaE;
    }
}