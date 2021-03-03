namespace ZACHET1
{
    partial class DataReader
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.begin = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начало периода:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Конец периода:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(217, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вывести данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(217, 54);
            this.begin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.begin.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(310, 26);
            this.begin.TabIndex = 7;
            this.begin.Value = new System.DateTime(2021, 2, 21, 0, 0, 0, 0);
            this.begin.ValueChanged += new System.EventHandler(this.begin_ValueChanged);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(217, 98);
            this.end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.end.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(310, 26);
            this.end.TabIndex = 8;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LAPTOP-0C6B2G0M;Initial Catalog=AdventureWorks2017;Integrated Securit" +
    "y=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(43, 263);
            this.ResultsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(516, 473);
            this.ResultsTextBox.TabIndex = 9;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT SalesOrderID, SalesOrderDetailID, ProductID, ModifiedDate, OrderQty, LineT" +
    "otal\r\nFROM   Sales.SalesOrderDetail\r\nWHERE (ModifiedDate BETWEEN @FirstDate AND " +
    "@LastDate)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FirstDate", System.Data.SqlDbType.DateTime, 8, "ModifiedDate"),
            new System.Data.SqlClient.SqlParameter("@LastDate", System.Data.SqlDbType.DateTime, 8, "ModifiedDate")});
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 774);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.end);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataReader";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker begin;
        private System.Windows.Forms.DateTimePicker end;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}

