namespace FileEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(48, 40);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(421, 20);
            this.tbPath.TabIndex = 0;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(475, 38);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Brose";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(48, 77);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(61, 17);
            this.rbEncrypt.TabIndex = 2;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(157, 77);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(62, 17);
            this.rbDecrypt.TabIndex = 3;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Patch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(97, 111);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(251, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(48, 162);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(502, 43);
            this.btStart.TabIndex = 7;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDecrypt);
            this.Controls.Add(this.rbEncrypt);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FileEncryptDecrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btStart;
    }
}

