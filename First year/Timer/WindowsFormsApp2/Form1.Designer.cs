
namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartStopButton = new System.Windows.Forms.Button();
            this.ChooseBox = new System.Windows.Forms.ComboBox();
            this.CountSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(39, 49);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(324, 23);
            this.ProgressBar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // StartStopButton
            // 
            this.StartStopButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartStopButton.Location = new System.Drawing.Point(39, 93);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(105, 51);
            this.StartStopButton.TabIndex = 1;
            this.StartStopButton.Text = "Start/Stop";
            this.StartStopButton.UseVisualStyleBackColor = false;
            this.StartStopButton.Click += new System.EventHandler(this.button_Click);
            // 
            // ChooseBox
            // 
            this.ChooseBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChooseBox.FormattingEnabled = true;
            this.ChooseBox.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.ChooseBox.Location = new System.Drawing.Point(199, 107);
            this.ChooseBox.Name = "ChooseBox";
            this.ChooseBox.Size = new System.Drawing.Size(164, 24);
            this.ChooseBox.TabIndex = 3;
            this.ChooseBox.Text = "Choose value";
            // 
            // CountSeconds
            // 
            this.CountSeconds.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountSeconds.Location = new System.Drawing.Point(140, 9);
            this.CountSeconds.Name = "CountSeconds";
            this.CountSeconds.Size = new System.Drawing.Size(124, 23);
            this.CountSeconds.TabIndex = 4;
            this.CountSeconds.Text = "0 Sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(394, 187);
            this.Controls.Add(this.CountSeconds);
            this.Controls.Add(this.ChooseBox);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.ProgressBar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.ComboBox ChooseBox;
        private System.Windows.Forms.Label CountSeconds;
    }
}

