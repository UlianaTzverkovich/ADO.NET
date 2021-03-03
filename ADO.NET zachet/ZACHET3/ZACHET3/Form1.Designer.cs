namespace ZACHET3
{
    partial class Question
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
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTeacher.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTeacher.Location = new System.Drawing.Point(68, 40);
            this.buttonTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(187, 44);
            this.buttonTeacher.TabIndex = 0;
            this.buttonTeacher.Text = "Преподаватель";
            this.buttonTeacher.UseVisualStyleBackColor = false;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStudent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudent.Location = new System.Drawing.Point(68, 114);
            this.buttonStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(187, 44);
            this.buttonStudent.TabIndex = 1;
            this.buttonStudent.Text = "Студент";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(332, 186);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.buttonTeacher);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Question";
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Button buttonStudent;
    }
}

