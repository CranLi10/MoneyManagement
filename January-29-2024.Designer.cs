namespace MoneyManagement
{
    partial class BillingInformation
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
            this.BillingLable = new System.Windows.Forms.Label();
            this.BillingInformationGrid = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.SKULabel = new System.Windows.Forms.Label();
            this.VendorNameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DateLable = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillingInformationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BillingLable
            // 
            this.BillingLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillingLable.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingLable.Location = new System.Drawing.Point(12, 9);
            this.BillingLable.Name = "BillingLable";
            this.BillingLable.Size = new System.Drawing.Size(785, 65);
            this.BillingLable.TabIndex = 0;
            this.BillingLable.Text = "Sealed Air Billing Information";
            this.BillingLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BillingLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // BillingInformationGrid
            // 
            this.BillingInformationGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BillingInformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillingInformationGrid.Location = new System.Drawing.Point(12, 257);
            this.BillingInformationGrid.Name = "BillingInformationGrid";
            this.BillingInformationGrid.Size = new System.Drawing.Size(776, 249);
            this.BillingInformationGrid.TabIndex = 1;
            this.BillingInformationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillingInformationGrid_CellContentClick);
            this.BillingInformationGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillingInformationGrid_CellDoubleClick);
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.Silver;
            this.NewButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(12, 178);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(256, 57);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Silver;
            this.saveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(274, 178);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(252, 57);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(532, 178);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(256, 57);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(12, 152);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(256, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(274, 152);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(252, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(532, 152);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(254, 20);
            this.dateTextBox.TabIndex = 7;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(12, 97);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(256, 20);
            this.skuTextBox.TabIndex = 8;
            this.skuTextBox.TextChanged += new System.EventHandler(this.skuTextBox_TextChanged);
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.Location = new System.Drawing.Point(274, 97);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(252, 20);
            this.vendorTextBox.TabIndex = 9;
            // 
            // SKULabel
            // 
            this.SKULabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKULabel.Location = new System.Drawing.Point(11, 74);
            this.SKULabel.Name = "SKULabel";
            this.SKULabel.Size = new System.Drawing.Size(253, 20);
            this.SKULabel.TabIndex = 11;
            this.SKULabel.Text = "SKU";
            this.SKULabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // VendorNameLabel
            // 
            this.VendorNameLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorNameLabel.Location = new System.Drawing.Point(274, 74);
            this.VendorNameLabel.Name = "VendorNameLabel";
            this.VendorNameLabel.Size = new System.Drawing.Size(253, 20);
            this.VendorNameLabel.TabIndex = 12;
            this.VendorNameLabel.Text = "Vendor Name";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(529, 74);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(253, 20);
            this.CategoryLabel.TabIndex = 13;
            this.CategoryLabel.Text = "Category";
            // 
            // DateLable
            // 
            this.DateLable.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLable.Location = new System.Drawing.Point(533, 129);
            this.DateLable.Name = "DateLable";
            this.DateLable.Size = new System.Drawing.Size(253, 20);
            this.DateLable.TabIndex = 14;
            this.DateLable.Text = "Date";
            this.DateLable.Click += new System.EventHandler(this.QuantityLabel_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(274, 129);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(253, 20);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Description";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(12, 129);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(253, 20);
            this.PriceLabel.TabIndex = 16;
            this.PriceLabel.Text = "Price";
            // 
            // categoryBox
            // 
            this.categoryBox.AllowDrop = true;
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Production Supplies",
            "Maintenance Supplies",
            "Contract Labor"});
            this.categoryBox.Location = new System.Drawing.Point(536, 97);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(246, 21);
            this.categoryBox.TabIndex = 17;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // BillingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DateLable);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.VendorNameLabel);
            this.Controls.Add(this.SKULabel);
            this.Controls.Add(this.vendorTextBox);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.BillingInformationGrid);
            this.Controls.Add(this.BillingLable);
            this.Name = "BillingInformation";
            this.Text = "Billing Information";
            this.Load += new System.EventHandler(this.BillingInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillingInformationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BillingLable;
        private System.Windows.Forms.DataGridView BillingInformationGrid;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.Label SKULabel;
        private System.Windows.Forms.Label VendorNameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label DateLable;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}

