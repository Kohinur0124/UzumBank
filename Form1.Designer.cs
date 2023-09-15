namespace Sqlserver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_boxs1 = new Sqlserver.Text_boxs();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.text_boxs2 = new Sqlserver.Text_boxs();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckPhone = new System.Windows.Forms.Label();
            this.CheckPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raqamingizni kiriting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon raqami";
            // 
            // text_boxs1
            // 
            this.text_boxs1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_boxs1.Location = new System.Drawing.Point(41, 196);
            this.text_boxs1.Name = "text_boxs1";
            this.text_boxs1.Size = new System.Drawing.Size(307, 34);
            this.text_boxs1.TabIndex = 3;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(42)))), ((int)(((byte)(224)))));
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Location = new System.Drawing.Point(131, 505);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(42)))), ((int)(((byte)(224)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(153, 58);
            this.button_WOC1.TabIndex = 4;
            this.button_WOC1.Text = "Tekshirish";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // text_boxs2
            // 
            this.text_boxs2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_boxs2.Location = new System.Drawing.Point(41, 336);
            this.text_boxs2.Name = "text_boxs2";
            this.text_boxs2.PasswordChar = '*';
            this.text_boxs2.Size = new System.Drawing.Size(307, 34);
            this.text_boxs2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parol";
            // 
            // CheckPhone
            // 
            this.CheckPhone.AutoSize = true;
            this.CheckPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPhone.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckPhone.Location = new System.Drawing.Point(41, 242);
            this.CheckPhone.Name = "CheckPhone";
            this.CheckPhone.Size = new System.Drawing.Size(219, 25);
            this.CheckPhone.TabIndex = 7;
            this.CheckPhone.Text = "Namuna : +99800000000";
            // 
            // CheckPass
            // 
            this.CheckPass.AutoSize = true;
            this.CheckPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPass.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckPass.Location = new System.Drawing.Point(41, 384);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.Size = new System.Drawing.Size(0, 25);
            this.CheckPass.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(432, 653);
            this.Controls.Add(this.CheckPass);
            this.Controls.Add(this.CheckPhone);
            this.Controls.Add(this.text_boxs2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.text_boxs1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 700);
            this.MinimumSize = new System.Drawing.Size(450, 700);
            this.Name = "Form1";
            this.Text = "Uzum Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Text_boxs text_boxs1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private Text_boxs text_boxs2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CheckPhone;
        private System.Windows.Forms.Label CheckPass;
    }
}

