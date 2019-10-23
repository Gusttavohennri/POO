namespace WindowsFormsApplication1
{
    partial class frmEq2grau
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(3, 9);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(76, 9);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(171, 9);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "C";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(246, 9);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(32, 13);
            this.lblDelta.TabIndex = 2;
            this.lblDelta.Text = "Delta";
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(333, 9);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(43, 13);
            this.lblR1.TabIndex = 5;
            this.lblR1.Text = "Raiz 01";
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(413, 9);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(43, 13);
            this.lblR2.TabIndex = 4;
            this.lblR2.Text = "Raiz 02";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(6, 36);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(60, 20);
            this.txtA.TabIndex = 6;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(79, 36);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(60, 20);
            this.txtB.TabIndex = 7;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(249, 36);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(60, 20);
            this.txtDelta.TabIndex = 9;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(174, 36);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(60, 20);
            this.txtC.TabIndex = 8;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(416, 36);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(60, 20);
            this.txtR2.TabIndex = 11;
            this.txtR2.Tag = "";
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(336, 36);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(60, 20);
            this.txtR1.TabIndex = 10;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(246, 86);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(59, 13);
            this.lblMsg.TabIndex = 12;
            this.lblMsg.Tag = "j";
            this.lblMsg.Text = "Mensagem";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(6, 62);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(171, 37);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmEq2grau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(493, 179);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.txtDelta);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "frmEq2grau";
            this.Tag = "1";
            this.Text = "Equação do 2° Grau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCalc;
    }
}

