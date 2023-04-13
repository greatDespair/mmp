namespace Laba3
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
            this.ConstOptimizeButton = new System.Windows.Forms.Button();
            this.OptimizeButton = new System.Windows.Forms.Button();
            this.OutputList = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.limit4 = new System.Windows.Forms.NumericUpDown();
            this.limit2 = new System.Windows.Forms.NumericUpDown();
            this.limit1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.factor44 = new System.Windows.Forms.NumericUpDown();
            this.factor43 = new System.Windows.Forms.NumericUpDown();
            this.factor42 = new System.Windows.Forms.NumericUpDown();
            this.factor41 = new System.Windows.Forms.NumericUpDown();
            this.factor24 = new System.Windows.Forms.NumericUpDown();
            this.factor23 = new System.Windows.Forms.NumericUpDown();
            this.factor22 = new System.Windows.Forms.NumericUpDown();
            this.factor21 = new System.Windows.Forms.NumericUpDown();
            this.factor14 = new System.Windows.Forms.NumericUpDown();
            this.factor13 = new System.Windows.Forms.NumericUpDown();
            this.factor12 = new System.Windows.Forms.NumericUpDown();
            this.factor11 = new System.Windows.Forms.NumericUpDown();
            this.RandomData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.limit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor11)).BeginInit();
            this.SuspendLayout();
            // 
            // ConstOptimizeButton
            // 
            this.ConstOptimizeButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.ConstOptimizeButton.Location = new System.Drawing.Point(108, 194);
            this.ConstOptimizeButton.Name = "ConstOptimizeButton";
            this.ConstOptimizeButton.Size = new System.Drawing.Size(390, 50);
            this.ConstOptimizeButton.TabIndex = 83;
            this.ConstOptimizeButton.Text = "Оптимизировать по образцу";
            this.ConstOptimizeButton.UseVisualStyleBackColor = true;
            this.ConstOptimizeButton.Click += new System.EventHandler(this.ConstOptimizeButton_Click);
            // 
            // OptimizeButton
            // 
            this.OptimizeButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.OptimizeButton.Location = new System.Drawing.Point(38, 539);
            this.OptimizeButton.Name = "OptimizeButton";
            this.OptimizeButton.Size = new System.Drawing.Size(259, 50);
            this.OptimizeButton.TabIndex = 82;
            this.OptimizeButton.Text = "Оптимизировать";
            this.OptimizeButton.UseVisualStyleBackColor = true;
            this.OptimizeButton.Click += new System.EventHandler(this.OptimizeButton_Click);
            // 
            // OutputList
            // 
            this.OutputList.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.OutputList.FormattingEnabled = true;
            this.OutputList.ItemHeight = 30;
            this.OutputList.Location = new System.Drawing.Point(612, 12);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(1024, 604);
            this.OutputList.TabIndex = 81;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label17.Location = new System.Drawing.Point(7, 445);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 30);
            this.label17.TabIndex = 80;
            this.label17.Text = "Z";
            // 
            // limit4
            // 
            this.limit4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limit4.Location = new System.Drawing.Point(508, 443);
            this.limit4.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.limit4.Name = "limit4";
            this.limit4.Size = new System.Drawing.Size(64, 35);
            this.limit4.TabIndex = 79;
            // 
            // limit2
            // 
            this.limit2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limit2.Location = new System.Drawing.Point(508, 373);
            this.limit2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.limit2.Name = "limit2";
            this.limit2.Size = new System.Drawing.Size(64, 35);
            this.limit2.TabIndex = 77;
            // 
            // limit1
            // 
            this.limit1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limit1.Location = new System.Drawing.Point(508, 311);
            this.limit1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.limit1.Name = "limit1";
            this.limit1.Size = new System.Drawing.Size(64, 35);
            this.limit1.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label13.Location = new System.Drawing.Point(443, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 30);
            this.label13.TabIndex = 75;
            this.label13.Text = "x4... =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label5.Location = new System.Drawing.Point(443, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 73;
            this.label5.Text = "x4... =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label14.Location = new System.Drawing.Point(333, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 30);
            this.label14.TabIndex = 72;
            this.label14.Text = "x3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label15.Location = new System.Drawing.Point(215, 446);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 30);
            this.label15.TabIndex = 71;
            this.label15.Text = "x2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label16.Location = new System.Drawing.Point(103, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 30);
            this.label16.TabIndex = 70;
            this.label16.Text = "x1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label6.Location = new System.Drawing.Point(333, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 30);
            this.label6.TabIndex = 66;
            this.label6.Text = "x3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label7.Location = new System.Drawing.Point(215, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 30);
            this.label7.TabIndex = 65;
            this.label7.Text = "x2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label8.Location = new System.Drawing.Point(103, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 30);
            this.label8.TabIndex = 64;
            this.label8.Text = "x1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label4.Location = new System.Drawing.Point(444, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 63;
            this.label4.Text = "x4... =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label3.Location = new System.Drawing.Point(333, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 30);
            this.label3.TabIndex = 62;
            this.label3.Text = "x3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label2.Location = new System.Drawing.Point(215, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 30);
            this.label2.TabIndex = 61;
            this.label2.Text = "x2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(103, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 30);
            this.label1.TabIndex = 60;
            this.label1.Text = "x1";
            // 
            // factor44
            // 
            this.factor44.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor44.Location = new System.Drawing.Point(373, 441);
            this.factor44.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor44.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor44.Name = "factor44";
            this.factor44.Size = new System.Drawing.Size(64, 35);
            this.factor44.TabIndex = 59;
            // 
            // factor43
            // 
            this.factor43.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor43.Location = new System.Drawing.Point(255, 441);
            this.factor43.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor43.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor43.Name = "factor43";
            this.factor43.Size = new System.Drawing.Size(64, 35);
            this.factor43.TabIndex = 58;
            // 
            // factor42
            // 
            this.factor42.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor42.Location = new System.Drawing.Point(145, 441);
            this.factor42.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor42.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor42.Name = "factor42";
            this.factor42.Size = new System.Drawing.Size(64, 35);
            this.factor42.TabIndex = 57;
            // 
            // factor41
            // 
            this.factor41.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor41.Location = new System.Drawing.Point(38, 441);
            this.factor41.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor41.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor41.Name = "factor41";
            this.factor41.Size = new System.Drawing.Size(64, 35);
            this.factor41.TabIndex = 56;
            // 
            // factor24
            // 
            this.factor24.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor24.Location = new System.Drawing.Point(373, 371);
            this.factor24.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor24.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor24.Name = "factor24";
            this.factor24.Size = new System.Drawing.Size(64, 35);
            this.factor24.TabIndex = 51;
            // 
            // factor23
            // 
            this.factor23.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor23.Location = new System.Drawing.Point(255, 371);
            this.factor23.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor23.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor23.Name = "factor23";
            this.factor23.Size = new System.Drawing.Size(64, 35);
            this.factor23.TabIndex = 50;
            // 
            // factor22
            // 
            this.factor22.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor22.Location = new System.Drawing.Point(145, 371);
            this.factor22.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor22.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor22.Name = "factor22";
            this.factor22.Size = new System.Drawing.Size(64, 35);
            this.factor22.TabIndex = 49;
            // 
            // factor21
            // 
            this.factor21.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor21.Location = new System.Drawing.Point(38, 371);
            this.factor21.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor21.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor21.Name = "factor21";
            this.factor21.Size = new System.Drawing.Size(64, 35);
            this.factor21.TabIndex = 48;
            // 
            // factor14
            // 
            this.factor14.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor14.Location = new System.Drawing.Point(373, 309);
            this.factor14.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor14.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor14.Name = "factor14";
            this.factor14.Size = new System.Drawing.Size(64, 35);
            this.factor14.TabIndex = 47;
            // 
            // factor13
            // 
            this.factor13.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor13.Location = new System.Drawing.Point(255, 309);
            this.factor13.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor13.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor13.Name = "factor13";
            this.factor13.Size = new System.Drawing.Size(64, 35);
            this.factor13.TabIndex = 46;
            // 
            // factor12
            // 
            this.factor12.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor12.Location = new System.Drawing.Point(145, 309);
            this.factor12.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor12.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor12.Name = "factor12";
            this.factor12.Size = new System.Drawing.Size(64, 35);
            this.factor12.TabIndex = 45;
            // 
            // factor11
            // 
            this.factor11.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor11.Location = new System.Drawing.Point(38, 309);
            this.factor11.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor11.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor11.Name = "factor11";
            this.factor11.Size = new System.Drawing.Size(64, 35);
            this.factor11.TabIndex = 44;
            // 
            // RandomData
            // 
            this.RandomData.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.RandomData.Location = new System.Drawing.Point(338, 539);
            this.RandomData.Name = "RandomData";
            this.RandomData.Size = new System.Drawing.Size(259, 50);
            this.RandomData.TabIndex = 84;
            this.RandomData.Text = "Случайные данные";
            this.RandomData.UseVisualStyleBackColor = true;
            this.RandomData.Click += new System.EventHandler(this.RandomData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 633);
            this.Controls.Add(this.RandomData);
            this.Controls.Add(this.ConstOptimizeButton);
            this.Controls.Add(this.OptimizeButton);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.limit4);
            this.Controls.Add(this.limit2);
            this.Controls.Add(this.limit1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.factor44);
            this.Controls.Add(this.factor43);
            this.Controls.Add(this.factor42);
            this.Controls.Add(this.factor41);
            this.Controls.Add(this.factor24);
            this.Controls.Add(this.factor23);
            this.Controls.Add(this.factor22);
            this.Controls.Add(this.factor21);
            this.Controls.Add(this.factor14);
            this.Controls.Add(this.factor13);
            this.Controls.Add(this.factor12);
            this.Controls.Add(this.factor11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.limit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConstOptimizeButton;
        private System.Windows.Forms.Button OptimizeButton;
        private System.Windows.Forms.ListBox OutputList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown limit4;
        private System.Windows.Forms.NumericUpDown limit2;
        private System.Windows.Forms.NumericUpDown limit1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown factor44;
        private System.Windows.Forms.NumericUpDown factor43;
        private System.Windows.Forms.NumericUpDown factor42;
        private System.Windows.Forms.NumericUpDown factor41;
        private System.Windows.Forms.NumericUpDown factor24;
        private System.Windows.Forms.NumericUpDown factor23;
        private System.Windows.Forms.NumericUpDown factor22;
        private System.Windows.Forms.NumericUpDown factor21;
        private System.Windows.Forms.NumericUpDown factor14;
        private System.Windows.Forms.NumericUpDown factor13;
        private System.Windows.Forms.NumericUpDown factor12;
        private System.Windows.Forms.NumericUpDown factor11;
        private System.Windows.Forms.Button RandomData;
    }
}

