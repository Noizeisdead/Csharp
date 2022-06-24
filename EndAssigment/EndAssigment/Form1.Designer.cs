namespace EndAssigment
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DriveText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DayPick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EndTimePick = new System.Windows.Forms.DateTimePicker();
            this.StartTimePick = new System.Windows.Forms.DateTimePicker();
            this.CalcPrice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DistanceInput = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CompanyText = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AverageDistance = new System.Windows.Forms.Button();
            this.LongestDrive = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.showTaxi = new System.Windows.Forms.Button();
            this.TaxiText = new System.Windows.Forms.RichTextBox();
            this.addTaxi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.TaxiIDInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DriveText);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.DayPick);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.EndTimePick);
            this.tabPage3.Controls.Add(this.StartTimePick);
            this.tabPage3.Controls.Add(this.CalcPrice);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.DistanceInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drive";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DriveText
            // 
            this.DriveText.Location = new System.Drawing.Point(432, 24);
            this.DriveText.Name = "DriveText";
            this.DriveText.Size = new System.Drawing.Size(330, 368);
            this.DriveText.TabIndex = 17;
            this.DriveText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Day:";
            // 
            // DayPick
            // 
            this.DayPick.Location = new System.Drawing.Point(94, 128);
            this.DayPick.Name = "DayPick";
            this.DayPick.Size = new System.Drawing.Size(250, 27);
            this.DayPick.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Distance:";
            // 
            // EndTimePick
            // 
            this.EndTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePick.Location = new System.Drawing.Point(94, 85);
            this.EndTimePick.Name = "EndTimePick";
            this.EndTimePick.Size = new System.Drawing.Size(250, 27);
            this.EndTimePick.TabIndex = 13;
            // 
            // StartTimePick
            // 
            this.StartTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePick.Location = new System.Drawing.Point(94, 46);
            this.StartTimePick.Name = "StartTimePick";
            this.StartTimePick.Size = new System.Drawing.Size(250, 27);
            this.StartTimePick.TabIndex = 12;
            // 
            // CalcPrice
            // 
            this.CalcPrice.Location = new System.Drawing.Point(94, 221);
            this.CalcPrice.Name = "CalcPrice";
            this.CalcPrice.Size = new System.Drawing.Size(143, 29);
            this.CalcPrice.TabIndex = 10;
            this.CalcPrice.Text = "Calculate Price";
            this.CalcPrice.UseVisualStyleBackColor = true;
            this.CalcPrice.Click += new System.EventHandler(this.CalcPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Time:";
            // 
            // DistanceInput
            // 
            this.DistanceInput.Location = new System.Drawing.Point(94, 164);
            this.DistanceInput.Name = "DistanceInput";
            this.DistanceInput.Size = new System.Drawing.Size(125, 27);
            this.DistanceInput.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CompanyText);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.AverageDistance);
            this.tabPage1.Controls.Add(this.LongestDrive);
            this.tabPage1.Controls.Add(this.income);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Company";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CompanyText
            // 
            this.CompanyText.Location = new System.Drawing.Point(443, 23);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(330, 368);
            this.CompanyText.TabIndex = 7;
            this.CompanyText.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Result:";
            // 
            // AverageDistance
            // 
            this.AverageDistance.Location = new System.Drawing.Point(20, 147);
            this.AverageDistance.Name = "AverageDistance";
            this.AverageDistance.Size = new System.Drawing.Size(179, 29);
            this.AverageDistance.TabIndex = 2;
            this.AverageDistance.Text = "Average distance";
            this.AverageDistance.UseVisualStyleBackColor = true;
            // 
            // LongestDrive
            // 
            this.LongestDrive.Location = new System.Drawing.Point(20, 100);
            this.LongestDrive.Name = "LongestDrive";
            this.LongestDrive.Size = new System.Drawing.Size(179, 29);
            this.LongestDrive.TabIndex = 1;
            this.LongestDrive.Text = "Longest Drive";
            this.LongestDrive.UseVisualStyleBackColor = true;
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(20, 55);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(179, 29);
            this.income.TabIndex = 0;
            this.income.Text = "Calculate Income";
            this.income.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.showTaxi);
            this.tabPage2.Controls.Add(this.TaxiText);
            this.tabPage2.Controls.Add(this.addTaxi);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.TaxiIDInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Taxi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // showTaxi
            // 
            this.showTaxi.Location = new System.Drawing.Point(225, 305);
            this.showTaxi.Name = "showTaxi";
            this.showTaxi.Size = new System.Drawing.Size(94, 29);
            this.showTaxi.TabIndex = 7;
            this.showTaxi.Text = "Show Taxi\'s";
            this.showTaxi.UseVisualStyleBackColor = true;
            // 
            // TaxiText
            // 
            this.TaxiText.Location = new System.Drawing.Point(443, 25);
            this.TaxiText.Name = "TaxiText";
            this.TaxiText.Size = new System.Drawing.Size(330, 368);
            this.TaxiText.TabIndex = 6;
            this.TaxiText.Text = "";
            // 
            // addTaxi
            // 
            this.addTaxi.Location = new System.Drawing.Point(54, 140);
            this.addTaxi.Name = "addTaxi";
            this.addTaxi.Size = new System.Drawing.Size(94, 29);
            this.addTaxi.TabIndex = 5;
            this.addTaxi.Text = "Add Taxi";
            this.addTaxi.UseVisualStyleBackColor = true;
            this.addTaxi.Click += new System.EventHandler(this.addTaxi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Link drive and taxi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(83, 260);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 27);
            this.textBox10.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(83, 215);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 27);
            this.textBox9.TabIndex = 2;
            // 
            // TaxiIDInput
            // 
            this.TaxiIDInput.Location = new System.Drawing.Point(83, 90);
            this.TaxiIDInput.Name = "TaxiIDInput";
            this.TaxiIDInput.Size = new System.Drawing.Size(125, 27);
            this.TaxiIDInput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button AverageDistance;
        private Button LongestDrive;
        private Button income;
        private TextBox textBox2;
        private TextBox DistanceInput;
        private Button addTaxi;
        private Button button1;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox TaxiIDInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button CalcPrice;
        private DateTimePicker EndTimePick;
        private DateTimePicker StartTimePick;
        private Label label4;
        private DateTimePicker DayPick;
        private Label label6;
        private RichTextBox TaxiText;
        private RichTextBox DriveText;
        private RichTextBox CompanyText;
        private Button showTaxi;
    }
}