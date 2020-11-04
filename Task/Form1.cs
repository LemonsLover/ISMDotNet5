using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixLibrary;

namespace Task
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int colCount = Convert.ToInt32(numericUpDownCol.Value);
            int rowCount = Convert.ToInt32(numericUpDownRow.Value);
            DataGridViewVisualizer dataGridViewVisualizer = new DataGridViewVisualizer(dataGridViewArray);
            dataGridViewVisualizer.Create(rowCount, colCount);
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            
            int[,] arr = new int[dataGridViewArray.Rows.Count, dataGridViewArray.Columns.Count]; 
            DataGridViewVisualizer.CreateArray(arr, dataGridViewArray);
            DataGridViewVisualizer dataGridViewVisualizer = new DataGridViewVisualizer(dataGridViewTrans);
            dataGridViewVisualizer.CreateTrans(arr);
            DataGridViewVisualizer.CreateArray(arr, dataGridViewArray);
            labelPositive.Text = "К-во позитивных элементов: " + DataGridViewVisualizer.amountPositiveNum(arr).ToString();
            if (DataGridViewVisualizer.MaxFromRepeating(arr) != int.MinValue)
                labelMaxReapited.Text = "Максимальний повторяющийся: " + DataGridViewVisualizer.MaxFromRepeating(arr).ToString();
            else labelMaxReapited.Text = "Максимальний повторяющийся: NAN";
            labelAmontOfNonZeroRows.Text = "К-во строк без нулей: " + DataGridViewVisualizer.AmountOfNonZeroRows(arr).ToString();
            labelAmountOfZeroCol.Text = "К-во столбцов с нулями: " + DataGridViewVisualizer.AmountOfZeroColumns(arr).ToString();
            if (DataGridViewVisualizer.LongestStreakRowIndex(arr) != -1)
                labelLongestStreakIndex.Text = "Номер строки с серией цифр: "
                    + DataGridViewVisualizer.LongestStreakRowIndex(arr).ToString();
            else labelLongestStreakIndex.Text = "Номер строки с серией цифр: NAN";
            DataGridViewVisualizer.MultiplyNoNegativeRows(arr, dataGridViewMultiplyNoNegative);
            DataGridViewVisualizer.SumNoNegativeColumns(arr, dataGridViewSumInNoNegativeColumns);
            labelMaxSumDiagonal.Text = "паралельних главной: " + DataGridViewVisualizer.MaxSumDiagonalElements(arr);
            DataGridViewVisualizer.SumNegativeColumns(arr, dataGridViewSumNegativeColumn);
            labelMinDiagonalSumModule.Text = "диагоналей паралельних побочной: " + DataGridViewVisualizer.MinSumDiagonalElements(arr);
        }
    }
}


