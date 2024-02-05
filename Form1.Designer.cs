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
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.SKUInformation = new System.Windows.Forms.TextBox();
            this.VendorInformation = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.SKULabel = new System.Windows.Forms.Label();
            this.VendorNameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
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
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Silver;
            this.EditButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(274, 178);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(252, 57);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
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
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(12, 152);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(256, 20);
            this.Price.TabIndex = 5;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(274, 152);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(252, 20);
            this.Description.TabIndex = 6;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(532, 152);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(254, 20);
            this.Quantity.TabIndex = 7;
            // 
            // SKUInformation
            // 
            this.SKUInformation.Location = new System.Drawing.Point(12, 97);
            this.SKUInformation.Name = "SKUInformation";
            this.SKUInformation.Size = new System.Drawing.Size(256, 20);
            this.SKUInformation.TabIndex = 8;
            // 
            // VendorInformation
            // 
            this.VendorInformation.Location = new System.Drawing.Point(274, 97);
            this.VendorInformation.Name = "VendorInformation";
            this.VendorInformation.Size = new System.Drawing.Size(252, 20);
            this.VendorInformation.TabIndex = 9;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(532, 97);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(254, 20);
            this.Category.TabIndex = 10;
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
            // QuantityLabel
            // 
            this.QuantityLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(533, 129);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(253, 20);
            this.QuantityLabel.TabIndex = 14;
            this.QuantityLabel.Text = "Quantity";
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
            // BillingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.VendorNameLabel);
            this.Controls.Add(this.SKULabel);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.VendorInformation);
            this.Controls.Add(this.SKUInformation);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.BillingInformationGrid);
            this.Controls.Add(this.BillingLable);
            this.Name = "BillingInformation";
            this.Text = "Billing Information";
            ((System.ComponentModel.ISupportInitialize)(this.BillingInformationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BillingLable;
        private System.Windows.Forms.DataGridView BillingInformationGrid;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox SKUInformation;
        private System.Windows.Forms.TextBox VendorInformation;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.Label SKULabel;
        private System.Windows.Forms.Label VendorNameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceLabel;
    }
}

