
namespace DataViewExample
{
    partial class DataViewExample
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetDataViewPropertiesButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.customersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.northwindDataSet1 = new DataViewExample.NorthwindDataSet();
            this.GetOrdersButton = new System.Windows.Forms.Button();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.CustomersGrid.Location = new System.Drawing.Point(0, 0);
            this.CustomersGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.RowHeadersWidth = 51;
            this.CustomersGrid.RowTemplate.Height = 24;
            this.CustomersGrid.Size = new System.Drawing.Size(359, 562);
            this.CustomersGrid.TabIndex = 0;
            // 
            // SortTextBox
            // 
            this.SortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortTextBox.Location = new System.Drawing.Point(462, 8);
            this.SortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(234, 30);
            this.SortTextBox.TabIndex = 1;
            this.SortTextBox.Text = "CustomerID";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterTextBox.Location = new System.Drawing.Point(462, 72);
            this.FilterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(234, 30);
            this.FilterTextBox.TabIndex = 1;
            this.FilterTextBox.Text = "City = \'London\'";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter";
            // 
            // SetDataViewPropertiesButton
            // 
            this.SetDataViewPropertiesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SetDataViewPropertiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetDataViewPropertiesButton.Location = new System.Drawing.Point(415, 144);
            this.SetDataViewPropertiesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SetDataViewPropertiesButton.Name = "SetDataViewPropertiesButton";
            this.SetDataViewPropertiesButton.Size = new System.Drawing.Size(281, 38);
            this.SetDataViewPropertiesButton.TabIndex = 3;
            this.SetDataViewPropertiesButton.Text = "Set DataView Properties";
            this.SetDataViewPropertiesButton.UseVisualStyleBackColor = true;
            this.SetDataViewPropertiesButton.Click += new System.EventHandler(this.SetDataViewPropertiesButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRowButton.Location = new System.Drawing.Point(552, 200);
            this.AddRowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(144, 38);
            this.AddRowButton.TabIndex = 3;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetOrdersButton
            // 
            this.GetOrdersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GetOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetOrdersButton.Location = new System.Drawing.Point(552, 259);
            this.GetOrdersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetOrdersButton.Name = "GetOrdersButton";
            this.GetOrdersButton.Size = new System.Drawing.Size(144, 38);
            this.GetOrdersButton.TabIndex = 3;
            this.GetOrdersButton.Text = "Get Orders";
            this.GetOrdersButton.UseVisualStyleBackColor = true;
            this.GetOrdersButton.Click += new System.EventHandler(this.GetOrdersButton_Click);
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.OrdersGrid.Location = new System.Drawing.Point(703, 0);
            this.OrdersGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.RowTemplate.Height = 24;
            this.OrdersGrid.Size = new System.Drawing.Size(397, 562);
            this.OrdersGrid.TabIndex = 4;
            // 
            // DataViewExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.GetOrdersButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.SetDataViewPropertiesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.CustomersGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataViewExample";
            this.Text = "Создание и использование объектов DataView";
            this.Load += new System.EventHandler(this.DataViewExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetDataViewPropertiesButton;
        private System.Windows.Forms.Button AddRowButton;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.Button GetOrdersButton;
        private System.Windows.Forms.DataGridView OrdersGrid;
    }
}

