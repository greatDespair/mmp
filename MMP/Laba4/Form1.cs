using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        private bool error = false;
        List<List<decimal>> _simpTable = new List<List<decimal>>();
        Dictionary<int, decimal> dLine = new Dictionary<int, decimal>();
        private List<int> basis = new List<int> { 4, 5, 6 };
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        #region Двойственный симплекс метод
        private void SolveByDoubleSimplex()
        {
            // STEP 2

            if (!CanSolveDoubleSimplex())
            {
                error = true;
                return;
            }

            // STEP 3

            int basisLine = GetMinIndex();

            // STEP 4

            dLine.Clear();

            for (int i = 0; i < _simpTable[basisLine].Count - 1; i++)
            {
                if (_simpTable[basisLine][i] < 0)
                {
                    dLine[i] = Math.Abs(_simpTable[_simpTable.Count - 1][i] /
                        _simpTable[basisLine][i]);
                }
            }

            int basisColumn = GetMinIndexD();

            List<List<decimal>> _simpTableCopy = new List<List<decimal>>();
            foreach (var item in _simpTable)
            {
                _simpTableCopy.Add(new List<decimal>(item));
            }
            // а) Вычисления для разрещающей строки

            for (int j = 0; j < _simpTable[basisLine].Count; j++)
            {
                _simpTable[basisLine][j] = _simpTableCopy[basisLine][j] / _simpTableCopy[basisLine][basisColumn];
            }

            // б) Вычисления для всех остальных строк

            for (int i = 0; i < _simpTable.Count; i++)
            {
                if (i != basisLine)
                {
                    for (int j = 0; j < _simpTable[i].Count; j++)
                    {
                        _simpTable[i][j] = _simpTableCopy[i][j] + _simpTable[basisLine][j] * (-_simpTableCopy[i][basisColumn]);
                    }
                }
            }

            ArraysToString();

        }

        private int GetMinIndexD()
        {
            var minValue = dLine.Values.Min();
            return dLine.First(elem => elem.Value == minValue).Key;
        }
        private int GetMinIndex()
        {
            decimal minValue = _simpTable[0][_simpTable[0].Count - 1];
            int index = 0;
            for (int i = 0; i < _simpTable.Count; i++)
            {
                if (minValue > _simpTable[i][_simpTable[i].Count - 1])
                {
                    minValue = _simpTable[i][_simpTable[i].Count - 1];
                    index = i;
                }
            }
            return index;
        }
        private bool CanSolveDoubleSimplex()
        {
            for (int i = 0; i < _simpTable.Count; i++)
            {
                if (_simpTable[i][_simpTable[i].Count - 1] < 0)
                {
                    if (_simpTable[i].Where(elem => elem < 0).Count() > 1)
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }
        #endregion

        #region Симплекс метод
        private void SolveBySimplex()
        {
            int k = 10;
            while (true)
            {
                if (k == 0)
                    break;
                k--;
                // STEP 1
                if (!CanOptimize())
                {
                    break;
                }

                // STEP 2

                int basisColumn = ChooseBasisColumn();

                // STEP 3

                if (!CheckUnlimTargetFunction(basisColumn))
                {
                    break;
                }

                // STEP 4

                decimal[] simplexLinks = new decimal[_simpTable.Count - 1];

                for (int i = 0; i < _simpTable.Count - 1; i++)
                {
                    if (_simpTable[i][basisColumn] > 0)
                        simplexLinks[i] = _simpTable[i][_simpTable[i].Count - 1] / _simpTable[i][basisColumn];
                    else
                        simplexLinks[i] = -1;
                }

                // STEP 5

                int basisLine = ChooseBasisLine(simplexLinks);

                // STEP 6

                basis[basisLine] = basisColumn + 1;

                // STEP 7

                List<List<decimal>> _simpTableCopy = new List<List<decimal>>();
                foreach(var item in _simpTable)
                {
                    _simpTableCopy.Add(new List<decimal>(item));
                }

                // а) Вычисления для разрещающей строки

                for (int j = 0; j < _simpTable[basisLine].Count; j++)
                {
                    _simpTable[basisLine][j] = _simpTableCopy[basisLine][j] / _simpTableCopy[basisLine][basisColumn];
                }

                // б) Вычисления для всех остальных строк

                for (int i = 0; i < _simpTable.Count; i++)
                {
                    if (i != basisLine)
                    {
                        for (int j = 0; j < _simpTable[i].Count; j++)
                        {
                            _simpTable[i][j] = _simpTableCopy[i][j] + _simpTable[basisLine][j] * (-_simpTableCopy[i][basisColumn]);
                        }
                    }
                }

                ArraysToString();
            }
        }
        private int ChooseBasisColumn()
        {
            decimal minValue = 0;
            int position = 0;
            for (int i = 0; i < _simpTable[_simpTable.Count - 1].Count; i++)
            {
                if (_simpTable[_simpTable.Count - 1][i] < minValue)
                {
                    minValue = _simpTable[_simpTable.Count - 1][i];
                    position = i;
                }
            }
            return position;
        }

        private int ChooseBasisLine(decimal[] simplexLinks)
        {
            int position = 0;
            decimal minValue = decimal.MaxValue;
            for (int i = 0; i < simplexLinks.Length; i++)
            {
                if (simplexLinks[i] == -1)
                    continue;

                if (simplexLinks[i] < minValue)
                {
                    minValue = simplexLinks[i];
                    position = i;
                }
            }
            return position;
        }

        private bool CanOptimize()
        {
            for (int i = 0; i < _simpTable[_simpTable.Count - 1].Count; i++)
            {
                if (Math.Round(_simpTable[_simpTable.Count - 1][i], 7) < 0)
                    return true;
            }
            return false;
        }

        private bool CheckUnlimTargetFunction(int basis)
        {
            int negativeCounter = 0;
            for (int i = 0; i < _simpTable.Count - 1; i++)
            {
                if (_simpTable[i][basis] <= 0)
                    negativeCounter++;
            }
            if (negativeCounter < 3)
                return true;
            error = true;
            return false;
        }
        #endregion

        // Оптимизировать согласно введенным данным
        private void OptimizeButton_Click(object sender, EventArgs e)
        {
            error = false;
            OutputList.Items.Clear();

            _simpTable = new List<List<decimal>>();

            //_simpTable.Add(new List<decimal> { factor11.Value, factor12.Value, factor13.Value, 1, 0, 0, limit1.Value });
            //_simpTable.Add(new List<decimal> { factor21.Value, factor22.Value, factor23.Value, 0, 1, 0, limit2.Value });
            //_simpTable.Add(new List<decimal> { factor31.Value, factor32.Value, factor33.Value, 0, 0, 1, limit3.Value });
            //_simpTable.Add(new List<decimal> { - factor41.Value, - factor42.Value, - factor43.Value, 0, 0, 0, 0 });


            _simpTable.Add(new List<decimal> { 2, 3, 5, 1, 0, 0, 4 });
            _simpTable.Add(new List<decimal> { 8, 4, 0, 0, 1, 0, 8 });
            _simpTable.Add(new List<decimal> { 3, 4, 4, 0, 0, 1, 3 });
            _simpTable.Add(new List<decimal> { 3, 2, -10, 0, 0, 0, 0 });

            basis = new List<int> { 4, 5, 6 };

            GomorySolve();

            Interpretation();
        }
        #region Метод Гомори
        private void GomorySolve()
        {

            ArraysToString();

            while (true)
            {
                while (true)
                {
                    bool isDoubleSimplex = false;

                    for (int i = 0; i < _simpTable.Count - 1; i++)
                    {
                        if (_simpTable[i][_simpTable[i].Count - 1] < 0)
                        {
                            isDoubleSimplex = true;
                        }
                    }

                    if (isDoubleSimplex)
                        SolveByDoubleSimplex();
                    else
                    {
                        SolveBySimplex();
                        break;
                    }
                }

                if (error)
                {
                    OutputError();
                    return;
                }

                // STEP 2 Проверка целочисленности

                if (CheckIntegrality())
                    return;

                // STEP 3

                int indexOfComponent = GetIndexByMaxFractionalPart();

                if (CheckValuesIntegrality(indexOfComponent))
                {
                    return;
                }

                //STEP 4

                ExpandMatrix(indexOfComponent);
                ArraysToString();
            }
        }

        private void ExpandMatrix(int index)
        {
            int countX = _simpTable.Count + basis.Count;

            basis.Add(countX);

            List<decimal> newRow = new List<decimal>();
            foreach (var item in _simpTable[index])
            {
                newRow.Add(-GetFractionalPart(item));
            }
            decimal lastElem = newRow[newRow.Count - 1];
            newRow[newRow.Count - 1] = 1;
            newRow.Add(lastElem);

            foreach (var oldRow in _simpTable)
            {
                decimal lastElemList = oldRow[oldRow.Count - 1];
                oldRow[oldRow.Count - 1] = 0;
                oldRow.Add(lastElemList);
            }

            List<decimal> oldRowZ = new List<decimal>(_simpTable[_simpTable.Count - 1]);
            _simpTable.RemoveAt(_simpTable.Count - 1);
            _simpTable.Add(newRow);
            _simpTable.Add(oldRowZ);


        }

        private int GetIndexByMaxFractionalPart()
        {
            int index = 0;
            decimal maxFractionalPart = 0;
            for (int i = 0; i < _simpTable.Count - 1; i++)
            {
                var fractionalPart = GetFractionalPart(_simpTable[i][_simpTable[i].Count - 1]);
                if (fractionalPart != 0)
                {
                    if(fractionalPart > maxFractionalPart)
                    {
                        index = i;
                        maxFractionalPart = fractionalPart;
                    }
                }
            }
            return index;
        }

        private bool CheckValuesIntegrality(int index)
        {
            for(int i = 0; i < _simpTable[index].Count - 1; i++)
            {
                if (GetFractionalPart(_simpTable[index][i]) != 0)
                    return false;
            }
            return true;
        }

        private bool CheckIntegrality()
        {
            for(int i = 0; i < _simpTable.Count; i++)
            {
                if (GetFractionalPart(_simpTable[i][_simpTable[i].Count - 1]) != 0)
                    return false;
            }
            return true;
        }

        private decimal GetFractionalPart(decimal value)
        {
            value = Math.Abs(value);
            return Math.Round(value - Math.Truncate(value), 7);
        }

        #endregion

        // Оптимизировать согласно варианту
        private void ConstOptimizeButton_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();

            _simpTable = new List<List<decimal>>();
            _simpTable.Add(new List<decimal> { 3, 2, 1, 1, 0, 0, 10 });
            _simpTable.Add(new List<decimal> { 1, 4, 1, 0, 1, 0, 11 });
            _simpTable.Add( new List<decimal> { 3, 3, 1, 0, 0, 1, 13 });
            _simpTable.Add( new List<decimal> { -4, -5, -1, 0, 0, 0, 0 });

            basis = new List<int> { 4, 5, 6 };

            GomorySolve();

            Interpretation();
        }

        // Вывод симплексной таблицы
        private void ArraysToString()
        {
            string titlesline = "xk(i)";
            for(int i = 0; i < _simpTable[0].Count - 1; i++)
            {
                titlesline += "\tx" + (i + 1);
            }
            titlesline += "\tb";
            OutputList.Items.Add(titlesline);

            for(int k = 0; k < basis.Count; k++)
            {
                string xLine = "x" + basis[k] + "\t";
                for(int i = 0; i < _simpTable[k].Count; i++)
                {
                    xLine += Math.Round(_simpTable[k][i], 4) + "\t";
                }
                OutputList.Items.Add(xLine);
            }
            string lineFunc = "Z\t";
            for (int i = 0; i < _simpTable[_simpTable.Count - 1].Count; i++)
            {
                lineFunc += Math.Round(_simpTable[_simpTable.Count - 1][i], 4) + "\t";
            }
            OutputList.Items.Add(lineFunc);
            OutputList.Items.Add("+----------------------------------------------------------------------------------------------------------------------+");
        }

        // Вывод интерпертации результатов
        private void Interpretation()
        {
            OutputList.Items.Add("Интерпретация результатов:");
            for (int i = 1; i < _simpTable.Count - 1; i++)
            {
                if (basis.Contains(i))
                {
                    int pos = 0;
                    for (int j = 0; j < basis.Count; j++)
                    {
                        if (basis[j] == i)
                            pos = j;
                    }

                    OutputList.Items.Add("Объем продукции П" + i + " должен составлять " +
                        _simpTable[pos][_simpTable[pos].Count - 1] + " ед. за исследуемый временной период");
                }
                else
                {
                    OutputList.Items.Add("Объем продукции П" + i + " должен составлять " +
                        0 + " ед. за исследуемый временной период");
                }
            }

            OutputList.Items.Add("Доход от реализации продукции составит " + _simpTable[_simpTable.Count - 1][_simpTable[_simpTable.Count - 1].Count - 1] +
                " ден. ед. за исследуемый временной период");

            OutputList.Items.Add("+----------------------------------------------------------------------------------------------------------------------+");
        }
        private bool CheckErrorInterpretation()
        {
            if (_simpTable[3][7] < 0)
                return false;
            for (int i = 0; i < _simpTable.Count - 1; i++)
            {
                if (_simpTable[i][7] <= 0)
                    return false;
            }
            return true;
        }
        private void OutputError()
        {
            OutputList.Items.Add("Интерпретация результатов:");
            OutputList.Items.Add("В рамках текущей задачи оптимального решения не существует.");
        }

        private void RandomData_Click(object sender, EventArgs e)
        {
            Random rX = new Random();
            factor11.Value = rX.Next(-10, 10);
            factor12.Value = rX.Next(-10, 10);
            factor13.Value = rX.Next(-10, 10);
            factor21.Value = rX.Next(-10, 10);
            factor22.Value = rX.Next(-10, 10);
            factor23.Value = rX.Next(-10, 10);
            factor31.Value = rX.Next(-10, 10);
            factor32.Value = rX.Next(-10, 10);
            factor33.Value = rX.Next(-10, 10);
            factor41.Value = rX.Next(-10, 10);
            factor42.Value = rX.Next(-10, 10);
            factor43.Value = rX.Next(-10, 10);
            limit1.Value = rX.Next(-10, 10);
            limit2.Value = rX.Next(-10, 10);
        }
    }
}
