﻿namespace Laba4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RandomData = new System.Windows.Forms.Button();
            this.ConstOptimizeButton = new System.Windows.Forms.Button();
            this.OptimizeButton = new System.Windows.Forms.Button();
            this.OutputList = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.limit2 = new System.Windows.Forms.NumericUpDown();
            this.limit1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.factor43 = new System.Windows.Forms.NumericUpDown();
            this.factor42 = new System.Windows.Forms.NumericUpDown();
            this.factor41 = new System.Windows.Forms.NumericUpDown();
            this.factor23 = new System.Windows.Forms.NumericUpDown();
            this.factor22 = new System.Windows.Forms.NumericUpDown();
            this.factor21 = new System.Windows.Forms.NumericUpDown();
            this.factor13 = new System.Windows.Forms.NumericUpDown();
            this.factor12 = new System.Windows.Forms.NumericUpDown();
            this.factor11 = new System.Windows.Forms.NumericUpDown();
            this.limit3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.factor33 = new System.Windows.Forms.NumericUpDown();
            this.factor32 = new System.Windows.Forms.NumericUpDown();
            this.factor31 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor31)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Laba4.Properties.Resources.Screenshot_2;
            this.pictureBox1.Location = new System.Drawing.Point(188, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 157);
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // RandomData
            // 
            this.RandomData.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.RandomData.Location = new System.Drawing.Point(341, 626);
            this.RandomData.Name = "RandomData";
            this.RandomData.Size = new System.Drawing.Size(259, 50);
            this.RandomData.TabIndex = 117;
            this.RandomData.Text = "Случайные данные";
            this.RandomData.UseVisualStyleBackColor = true;
            this.RandomData.Click += new System.EventHandler(this.RandomData_Click);
            // 
            // ConstOptimizeButton
            // 
            this.ConstOptimizeButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.ConstOptimizeButton.Location = new System.Drawing.Point(111, 251);
            this.ConstOptimizeButton.Name = "ConstOptimizeButton";
            this.ConstOptimizeButton.Size = new System.Drawing.Size(373, 50);
            this.ConstOptimizeButton.TabIndex = 116;
            this.ConstOptimizeButton.Text = "Оптимизировать по образцу";
            this.ConstOptimizeButton.UseVisualStyleBackColor = true;
            this.ConstOptimizeButton.Click += new System.EventHandler(this.ConstOptimizeButton_Click);
            // 
            // OptimizeButton
            // 
            this.OptimizeButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.OptimizeButton.Location = new System.Drawing.Point(41, 626);
            this.OptimizeButton.Name = "OptimizeButton";
            this.OptimizeButton.Size = new System.Drawing.Size(259, 50);
            this.OptimizeButton.TabIndex = 115;
            this.OptimizeButton.Text = "Оптимизировать";
            this.OptimizeButton.UseVisualStyleBackColor = true;
            this.OptimizeButton.Click += new System.EventHandler(this.OptimizeButton_Click);
            // 
            // OutputList
            // 
            this.OutputList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputList.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputList.FormattingEnabled = true;
            this.OutputList.ItemHeight = 21;
            this.OutputList.Location = new System.Drawing.Point(617, 12);
            this.OutputList.Name = "OutputList";
            this.OutputList.ScrollAlwaysVisible = true;
            this.OutputList.Size = new System.Drawing.Size(893, 655);
            this.OutputList.TabIndex = 114;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label17.Location = new System.Drawing.Point(36, 529);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 30);
            this.label17.TabIndex = 113;
            this.label17.Text = "Z";
            // 
            // limit2
            // 
            this.limit2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limit2.Location = new System.Drawing.Point(420, 408);
            this.limit2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.limit2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.limit2.Name = "limit2";
            this.limit2.Size = new System.Drawing.Size(64, 35);
            this.limit2.TabIndex = 111;
            // 
            // limit1
            // 
            this.limit1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limit1.Location = new System.Drawing.Point(420, 346);
            this.limit1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.limit1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.limit1.Name = "limit1";
            this.limit1.Size = new System.Drawing.Size(64, 35);
            this.limit1.TabIndex = 110;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label14.Location = new System.Drawing.Point(362, 530);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 30);
            this.label14.TabIndex = 107;
            this.label14.Text = "x3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label15.Location = new System.Drawing.Point(244, 530);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 30);
            this.label15.TabIndex = 106;
            this.label15.Text = "x2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label16.Location = new System.Drawing.Point(132, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 30);
            this.label16.TabIndex = 105;
            this.label16.Text = "x1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label6.Location = new System.Drawing.Point(362, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 30);
            this.label6.TabIndex = 104;
            this.label6.Text = "x3 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label7.Location = new System.Drawing.Point(244, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 30);
            this.label7.TabIndex = 103;
            this.label7.Text = "x2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label8.Location = new System.Drawing.Point(132, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 30);
            this.label8.TabIndex = 102;
            this.label8.Text = "x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label3.Location = new System.Drawing.Point(362, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 30);
            this.label3.TabIndex = 100;
            this.label3.Text = "x3 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label2.Location = new System.Drawing.Point(244, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 30);
            this.label2.TabIndex = 99;
            this.label2.Text = "x2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(132, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 30);
            this.label1.TabIndex = 98;
            this.label1.Text = "x1";
            // 
            // factor43
            // 
            this.factor43.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor43.Location = new System.Drawing.Point(284, 525);
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
            this.factor43.TabIndex = 96;
            // 
            // factor42
            // 
            this.factor42.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor42.Location = new System.Drawing.Point(174, 525);
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
            this.factor42.TabIndex = 95;
            // 
            // factor41
            // 
            this.factor41.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor41.Location = new System.Drawing.Point(67, 525);
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
            this.factor41.TabIndex = 94;
            // 
            // factor23
            // 
            this.factor23.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor23.Location = new System.Drawing.Point(284, 405);
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
            this.factor23.TabIndex = 92;
            // 
            // factor22
            // 
            this.factor22.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor22.Location = new System.Drawing.Point(174, 405);
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
            this.factor22.TabIndex = 91;
            // 
            // factor21
            // 
            this.factor21.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor21.Location = new System.Drawing.Point(67, 405);
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
            this.factor21.TabIndex = 90;
            // 
            // factor13
            // 
            this.factor13.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor13.Location = new System.Drawing.Point(284, 343);
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
            this.factor13.TabIndex = 88;
            // 
            // factor12
            // 
            this.factor12.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor12.Location = new System.Drawing.Point(174, 343);
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
            this.factor12.TabIndex = 87;
            // 
            // factor11
            // 
            this.factor11.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor11.Location = new System.Drawing.Point(67, 343);
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
            this.factor11.TabIndex = 86;
            // 
            // limit3
            // 
            this.limit3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limit3.Location = new System.Drawing.Point(420, 467);
            this.limit3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.limit3.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.limit3.Name = "limit3";
            this.limit3.Size = new System.Drawing.Size(64, 35);
            this.limit3.TabIndex = 127;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label10.Location = new System.Drawing.Point(362, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 30);
            this.label10.TabIndex = 125;
            this.label10.Text = "x3 =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label11.Location = new System.Drawing.Point(244, 469);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 30);
            this.label11.TabIndex = 124;
            this.label11.Text = "x2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.label12.Location = new System.Drawing.Point(132, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 30);
            this.label12.TabIndex = 123;
            this.label12.Text = "x1";
            // 
            // factor33
            // 
            this.factor33.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor33.Location = new System.Drawing.Point(284, 464);
            this.factor33.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor33.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor33.Name = "factor33";
            this.factor33.Size = new System.Drawing.Size(64, 35);
            this.factor33.TabIndex = 121;
            // 
            // factor32
            // 
            this.factor32.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor32.Location = new System.Drawing.Point(174, 464);
            this.factor32.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor32.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor32.Name = "factor32";
            this.factor32.Size = new System.Drawing.Size(64, 35);
            this.factor32.TabIndex = 120;
            // 
            // factor31
            // 
            this.factor31.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factor31.Location = new System.Drawing.Point(67, 464);
            this.factor31.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.factor31.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.factor31.Name = "factor31";
            this.factor31.Size = new System.Drawing.Size(64, 35);
            this.factor31.TabIndex = 119;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 688);
            this.Controls.Add(this.limit3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.factor33);
            this.Controls.Add(this.factor32);
            this.Controls.Add(this.factor31);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RandomData);
            this.Controls.Add(this.ConstOptimizeButton);
            this.Controls.Add(this.OptimizeButton);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.limit2);
            this.Controls.Add(this.limit1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.factor43);
            this.Controls.Add(this.factor42);
            this.Controls.Add(this.factor41);
            this.Controls.Add(this.factor23);
            this.Controls.Add(this.factor22);
            this.Controls.Add(this.factor21);
            this.Controls.Add(this.factor13);
            this.Controls.Add(this.factor12);
            this.Controls.Add(this.factor11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor31)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RandomData;
        private System.Windows.Forms.Button ConstOptimizeButton;
        private System.Windows.Forms.Button OptimizeButton;
        private System.Windows.Forms.ListBox OutputList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown limit2;
        private System.Windows.Forms.NumericUpDown limit1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown factor43;
        private System.Windows.Forms.NumericUpDown factor42;
        private System.Windows.Forms.NumericUpDown factor41;
        private System.Windows.Forms.NumericUpDown factor23;
        private System.Windows.Forms.NumericUpDown factor22;
        private System.Windows.Forms.NumericUpDown factor21;
        private System.Windows.Forms.NumericUpDown factor13;
        private System.Windows.Forms.NumericUpDown factor12;
        private System.Windows.Forms.NumericUpDown factor11;
        private System.Windows.Forms.NumericUpDown limit3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown factor33;
        private System.Windows.Forms.NumericUpDown factor32;
        private System.Windows.Forms.NumericUpDown factor31;
    }
}

