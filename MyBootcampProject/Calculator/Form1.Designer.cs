﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.btnName1 = new System.Windows.Forms.Button();
            this.btnName2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName1.Location = new System.Drawing.Point(37, 68);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(81, 29);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Hello";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName2.Location = new System.Drawing.Point(242, 74);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(22, 23);
            this.lblName2.TabIndex = 1;
            this.lblName2.Text = "0";
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName3.Location = new System.Drawing.Point(392, 74);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(24, 23);
            this.lblName3.TabIndex = 2;
            this.lblName3.Text = "0";
            // 
            // btnName1
            // 
            this.btnName1.BackColor = System.Drawing.Color.CadetBlue;
            this.btnName1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnName1.Location = new System.Drawing.Point(85, 119);
            this.btnName1.Name = "btnName1";
            this.btnName1.Size = new System.Drawing.Size(150, 80);
            this.btnName1.TabIndex = 3;
            this.btnName1.Text = "НАЖМИ!";
            this.btnName1.UseVisualStyleBackColor = false;
            this.btnName1.Click += new System.EventHandler(this.btnName1_Click);
            // 
            // btnName2
            // 
            this.btnName2.BackColor = System.Drawing.Color.Yellow;
            this.btnName2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnName2.Location = new System.Drawing.Point(279, 119);
            this.btnName2.Name = "btnName2";
            this.btnName2.Size = new System.Drawing.Size(150, 80);
            this.btnName2.TabIndex = 4;
            this.btnName2.Text = "Клик";
            this.btnName2.UseVisualStyleBackColor = false;
            this.btnName2.Click += new System.EventHandler(this.btnName2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(514, 211);
            this.Controls.Add(this.btnName2);
            this.Controls.Add(this.btnName1);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя первая программа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Button btnName1;
        private System.Windows.Forms.Button btnName2;
    }
}

