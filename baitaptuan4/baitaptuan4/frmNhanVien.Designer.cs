﻿namespace baitaptuan4
{
    partial class frmNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_msnv = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương cơ bản";
            // 
            // txt_msnv
            // 
            this.txt_msnv.Location = new System.Drawing.Point(176, 53);
            this.txt_msnv.Name = "txt_msnv";
            this.txt_msnv.Size = new System.Drawing.Size(192, 22);
            this.txt_msnv.TabIndex = 3;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(176, 121);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(192, 22);
            this.txt_ten.TabIndex = 4;
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(176, 189);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(192, 22);
            this.txt_luong.TabIndex = 5;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(176, 263);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(293, 263);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 318);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txt_luong);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_msnv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_msnv;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}