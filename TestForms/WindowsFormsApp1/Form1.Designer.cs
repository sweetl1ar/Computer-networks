namespace WindowsFormsApp1
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
            this.button_log = new System.Windows.Forms.Button();
            this.auth = new System.Windows.Forms.Label();
            this.textBox_loginn = new System.Windows.Forms.TextBox();
            this.textBox_passwordd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_log
            // 
            this.button_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_log.Location = new System.Drawing.Point(357, 301);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(94, 44);
            this.button_log.TabIndex = 0;
            this.button_log.Text = "Войти";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth.Location = new System.Drawing.Point(311, 32);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(178, 31);
            this.auth.TabIndex = 1;
            this.auth.Text = "Авторизация";
            this.auth.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_loginn
            // 
            this.textBox_loginn.Location = new System.Drawing.Point(317, 148);
            this.textBox_loginn.Name = "textBox_loginn";
            this.textBox_loginn.Size = new System.Drawing.Size(172, 20);
            this.textBox_loginn.TabIndex = 2;
            this.textBox_loginn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_passwordd
            // 
            this.textBox_passwordd.Location = new System.Drawing.Point(317, 214);
            this.textBox_passwordd.Name = "textBox_passwordd";
            this.textBox_passwordd.Size = new System.Drawing.Size(172, 20);
            this.textBox_passwordd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(203, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(203, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пароль";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(799, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_passwordd);
            this.Controls.Add(this.textBox_loginn);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.button_log);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Label auth;
        private System.Windows.Forms.TextBox textBox_loginn;
        private System.Windows.Forms.TextBox textBox_passwordd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

