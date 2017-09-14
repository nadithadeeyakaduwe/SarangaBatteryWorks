namespace SarangaBatteryWorks.Forms
{
    partial class Main
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
            this.Main_page = new System.Windows.Forms.TabControl();
            this.tabPage_stock = new System.Windows.Forms.TabPage();
            this.table_stock = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage_sales = new System.Windows.Forms.TabPage();
            this.tabPage_invoice = new System.Windows.Forms.TabPage();
            this.tabPage_reorder = new System.Windows.Forms.TabPage();
            this.table_reorders = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer_salestab = new System.Windows.Forms.SplitContainer();
            this.lbl_customer_salestab = new System.Windows.Forms.Label();
            this.lbl_battery_salestab = new System.Windows.Forms.Label();
            this.lbl_customerName_salestab = new System.Windows.Forms.Label();
            this.lbl_customertelephone_salestab = new System.Windows.Forms.Label();
            this.lbl_customerAddress_salestab = new System.Windows.Forms.Label();
            this.txtbx_cusName_salestab = new System.Windows.Forms.TextBox();
            this.txtbx_cusPhone_salestab = new System.Windows.Forms.TextBox();
            this.txtbx_cusAddress_salestab = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl_batteryPrice_salestab = new System.Windows.Forms.Label();
            this.lbl_batteryType_salestab = new System.Windows.Forms.Label();
            this.lbl_batteryMake_salestab = new System.Windows.Forms.Label();
            this.lbl_warrenty_salestab = new System.Windows.Forms.Label();
            this._lbl_fullWarrenty_salestab = new System.Windows.Forms.Label();
            this._lbl_prorataWarrenty_salestab = new System.Windows.Forms.Label();
            this.txtbx_fullWarrenty_salestab = new System.Windows.Forms.TextBox();
            this.txtbx_prorataWarrenty_salestab = new System.Windows.Forms.TextBox();
            this.btn_invoice_salestab = new System.Windows.Forms.Button();
            this.Main_page.SuspendLayout();
            this.tabPage_stock.SuspendLayout();
            this.tabPage_sales.SuspendLayout();
            this.tabPage_reorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_salestab)).BeginInit();
            this.splitContainer_salestab.Panel1.SuspendLayout();
            this.splitContainer_salestab.Panel2.SuspendLayout();
            this.splitContainer_salestab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_page
            // 
            this.Main_page.Controls.Add(this.tabPage_stock);
            this.Main_page.Controls.Add(this.tabPage_sales);
            this.Main_page.Controls.Add(this.tabPage_invoice);
            this.Main_page.Controls.Add(this.tabPage_reorder);
            this.Main_page.Location = new System.Drawing.Point(1, 12);
            this.Main_page.Name = "Main_page";
            this.Main_page.SelectedIndex = 0;
            this.Main_page.Size = new System.Drawing.Size(628, 338);
            this.Main_page.TabIndex = 0;
            // 
            // tabPage_stock
            // 
            this.tabPage_stock.Controls.Add(this.table_stock);
            this.tabPage_stock.Location = new System.Drawing.Point(4, 22);
            this.tabPage_stock.Name = "tabPage_stock";
            this.tabPage_stock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_stock.Size = new System.Drawing.Size(749, 283);
            this.tabPage_stock.TabIndex = 0;
            this.tabPage_stock.Text = "STOCK";
            this.tabPage_stock.UseVisualStyleBackColor = true;
            // 
            // table_stock
            // 
            this.table_stock.ColumnCount = 7;
            this.table_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.99454F));
            this.table_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.00546F));
            this.table_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.table_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.table_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.table_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.table_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.table_stock.Location = new System.Drawing.Point(3, 40);
            this.table_stock.Name = "table_stock";
            this.table_stock.RowCount = 2;
            this.table_stock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_stock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_stock.Size = new System.Drawing.Size(737, 162);
            this.table_stock.TabIndex = 1;
            // 
            // tabPage_sales
            // 
            this.tabPage_sales.Controls.Add(this.splitContainer_salestab);
            this.tabPage_sales.Location = new System.Drawing.Point(4, 22);
            this.tabPage_sales.Name = "tabPage_sales";
            this.tabPage_sales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sales.Size = new System.Drawing.Size(620, 312);
            this.tabPage_sales.TabIndex = 1;
            this.tabPage_sales.Text = "SALES";
            this.tabPage_sales.UseVisualStyleBackColor = true;
            this.tabPage_sales.Click += new System.EventHandler(this.tabPage_sales_Click);
            // 
            // tabPage_invoice
            // 
            this.tabPage_invoice.Location = new System.Drawing.Point(4, 22);
            this.tabPage_invoice.Name = "tabPage_invoice";
            this.tabPage_invoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_invoice.Size = new System.Drawing.Size(620, 312);
            this.tabPage_invoice.TabIndex = 2;
            this.tabPage_invoice.Text = "INVOICE";
            this.tabPage_invoice.UseVisualStyleBackColor = true;
            // 
            // tabPage_reorder
            // 
            this.tabPage_reorder.Controls.Add(this.table_reorders);
            this.tabPage_reorder.Location = new System.Drawing.Point(4, 22);
            this.tabPage_reorder.Name = "tabPage_reorder";
            this.tabPage_reorder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_reorder.Size = new System.Drawing.Size(749, 283);
            this.tabPage_reorder.TabIndex = 3;
            this.tabPage_reorder.Text = "RE-ORDERS";
            this.tabPage_reorder.UseVisualStyleBackColor = true;
            // 
            // table_reorders
            // 
            this.table_reorders.ColumnCount = 7;
            this.table_reorders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.99454F));
            this.table_reorders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.00546F));
            this.table_reorders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.table_reorders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.table_reorders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.table_reorders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.table_reorders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.table_reorders.Location = new System.Drawing.Point(7, 38);
            this.table_reorders.Name = "table_reorders";
            this.table_reorders.RowCount = 2;
            this.table_reorders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_reorders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_reorders.Size = new System.Drawing.Size(736, 100);
            this.table_reorders.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // splitContainer_salestab
            // 
            this.splitContainer_salestab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_salestab.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_salestab.Name = "splitContainer_salestab";
            // 
            // splitContainer_salestab.Panel1
            // 
            this.splitContainer_salestab.Panel1.Controls.Add(this.txtbx_cusAddress_salestab);
            this.splitContainer_salestab.Panel1.Controls.Add(this.txtbx_cusPhone_salestab);
            this.splitContainer_salestab.Panel1.Controls.Add(this.txtbx_cusName_salestab);
            this.splitContainer_salestab.Panel1.Controls.Add(this.lbl_customerAddress_salestab);
            this.splitContainer_salestab.Panel1.Controls.Add(this.lbl_customertelephone_salestab);
            this.splitContainer_salestab.Panel1.Controls.Add(this.lbl_customerName_salestab);
            this.splitContainer_salestab.Panel1.Controls.Add(this.lbl_customer_salestab);
            // 
            // splitContainer_salestab.Panel2
            // 
            this.splitContainer_salestab.Panel2.Controls.Add(this.btn_invoice_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this.txtbx_prorataWarrenty_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this.txtbx_fullWarrenty_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this._lbl_prorataWarrenty_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this._lbl_fullWarrenty_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this.lbl_warrenty_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this.textBox4);
            this.splitContainer_salestab.Panel2.Controls.Add(this.textBox5);
            this.splitContainer_salestab.Panel2.Controls.Add(this.textBox6);
            this.splitContainer_salestab.Panel2.Controls.Add(this.lbl_batteryPrice_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this.lbl_batteryType_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this.lbl_batteryMake_salestab);
            this.splitContainer_salestab.Panel2.Controls.Add(this.lbl_battery_salestab);
            this.splitContainer_salestab.Size = new System.Drawing.Size(614, 306);
            this.splitContainer_salestab.SplitterDistance = 309;
            this.splitContainer_salestab.TabIndex = 0;
            // 
            // lbl_customer_salestab
            // 
            this.lbl_customer_salestab.AutoSize = true;
            this.lbl_customer_salestab.Location = new System.Drawing.Point(133, 19);
            this.lbl_customer_salestab.Name = "lbl_customer_salestab";
            this.lbl_customer_salestab.Size = new System.Drawing.Size(68, 13);
            this.lbl_customer_salestab.TabIndex = 0;
            this.lbl_customer_salestab.Text = "CUSTOMER";
            // 
            // lbl_battery_salestab
            // 
            this.lbl_battery_salestab.AutoSize = true;
            this.lbl_battery_salestab.Location = new System.Drawing.Point(133, 19);
            this.lbl_battery_salestab.Name = "lbl_battery_salestab";
            this.lbl_battery_salestab.Size = new System.Drawing.Size(57, 13);
            this.lbl_battery_salestab.TabIndex = 1;
            this.lbl_battery_salestab.Text = "BATTERY";
            // 
            // lbl_customerName_salestab
            // 
            this.lbl_customerName_salestab.AutoSize = true;
            this.lbl_customerName_salestab.Location = new System.Drawing.Point(27, 59);
            this.lbl_customerName_salestab.Name = "lbl_customerName_salestab";
            this.lbl_customerName_salestab.Size = new System.Drawing.Size(35, 13);
            this.lbl_customerName_salestab.TabIndex = 2;
            this.lbl_customerName_salestab.Text = "Name";
            // 
            // lbl_customertelephone_salestab
            // 
            this.lbl_customertelephone_salestab.AutoSize = true;
            this.lbl_customertelephone_salestab.Location = new System.Drawing.Point(4, 91);
            this.lbl_customertelephone_salestab.Name = "lbl_customertelephone_salestab";
            this.lbl_customertelephone_salestab.Size = new System.Drawing.Size(58, 13);
            this.lbl_customertelephone_salestab.TabIndex = 3;
            this.lbl_customertelephone_salestab.Text = "Telephone";
            // 
            // lbl_customerAddress_salestab
            // 
            this.lbl_customerAddress_salestab.AutoSize = true;
            this.lbl_customerAddress_salestab.Location = new System.Drawing.Point(17, 144);
            this.lbl_customerAddress_salestab.Name = "lbl_customerAddress_salestab";
            this.lbl_customerAddress_salestab.Size = new System.Drawing.Size(45, 13);
            this.lbl_customerAddress_salestab.TabIndex = 4;
            this.lbl_customerAddress_salestab.Text = "Address";
            // 
            // txtbx_cusName_salestab
            // 
            this.txtbx_cusName_salestab.Location = new System.Drawing.Point(92, 56);
            this.txtbx_cusName_salestab.Name = "txtbx_cusName_salestab";
            this.txtbx_cusName_salestab.Size = new System.Drawing.Size(201, 20);
            this.txtbx_cusName_salestab.TabIndex = 5;
            // 
            // txtbx_cusPhone_salestab
            // 
            this.txtbx_cusPhone_salestab.Location = new System.Drawing.Point(92, 88);
            this.txtbx_cusPhone_salestab.Multiline = true;
            this.txtbx_cusPhone_salestab.Name = "txtbx_cusPhone_salestab";
            this.txtbx_cusPhone_salestab.Size = new System.Drawing.Size(201, 41);
            this.txtbx_cusPhone_salestab.TabIndex = 6;
            // 
            // txtbx_cusAddress_salestab
            // 
            this.txtbx_cusAddress_salestab.Location = new System.Drawing.Point(92, 141);
            this.txtbx_cusAddress_salestab.Multiline = true;
            this.txtbx_cusAddress_salestab.Name = "txtbx_cusAddress_salestab";
            this.txtbx_cusAddress_salestab.Size = new System.Drawing.Size(201, 56);
            this.txtbx_cusAddress_salestab.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 88);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(79, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(201, 20);
            this.textBox6.TabIndex = 11;
            // 
            // lbl_batteryPrice_salestab
            // 
            this.lbl_batteryPrice_salestab.AutoSize = true;
            this.lbl_batteryPrice_salestab.Location = new System.Drawing.Point(17, 126);
            this.lbl_batteryPrice_salestab.Name = "lbl_batteryPrice_salestab";
            this.lbl_batteryPrice_salestab.Size = new System.Drawing.Size(31, 13);
            this.lbl_batteryPrice_salestab.TabIndex = 10;
            this.lbl_batteryPrice_salestab.Text = "Price";
            this.lbl_batteryPrice_salestab.Click += new System.EventHandler(this.lbl_batteryPrice_salestab_Click);
            // 
            // lbl_batteryType_salestab
            // 
            this.lbl_batteryType_salestab.AutoSize = true;
            this.lbl_batteryType_salestab.Location = new System.Drawing.Point(14, 91);
            this.lbl_batteryType_salestab.Name = "lbl_batteryType_salestab";
            this.lbl_batteryType_salestab.Size = new System.Drawing.Size(31, 13);
            this.lbl_batteryType_salestab.TabIndex = 9;
            this.lbl_batteryType_salestab.Text = "Type";
            // 
            // lbl_batteryMake_salestab
            // 
            this.lbl_batteryMake_salestab.AutoSize = true;
            this.lbl_batteryMake_salestab.Location = new System.Drawing.Point(14, 59);
            this.lbl_batteryMake_salestab.Name = "lbl_batteryMake_salestab";
            this.lbl_batteryMake_salestab.Size = new System.Drawing.Size(34, 13);
            this.lbl_batteryMake_salestab.TabIndex = 8;
            this.lbl_batteryMake_salestab.Text = "Make";
            // 
            // lbl_warrenty_salestab
            // 
            this.lbl_warrenty_salestab.AutoSize = true;
            this.lbl_warrenty_salestab.Location = new System.Drawing.Point(14, 160);
            this.lbl_warrenty_salestab.Name = "lbl_warrenty_salestab";
            this.lbl_warrenty_salestab.Size = new System.Drawing.Size(70, 13);
            this.lbl_warrenty_salestab.TabIndex = 14;
            this.lbl_warrenty_salestab.Text = "WARRENTY";
            // 
            // _lbl_fullWarrenty_salestab
            // 
            this._lbl_fullWarrenty_salestab.AutoSize = true;
            this._lbl_fullWarrenty_salestab.Location = new System.Drawing.Point(31, 184);
            this._lbl_fullWarrenty_salestab.Name = "_lbl_fullWarrenty_salestab";
            this._lbl_fullWarrenty_salestab.Size = new System.Drawing.Size(99, 13);
            this._lbl_fullWarrenty_salestab.TabIndex = 15;
            this._lbl_fullWarrenty_salestab.Text = "FULL WARRENTY";
            // 
            // _lbl_prorataWarrenty_salestab
            // 
            this._lbl_prorataWarrenty_salestab.AutoSize = true;
            this._lbl_prorataWarrenty_salestab.Location = new System.Drawing.Point(68, 206);
            this._lbl_prorataWarrenty_salestab.Name = "_lbl_prorataWarrenty_salestab";
            this._lbl_prorataWarrenty_salestab.Size = new System.Drawing.Size(62, 13);
            this._lbl_prorataWarrenty_salestab.TabIndex = 16;
            this._lbl_prorataWarrenty_salestab.Text = "PRO-RATA";
            // 
            // txtbx_fullWarrenty_salestab
            // 
            this.txtbx_fullWarrenty_salestab.Location = new System.Drawing.Point(136, 177);
            this.txtbx_fullWarrenty_salestab.Name = "txtbx_fullWarrenty_salestab";
            this.txtbx_fullWarrenty_salestab.Size = new System.Drawing.Size(144, 20);
            this.txtbx_fullWarrenty_salestab.TabIndex = 17;
            // 
            // txtbx_prorataWarrenty_salestab
            // 
            this.txtbx_prorataWarrenty_salestab.Location = new System.Drawing.Point(136, 203);
            this.txtbx_prorataWarrenty_salestab.Name = "txtbx_prorataWarrenty_salestab";
            this.txtbx_prorataWarrenty_salestab.Size = new System.Drawing.Size(144, 20);
            this.txtbx_prorataWarrenty_salestab.TabIndex = 18;
            // 
            // btn_invoice_salestab
            // 
            this.btn_invoice_salestab.Location = new System.Drawing.Point(204, 260);
            this.btn_invoice_salestab.Name = "btn_invoice_salestab";
            this.btn_invoice_salestab.Size = new System.Drawing.Size(75, 23);
            this.btn_invoice_salestab.TabIndex = 19;
            this.btn_invoice_salestab.Text = "INVOICE";
            this.btn_invoice_salestab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 362);
            this.Controls.Add(this.Main_page);
            this.Name = "Main";
            this.Text = "Main";
            this.Main_page.ResumeLayout(false);
            this.tabPage_stock.ResumeLayout(false);
            this.tabPage_sales.ResumeLayout(false);
            this.tabPage_reorder.ResumeLayout(false);
            this.splitContainer_salestab.Panel1.ResumeLayout(false);
            this.splitContainer_salestab.Panel1.PerformLayout();
            this.splitContainer_salestab.Panel2.ResumeLayout(false);
            this.splitContainer_salestab.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_salestab)).EndInit();
            this.splitContainer_salestab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Main_page;
        private System.Windows.Forms.TabPage tabPage_stock;
        private System.Windows.Forms.TableLayoutPanel table_stock;
        private System.Windows.Forms.TabPage tabPage_invoice;
        private System.Windows.Forms.TabPage tabPage_reorder;
        private System.Windows.Forms.TableLayoutPanel table_reorders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_sales;
        private System.Windows.Forms.SplitContainer splitContainer_salestab;
        private System.Windows.Forms.TextBox txtbx_cusAddress_salestab;
        private System.Windows.Forms.TextBox txtbx_cusPhone_salestab;
        private System.Windows.Forms.TextBox txtbx_cusName_salestab;
        private System.Windows.Forms.Label lbl_customerAddress_salestab;
        private System.Windows.Forms.Label lbl_customertelephone_salestab;
        private System.Windows.Forms.Label lbl_customerName_salestab;
        private System.Windows.Forms.Label lbl_customer_salestab;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbl_batteryPrice_salestab;
        private System.Windows.Forms.Label lbl_batteryType_salestab;
        private System.Windows.Forms.Label lbl_batteryMake_salestab;
        private System.Windows.Forms.Label lbl_battery_salestab;
        private System.Windows.Forms.Button btn_invoice_salestab;
        private System.Windows.Forms.TextBox txtbx_prorataWarrenty_salestab;
        private System.Windows.Forms.TextBox txtbx_fullWarrenty_salestab;
        private System.Windows.Forms.Label _lbl_prorataWarrenty_salestab;
        private System.Windows.Forms.Label _lbl_fullWarrenty_salestab;
        private System.Windows.Forms.Label lbl_warrenty_salestab;
    }
}