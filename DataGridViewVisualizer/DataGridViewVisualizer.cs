using System;
using System.Windows.Forms;

namespace MatrixLibrary
{
    public class DataGridViewVisualizer
    {
        protected DataGridView DataGrid;

        public DataGridViewVisualizer(DataGridView dataGrid)
        {
            DataGrid = dataGrid;
        }

        public void Create(int rowCount, int colCount)
        {
            Random rnd = new Random();

            DataGrid.RowCount = rowCount;
            DataGrid.ColumnCount = colCount;

            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    DataGrid.Rows[i].HeaderCell.Value = i.ToString();
                    DataGrid.Columns[j].HeaderCell.Value = j.ToString();
                    DataGrid.Columns[j].Width = 30;
                    DataGrid[j, i].Value = rnd.Next(-100, 100);
                }
        }
        public void CreateTrans(in int[,] arr)
        {
            int[,] arrTrans = new int[arr.GetLength(1), arr.GetLength(0)];
            DataGrid.RowCount = arr.GetLength(1);
            DataGrid.ColumnCount = arr.GetLength(0);

            for (int i = 0; i < arr.GetLength(1); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arrTrans[i, j] = arr[j, i];
                }

            for (int i = 0; i < arrTrans.GetLength(0); i++)
                for (int j = 0; j < arrTrans.GetLength(1); j++)
                {
                    DataGrid.Rows[i].HeaderCell.Value = i.ToString();
                    DataGrid.Columns[j].HeaderCell.Value = j.ToString();
                    DataGrid.Columns[j].Width = 30;
                    DataGrid[j, i].Value = arrTrans[i, j];
                }

        }
        public static void CreateArray(int[,] arr, DataGridView dataGrid)
        {

            for (int i = 0; i < dataGrid.Rows.Count; i++)
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    arr[i, j] = Convert.ToInt32(dataGrid[j, i].Value);
                }
        }
        public static int amountPositiveNum(int[,] arr)
        {
            int amount = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] > 0)
                        amount++;
            return amount;
        }
        public static int MaxFromRepeating(int[,] arr)
        {
            int[] arr_single = new int[arr.GetLength(0) * arr.GetLength(1)]; int index = 0, max = int.MinValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr_single[index] = arr[i, j];
                    index++;
                }
            }
            Array.Sort(arr_single);

            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr_single[i] == arr_single[j] && i != j)
                    {
                        if (arr_single[i] > max) max = arr_single[i];
                    }
                }

            return max;
        }
        public static int AmountOfNonZeroRows(int[,] arr)
        {
            int tmp = 0, amount = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0) tmp++;
                    if (tmp == arr.GetLength(1)) amount++;
                }
                tmp = 0;
            }
            return amount;
        }
        public static int AmountOfZeroColumns(int[,] arr)
        {
            int amount = 0, j_j = -1;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i, j] == 0 && j != j_j) { amount++; j_j = j; }
                }
            }
            return amount;
        }
        public static int LongestStreakRowIndex(int[,] arr)
        {
            int[] streak = new int[arr.GetLength(0)];
            int streakIndex = -1, k = 0, flag = 0, max = int.MinValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j - 1] == arr[i, j]) { streak[k]++; flag = 1; }
                    else if (flag == 0) streak[k] = 1;
                    if (arr[i, j - 1] == arr[i, j] && j == 1) streak[k]++;
                }
                k++;
                flag = 0;
            }
            for (int i = 0; i < streak.Length; i++)
                if (streak[i] >= max && streak[i] != 1) { max = streak[i]; streakIndex = i; }
            return streakIndex;
        }
        public static void MultiplyNoNegativeRows(int[,] arr, DataGridView dataGrid)
        {
            int tmp = 0, index = 0;
            double result = 1;
            dataGrid.RowCount = arr.GetLength(0);
            dataGrid.ColumnCount = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    dataGrid.Rows[i].HeaderCell.Value = i.ToString();
                    dataGrid.Columns[0].HeaderCell.Value = "Результат умножения";
                    dataGrid.Columns[0].Width = 70;
                    if (arr[i, j] >= 0) tmp++;
                    if (tmp == arr.GetLength(1))
                    {
                        for (int j_j = 0; j_j < arr.GetLength(1); j_j++)
                        {
                            result *= arr[i, j_j];
                        }
                        dataGrid[0, index].Value = result;
                        index++;
                    }
                }
                if (tmp != arr.GetLength(1)) { index++; dataGrid[0, index - 1].Value = "-"; }
                result = 1;
                tmp = 0;
            }

        }
        public static void SumNoNegativeColumns(int[,] arr, DataGridView dataGrid)
        {
            int tmp = 0, index = 0, result = 0;
            dataGrid.RowCount = 1;
            dataGrid.ColumnCount = arr.GetLength(1);

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    dataGrid.Rows[0].HeaderCell.Value = "Рузультат";
                    dataGrid.Columns[j].HeaderCell.Value = j.ToString();
                    dataGrid.Columns[j].Width = 30;
                    if (arr[i, j] >= 0) tmp++;
                    if (tmp == arr.GetLength(0))
                    {
                        for (int i_i = 0; i_i < arr.GetLength(0); i_i++)
                        {
                            result += arr[i_i, j];
                        }
                        dataGrid[index, 0].Value = result;
                        index++;
                    }
                }
                if (tmp != arr.GetLength(0)) { index++; dataGrid[index - 1, 0].Value = "-"; }
                result = 0;
                tmp = 0;
            }
        }
        public static int MaxSumDiagonalElements(int[,] arr)
        {
            int maxSum_up = int.MinValue, maxSum_down = int.MinValue, sum_up = 0, sum_down = 0,
                max, step = 1;
            while (step <= arr.GetLength(0) && step <= arr.GetLength(1))
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i + step == j)
                        {
                            sum_up += arr[i, j];
                        }
                    }
                }
                if (sum_up > maxSum_up && sum_up != 0) maxSum_up = sum_up;
                sum_up = 0;


                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i - step == j)
                        {
                            sum_down += arr[i, j];
                        }
                    }
                }
                if (sum_down > maxSum_down && sum_down != 0) maxSum_down = sum_down;
                sum_down = 0;
                step++;
            }
            if (maxSum_down > maxSum_up) max = maxSum_down;
            else max = maxSum_up;
            return max;
        }
        public static void SumNegativeColumns(int[,] arr, DataGridView dataGrid)
        {
            int tmp = 0, index = 0, result = 0;
            dataGrid.RowCount = 1;
            dataGrid.ColumnCount = arr.GetLength(1);

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    dataGrid.Rows[0].HeaderCell.Value = "Рузультат";
                    dataGrid.Columns[j].HeaderCell.Value = j.ToString();
                    dataGrid.Columns[j].Width = 30;
                    if (arr[i, j] < 0) tmp++;
                    if (tmp == 1)
                    {
                        for (int i_i = 0; i_i < arr.GetLength(0); i_i++)
                        {
                            result += arr[i_i, j];
                        }
                        dataGrid[index, 0].Value = result;
                        index++;
                        tmp++;
                    }
                }
                if (tmp <= 0) { index++; dataGrid[index - 1, 0].Value = "-"; }
                result = 0;
                tmp = 0;
            }
        }
        public static int MinSumDiagonalElements(int[,] arr)
        {
            int[,] revertArr = new int[arr.GetLength(0), arr.GetLength(1)];
            int minSum_up = int.MaxValue, minSum_down = int.MaxValue, sum_up = 0, sum_down = 0,
                min, step_a = 0, step = 1;

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    revertArr[i, j] = arr[arr.GetLength(0) - 1 - step_a, j];
                    step_a++;
                }
                step_a = 0;
            }

            while (step <= arr.GetLength(0) && step <= arr.GetLength(1))
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i + step == j)
                        {
                            sum_up += Math.Abs(revertArr[i, j]);
                        }
                    }
                }
                if (sum_up < minSum_up && sum_up != 0) minSum_up = sum_up;
                sum_up = 0;


                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i - step == j)
                        {
                            sum_down += Math.Abs(revertArr[i, j]);
                        }
                    }
                }
                if (sum_down < minSum_down && sum_down != 0) minSum_down = sum_down;
                sum_down = 0;
                step++;
            }
            if (minSum_down < minSum_up) min = minSum_down;
            else min = minSum_up;
            return min;
        }
    }
}