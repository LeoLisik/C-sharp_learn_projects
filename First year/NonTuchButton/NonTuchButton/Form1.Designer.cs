
namespace NonTuchButton
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
            this.TouchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TouchButton
            // 
            this.TouchButton.BackColor = System.Drawing.Color.Gold;
            this.TouchButton.ForeColor = System.Drawing.Color.Blue;
            this.TouchButton.Location = new System.Drawing.Point(248, 141);
            this.TouchButton.Margin = new System.Windows.Forms.Padding(2);
            this.TouchButton.Name = "TouchButton";
            this.TouchButton.Size = new System.Drawing.Size(128, 33);
            this.TouchButton.TabIndex = 0;
            this.TouchButton.Text = "Click me";
            this.TouchButton.UseVisualStyleBackColor = false;
            this.TouchButton.Click += new System.EventHandler(this.TouchButton_Click);
            this.TouchButton.MouseEnter += new System.EventHandler(this.TouchButton_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(270, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NonTuchButton.Properties.Resources._59f8e0d00c7cb__1_;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TouchButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Button catchers";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TouchButton;
        private System.Windows.Forms.Label label1;
    }
}

