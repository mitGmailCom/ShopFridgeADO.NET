namespace ShopFridgeADO.NET
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNameSaller = new System.Windows.Forms.Label();
            this.txbSaller = new System.Windows.Forms.TextBox();
            this.txbCustomer = new System.Windows.Forms.TextBox();
            this.lbNameBuyer = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.txbCountProduct = new System.Windows.Forms.TextBox();
            this.lbCountProduct = new System.Windows.Forms.Label();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.btnAddToTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadToDB = new System.Windows.Forms.Button();
            this.btnShowProducts = new System.Windows.Forms.Button();
            this.btnShowReceipt = new System.Windows.Forms.Button();
            this.btnShowSales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnShowBSaller = new System.Windows.Forms.Button();
            this.btnShowBCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNameSaller
            // 
            this.lbNameSaller.AutoSize = true;
            this.lbNameSaller.Location = new System.Drawing.Point(5, 30);
            this.lbNameSaller.Name = "lbNameSaller";
            this.lbNameSaller.Size = new System.Drawing.Size(87, 13);
            this.lbNameSaller.TabIndex = 0;
            this.lbNameSaller.Text = "ФИО Продавец";
            // 
            // txbSaller
            // 
            this.txbSaller.Location = new System.Drawing.Point(103, 27);
            this.txbSaller.Name = "txbSaller";
            this.txbSaller.Size = new System.Drawing.Size(120, 20);
            this.txbSaller.TabIndex = 1;
            // 
            // txbCustomer
            // 
            this.txbCustomer.Location = new System.Drawing.Point(103, 63);
            this.txbCustomer.Name = "txbCustomer";
            this.txbCustomer.Size = new System.Drawing.Size(120, 20);
            this.txbCustomer.TabIndex = 3;
            // 
            // lbNameBuyer
            // 
            this.lbNameBuyer.AutoSize = true;
            this.lbNameBuyer.Location = new System.Drawing.Point(4, 66);
            this.lbNameBuyer.Name = "lbNameBuyer";
            this.lbNameBuyer.Size = new System.Drawing.Size(97, 13);
            this.lbNameBuyer.TabIndex = 2;
            this.lbNameBuyer.Text = "ФИО Покупатель";
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(5, 101);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(62, 13);
            this.lbProduct.TabIndex = 4;
            this.lbProduct.Text = "Продукция";
            // 
            // txbCountProduct
            // 
            this.txbCountProduct.Location = new System.Drawing.Point(103, 213);
            this.txbCountProduct.Name = "txbCountProduct";
            this.txbCountProduct.Size = new System.Drawing.Size(121, 20);
            this.txbCountProduct.TabIndex = 7;
            // 
            // lbCountProduct
            // 
            this.lbCountProduct.AutoSize = true;
            this.lbCountProduct.Location = new System.Drawing.Point(6, 216);
            this.lbCountProduct.Name = "lbCountProduct";
            this.lbCountProduct.Size = new System.Drawing.Size(66, 13);
            this.lbCountProduct.TabIndex = 6;
            this.lbCountProduct.Text = "Количество";
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.Location = new System.Drawing.Point(103, 101);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(120, 95);
            this.listBoxProduct.TabIndex = 8;
            // 
            // btnAddToTable
            // 
            this.btnAddToTable.Location = new System.Drawing.Point(9, 247);
            this.btnAddToTable.Name = "btnAddToTable";
            this.btnAddToTable.Size = new System.Drawing.Size(107, 31);
            this.btnAddToTable.TabIndex = 9;
            this.btnAddToTable.Text = "Add to Table";
            this.btnAddToTable.UseVisualStyleBackColor = true;
            this.btnAddToTable.Click += new System.EventHandler(this.btnAddToTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 258);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnLoadToDB
            // 
            this.btnLoadToDB.Location = new System.Drawing.Point(122, 247);
            this.btnLoadToDB.Name = "btnLoadToDB";
            this.btnLoadToDB.Size = new System.Drawing.Size(103, 31);
            this.btnLoadToDB.TabIndex = 16;
            this.btnLoadToDB.Text = "Load to DB";
            this.btnLoadToDB.UseVisualStyleBackColor = true;
            this.btnLoadToDB.Click += new System.EventHandler(this.btnLoadToDB_Click);
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.Location = new System.Drawing.Point(249, 288);
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.Size = new System.Drawing.Size(95, 31);
            this.btnShowProducts.TabIndex = 17;
            this.btnShowProducts.Text = "Show Products";
            this.btnShowProducts.UseVisualStyleBackColor = true;
            this.btnShowProducts.Click += new System.EventHandler(this.btnShowProducts_Click);
            // 
            // btnShowReceipt
            // 
            this.btnShowReceipt.Location = new System.Drawing.Point(350, 288);
            this.btnShowReceipt.Name = "btnShowReceipt";
            this.btnShowReceipt.Size = new System.Drawing.Size(92, 31);
            this.btnShowReceipt.TabIndex = 18;
            this.btnShowReceipt.Text = "ShowReseipt";
            this.btnShowReceipt.UseVisualStyleBackColor = true;
            this.btnShowReceipt.Click += new System.EventHandler(this.btnShowReceipt_Click);
            // 
            // btnShowSales
            // 
            this.btnShowSales.Location = new System.Drawing.Point(448, 288);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(81, 31);
            this.btnShowSales.TabIndex = 19;
            this.btnShowSales.Text = "Show Sales";
            this.btnShowSales.UseVisualStyleBackColor = true;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSaller);
            this.groupBox1.Controls.Add(this.lbNameSaller);
            this.groupBox1.Controls.Add(this.lbNameBuyer);
            this.groupBox1.Controls.Add(this.txbCustomer);
            this.groupBox1.Controls.Add(this.btnLoadToDB);
            this.groupBox1.Controls.Add(this.lbProduct);
            this.groupBox1.Controls.Add(this.listBoxProduct);
            this.groupBox1.Controls.Add(this.btnAddToTable);
            this.groupBox1.Controls.Add(this.lbCountProduct);
            this.groupBox1.Controls.Add(this.txbCountProduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 291);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(11, 12);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(224, 23);
            this.btnLoadData.TabIndex = 22;
            this.btnLoadData.Text = "Connect to DB";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnShowBSaller
            // 
            this.btnShowBSaller.Location = new System.Drawing.Point(535, 288);
            this.btnShowBSaller.Name = "btnShowBSaller";
            this.btnShowBSaller.Size = new System.Drawing.Size(87, 31);
            this.btnShowBSaller.TabIndex = 23;
            this.btnShowBSaller.Text = "ShowSaller";
            this.btnShowBSaller.UseVisualStyleBackColor = true;
            this.btnShowBSaller.Click += new System.EventHandler(this.btnShowBSaller_Click);
            // 
            // btnShowBCustomer
            // 
            this.btnShowBCustomer.Location = new System.Drawing.Point(628, 288);
            this.btnShowBCustomer.Name = "btnShowBCustomer";
            this.btnShowBCustomer.Size = new System.Drawing.Size(87, 31);
            this.btnShowBCustomer.TabIndex = 24;
            this.btnShowBCustomer.Text = "ShowCustomer";
            this.btnShowBCustomer.UseVisualStyleBackColor = true;
            this.btnShowBCustomer.Click += new System.EventHandler(this.btnShowBCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 335);
            this.Controls.Add(this.btnShowBCustomer);
            this.Controls.Add(this.btnShowBSaller);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowSales);
            this.Controls.Add(this.btnShowReceipt);
            this.Controls.Add(this.btnShowProducts);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Shop of fridges";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNameSaller;
        private System.Windows.Forms.TextBox txbSaller;
        private System.Windows.Forms.TextBox txbCustomer;
        private System.Windows.Forms.Label lbNameBuyer;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.TextBox txbCountProduct;
        private System.Windows.Forms.Label lbCountProduct;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Button btnAddToTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadToDB;
        private System.Windows.Forms.Button btnShowProducts;
        private System.Windows.Forms.Button btnShowReceipt;
        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnShowBSaller;
        private System.Windows.Forms.Button btnShowBCustomer;
    }
}

