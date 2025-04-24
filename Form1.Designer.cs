namespace Assignment3._4._1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            isDecafDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            cRoastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeOzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeBindingSource = new BindingSource(components);
            txtBevName = new TextBox();
            txtPrice = new TextBox();
            txtSizeOz = new TextBox();
            cmbRoast = new ComboBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnDlt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { isDecafDataGridViewCheckBoxColumn, cRoastDataGridViewTextBoxColumn, bevNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, sizeOzDataGridViewTextBoxColumn });
            dataGridView1.DataSource = coffeeBindingSource;
            dataGridView1.Location = new Point(27, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 410);
            dataGridView1.TabIndex = 0;
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            // 
            // cRoastDataGridViewTextBoxColumn
            // 
            cRoastDataGridViewTextBoxColumn.DataPropertyName = "CRoast";
            cRoastDataGridViewTextBoxColumn.HeaderText = "CRoast";
            cRoastDataGridViewTextBoxColumn.Name = "cRoastDataGridViewTextBoxColumn";
            // 
            // bevNameDataGridViewTextBoxColumn
            // 
            bevNameDataGridViewTextBoxColumn.DataPropertyName = "BevName";
            bevNameDataGridViewTextBoxColumn.HeaderText = "BevName";
            bevNameDataGridViewTextBoxColumn.Name = "bevNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sizeOzDataGridViewTextBoxColumn
            // 
            sizeOzDataGridViewTextBoxColumn.DataPropertyName = "SizeOz";
            sizeOzDataGridViewTextBoxColumn.HeaderText = "SizeOz";
            sizeOzDataGridViewTextBoxColumn.Name = "sizeOzDataGridViewTextBoxColumn";
            // 
            // coffeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            // 
            // txtBevName
            // 
            txtBevName.Location = new Point(275, 32);
            txtBevName.Name = "txtBevName";
            txtBevName.Size = new Size(100, 23);
            txtBevName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(381, 32);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtSizeOz
            // 
            txtSizeOz.Location = new Point(487, 32);
            txtSizeOz.Name = "txtSizeOz";
            txtSizeOz.Size = new Size(100, 23);
            txtSizeOz.TabIndex = 3;
            // 
            // cmbRoast
            // 
            cmbRoast.FormattingEnabled = true;
            cmbRoast.Location = new Point(148, 32);
            cmbRoast.Name = "cmbRoast";
            cmbRoast.Size = new Size(121, 23);
            cmbRoast.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(60, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Decaf";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Roast";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 9);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Beverage Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 9);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 9);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 9;
            label4.Text = "Size";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(245, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDlt
            // 
            btnDlt.Location = new Point(349, 76);
            btnDlt.Name = "btnDlt";
            btnDlt.Size = new Size(75, 23);
            btnDlt.TabIndex = 11;
            btnDlt.Text = "Delete";
            btnDlt.UseVisualStyleBackColor = true;
            btnDlt.Click += btnDlt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 611);
            Controls.Add(btnDlt);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(cmbRoast);
            Controls.Add(txtSizeOz);
            Controls.Add(txtPrice);
            Controls.Add(txtBevName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn cRoastDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeOzDataGridViewTextBoxColumn;
        private BindingSource coffeeBindingSource;
        private TextBox txtBevName;
        private TextBox txtPrice;
        private TextBox txtSizeOz;
        private ComboBox cmbRoast;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnDlt;
    }
}
