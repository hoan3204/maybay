namespace mbbb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewMayBay = new DataGridView();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMayBay).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMayBay
            // 
            dataGridViewMayBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMayBay.Location = new Point(81, 110);
            dataGridViewMayBay.Name = "dataGridViewMayBay";
            dataGridViewMayBay.RowHeadersWidth = 51;
            dataGridViewMayBay.Size = new Size(650, 188);
            dataGridViewMayBay.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(489, 361);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm máy bay";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(239, 362);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(285, 27);
            label1.Name = "label1";
            label1.Size = new Size(205, 35);
            label1.TabIndex = 4;
            label1.Text = "Quản Lý Máy Bay";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridViewMayBay);
            Name = "Form1";
            Text = "Form1";
            Load += MayBayForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMayBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMayBay;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnEdit;
        private Label label1;
    }
}
