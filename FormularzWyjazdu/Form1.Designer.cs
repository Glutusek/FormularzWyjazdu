
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
            this.NumOfDays = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.CountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
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
            this.NumOfDaysLabel.Location = new System.Drawing.Point(198, 215);
            this.NumOfDaysLabel.Name = "NumOfDaysLabel";
            this.NumOfDaysLabel.Size = new System.Drawing.Size(90, 30);
            this.NumOfDaysLabel.TabIndex = 10;
            this.NumOfDaysLabel.Text = "Ilość dni";
            // 
            // NumOfDays
            // 
            this.NumOfDays.AutoSize = true;
            this.NumOfDays.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumOfDays.Location = new System.Drawing.Point(231, 245);
            this.NumOfDays.Name = "NumOfDays";
            this.NumOfDays.Size = new System.Drawing.Size(22, 25);
            this.NumOfDays.TabIndex = 11;
            this.NumOfDays.Text = "0";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(266, 308);
            this.Price.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(72, 23);
            this.Price.TabIndex = 12;
            this.Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(99, 301);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(161, 30);
            this.PriceLabel.TabIndex = 13;
            this.PriceLabel.Text = "Cena za 24h (zł)";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.Location = new System.Drawing.Point(712, 158);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(96, 37);
            this.TotalPriceLabel.TabIndex = 14;
            this.TotalPriceLabel.Text = "Razem";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPrice.Location = new System.Drawing.Point(733, 215);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(52, 32);
            this.TotalPrice.TabIndex = 15;
            this.TotalPrice.Text = "0 zł";
            // 
            // CountButton
            // 
            this.CountButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountButton.Location = new System.Drawing.Point(198, 368);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 31);
            this.CountButton.TabIndex = 16;
            this.CountButton.Text = "Oblicz";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.Price);
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
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
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
        private System.Windows.Forms.Label NumOfDays;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button CountButton;
    }
}

