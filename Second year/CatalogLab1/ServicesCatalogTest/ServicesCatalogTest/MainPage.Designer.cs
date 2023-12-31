
namespace ServicesCatalogTest
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainWindowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogButton = new System.Windows.Forms.ToolStripMenuItem();
            this.по1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.по4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеСразуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceTitle = new System.Windows.Forms.Label();
            this.Question1 = new System.Windows.Forms.Label();
            this.QuestionTitle = new System.Windows.Forms.Label();
            this.AnswerTitle = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Label();
            this.Answer3 = new System.Windows.Forms.Label();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainWindowButton,
            this.CatalogButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(107, 31);
            this.MainWindowButton.Text = "Главная";
            this.MainWindowButton.Click += new System.EventHandler(this.BuildMainPage);
            // 
            // CatalogButton
            // 
            this.CatalogButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.по1ToolStripMenuItem,
            this.по4ToolStripMenuItem,
            this.всеСразуToolStripMenuItem});
            this.CatalogButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(170, 31);
            this.CatalogButton.Text = "Каталог услуг";
            // 
            // по1ToolStripMenuItem
            // 
            this.по1ToolStripMenuItem.Name = "по1ToolStripMenuItem";
            this.по1ToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.по1ToolStripMenuItem.Text = "По 1";
            this.по1ToolStripMenuItem.Click += new System.EventHandler(this.BuildCatalogPage);
            // 
            // по4ToolStripMenuItem
            // 
            this.по4ToolStripMenuItem.Name = "по4ToolStripMenuItem";
            this.по4ToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.по4ToolStripMenuItem.Text = "По 4";
            this.по4ToolStripMenuItem.Click += new System.EventHandler(this.BuildCatalogPage);
            // 
            // всеСразуToolStripMenuItem
            // 
            this.всеСразуToolStripMenuItem.Name = "всеСразуToolStripMenuItem";
            this.всеСразуToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.всеСразуToolStripMenuItem.Text = "Все сразу";
            this.всеСразуToolStripMenuItem.Click += new System.EventHandler(this.BuildCatalogPage);
            // 
            // ServiceTitle
            // 
            this.ServiceTitle.AutoSize = true;
            this.ServiceTitle.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceTitle.Location = new System.Drawing.Point(12, 53);
            this.ServiceTitle.Name = "ServiceTitle";
            this.ServiceTitle.Size = new System.Drawing.Size(741, 32);
            this.ServiceTitle.TabIndex = 1;
            this.ServiceTitle.Text = "Сервис реставрации раритетных автомобилей \"Phoenix\"";
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.BackColor = System.Drawing.Color.Transparent;
            this.Question1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question1.Location = new System.Drawing.Point(128, 160);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(137, 27);
            this.Question1.TabIndex = 2;
            this.Question1.Text = "Почему мы?";
            // 
            // QuestionTitle
            // 
            this.QuestionTitle.AutoSize = true;
            this.QuestionTitle.BackColor = System.Drawing.Color.Transparent;
            this.QuestionTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTitle.Location = new System.Drawing.Point(155, 100);
            this.QuestionTitle.Name = "QuestionTitle";
            this.QuestionTitle.Size = new System.Drawing.Size(89, 27);
            this.QuestionTitle.TabIndex = 3;
            this.QuestionTitle.Text = "Вопрос";
            // 
            // AnswerTitle
            // 
            this.AnswerTitle.AutoSize = true;
            this.AnswerTitle.BackColor = System.Drawing.Color.Transparent;
            this.AnswerTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTitle.Location = new System.Drawing.Point(512, 100);
            this.AnswerTitle.Name = "AnswerTitle";
            this.AnswerTitle.Size = new System.Drawing.Size(71, 27);
            this.AnswerTitle.TabIndex = 4;
            this.AnswerTitle.Text = "Ответ";
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.BackColor = System.Drawing.Color.Transparent;
            this.Answer1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.Location = new System.Drawing.Point(341, 160);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(403, 27);
            this.Answer1.TabIndex = 5;
            this.Answer1.Text = "Премиальный сервис, как и ваше авто";
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.BackColor = System.Drawing.Color.Transparent;
            this.Question2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question2.Location = new System.Drawing.Point(155, 222);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(101, 27);
            this.Question2.TabIndex = 6;
            this.Question2.Text = "Вопрос2";
            // 
            // Question3
            // 
            this.Question3.AutoSize = true;
            this.Question3.BackColor = System.Drawing.Color.Transparent;
            this.Question3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question3.ForeColor = System.Drawing.Color.Black;
            this.Question3.Location = new System.Drawing.Point(155, 288);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(101, 27);
            this.Question3.TabIndex = 7;
            this.Question3.Text = "Вопрос3";
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.BackColor = System.Drawing.Color.Transparent;
            this.Answer2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(512, 222);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(83, 27);
            this.Answer2.TabIndex = 8;
            this.Answer2.Text = "Ответ2";
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.BackColor = System.Drawing.Color.Transparent;
            this.Answer3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.Location = new System.Drawing.Point(512, 288);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(83, 27);
            this.Answer3.TabIndex = 9;
            this.Answer3.Text = "Ответ3";
            // 
            // FooterLabel
            // 
            this.FooterLabel.AutoSize = true;
            this.FooterLabel.BackColor = System.Drawing.Color.Transparent;
            this.FooterLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FooterLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FooterLabel.Location = new System.Drawing.Point(128, 374);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(497, 26);
            this.FooterLabel.TabIndex = 10;
            this.FooterLabel.Text = "Звоните и запишитесь на техосмотр сегодня!";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ServicesCatalogTest.Properties.Resources.car_service_centre_auto_repair_workshop_blurred_panoramic_background_293060_5326;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.AnswerTitle);
            this.Controls.Add(this.QuestionTitle);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.ServiceTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Автомастерская \"Phoenix\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainWindowButton;
        private System.Windows.Forms.ToolStripMenuItem CatalogButton;
        private System.Windows.Forms.Label ServiceTitle;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Label QuestionTitle;
        private System.Windows.Forms.Label AnswerTitle;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.Label Question3;
        private System.Windows.Forms.Label Answer2;
        private System.Windows.Forms.Label Answer3;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.ToolStripMenuItem по1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem по4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеСразуToolStripMenuItem;
    }
}