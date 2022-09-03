namespace NameChanger
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
            this.changeFileButton = new System.Windows.Forms.Button();
            this.oldAudioList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfAudiofiles = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.newAudioList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // changeFileButton
            // 
            this.changeFileButton.Location = new System.Drawing.Point(253, 362);
            this.changeFileButton.Name = "changeFileButton";
            this.changeFileButton.Size = new System.Drawing.Size(75, 23);
            this.changeFileButton.TabIndex = 0;
            this.changeFileButton.Text = "Change name";
            this.changeFileButton.UseVisualStyleBackColor = true;
            this.changeFileButton.Click += new System.EventHandler(this.changeFileButton_Click);
            // 
            // oldAudioList
            // 
            this.oldAudioList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.oldAudioList.FullRowSelect = true;
            this.oldAudioList.GridLines = true;
            this.oldAudioList.HideSelection = false;
            this.oldAudioList.Location = new System.Drawing.Point(41, 24);
            this.oldAudioList.Margin = new System.Windows.Forms.Padding(1);
            this.oldAudioList.Name = "oldAudioList";
            this.oldAudioList.Size = new System.Drawing.Size(221, 248);
            this.oldAudioList.TabIndex = 1;
            this.oldAudioList.UseCompatibleStateImageBehavior = false;
            this.oldAudioList.View = System.Windows.Forms.View.Details;
            this.oldAudioList.SelectedIndexChanged += new System.EventHandler(this.oldAudioList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Processed files:";
            // 
            // numberOfAudiofiles
            // 
            this.numberOfAudiofiles.AutoSize = true;
            this.numberOfAudiofiles.ForeColor = System.Drawing.Color.YellowGreen;
            this.numberOfAudiofiles.Location = new System.Drawing.Point(339, 336);
            this.numberOfAudiofiles.Name = "numberOfAudiofiles";
            this.numberOfAudiofiles.Size = new System.Drawing.Size(0, 13);
            this.numberOfAudiofiles.TabIndex = 4;
            this.numberOfAudiofiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numberOfAudiofiles.Click += new System.EventHandler(this.numberOfAudiofiles_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name of file";
            this.columnHeader1.Width = 217;
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(224, 303);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(124, 20);
            this.prefixTextBox.TabIndex = 5;
            this.prefixTextBox.Text = "y2mate.com - ";
            // 
            // newAudioList
            // 
            this.newAudioList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.newAudioList.FullRowSelect = true;
            this.newAudioList.GridLines = true;
            this.newAudioList.HideSelection = false;
            this.newAudioList.Location = new System.Drawing.Point(309, 24);
            this.newAudioList.Margin = new System.Windows.Forms.Padding(1);
            this.newAudioList.Name = "newAudioList";
            this.newAudioList.Size = new System.Drawing.Size(221, 248);
            this.newAudioList.TabIndex = 6;
            this.newAudioList.UseCompatibleStateImageBehavior = false;
            this.newAudioList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name of file";
            this.columnHeader2.Width = 217;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 410);
            this.Controls.Add(this.newAudioList);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.numberOfAudiofiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldAudioList);
            this.Controls.Add(this.changeFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeFileButton;
        private System.Windows.Forms.ListView oldAudioList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfAudiofiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.ListView newAudioList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

