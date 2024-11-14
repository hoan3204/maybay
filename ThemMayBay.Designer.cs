namespace mbbb
{
    partial class ThemMayBay
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
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTenMayBay = new TextBox();
            txtNamSX = new TextBox();
            label3 = new Label();
            txtSoGioBay = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 105);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Máy Bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 168);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "Năm Sản Xuất";
            // 
            // txtTenMayBay
            // 
            txtTenMayBay.Location = new Point(183, 102);
            txtTenMayBay.Name = "txtTenMayBay";
            txtTenMayBay.Size = new Size(125, 27);
            txtTenMayBay.TabIndex = 3;
            // 
            // txtNamSX
            // 
            txtNamSX.Location = new Point(183, 168);
            txtNamSX.Name = "txtNamSX";
            txtNamSX.Size = new Size(125, 27);
            txtNamSX.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 238);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Số Giờ Bay";
            // 
            // txtSoGioBay
            // 
            txtSoGioBay.Location = new Point(183, 238);
            txtSoGioBay.Name = "txtSoGioBay";
            txtSoGioBay.Size = new Size(125, 27);
            txtSoGioBay.TabIndex = 6;
            // 
            // ThemMayBay
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
            Controls.Add(btnAdd);
            Name = "ThemMayBay";
            Text = "ThemMayBay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Label label2;
        private TextBox txtTenMayBay;
        private TextBox txtNamSX;
        private Label label3;
        private TextBox txtSoGioBay;
    }
}