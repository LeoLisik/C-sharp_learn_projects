
namespace Property
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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.MidMarkLabel = new System.Windows.Forms.Label();
            this.MidMarkInput = new System.Windows.Forms.TextBox();
            this.OutputPlace = new System.Windows.Forms.RichTextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInput.Location = new System.Drawing.Point(22, 47);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(112, 30);
            this.NameInput.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(45, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 27);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(31, 89);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(93, 27);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Возраст";
            // 
            // AgeInput
            // 
            this.AgeInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeInput.Location = new System.Drawing.Point(22, 129);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(112, 30);
            this.AgeInput.TabIndex = 4;
            // 
            // MidMarkLabel
            // 
            this.MidMarkLabel.AutoSize = true;
            this.MidMarkLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MidMarkLabel.Location = new System.Drawing.Point(12, 186);
            this.MidMarkLabel.Name = "MidMarkLabel";
            this.MidMarkLabel.Size = new System.Drawing.Size(143, 27);
            this.MidMarkLabel.TabIndex = 5;
            this.MidMarkLabel.Text = "Средний бал";
            // 
            // MidMarkInput
            // 
            this.MidMarkInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MidMarkInput.Location = new System.Drawing.Point(22, 229);
            this.MidMarkInput.Name = "MidMarkInput";
            this.MidMarkInput.Size = new System.Drawing.Size(112, 30);
            this.MidMarkInput.TabIndex = 6;
            // 
            // OutputPlace
            // 
            this.OutputPlace.Location = new System.Drawing.Point(163, 9);
            this.OutputPlace.Name = "OutputPlace";
            this.OutputPlace.Size = new System.Drawing.Size(224, 250);
            this.OutputPlace.TabIndex = 7;
            this.OutputPlace.Text = "";
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputButton.Location = new System.Drawing.Point(17, 278);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(122, 50);
            this.InputButton.TabIndex = 8;
            this.InputButton.Text = "Загрузить";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.LoadData);
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputButton.Location = new System.Drawing.Point(163, 278);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(224, 50);
            this.OutputButton.TabIndex = 9;
            this.OutputButton.Text = "Выгрузить";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.GetData);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 340);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.OutputPlace);
            this.Controls.Add(this.MidMarkInput);
            this.Controls.Add(this.MidMarkLabel);
            this.Controls.Add(this.AgeInput);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameInput);
            this.Name = "MainWindow";
            this.Text = "Студент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.Label MidMarkLabel;
        private System.Windows.Forms.TextBox MidMarkInput;
        private System.Windows.Forms.RichTextBox OutputPlace;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button OutputButton;
    }
}

