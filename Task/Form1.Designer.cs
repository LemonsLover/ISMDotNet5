namespace Task
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
            this.labelCol = new System.Windows.Forms.Label();
            this.labelRow = new System.Windows.Forms.Label();
            this.numericUpDownCol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelPositive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTrans = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMaxReapited = new System.Windows.Forms.Label();
            this.labelAmontOfNonZeroRows = new System.Windows.Forms.Label();
            this.labelAmountOfZeroCol = new System.Windows.Forms.Label();
            this.labelLongestStreakIndex = new System.Windows.Forms.Label();
            this.dataGridViewMultiplyNoNegative = new System.Windows.Forms.DataGridView();
            this.labelMultiplyNonegative = new System.Windows.Forms.Label();
            this.labelSumInNoNegativeColumns = new System.Windows.Forms.Label();
            this.dataGridViewSumInNoNegativeColumns = new System.Windows.Forms.DataGridView();
            this.labelMaxSumDiagonal_no_use = new System.Windows.Forms.Label();
            this.labelMaxSumDiagonal = new System.Windows.Forms.Label();
            this.dataGridViewSumNegativeColumn = new System.Windows.Forms.DataGridView();
            this.labelSumNegativeColumn = new System.Windows.Forms.Label();
            this.labelMinDiagonalSumModule = new System.Windows.Forms.Label();
            this.labelMinDiagonalSumModule_no_use = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMultiplyNoNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumInNoNegativeColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumNegativeColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCol
            // 
            this.labelCol.AutoSize = true;
            this.labelCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCol.Location = new System.Drawing.Point(41, 17);
            this.labelCol.Name = "labelCol";
            this.labelCol.Size = new System.Drawing.Size(136, 20);
            this.labelCol.TabIndex = 0;
            this.labelCol.Text = "К-во столбцов:";
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRow.Location = new System.Drawing.Point(41, 57);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(104, 20);
            this.labelRow.TabIndex = 1;
            this.labelRow.Text = "К-во строк:";
            // 
            // numericUpDownCol
            // 
            this.numericUpDownCol.Location = new System.Drawing.Point(183, 11);
            this.numericUpDownCol.Name = "numericUpDownCol";
            this.numericUpDownCol.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownCol.TabIndex = 2;
            this.numericUpDownCol.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Location = new System.Drawing.Point(183, 51);
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownRow.TabIndex = 3;
            this.numericUpDownRow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(45, 103);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(258, 62);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Генерировать массив";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(408, 26);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersWidth = 50;
            this.dataGridViewArray.RowTemplate.Height = 28;
            this.dataGridViewArray.Size = new System.Drawing.Size(425, 263);
            this.dataGridViewArray.TabIndex = 5;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolve.Location = new System.Drawing.Point(45, 171);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(258, 40);
            this.buttonSolve.TabIndex = 6;
            this.buttonSolve.Text = "Решить массив";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelPositive
            // 
            this.labelPositive.AutoSize = true;
            this.labelPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositive.Location = new System.Drawing.Point(27, 224);
            this.labelPositive.Name = "labelPositive";
            this.labelPositive.Size = new System.Drawing.Size(294, 20);
            this.labelPositive.TabIndex = 7;
            this.labelPositive.Text = "К-во позитивных элементов: NAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Обычная матрица";
            // 
            // dataGridViewTrans
            // 
            this.dataGridViewTrans.AllowUserToAddRows = false;
            this.dataGridViewTrans.AllowUserToDeleteRows = false;
            this.dataGridViewTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrans.Location = new System.Drawing.Point(408, 315);
            this.dataGridViewTrans.Name = "dataGridViewTrans";
            this.dataGridViewTrans.RowHeadersWidth = 50;
            this.dataGridViewTrans.RowTemplate.Height = 28;
            this.dataGridViewTrans.Size = new System.Drawing.Size(425, 294);
            this.dataGridViewTrans.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Транспонированная матрица";
            // 
            // labelMaxReapited
            // 
            this.labelMaxReapited.AutoSize = true;
            this.labelMaxReapited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxReapited.Location = new System.Drawing.Point(27, 247);
            this.labelMaxReapited.Name = "labelMaxReapited";
            this.labelMaxReapited.Size = new System.Drawing.Size(321, 20);
            this.labelMaxReapited.TabIndex = 11;
            this.labelMaxReapited.Text = "Максимальний повторяющийся: NAN";
            // 
            // labelAmontOfNonZeroRows
            // 
            this.labelAmontOfNonZeroRows.AutoSize = true;
            this.labelAmontOfNonZeroRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmontOfNonZeroRows.Location = new System.Drawing.Point(27, 270);
            this.labelAmontOfNonZeroRows.Name = "labelAmontOfNonZeroRows";
            this.labelAmontOfNonZeroRows.Size = new System.Drawing.Size(233, 20);
            this.labelAmontOfNonZeroRows.TabIndex = 12;
            this.labelAmontOfNonZeroRows.Text = "К-во строк без нулей: NAN";
            // 
            // labelAmountOfZeroCol
            // 
            this.labelAmountOfZeroCol.AutoSize = true;
            this.labelAmountOfZeroCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountOfZeroCol.Location = new System.Drawing.Point(27, 290);
            this.labelAmountOfZeroCol.Name = "labelAmountOfZeroCol";
            this.labelAmountOfZeroCol.Size = new System.Drawing.Size(257, 20);
            this.labelAmountOfZeroCol.TabIndex = 13;
            this.labelAmountOfZeroCol.Text = "К-во столбцов с нулями: NAN";
            // 
            // labelLongestStreakIndex
            // 
            this.labelLongestStreakIndex.AutoSize = true;
            this.labelLongestStreakIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongestStreakIndex.Location = new System.Drawing.Point(27, 310);
            this.labelLongestStreakIndex.Name = "labelLongestStreakIndex";
            this.labelLongestStreakIndex.Size = new System.Drawing.Size(302, 20);
            this.labelLongestStreakIndex.TabIndex = 14;
            this.labelLongestStreakIndex.Text = "Номер строки с серией цифр: NAN";
            // 
            // dataGridViewMultiplyNoNegative
            // 
            this.dataGridViewMultiplyNoNegative.AllowUserToAddRows = false;
            this.dataGridViewMultiplyNoNegative.AllowUserToDeleteRows = false;
            this.dataGridViewMultiplyNoNegative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMultiplyNoNegative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMultiplyNoNegative.Location = new System.Drawing.Point(839, 26);
            this.dataGridViewMultiplyNoNegative.Name = "dataGridViewMultiplyNoNegative";
            this.dataGridViewMultiplyNoNegative.RowHeadersWidth = 50;
            this.dataGridViewMultiplyNoNegative.RowTemplate.Height = 28;
            this.dataGridViewMultiplyNoNegative.Size = new System.Drawing.Size(434, 263);
            this.dataGridViewMultiplyNoNegative.TabIndex = 15;
            // 
            // labelMultiplyNonegative
            // 
            this.labelMultiplyNonegative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMultiplyNonegative.AutoSize = true;
            this.labelMultiplyNonegative.Location = new System.Drawing.Point(835, 3);
            this.labelMultiplyNonegative.Name = "labelMultiplyNonegative";
            this.labelMultiplyNonegative.Size = new System.Drawing.Size(438, 20);
            this.labelMultiplyNonegative.TabIndex = 16;
            this.labelMultiplyNonegative.Text = "Перемножение элементов в строках без отрицательних";
            // 
            // labelSumInNoNegativeColumns
            // 
            this.labelSumInNoNegativeColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSumInNoNegativeColumns.AutoSize = true;
            this.labelSumInNoNegativeColumns.Location = new System.Drawing.Point(835, 292);
            this.labelSumInNoNegativeColumns.Name = "labelSumInNoNegativeColumns";
            this.labelSumInNoNegativeColumns.Size = new System.Drawing.Size(383, 20);
            this.labelSumInNoNegativeColumns.TabIndex = 18;
            this.labelSumInNoNegativeColumns.Text = "Сумма элементов в столбцах без отрицательних";
            // 
            // dataGridViewSumInNoNegativeColumns
            // 
            this.dataGridViewSumInNoNegativeColumns.AllowUserToAddRows = false;
            this.dataGridViewSumInNoNegativeColumns.AllowUserToDeleteRows = false;
            this.dataGridViewSumInNoNegativeColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSumInNoNegativeColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSumInNoNegativeColumns.Location = new System.Drawing.Point(839, 315);
            this.dataGridViewSumInNoNegativeColumns.Name = "dataGridViewSumInNoNegativeColumns";
            this.dataGridViewSumInNoNegativeColumns.RowHeadersWidth = 100;
            this.dataGridViewSumInNoNegativeColumns.RowTemplate.Height = 28;
            this.dataGridViewSumInNoNegativeColumns.Size = new System.Drawing.Size(434, 294);
            this.dataGridViewSumInNoNegativeColumns.TabIndex = 17;
            // 
            // labelMaxSumDiagonal_no_use
            // 
            this.labelMaxSumDiagonal_no_use.AutoSize = true;
            this.labelMaxSumDiagonal_no_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxSumDiagonal_no_use.Location = new System.Drawing.Point(27, 330);
            this.labelMaxSumDiagonal_no_use.Name = "labelMaxSumDiagonal_no_use";
            this.labelMaxSumDiagonal_no_use.Size = new System.Drawing.Size(346, 20);
            this.labelMaxSumDiagonal_no_use.TabIndex = 19;
            this.labelMaxSumDiagonal_no_use.Text = "Большая сумма элементов диагоналей";
            // 
            // labelMaxSumDiagonal
            // 
            this.labelMaxSumDiagonal.AutoSize = true;
            this.labelMaxSumDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxSumDiagonal.Location = new System.Drawing.Point(27, 350);
            this.labelMaxSumDiagonal.Name = "labelMaxSumDiagonal";
            this.labelMaxSumDiagonal.Size = new System.Drawing.Size(239, 20);
            this.labelMaxSumDiagonal.TabIndex = 20;
            this.labelMaxSumDiagonal.Text = "паралельних главной: NAN";
            // 
            // dataGridViewSumNegativeColumn
            // 
            this.dataGridViewSumNegativeColumn.AllowUserToAddRows = false;
            this.dataGridViewSumNegativeColumn.AllowUserToDeleteRows = false;
            this.dataGridViewSumNegativeColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewSumNegativeColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSumNegativeColumn.Location = new System.Drawing.Point(12, 450);
            this.dataGridViewSumNegativeColumn.Name = "dataGridViewSumNegativeColumn";
            this.dataGridViewSumNegativeColumn.RowHeadersWidth = 100;
            this.dataGridViewSumNegativeColumn.RowTemplate.Height = 28;
            this.dataGridViewSumNegativeColumn.Size = new System.Drawing.Size(390, 159);
            this.dataGridViewSumNegativeColumn.TabIndex = 21;
            // 
            // labelSumNegativeColumn
            // 
            this.labelSumNegativeColumn.AutoSize = true;
            this.labelSumNegativeColumn.Location = new System.Drawing.Point(8, 427);
            this.labelSumNegativeColumn.Name = "labelSumNegativeColumn";
            this.labelSumNegativeColumn.Size = new System.Drawing.Size(380, 20);
            this.labelSumNegativeColumn.TabIndex = 22;
            this.labelSumNegativeColumn.Text = "Сумма элементов в столбцах c отрицательными";
            // 
            // labelMinDiagonalSumModule
            // 
            this.labelMinDiagonalSumModule.AutoSize = true;
            this.labelMinDiagonalSumModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinDiagonalSumModule.Location = new System.Drawing.Point(27, 391);
            this.labelMinDiagonalSumModule.Name = "labelMinDiagonalSumModule";
            this.labelMinDiagonalSumModule.Size = new System.Drawing.Size(356, 20);
            this.labelMinDiagonalSumModule.TabIndex = 24;
            this.labelMinDiagonalSumModule.Text = "диагоналей паралельних побочной: NAN";
            // 
            // labelMinDiagonalSumModule_no_use
            // 
            this.labelMinDiagonalSumModule_no_use.AutoSize = true;
            this.labelMinDiagonalSumModule_no_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinDiagonalSumModule_no_use.Location = new System.Drawing.Point(27, 371);
            this.labelMinDiagonalSumModule_no_use.Name = "labelMinDiagonalSumModule_no_use";
            this.labelMinDiagonalSumModule_no_use.Size = new System.Drawing.Size(311, 20);
            this.labelMinDiagonalSumModule_no_use.TabIndex = 23;
            this.labelMinDiagonalSumModule_no_use.Text = "Меньший модуль суммы элементов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 614);
            this.Controls.Add(this.labelMinDiagonalSumModule);
            this.Controls.Add(this.labelMinDiagonalSumModule_no_use);
            this.Controls.Add(this.labelSumNegativeColumn);
            this.Controls.Add(this.dataGridViewSumNegativeColumn);
            this.Controls.Add(this.labelMaxSumDiagonal);
            this.Controls.Add(this.labelMaxSumDiagonal_no_use);
            this.Controls.Add(this.labelSumInNoNegativeColumns);
            this.Controls.Add(this.dataGridViewSumInNoNegativeColumns);
            this.Controls.Add(this.labelMultiplyNonegative);
            this.Controls.Add(this.dataGridViewMultiplyNoNegative);
            this.Controls.Add(this.labelLongestStreakIndex);
            this.Controls.Add(this.labelAmountOfZeroCol);
            this.Controls.Add(this.labelAmontOfNonZeroRows);
            this.Controls.Add(this.labelMaxReapited);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPositive);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.numericUpDownRow);
            this.Controls.Add(this.numericUpDownCol);
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.labelCol);
            this.MinimumSize = new System.Drawing.Size(1350, 670);
            this.Name = "Form1";
            this.Text = "ISMDotNet5 by Yehor Ovseukov";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMultiplyNoNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumInNoNegativeColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumNegativeColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCol;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.NumericUpDown numericUpDownCol;
        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelPositive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMaxReapited;
        private System.Windows.Forms.Label labelAmontOfNonZeroRows;
        private System.Windows.Forms.Label labelAmountOfZeroCol;
        private System.Windows.Forms.Label labelLongestStreakIndex;
        private System.Windows.Forms.DataGridView dataGridViewMultiplyNoNegative;
        private System.Windows.Forms.Label labelMultiplyNonegative;
        private System.Windows.Forms.Label labelSumInNoNegativeColumns;
        private System.Windows.Forms.DataGridView dataGridViewSumInNoNegativeColumns;
        private System.Windows.Forms.Label labelMaxSumDiagonal_no_use;
        private System.Windows.Forms.Label labelMaxSumDiagonal;
        private System.Windows.Forms.DataGridView dataGridViewSumNegativeColumn;
        private System.Windows.Forms.Label labelSumNegativeColumn;
        private System.Windows.Forms.Label labelMinDiagonalSumModule;
        private System.Windows.Forms.Label labelMinDiagonalSumModule_no_use;
    }
}

