namespace Laba6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMakeGood = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridB = new System.Windows.Forms.DataGridView();
            this.MatrB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridC = new System.Windows.Forms.DataGridView();
            this.gridA = new System.Windows.Forms.DataGridView();
            this.MatrA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFirstPay = new System.Windows.Forms.Label();
            this.btnFirstPay = new System.Windows.Forms.Button();
            this.lblCheck2 = new System.Windows.Forms.Label();
            this.lblCheck1 = new System.Windows.Forms.Label();
            this.btnNordWest = new System.Windows.Forms.Button();
            this.gridSupport = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblOptimum = new System.Windows.Forms.Label();
            this.btnStep2 = new System.Windows.Forms.Button();
            this.btnStep1 = new System.Windows.Forms.Button();
            this.gridFinal = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakeGood
            // 
            this.btnMakeGood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeGood.Font = new System.Drawing.Font("Yu Gothic UI Light", 28F);
            this.btnMakeGood.Location = new System.Drawing.Point(230, 557);
            this.btnMakeGood.Name = "btnMakeGood";
            this.btnMakeGood.Size = new System.Drawing.Size(409, 124);
            this.btnMakeGood.TabIndex = 6;
            this.btnMakeGood.Text = "Запуск";
            this.btnMakeGood.UseVisualStyleBackColor = true;
            this.btnMakeGood.Click += new System.EventHandler(this.btnMakeGood_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 525);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.gridB);
            this.tabPage1.Controls.Add(this.gridC);
            this.tabPage1.Controls.Add(this.gridA);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Условия задачи";
            // 
            // gridB
            // 
            this.gridB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridB.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatrB});
            this.gridB.GridColor = System.Drawing.SystemColors.Control;
            this.gridB.Location = new System.Drawing.Point(189, 0);
            this.gridB.Name = "gridB";
            dataGridViewCellStyle2.NullValue = "-";
            this.gridB.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridB.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridB.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            this.gridB.RowTemplate.DefaultCellStyle.Format = "N2";
            this.gridB.RowTemplate.DefaultCellStyle.NullValue = "-";
            this.gridB.Size = new System.Drawing.Size(193, 487);
            this.gridB.TabIndex = 2;
            this.gridB.Visible = false;
            this.gridB.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridB_RowsAdded);
            this.gridB.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridB_RowsRemoved);
            // 
            // MatrB
            // 
            this.MatrB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "null";
            this.MatrB.DefaultCellStyle = dataGridViewCellStyle1;
            this.MatrB.HeaderText = "Потребители";
            this.MatrB.Name = "MatrB";
            this.MatrB.Width = 146;
            // 
            // gridC
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            this.gridC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "N5";
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridC.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridC.GridColor = System.Drawing.SystemColors.Control;
            this.gridC.Location = new System.Drawing.Point(388, 0);
            this.gridC.Name = "gridC";
            this.gridC.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "null";
            this.gridC.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridC.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            this.gridC.RowTemplate.DefaultCellStyle.NullValue = "-";
            this.gridC.Size = new System.Drawing.Size(441, 487);
            this.gridC.TabIndex = 1;
            this.gridC.Visible = false;
            // 
            // gridA
            // 
            this.gridA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridA.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatrA});
            this.gridA.GridColor = System.Drawing.SystemColors.Control;
            this.gridA.Location = new System.Drawing.Point(0, 0);
            this.gridA.MultiSelect = false;
            this.gridA.Name = "gridA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridA.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Format = "N4";
            dataGridViewCellStyle8.NullValue = null;
            this.gridA.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridA.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridA.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            this.gridA.RowTemplate.DefaultCellStyle.Format = "N2";
            this.gridA.RowTemplate.DefaultCellStyle.NullValue = "-";
            this.gridA.Size = new System.Drawing.Size(183, 487);
            this.gridA.TabIndex = 0;
            this.gridA.Visible = false;
            this.gridA.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridA_RowsAdded);
            this.gridA.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridA_RowsRemoved);
            // 
            // MatrA
            // 
            this.MatrA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "null";
            this.MatrA.DefaultCellStyle = dataGridViewCellStyle6;
            this.MatrA.FillWeight = 50F;
            this.MatrA.HeaderText = "Поставщики";
            this.MatrA.Name = "MatrA";
            this.MatrA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MatrA.Width = 118;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lblFirstPay);
            this.tabPage2.Controls.Add(this.btnFirstPay);
            this.tabPage2.Controls.Add(this.lblCheck2);
            this.tabPage2.Controls.Add(this.lblCheck1);
            this.tabPage2.Controls.Add(this.btnNordWest);
            this.tabPage2.Controls.Add(this.gridSupport);
            this.tabPage2.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Опорный план";
            // 
            // lblFirstPay
            // 
            this.lblFirstPay.AutoSize = true;
            this.lblFirstPay.Location = new System.Drawing.Point(6, 174);
            this.lblFirstPay.Name = "lblFirstPay";
            this.lblFirstPay.Size = new System.Drawing.Size(0, 25);
            this.lblFirstPay.TabIndex = 8;
            // 
            // btnFirstPay
            // 
            this.btnFirstPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirstPay.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F);
            this.btnFirstPay.Location = new System.Drawing.Point(295, 359);
            this.btnFirstPay.Name = "btnFirstPay";
            this.btnFirstPay.Size = new System.Drawing.Size(287, 75);
            this.btnFirstPay.TabIndex = 7;
            this.btnFirstPay.Text = "Стоимость по опорному плану";
            this.btnFirstPay.UseVisualStyleBackColor = true;
            this.btnFirstPay.Click += new System.EventHandler(this.btnFirstPay_Click);
            // 
            // lblCheck2
            // 
            this.lblCheck2.AutoSize = true;
            this.lblCheck2.Location = new System.Drawing.Point(6, 132);
            this.lblCheck2.Name = "lblCheck2";
            this.lblCheck2.Size = new System.Drawing.Size(0, 25);
            this.lblCheck2.TabIndex = 6;
            // 
            // lblCheck1
            // 
            this.lblCheck1.AutoSize = true;
            this.lblCheck1.Location = new System.Drawing.Point(6, 119);
            this.lblCheck1.Name = "lblCheck1";
            this.lblCheck1.Size = new System.Drawing.Size(0, 25);
            this.lblCheck1.TabIndex = 5;
            // 
            // btnNordWest
            // 
            this.btnNordWest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNordWest.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNordWest.Location = new System.Drawing.Point(295, 282);
            this.btnNordWest.Name = "btnNordWest";
            this.btnNordWest.Size = new System.Drawing.Size(287, 71);
            this.btnNordWest.TabIndex = 1;
            this.btnNordWest.Text = "Найти опорный план";
            this.btnNordWest.UseVisualStyleBackColor = true;
            this.btnNordWest.Click += new System.EventHandler(this.btnNordWest_Click);
            // 
            // gridSupport
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F);
            this.gridSupport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridSupport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "-";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupport.DefaultCellStyle = dataGridViewCellStyle10;
            this.gridSupport.Location = new System.Drawing.Point(154, 6);
            this.gridSupport.Name = "gridSupport";
            this.gridSupport.RowHeadersWidth = 50;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F);
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "-";
            this.gridSupport.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridSupport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F);
            this.gridSupport.RowTemplate.DefaultCellStyle.Format = "N2";
            this.gridSupport.RowTemplate.DefaultCellStyle.NullValue = "-";
            this.gridSupport.Size = new System.Drawing.Size(577, 270);
            this.gridSupport.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.lblOptimum);
            this.tabPage3.Controls.Add(this.btnStep2);
            this.tabPage3.Controls.Add(this.btnStep1);
            this.tabPage3.Controls.Add(this.gridFinal);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(829, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оптимальное решение";
            // 
            // lblOptimum
            // 
            this.lblOptimum.AutoSize = true;
            this.lblOptimum.Location = new System.Drawing.Point(3, 58);
            this.lblOptimum.Name = "lblOptimum";
            this.lblOptimum.Size = new System.Drawing.Size(0, 25);
            this.lblOptimum.TabIndex = 6;
            // 
            // btnStep2
            // 
            this.btnStep2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStep2.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F);
            this.btnStep2.Location = new System.Drawing.Point(223, 361);
            this.btnStep2.Name = "btnStep2";
            this.btnStep2.Size = new System.Drawing.Size(415, 69);
            this.btnStep2.TabIndex = 5;
            this.btnStep2.Text = "Стоимость по плану оптимизации";
            this.btnStep2.UseVisualStyleBackColor = true;
            this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
            // 
            // btnStep1
            // 
            this.btnStep1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStep1.Font = new System.Drawing.Font("Yu Gothic UI Light", 15.75F);
            this.btnStep1.Location = new System.Drawing.Point(223, 287);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(415, 68);
            this.btnStep1.TabIndex = 4;
            this.btnStep1.Text = "Найти план оптимизации";
            this.btnStep1.UseVisualStyleBackColor = true;
            this.btnStep1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gridFinal
            // 
            this.gridFinal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "null";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFinal.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridFinal.Location = new System.Drawing.Point(204, 7);
            this.gridFinal.Name = "gridFinal";
            this.gridFinal.RowHeadersWidth = 50;
            this.gridFinal.Size = new System.Drawing.Size(452, 258);
            this.gridFinal.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(852, 693);
            this.Controls.Add(this.btnMakeGood);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Акмашев, Косенко, гр. 20ВП1, ММП №6 - Метод потенциалов";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridA;
        private System.Windows.Forms.DataGridView gridC;
        private System.Windows.Forms.DataGridView gridB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNordWest;
        private System.Windows.Forms.DataGridView gridSupport;
        private System.Windows.Forms.Label lblCheck1;
        private System.Windows.Forms.Label lblCheck2;
        private System.Windows.Forms.Label lblFirstPay;
        private System.Windows.Forms.Button btnFirstPay;
        private System.Windows.Forms.Button btnStep1;
        private System.Windows.Forms.DataGridView gridFinal;
        private System.Windows.Forms.Button btnStep2;
        private System.Windows.Forms.Button btnMakeGood;
        private System.Windows.Forms.Label lblOptimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatrB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatrA;
    }
}