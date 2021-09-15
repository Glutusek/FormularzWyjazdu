
namespace FormularzWyjazdu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActualDate = new System.Windows.Forms.DateTimePicker();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BornDateLabel = new System.Windows.Forms.Label();
            this.BornDate = new System.Windows.Forms.DateTimePicker();
            this.ArriveDate = new System.Windows.Forms.DateTimePicker();
            this.ArriveDateLabel = new System.Windows.Forms.Label();
            this.LeaveDateLabel = new System.Windows.Forms.Label();
            this.LeaveDate = new System.Windows.Forms.DateTimePicker();
            this.ActualDateLabel = new System.Windows.Forms.Label();
            this.NumOfDaysLabel = new System.Windows.Forms.Label();
            this.NumOfDays = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfDays)).BeginInit();
            this.SuspendLayout();
            // 
            // ActualDate
            // 
            this.ActualDate.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualDate.Enabled = false;
            this.ActualDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualDate.Location = new System.Drawing.Point(588, 45);
            this.ActualDate.Name = "ActualDate";
            this.ActualDate.Size = new System.Drawing.Size(327, 33);
            this.ActualDate.TabIndex = 0;
            this.ActualDate.Value = new System.DateTime(2021, 9, 15, 9, 34, 11, 756);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(27, 42);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(113, 35);
            this.NameBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(56, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 30);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Imię";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // BornDateLabel
            // 
            this.BornDateLabel.AutoSize = true;
            this.BornDateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BornDateLabel.Location = new System.Drawing.Point(218, 12);
            this.BornDateLabel.Name = "BornDateLabel";
            this.BornDateLabel.Size = new System.Drawing.Size(155, 30);
            this.BornDateLabel.TabIndex = 3;
            this.BornDateLabel.Text = "Data urodzenia";
            // 
            // BornDate
            // 
            this.BornDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BornDate.Location = new System.Drawing.Point(162, 44);
            this.BornDate.Name = "BornDate";
            this.BornDate.Size = new System.Drawing.Size(282, 29);
            this.BornDate.TabIndex = 4;
            // 
            // ArriveDate
            // 
            this.ArriveDate.Location = new System.Drawing.Point(12, 165);
            this.ArriveDate.Name = "ArriveDate";
            this.ArriveDate.Size = new System.Drawing.Size(200, 23);
            this.ArriveDate.TabIndex = 5;
            this.ArriveDate.ValueChanged += new System.EventHandler(this.ArriveDate_ValueChanged);
            // 
            // ArriveDateLabel
            // 
            this.ArriveDateLabel.AutoSize = true;
            this.ArriveDateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArriveDateLabel.Location = new System.Drawing.Point(38, 121);
            this.ArriveDateLabel.Name = "ArriveDateLabel";
            this.ArriveDateLabel.Size = new System.Drawing.Size(152, 30);
            this.ArriveDateLabel.TabIndex = 6;
            this.ArriveDateLabel.Text = "Data przyjazdu";
            // 
            // LeaveDateLabel
            // 
            this.LeaveDateLabel.AutoSize = true;
            this.LeaveDateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeaveDateLabel.Location = new System.Drawing.Point(320, 121);
            this.LeaveDateLabel.Name = "LeaveDateLabel";
            this.LeaveDateLabel.Size = new System.Drawing.Size(137, 30);
            this.LeaveDateLabel.TabIndex = 7;
            this.LeaveDateLabel.Text = "Data odjazdu";
            // 
            // LeaveDate
            // 
            this.LeaveDate.Location = new System.Drawing.Point(286, 165);
            this.LeaveDate.Name = "LeaveDate";
            this.LeaveDate.Size = new System.Drawing.Size(200, 23);
            this.LeaveDate.TabIndex = 8;
            this.LeaveDate.ValueChanged += new System.EventHandler(this.LeaveDate_ValueChanged);
            // 
            // ActualDateLabel
            // 
            this.ActualDateLabel.AutoSize = true;
            this.ActualDateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualDateLabel.Location = new System.Drawing.Point(724, 9);
            this.ActualDateLabel.Name = "ActualDateLabel";
            this.ActualDateLabel.Size = new System.Drawing.Size(73, 30);
            this.ActualDateLabel.TabIndex = 9;
            this.ActualDateLabel.Text = "Dzisiaj";
            // 
            // NumOfDaysLabel
            // 
            this.NumOfDaysLabel.AutoSize = true;
            this.NumOfDaysLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumOfDaysLabel.Location = new System.Drawing.Point(201, 202);
            this.NumOfDaysLabel.Name = "NumOfDaysLabel";
            this.NumOfDaysLabel.Size = new System.Drawing.Size(90, 30);
            this.NumOfDaysLabel.TabIndex = 10;
            this.NumOfDaysLabel.Text = "Ilość dni";
            // 
            // NumOfDays
            // 
            this.NumOfDays.Location = new System.Drawing.Point(188, 235);
            this.NumOfDays.Name = "NumOfDays";
            this.NumOfDays.Size = new System.Drawing.Size(120, 23);
            this.NumOfDays.TabIndex = 11;
            this.NumOfDays.ValueChanged += new System.EventHandler(this.NumOfDays_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.NumOfDays);
            this.Controls.Add(this.NumOfDaysLabel);
            this.Controls.Add(this.ActualDateLabel);
            this.Controls.Add(this.LeaveDate);
            this.Controls.Add(this.LeaveDateLabel);
            this.Controls.Add(this.ArriveDateLabel);
            this.Controls.Add(this.ArriveDate);
            this.Controls.Add(this.BornDate);
            this.Controls.Add(this.BornDateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ActualDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ActualDate;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BornDateLabel;
        private System.Windows.Forms.DateTimePicker BornDate;
        private System.Windows.Forms.DateTimePicker ArriveDate;
        private System.Windows.Forms.Label ArriveDateLabel;
        private System.Windows.Forms.Label LeaveDateLabel;
        private System.Windows.Forms.DateTimePicker LeaveDate;
        private System.Windows.Forms.Label ActualDateLabel;
        private System.Windows.Forms.Label NumOfDaysLabel;
        private System.Windows.Forms.NumericUpDown NumOfDays;
    }
}

