namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBNumber1 = new System.Windows.Forms.TextBox();
            this.txtBNumber2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplay = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второе число:";
            // 
            // txtBNumber1
            // 
            this.txtBNumber1.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtBNumber1.Location = new System.Drawing.Point(205, 45);
            this.txtBNumber1.Name = "txtBNumber1";
            this.txtBNumber1.Size = new System.Drawing.Size(100, 30);
            this.txtBNumber1.TabIndex = 2;
            this.txtBNumber1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtBNumber2
            // 
            this.txtBNumber2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBNumber2.Location = new System.Drawing.Point(205, 99);
            this.txtBNumber2.Name = "txtBNumber2";
            this.txtBNumber2.Size = new System.Drawing.Size(100, 30);
            this.txtBNumber2.TabIndex = 3;
            this.txtBNumber2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Orange;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(16, 204);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 70);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(239, 357);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(26, 26);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "*";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Orange;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(92, 204);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 70);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMultiplay
            // 
            this.btnMultiplay.BackColor = System.Drawing.Color.Orange;
            this.btnMultiplay.FlatAppearance.BorderSize = 0;
            this.btnMultiplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplay.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiplay.Location = new System.Drawing.Point(168, 204);
            this.btnMultiplay.Name = "btnMultiplay";
            this.btnMultiplay.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnMultiplay.Size = new System.Drawing.Size(70, 70);
            this.btnMultiplay.TabIndex = 11;
            this.btnMultiplay.Text = "*";
            this.btnMultiplay.UseVisualStyleBackColor = false;
            this.btnMultiplay.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Orange;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(244, 204);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 70);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiplay);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtBNumber2);
            this.Controls.Add(this.txtBNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBNumber1;
        private System.Windows.Forms.TextBox txtBNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplay;
        private System.Windows.Forms.Button btnDivide;
    }
}