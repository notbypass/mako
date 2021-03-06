﻿namespace mako
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
            this.logBox = new System.Windows.Forms.TextBox();
            this.pasBox = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Label();
            this.Pas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.Location = new System.Drawing.Point(112, 45);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(200, 29);
            this.logBox.TabIndex = 2;
            // 
            // pasBox
            // 
            this.pasBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasBox.Location = new System.Drawing.Point(112, 75);
            this.pasBox.Name = "pasBox";
            this.pasBox.PasswordChar = '*';
            this.pasBox.Size = new System.Drawing.Size(200, 29);
            this.pasBox.TabIndex = 3;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(22, 53);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(61, 21);
            this.log.TabIndex = 4;
            this.log.Text = "Логин";
            // 
            // Pas
            // 
            this.Pas.AutoSize = true;
            this.Pas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pas.Location = new System.Drawing.Point(22, 83);
            this.Pas.Name = "Pas";
            this.Pas.Size = new System.Drawing.Size(69, 21);
            this.Pas.TabIndex = 5;
            this.Pas.Text = "Пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mako.Properties.Resources.d842b416369bd7d72b80f36fd953fcf84b89ad55r1_480_270v2_uhq;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // outButton
            // 
            this.outButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outButton.Image = global::mako.Properties.Resources.logout;
            this.outButton.Location = new System.Drawing.Point(12, 136);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(61, 45);
            this.outButton.TabIndex = 1;
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.Image = global::mako.Properties.Resources.login__3_;
            this.logButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logButton.Location = new System.Drawing.Point(267, 136);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(61, 45);
            this.logButton.TabIndex = 0;
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 193);
            this.Controls.Add(this.Pas);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pasBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox pasBox;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label Pas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
