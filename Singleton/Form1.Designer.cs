namespace Singleton
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
            this.btnSaveDocument = new System.Windows.Forms.Button();
            this.btnConnectDb = new System.Windows.Forms.Button();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSaveDocument
            // 
            this.btnSaveDocument.Location = new System.Drawing.Point(403, 294);
            this.btnSaveDocument.Name = "btnSaveDocument";
            this.btnSaveDocument.Size = new System.Drawing.Size(105, 70);
            this.btnSaveDocument.TabIndex = 0;
            this.btnSaveDocument.Text = "Зберегти документ";
            this.btnSaveDocument.UseVisualStyleBackColor = true;
            this.btnSaveDocument.Click += new System.EventHandler(this.btnSaveDocument_Click);
            // 
            // btnConnectDb
            // 
            this.btnConnectDb.Location = new System.Drawing.Point(514, 294);
            this.btnConnectDb.Name = "btnConnectDb";
            this.btnConnectDb.Size = new System.Drawing.Size(105, 70);
            this.btnConnectDb.TabIndex = 1;
            this.btnConnectDb.Text = "Підключитися до БД";
            this.btnConnectDb.UseVisualStyleBackColor = true;
            this.btnConnectDb.Click += new System.EventHandler(this.btnConnectDb_Click);
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Location = new System.Drawing.Point(625, 294);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(105, 70);
            this.btnViewLogs.TabIndex = 2;
            this.btnViewLogs.Text = "Перевірити логи";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(403, 244);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(327, 20);
            this.txtDocument.TabIndex = 3;
            this.txtDocument.TextChanged += new System.EventHandler(this.txtDocument_TextChanged);
            // 
            // lstLogs
            // 
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(12, 12);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(326, 186);
            this.lstLogs.TabIndex = 4;
            this.lstLogs.SelectedIndexChanged += new System.EventHandler(this.lstLogs_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.btnViewLogs);
            this.Controls.Add(this.btnConnectDb);
            this.Controls.Add(this.btnSaveDocument);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDocument;
        private System.Windows.Forms.Button btnConnectDb;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.ListBox lstLogs;
    }
}

