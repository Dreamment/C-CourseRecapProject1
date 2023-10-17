namespace RecapProject1
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
            gbxFilterCatogeries = new GroupBox();
            lblFilterCategory = new Label();
            cbxFilterCategory = new ComboBox();
            gbxFilterName = new GroupBox();
            lblFilterSearch = new Label();
            tbxFilterName = new TextBox();
            dataGridView1 = new DataGridView();
            gbxFilterCatogeries.SuspendLayout();
            gbxFilterName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbxFilterCatogeries
            // 
            gbxFilterCatogeries.Controls.Add(lblFilterCategory);
            gbxFilterCatogeries.Controls.Add(cbxFilterCategory);
            gbxFilterCatogeries.Location = new Point(12, 12);
            gbxFilterCatogeries.Name = "gbxFilterCatogeries";
            gbxFilterCatogeries.Size = new Size(814, 96);
            gbxFilterCatogeries.TabIndex = 0;
            gbxFilterCatogeries.TabStop = false;
            gbxFilterCatogeries.Text = "Filter By Category";
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilterCategory.Location = new Point(24, 34);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(72, 19);
            lblFilterCategory.TabIndex = 1;
            lblFilterCategory.Text = "Category :";
            // 
            // cbxFilterCategory
            // 
            cbxFilterCategory.FormattingEnabled = true;
            cbxFilterCategory.Location = new Point(105, 33);
            cbxFilterCategory.Name = "cbxFilterCategory";
            cbxFilterCategory.Size = new Size(222, 23);
            cbxFilterCategory.TabIndex = 0;
            // 
            // gbxFilterName
            // 
            gbxFilterName.Controls.Add(tbxFilterName);
            gbxFilterName.Controls.Add(lblFilterSearch);
            gbxFilterName.Location = new Point(12, 114);
            gbxFilterName.Name = "gbxFilterName";
            gbxFilterName.Size = new Size(814, 96);
            gbxFilterName.TabIndex = 2;
            gbxFilterName.TabStop = false;
            gbxFilterName.Text = "Filter By Name";
            // 
            // lblFilterSearch
            // 
            lblFilterSearch.AutoSize = true;
            lblFilterSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilterSearch.Location = new Point(44, 34);
            lblFilterSearch.Name = "lblFilterSearch";
            lblFilterSearch.Size = new Size(52, 19);
            lblFilterSearch.TabIndex = 1;
            lblFilterSearch.Text = "Name :";
            // 
            // tbxFilterName
            // 
            tbxFilterName.Location = new Point(105, 33);
            tbxFilterName.Name = "tbxFilterName";
            tbxFilterName.Size = new Size(222, 23);
            tbxFilterName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(814, 213);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 441);
            Controls.Add(dataGridView1);
            Controls.Add(gbxFilterName);
            Controls.Add(gbxFilterCatogeries);
            Name = "Form1";
            Text = "Products";
            gbxFilterCatogeries.ResumeLayout(false);
            gbxFilterCatogeries.PerformLayout();
            gbxFilterName.ResumeLayout(false);
            gbxFilterName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxFilterCatogeries;
        private Label lblFilterCategory;
        private ComboBox cbxFilterCategory;
        private GroupBox gbxFilterName;
        private TextBox tbxFilterName;
        private Label lblFilterSearch;
        private DataGridView dataGridView1;
    }
}