
namespace LoadImageIntoDatabase
{
    partial class InfoInputWindow
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ServiceNameText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.ShowImagePlace = new System.Windows.Forms.PictureBox();
            this.ConfirmInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowImagePlace)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(570, 33);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Ввод данных для добавления строки в таблицу";
            // 
            // ServiceNameText
            // 
            this.ServiceNameText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceNameText.Location = new System.Drawing.Point(227, 68);
            this.ServiceNameText.Name = "ServiceNameText";
            this.ServiceNameText.Size = new System.Drawing.Size(355, 34);
            this.ServiceNameText.TabIndex = 1;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(227, 223);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(355, 163);
            this.DescriptionText.TabIndex = 2;
            this.DescriptionText.Text = "";
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceNameLabel.Location = new System.Drawing.Point(27, 68);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(184, 27);
            this.ServiceNameLabel.TabIndex = 4;
            this.ServiceNameLabel.Text = "Название услуги";
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceText.Location = new System.Drawing.Point(227, 129);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(355, 34);
            this.PriceText.TabIndex = 5;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(88, 132);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 27);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Цена";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(350, 193);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(114, 27);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Описание";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageLabel.Location = new System.Drawing.Point(49, 193);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(150, 27);
            this.ImageLabel.TabIndex = 8;
            this.ImageLabel.Text = "Изображение";
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectImageButton.Location = new System.Drawing.Point(54, 395);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(145, 43);
            this.SelectImageButton.TabIndex = 9;
            this.SelectImageButton.Text = "Выбрать";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImage);
            // 
            // ShowImagePlace
            // 
            this.ShowImagePlace.Location = new System.Drawing.Point(32, 223);
            this.ShowImagePlace.Name = "ShowImagePlace";
            this.ShowImagePlace.Size = new System.Drawing.Size(179, 163);
            this.ShowImagePlace.TabIndex = 10;
            this.ShowImagePlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowImagePlace.TabStop = false;
            // 
            // ConfirmInfoButton
            // 
            this.ConfirmInfoButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmInfoButton.Location = new System.Drawing.Point(227, 395);
            this.ConfirmInfoButton.Name = "ConfirmInfoButton";
            this.ConfirmInfoButton.Size = new System.Drawing.Size(355, 43);
            this.ConfirmInfoButton.TabIndex = 11;
            this.ConfirmInfoButton.Text = "Подтвердить";
            this.ConfirmInfoButton.UseVisualStyleBackColor = true;
            this.ConfirmInfoButton.Click += new System.EventHandler(this.ConfirmInformation);
            // 
            // InfoInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.ConfirmInfoButton);
            this.Controls.Add(this.ShowImagePlace);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.ServiceNameLabel);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.ServiceNameText);
            this.Controls.Add(this.TitleLabel);
            this.Name = "InfoInputWindow";
            this.Text = "DataInput";
            ((System.ComponentModel.ISupportInitialize)(this.ShowImagePlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox ServiceNameText;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.Label ServiceNameLabel;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.PictureBox ShowImagePlace;
        private System.Windows.Forms.Button ConfirmInfoButton;
    }
}