﻿namespace QuanLySanBongMini
{
    partial class fNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapHang));
            this.btThemNganhHang = new System.Windows.Forms.Button();
            this.btXoaNganhHang = new System.Windows.Forms.Button();
            this.btSuaNganhHang = new System.Windows.Forms.Button();
            this.tbtenNganhHang = new System.Windows.Forms.TextBox();
            this.lvNganhHang = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btThemNganhHang
            // 
            this.btThemNganhHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNganhHang.Image = global::QuanLySanBongMini.Properties.Resources.plus_2_math_34px3;
            this.btThemNganhHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemNganhHang.Location = new System.Drawing.Point(212, 12);
            this.btThemNganhHang.Name = "btThemNganhHang";
            this.btThemNganhHang.Size = new System.Drawing.Size(80, 39);
            this.btThemNganhHang.TabIndex = 1;
            this.btThemNganhHang.Text = "Thêm";
            this.btThemNganhHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemNganhHang.UseVisualStyleBackColor = true;
            this.btThemNganhHang.Click += new System.EventHandler(this.btThemNganhHang_Click);
            // 
            // btXoaNganhHang
            // 
            this.btXoaNganhHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNganhHang.Image = global::QuanLySanBongMini.Properties.Resources.delete_sign_34px;
            this.btXoaNganhHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaNganhHang.Location = new System.Drawing.Point(212, 102);
            this.btXoaNganhHang.Name = "btXoaNganhHang";
            this.btXoaNganhHang.Size = new System.Drawing.Size(80, 39);
            this.btXoaNganhHang.TabIndex = 2;
            this.btXoaNganhHang.Text = "Xóa";
            this.btXoaNganhHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaNganhHang.UseVisualStyleBackColor = true;
            // 
            // btSuaNganhHang
            // 
            this.btSuaNganhHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNganhHang.Image = global::QuanLySanBongMini.Properties.Resources.pencil_tip_34px1;
            this.btSuaNganhHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaNganhHang.Location = new System.Drawing.Point(212, 57);
            this.btSuaNganhHang.Name = "btSuaNganhHang";
            this.btSuaNganhHang.Size = new System.Drawing.Size(80, 39);
            this.btSuaNganhHang.TabIndex = 3;
            this.btSuaNganhHang.Text = "Sửa";
            this.btSuaNganhHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaNganhHang.UseVisualStyleBackColor = true;
            // 
            // tbtenNganhHang
            // 
            this.tbtenNganhHang.Location = new System.Drawing.Point(48, 13);
            this.tbtenNganhHang.Name = "tbtenNganhHang";
            this.tbtenNganhHang.Size = new System.Drawing.Size(157, 20);
            this.tbtenNganhHang.TabIndex = 4;
            // 
            // lvNganhHang
            // 
            this.lvNganhHang.HideSelection = false;
            this.lvNganhHang.Location = new System.Drawing.Point(12, 39);
            this.lvNganhHang.Name = "lvNganhHang";
            this.lvNganhHang.Size = new System.Drawing.Size(193, 243);
            this.lvNganhHang.TabIndex = 0;
            this.lvNganhHang.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên";
            // 
            // fNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtenNganhHang);
            this.Controls.Add(this.btSuaNganhHang);
            this.Controls.Add(this.btXoaNganhHang);
            this.Controls.Add(this.btThemNganhHang);
            this.Controls.Add(this.lvNganhHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ngành hàng";
            this.Load += new System.EventHandler(this.fNhapHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btThemNganhHang;
        private System.Windows.Forms.Button btXoaNganhHang;
        private System.Windows.Forms.Button btSuaNganhHang;
        private System.Windows.Forms.TextBox tbtenNganhHang;
        private System.Windows.Forms.ListView lvNganhHang;
        private System.Windows.Forms.Label label1;
    }
}