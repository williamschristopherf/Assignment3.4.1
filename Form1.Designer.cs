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
            coffeeBindingSource = new BindingSource(components);
            isDecafDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            varietyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cRoastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tempFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packageTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeOzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { isDecafDataGridViewCheckBoxColumn, varietyDataGridViewTextBoxColumn, cRoastDataGridViewTextBoxColumn, bevNameDataGridViewTextBoxColumn, tempFDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, packageTypeDataGridViewTextBoxColumn, sizeOzDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = coffeeBindingSource;
            dataGridView1.Location = new Point(27, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(945, 150);
            dataGridView1.TabIndex = 0;
            // 
            // cofeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            // 
            // varietyDataGridViewTextBoxColumn
            // 
            varietyDataGridViewTextBoxColumn.DataPropertyName = "Variety";
            varietyDataGridViewTextBoxColumn.HeaderText = "Variety";
            varietyDataGridViewTextBoxColumn.Name = "varietyDataGridViewTextBoxColumn";
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
            // tempFDataGridViewTextBoxColumn
            // 
            tempFDataGridViewTextBoxColumn.DataPropertyName = "TempF";
            tempFDataGridViewTextBoxColumn.HeaderText = "TempF";
            tempFDataGridViewTextBoxColumn.Name = "tempFDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // packageTypeDataGridViewTextBoxColumn
            // 
            packageTypeDataGridViewTextBoxColumn.DataPropertyName = "PackageType";
            packageTypeDataGridViewTextBoxColumn.HeaderText = "PackageType";
            packageTypeDataGridViewTextBoxColumn.Name = "packageTypeDataGridViewTextBoxColumn";
            // 
            // sizeOzDataGridViewTextBoxColumn
            // 
            sizeOzDataGridViewTextBoxColumn.DataPropertyName = "SizeOz";
            sizeOzDataGridViewTextBoxColumn.HeaderText = "SizeOz";
            sizeOzDataGridViewTextBoxColumn.Name = "sizeOzDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 961);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn varietyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cRoastDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeOzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private BindingSource coffeeBindingSource;
    }
}
