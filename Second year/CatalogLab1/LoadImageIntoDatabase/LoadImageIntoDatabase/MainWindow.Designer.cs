
namespace LoadImageIntoDatabase
{
    partial class MainWindow
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
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.GetImageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(12, 90);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(152, 96);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Загрузить";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.InputInfoForLoadImages);
            // 
            // GetImageButton
            // 
            this.GetImageButton.Location = new System.Drawing.Point(170, 90);
            this.GetImageButton.Name = "GetImageButton";
            this.GetImageButton.Size = new System.Drawing.Size(152, 96);
            this.GetImageButton.TabIndex = 1;
            this.GetImageButton.Text = "Выгрузить";
            this.GetImageButton.UseVisualStyleBackColor = true;
            this.GetImageButton.Click += new System.EventHandler(this.GetImageFromDatabase);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 284);
            this.Controls.Add(this.GetImageButton);
            this.Controls.Add(this.LoadImageButton);
            this.Name = "MainForm";
            this.Text = "Загрузка картинок";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button GetImageButton;
    }
}

