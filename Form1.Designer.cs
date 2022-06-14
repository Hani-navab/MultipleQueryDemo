namespace MultipleQueryDemo
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
            this.components = new System.ComponentModel.Container();
            this.dbgSales = new System.Windows.Forms.DataGridView();
            this.salesOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierTrackingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialOfferIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsSales = new MultipleQueryDemo.dsSales();
            this.sbsSales = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrderDetailTableAdapter = new MultipleQueryDemo.dsSalesTableAdapters.SalesOrderDetailTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.sbsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.dsProduct = new MultipleQueryDemo.dsProduct();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNoDiscount = new System.Windows.Forms.RadioButton();
            this.btnDiscount = new System.Windows.Forms.RadioButton();
            this.productTableAdapter = new MultipleQueryDemo.dsProductTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbgSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbsSales)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduct)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbgSales
            // 
            this.dbgSales.AutoGenerateColumns = false;
            this.dbgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderIDDataGridViewTextBoxColumn,
            this.salesOrderDetailIDDataGridViewTextBoxColumn,
            this.carrierTrackingNumberDataGridViewTextBoxColumn,
            this.orderQtyDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.specialOfferIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitPriceDiscountDataGridViewTextBoxColumn,
            this.lineTotalDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.dbgSales.DataMember = "SalesOrderDetail";
            this.dbgSales.DataSource = this.dsSales;
            this.dbgSales.Location = new System.Drawing.Point(12, 131);
            this.dbgSales.Name = "dbgSales";
            this.dbgSales.Size = new System.Drawing.Size(676, 297);
            this.dbgSales.TabIndex = 0;
            // 
            // salesOrderIDDataGridViewTextBoxColumn
            // 
            this.salesOrderIDDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn.HeaderText = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn.Name = "salesOrderIDDataGridViewTextBoxColumn";
            // 
            // salesOrderDetailIDDataGridViewTextBoxColumn
            // 
            this.salesOrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderDetailID";
            this.salesOrderDetailIDDataGridViewTextBoxColumn.HeaderText = "SalesOrderDetailID";
            this.salesOrderDetailIDDataGridViewTextBoxColumn.Name = "salesOrderDetailIDDataGridViewTextBoxColumn";
            this.salesOrderDetailIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carrierTrackingNumberDataGridViewTextBoxColumn
            // 
            this.carrierTrackingNumberDataGridViewTextBoxColumn.DataPropertyName = "CarrierTrackingNumber";
            this.carrierTrackingNumberDataGridViewTextBoxColumn.HeaderText = "CarrierTrackingNumber";
            this.carrierTrackingNumberDataGridViewTextBoxColumn.Name = "carrierTrackingNumberDataGridViewTextBoxColumn";
            // 
            // orderQtyDataGridViewTextBoxColumn
            // 
            this.orderQtyDataGridViewTextBoxColumn.DataPropertyName = "OrderQty";
            this.orderQtyDataGridViewTextBoxColumn.HeaderText = "OrderQty";
            this.orderQtyDataGridViewTextBoxColumn.Name = "orderQtyDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // specialOfferIDDataGridViewTextBoxColumn
            // 
            this.specialOfferIDDataGridViewTextBoxColumn.DataPropertyName = "SpecialOfferID";
            this.specialOfferIDDataGridViewTextBoxColumn.HeaderText = "SpecialOfferID";
            this.specialOfferIDDataGridViewTextBoxColumn.Name = "specialOfferIDDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // unitPriceDiscountDataGridViewTextBoxColumn
            // 
            this.unitPriceDiscountDataGridViewTextBoxColumn.DataPropertyName = "UnitPriceDiscount";
            this.unitPriceDiscountDataGridViewTextBoxColumn.HeaderText = "UnitPriceDiscount";
            this.unitPriceDiscountDataGridViewTextBoxColumn.Name = "unitPriceDiscountDataGridViewTextBoxColumn";
            // 
            // lineTotalDataGridViewTextBoxColumn
            // 
            this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.HeaderText = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
            this.lineTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // dsSales
            // 
            this.dsSales.DataSetName = "dsSales";
            this.dsSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sbsSales
            // 
            this.sbsSales.DataMember = "SalesOrderDetail";
            this.sbsSales.DataSource = this.dsSales;
            // 
            // salesOrderDetailTableAdapter
            // 
            this.salesOrderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 100);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboProduct);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search By Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboProduct
            // 
            this.cboProduct.DataSource = this.sbsProduct;
            this.cboProduct.DisplayMember = "Name";
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(113, 17);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(278, 21);
            this.cboProduct.TabIndex = 1;
            this.cboProduct.ValueMember = "ProductID";
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sbsProduct
            // 
            this.sbsProduct.DataMember = "Product";
            this.sbsProduct.DataSource = this.dsProduct;
            // 
            // dsProduct
            // 
            this.dsProduct.DataSetName = "dsProduct";
            this.dsProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearchByDate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtpEnd);
            this.tabPage2.Controls.Add(this.dtpStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search By Date";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(567, 24);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByDate.TabIndex = 4;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From : ";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(339, 24);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(79, 24);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnNoDiscount);
            this.tabPage3.Controls.Add(this.btnDiscount);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(668, 74);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search By Discount";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNoDiscount
            // 
            this.btnNoDiscount.AutoSize = true;
            this.btnNoDiscount.Location = new System.Drawing.Point(287, 23);
            this.btnNoDiscount.Name = "btnNoDiscount";
            this.btnNoDiscount.Size = new System.Drawing.Size(84, 17);
            this.btnNoDiscount.TabIndex = 1;
            this.btnNoDiscount.TabStop = true;
            this.btnNoDiscount.Text = "No Discount";
            this.btnNoDiscount.UseVisualStyleBackColor = true;
            this.btnNoDiscount.CheckedChanged += new System.EventHandler(this.btnNoDiscount_CheckedChanged);
            // 
            // btnDiscount
            // 
            this.btnDiscount.AutoSize = true;
            this.btnDiscount.Location = new System.Drawing.Point(120, 23);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(92, 17);
            this.btnDiscount.TabIndex = 0;
            this.btnDiscount.TabStop = true;
            this.btnDiscount.Text = "With Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.CheckedChanged += new System.EventHandler(this.btnNoDiscount_CheckedChanged);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dbgSales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbsSales)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgSales;
        private System.Windows.Forms.BindingSource sbsSales;
        private dsSales dsSales;
        private MultipleQueryDemo.dsSalesTableAdapters.SalesOrderDetailTableAdapter salesOrderDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierTrackingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialOfferIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.BindingSource sbsProduct;
        private dsProduct dsProduct;
        private MultipleQueryDemo.dsProductTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton btnNoDiscount;
        private System.Windows.Forms.RadioButton btnDiscount;
    }
}

