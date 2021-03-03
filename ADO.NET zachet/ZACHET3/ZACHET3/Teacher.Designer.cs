namespace ZACHET3
{
    partial class TeacherForm
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
            this.TeacherdataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherdataGridView
            // 
            this.TeacherdataGridView.AllowUserToOrderColumns = true;
            this.TeacherdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeacherdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherdataGridView.Location = new System.Drawing.Point(0, 61);
            this.TeacherdataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TeacherdataGridView.Name = "TeacherdataGridView";
            this.TeacherdataGridView.RowHeadersWidth = 62;
            this.TeacherdataGridView.RowTemplate.Height = 24;
            this.TeacherdataGridView.Size = new System.Drawing.Size(901, 517);
            this.TeacherdataGridView.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(12, 13);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(129, 40);
            this.buttonSaveChanges.TabIndex = 1;
            this.buttonSaveChanges.Text = "Сохранить";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(900, 578);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.TeacherdataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TeacherForm";
            this.Text = "Преподаватель";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherdataGridView;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}