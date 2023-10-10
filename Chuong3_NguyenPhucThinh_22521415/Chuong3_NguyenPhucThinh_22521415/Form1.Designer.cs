namespace Chuong3_NguyenPhucThinh_22521415
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
            this.lb_ps1 = new System.Windows.Forms.Label();
            this.lb_ps2 = new System.Windows.Forms.Label();
            this.lb_tu = new System.Windows.Forms.Label();
            this.lb_ms = new System.Windows.Forms.Label();
            this.tb_tu1 = new System.Windows.Forms.TextBox();
            this.tb_mau1 = new System.Windows.Forms.TextBox();
            this.tb_tu2 = new System.Windows.Forms.TextBox();
            this.tb_mau2 = new System.Windows.Forms.TextBox();
            this.bt_cong = new System.Windows.Forms.Button();
            this.bt_tru = new System.Windows.Forms.Button();
            this.bt_nhan = new System.Windows.Forms.Button();
            this.bt_chia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ps1
            // 
            this.lb_ps1.AutoSize = true;
            this.lb_ps1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ps1.Location = new System.Drawing.Point(91, 125);
            this.lb_ps1.Name = "lb_ps1";
            this.lb_ps1.Size = new System.Drawing.Size(115, 24);
            this.lb_ps1.TabIndex = 0;
            this.lb_ps1.Text = "Phân số 1: ";
            // 
            // lb_ps2
            // 
            this.lb_ps2.AutoEllipsis = true;
            this.lb_ps2.AutoSize = true;
            this.lb_ps2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ps2.Location = new System.Drawing.Point(91, 176);
            this.lb_ps2.Name = "lb_ps2";
            this.lb_ps2.Size = new System.Drawing.Size(109, 24);
            this.lb_ps2.TabIndex = 1;
            this.lb_ps2.Text = "Phân số 2:";
            // 
            // lb_tu
            // 
            this.lb_tu.AutoSize = true;
            this.lb_tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tu.Location = new System.Drawing.Point(257, 92);
            this.lb_tu.Name = "lb_tu";
            this.lb_tu.Size = new System.Drawing.Size(53, 20);
            this.lb_tu.TabIndex = 2;
            this.lb_tu.Text = "Tử số";
            // 
            // lb_ms
            // 
            this.lb_ms.AutoSize = true;
            this.lb_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ms.Location = new System.Drawing.Point(408, 92);
            this.lb_ms.Name = "lb_ms";
            this.lb_ms.Size = new System.Drawing.Size(67, 20);
            this.lb_ms.TabIndex = 3;
            this.lb_ms.Text = "Mẫu số";
            this.lb_ms.Click += new System.EventHandler(this.lb_ms_Click);
            // 
            // tb_tu1
            // 
            this.tb_tu1.Location = new System.Drawing.Point(233, 125);
            this.tb_tu1.Name = "tb_tu1";
            this.tb_tu1.Size = new System.Drawing.Size(100, 20);
            this.tb_tu1.TabIndex = 4;
            this.tb_tu1.TextChanged += new System.EventHandler(this.tb_tu1_TextChanged);
            // 
            // tb_mau1
            // 
            this.tb_mau1.Location = new System.Drawing.Point(392, 125);
            this.tb_mau1.Name = "tb_mau1";
            this.tb_mau1.Size = new System.Drawing.Size(99, 20);
            this.tb_mau1.TabIndex = 5;
            this.tb_mau1.TextChanged += new System.EventHandler(this.tb_mau1_TextChanged);
            // 
            // tb_tu2
            // 
            this.tb_tu2.Location = new System.Drawing.Point(233, 176);
            this.tb_tu2.Name = "tb_tu2";
            this.tb_tu2.Size = new System.Drawing.Size(100, 20);
            this.tb_tu2.TabIndex = 6;
            this.tb_tu2.TextChanged += new System.EventHandler(this.tb_tu2_TextChanged);
            // 
            // tb_mau2
            // 
            this.tb_mau2.Location = new System.Drawing.Point(392, 176);
            this.tb_mau2.Name = "tb_mau2";
            this.tb_mau2.Size = new System.Drawing.Size(99, 20);
            this.tb_mau2.TabIndex = 7;
            this.tb_mau2.TextChanged += new System.EventHandler(this.tb_mau2_TextChanged);
            // 
            // bt_cong
            // 
            this.bt_cong.Location = new System.Drawing.Point(127, 285);
            this.bt_cong.Name = "bt_cong";
            this.bt_cong.Size = new System.Drawing.Size(75, 23);
            this.bt_cong.TabIndex = 8;
            this.bt_cong.Text = "Cộng";
            this.bt_cong.UseVisualStyleBackColor = true;
            this.bt_cong.Click += new System.EventHandler(this.bt_cong_Click);
            // 
            // bt_tru
            // 
            this.bt_tru.Location = new System.Drawing.Point(233, 285);
            this.bt_tru.Name = "bt_tru";
            this.bt_tru.Size = new System.Drawing.Size(75, 23);
            this.bt_tru.TabIndex = 9;
            this.bt_tru.Text = "Trừ";
            this.bt_tru.UseVisualStyleBackColor = true;
            this.bt_tru.Click += new System.EventHandler(this.bt_tru_Click);
            // 
            // bt_nhan
            // 
            this.bt_nhan.Location = new System.Drawing.Point(340, 285);
            this.bt_nhan.Name = "bt_nhan";
            this.bt_nhan.Size = new System.Drawing.Size(75, 23);
            this.bt_nhan.TabIndex = 10;
            this.bt_nhan.Text = "Nhân";
            this.bt_nhan.UseVisualStyleBackColor = true;
            this.bt_nhan.Click += new System.EventHandler(this.bt_nhan_Click);
            // 
            // bt_chia
            // 
            this.bt_chia.Location = new System.Drawing.Point(451, 285);
            this.bt_chia.Name = "bt_chia";
            this.bt_chia.Size = new System.Drawing.Size(75, 23);
            this.bt_chia.TabIndex = 11;
            this.bt_chia.Text = "Chia";
            this.bt_chia.UseVisualStyleBackColor = true;
            this.bt_chia.Click += new System.EventHandler(this.bt_chia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_chia);
            this.Controls.Add(this.bt_nhan);
            this.Controls.Add(this.bt_tru);
            this.Controls.Add(this.bt_cong);
            this.Controls.Add(this.tb_mau2);
            this.Controls.Add(this.tb_tu2);
            this.Controls.Add(this.tb_mau1);
            this.Controls.Add(this.tb_tu1);
            this.Controls.Add(this.lb_ms);
            this.Controls.Add(this.lb_tu);
            this.Controls.Add(this.lb_ps2);
            this.Controls.Add(this.lb_ps1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ps1;
        private System.Windows.Forms.Label lb_ps2;
        private System.Windows.Forms.Label lb_tu;
        private System.Windows.Forms.Label lb_ms;
        private System.Windows.Forms.TextBox tb_tu1;
        private System.Windows.Forms.TextBox tb_mau1;
        private System.Windows.Forms.TextBox tb_tu2;
        private System.Windows.Forms.TextBox tb_mau2;
        private System.Windows.Forms.Button bt_cong;
        private System.Windows.Forms.Button bt_tru;
        private System.Windows.Forms.Button bt_nhan;
        private System.Windows.Forms.Button bt_chia;
    }
}

