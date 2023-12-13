namespace OOPLaba8
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
            this.X = new System.Windows.Forms.Button();
            this.OutPutText = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.CountSymbolString = new System.Windows.Forms.Label();
            this.NameFile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoFile = new System.Windows.Forms.Label();
            this.OKFile = new System.Windows.Forms.Button();
            this.InputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputRebro = new System.Windows.Forms.TextBox();
            this.ResCude = new System.Windows.Forms.Button();
            this.OutputRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.ForeColor = System.Drawing.Color.White;
            this.X.Location = new System.Drawing.Point(260, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(28, 28);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.UseMnemonic = false;
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutPutText
            // 
            this.OutPutText.Font = new System.Drawing.Font("Microsoft Himalaya", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutPutText.ForeColor = System.Drawing.Color.White;
            this.OutPutText.Location = new System.Drawing.Point(12, 67);
            this.OutPutText.Name = "OutPutText";
            this.OutPutText.Size = new System.Drawing.Size(276, 29);
            this.OutPutText.TabIndex = 1;
            this.OutPutText.Text = "Введіть Ім\'я та прізвище";
            this.OutPutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutPutText.Click += new System.EventHandler(this.OutPutText_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 155);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(228, 22);
            this.InputText.TabIndex = 2;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(246, 151);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(42, 31);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CountSymbolString
            // 
            this.CountSymbolString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountSymbolString.ForeColor = System.Drawing.Color.White;
            this.CountSymbolString.Location = new System.Drawing.Point(12, 116);
            this.CountSymbolString.Name = "CountSymbolString";
            this.CountSymbolString.Size = new System.Drawing.Size(276, 23);
            this.CountSymbolString.TabIndex = 4;
            this.CountSymbolString.Text = "Кількість символів -";
            // 
            // NameFile
            // 
            this.NameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFile.ForeColor = System.Drawing.Color.White;
            this.NameFile.Location = new System.Drawing.Point(12, 221);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(276, 23);
            this.NameFile.TabIndex = 5;
            this.NameFile.Text = "Ім\'я файлу - ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Зміст файлу";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoFile
            // 
            this.InfoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoFile.ForeColor = System.Drawing.Color.White;
            this.InfoFile.Location = new System.Drawing.Point(15, 349);
            this.InfoFile.Name = "InfoFile";
            this.InfoFile.Size = new System.Drawing.Size(273, 153);
            this.InfoFile.TabIndex = 7;
            this.InfoFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKFile
            // 
            this.OKFile.Location = new System.Drawing.Point(246, 260);
            this.OKFile.Name = "OKFile";
            this.OKFile.Size = new System.Drawing.Size(42, 31);
            this.OKFile.TabIndex = 9;
            this.OKFile.Text = "OK";
            this.OKFile.UseMnemonic = false;
            this.OKFile.UseVisualStyleBackColor = true;
            this.OKFile.Click += new System.EventHandler(this.OKFile_Click);
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(12, 264);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(228, 22);
            this.InputFile.TabIndex = 8;
            this.InputFile.TextChanged += new System.EventHandler(this.InputFile_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введіть ребро куба";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputRebro
            // 
            this.InputRebro.Location = new System.Drawing.Point(12, 562);
            this.InputRebro.Name = "InputRebro";
            this.InputRebro.Size = new System.Drawing.Size(228, 22);
            this.InputRebro.TabIndex = 11;
            // 
            // ResCude
            // 
            this.ResCude.Location = new System.Drawing.Point(246, 558);
            this.ResCude.Name = "ResCude";
            this.ResCude.Size = new System.Drawing.Size(42, 31);
            this.ResCude.TabIndex = 12;
            this.ResCude.Text = "OK";
            this.ResCude.UseMnemonic = false;
            this.ResCude.UseVisualStyleBackColor = true;
            this.ResCude.Click += new System.EventHandler(this.ResCude_Click);
            // 
            // OutputRes
            // 
            this.OutputRes.Font = new System.Drawing.Font("Microsoft Himalaya", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputRes.ForeColor = System.Drawing.Color.White;
            this.OutputRes.Location = new System.Drawing.Point(12, 604);
            this.OutputRes.Name = "OutputRes";
            this.OutputRes.Size = new System.Drawing.Size(276, 87);
            this.OutputRes.TabIndex = 13;
            this.OutputRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(300, 700);
            this.Controls.Add(this.OutputRes);
            this.Controls.Add(this.ResCude);
            this.Controls.Add(this.InputRebro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKFile);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.InfoFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.CountSymbolString);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.OutPutText);
            this.Controls.Add(this.X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ромб";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private string path = "info.txt";
        private string copyName;

        #endregion

        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Label OutPutText;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label CountSymbolString;
        private System.Windows.Forms.Label NameFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label InfoFile;
        private System.Windows.Forms.Button OKFile;
        private System.Windows.Forms.TextBox InputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputRebro;
        private System.Windows.Forms.Button ResCude;
        private System.Windows.Forms.Label OutputRes;
    }
}