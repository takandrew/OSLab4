
namespace OSLab4
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.MaximumRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ProvidedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResourceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Предоставлено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максимум";
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.Location = new System.Drawing.Point(28, 139);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.ReadOnly = true;
            this.LogRichTextBox.Size = new System.Drawing.Size(481, 328);
            this.LogRichTextBox.TabIndex = 4;
            this.LogRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Лог выполнения";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(212, 485);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(113, 58);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Запуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MaximumRichTextBox
            // 
            this.MaximumRichTextBox.Location = new System.Drawing.Point(364, 41);
            this.MaximumRichTextBox.Name = "MaximumRichTextBox";
            this.MaximumRichTextBox.Size = new System.Drawing.Size(145, 80);
            this.MaximumRichTextBox.TabIndex = 7;
            this.MaximumRichTextBox.Text = "2 0 2 2\n2 2 2 2\n2 4 2 4\n0 0 2 4";
            // 
            // ProvidedRichTextBox
            // 
            this.ProvidedRichTextBox.Location = new System.Drawing.Point(28, 41);
            this.ProvidedRichTextBox.Name = "ProvidedRichTextBox";
            this.ProvidedRichTextBox.Size = new System.Drawing.Size(145, 80);
            this.ProvidedRichTextBox.TabIndex = 8;
            this.ProvidedRichTextBox.Text = "2 0 0 0 \n2 2 0 0\n0 2 2 0\n0 0 2 2";
            // 
            // ResourceTextBox
            // 
            this.ResourceTextBox.Location = new System.Drawing.Point(209, 41);
            this.ResourceTextBox.Name = "ResourceTextBox";
            this.ResourceTextBox.Size = new System.Drawing.Size(123, 22);
            this.ResourceTextBox.TabIndex = 9;
            this.ResourceTextBox.Text = "4 4 4 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ресурсы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResourceTextBox);
            this.Controls.Add(this.ProvidedRichTextBox);
            this.Controls.Add(this.MaximumRichTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Управление процессами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox MaximumRichTextBox;
        private System.Windows.Forms.RichTextBox ProvidedRichTextBox;
        private System.Windows.Forms.TextBox ResourceTextBox;
        private System.Windows.Forms.Label label4;
    }
}

