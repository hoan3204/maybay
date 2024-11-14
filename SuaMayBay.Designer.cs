namespace mbbb
{
    partial class SuaMayBay
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
            txtSoGioBay = new TextBox();
            label3 = new Label();
            txtNamSX = new TextBox();
            txtTenMayBay = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtSoGioBay
            // 
            txtSoGioBay.Location = new Point(191, 183);
            txtSoGioBay.Name = "txtSoGioBay";
            txtSoGioBay.Size = new Size(125, 27);
            txtSoGioBay.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 183);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 12;
            label3.Text = "Số Giờ Bay";
            // 
            // txtNamSX
            // 
            txtNamSX.Location = new Point(191, 113);
            txtNamSX.Name = "txtNamSX";
            txtNamSX.Size = new Size(125, 27);
            txtNamSX.TabIndex = 11;
            // 
            // txtTenMayBay
            // 
            txtTenMayBay.Location = new Point(191, 47);
            txtTenMayBay.Name = "txtTenMayBay";
            txtTenMayBay.Size = new Size(125, 27);
            txtTenMayBay.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 113);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 9;
            label2.Text = "Năm Sản Xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên Máy Bay";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(45, 235);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.ClientSizeChanged += btnUpdate_ClientSizeChanged;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // SuaMayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoGioBay);
            Controls.Add(label3);
            Controls.Add(txtNamSX);
            Controls.Add(txtTenMayBay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Name = "SuaMayBay";
            Text = "SuaMayBay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoGioBay;
        private Label label3;
        private TextBox txtNamSX;
        private TextBox txtTenMayBay;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
    }
}