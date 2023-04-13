using System;
using System.Linq;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        private bool error = false;
        private decimal[][] _mLineTable;
        private decimal[][] _simpTable;
        private int[] basis = new int[2] { 5, 6 };
        private int[] mBasis = new int[2] { 3, 4 };
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        private void ArtificialBasisSolve()
        {
            while (true)
            {
                // STEP 1
                if (!CanOptimize(true))
                {
                    break;
                }

                // STEP 2

                int basisColumn = ChooseBasisColumn(true);

                // STEP 3

                if (!CheckUnlimTargetFunction(basisColumn, true))
                {
                    break;
                }

                // STEP 4

                decimal[] simplexLinks = new decimal[2];

                for (int i = 0; i < 2; i++)
                {
                    if (_simpTable[i][basisColumn] > 0)
                        simplexLinks[i] = _simpTable[i][_simpTable[i].Length - 1] / _simpTable[i][basisColumn];
                    else
                        simplexLinks[i] = -1;
                }

                // STEP 5

                int basisLine = ChooseBasisLine(simplexLinks);

                // STEP 6

                basis[basisLine] = basisColumn + 1;

                // STEP 7

                decimal[][] _simpTableCopy = new decimal[4][];
                for (int i = 0; i < 4; i++)
                {
                    _simpTableCopy[i] = new decimal[_simpTable[i].Length];
                    Array.Copy(_simpTable[i], _simpTableCopy[i], _simpTable[i].Length);
                }

                // а) Вычисления для разрещающей строки

                for (int j = 0; j < _simpTable[basisLine].Length; j++)
                {
                    _simpTable[basisLine][j] = _simpTableCopy[basisLine][j] / _simpTableCopy[basisLine][basisColumn];
                }

                // б) Вычисления для всех остальных строк

                for (int i = 0; i < _simpTable.Length; i++)
                {
                    if (i != basisLine)
                    {
                        for (int j = 0; j < _simpTable[i].Length; j++)
                        {
                            _simpTable[i][j] = _simpTableCopy[i][j] + _simpTable[basisLine][j] * (-_simpTableCopy[i][basisColumn]);
                        }
                    }
                }

                ArraysToString(true);
            }
        }
        private void Solve()
        {
            while (true)
            {
                // STEP 1
                if (!CanOptimize(false))
                {
                    break;
                }

                // STEP 2

                int basisColumn = ChooseBasisColumn(false);

                // STEP 3

                if (!CheckUnlimTargetFunction(basisColumn, false))
                {
                    break;
                }

                // STEP 4

                decimal[] simplexLinks = new decimal[2];

                for (int i = 0; i < 2; i++)
                {
                    if (_mLineTable[i][basisColumn] > 0)
                        simplexLinks[i] = _mLineTable[i][_mLineTable[i].Length - 1] / _mLineTable[i][basisColumn];
                    else
                        simplexLinks[i] = -1;
                }

                // STEP 5

                int basisLine = ChooseBasisLine(simplexLinks);

                // STEP 6

                basis[basisLine] = basisColumn + 1;

                // STEP 7

                decimal[][] _simpTableCopy = new decimal[3][];
                for (int i = 0; i < _simpTableCopy.Length; i++)
                {
                    _simpTableCopy[i] = new decimal[_mLineTable[i].Length];
                    Array.Copy(_mLineTable[i], _simpTableCopy[i], _mLineTable[i].Length);
                }

                // а) Вычисления для разрещающей строки

                for (int j = 0; j < _mLineTable[basisLine].Length; j++)
                {
                    _mLineTable[basisLine][j] = _simpTableCopy[basisLine][j] / _simpTableCopy[basisLine][basisColumn];
                }

                // б) Вычисления для всех остальных строк

                for (int i = 0; i < _mLineTable.Length; i++)
                {
                    if (i != basisLine)
                    {
                        for (int j = 0; j < _mLineTable[i].Length; j++)
                        {
                            _mLineTable[i][j] = _simpTableCopy[i][j] + _mLineTable[basisLine][j] * (-_simpTableCopy[i][basisColumn]);
                        }
                    }
                }

                ArraysToString(false);
            }
        }
        private int ChooseBasisColumn(bool mLine)
        {
            if (mLine)
            {
                decimal minValue = 0;
                int position = 0;
                for (int i = 0; i < _simpTable[3].Length - 1; i++)
                {
                    if (_simpTable[3][i] < minValue)
                    {
                        minValue = _simpTable[3][i];
                        position = i;
                    }
                }
                return position;
            }
            else
            {
                decimal minValue = 0;
                int position = 0;
                for (int i = 0; i < _mLineTable[2].Length - 1; i++)
                {
                    if (_mLineTable[2][i] < minValue)
                    {
                        minValue = _mLineTable[2][i];
                        position = i;
                    }
                }
                return position;
            }
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

        private bool CanOptimize(bool mLine)
        {
            if (mLine)
            {
                for (int i = 0; i < _simpTable[3].Length; i++)
                {
                    if (Math.Round(_simpTable[3][i], 7) < 0)
                        return true;
                }
                return false;
            }
            else
            {
                for (int i = 0; i < _mLineTable[2].Length; i++)
                {
                    if (Math.Round(_mLineTable[2][i], 7) < 0)
                        return true;
                }
                return false;
            }
        }

        private bool CheckUnlimTargetFunction(int basis, bool mLine)
        {
            if (mLine)
            {
                int negativeCounter = 0;
                for (int i = 0; i < _simpTable.Length - 2; i++)
                {
                    if (_simpTable[i][basis] <= 0)
                        negativeCounter++;
                }
                if (negativeCounter < 2)
                    return true;
                error = true;
                return false;
            }
            else
            {
                int negativeCounter = 0;
                for (int i = 0; i < _mLineTable.Length - 2; i++)
                {
                    if (_mLineTable[i][basis] <= 0)
                        negativeCounter++;
                }
                if (negativeCounter < 2)
                    return true;
                error = true;
                return false;
            }
        }

        // Оптимизировать согласно введенным данным
        private void OptimizeButton_Click(object sender, EventArgs e)
        {
            error = false;
            OutputList.Items.Clear();

            basis = new int[2] { 5, 6 };

            _simpTable = new decimal[4][];

            _simpTable[0] = new decimal[] { factor11.Value, factor12.Value, factor13.Value, factor14.Value, 1, 0, limit1.Value };
            _simpTable[1] = new decimal[] { factor21.Value, factor22.Value, factor23.Value, factor24.Value, 0, 1, limit2.Value };
            _simpTable[2] = new decimal[] { -factor41.Value, -factor42.Value, -factor43.Value, -factor44.Value, 0, 0, limit4.Value };
            _simpTable[3] = new decimal[] { 
                -_simpTable[0][0] - _simpTable[1][0],
                -_simpTable[0][1] - _simpTable[1][1],
                -_simpTable[0][2] - _simpTable[1][2],
                -_simpTable[0][2] - _simpTable[1][3],
                -_simpTable[0][2] - _simpTable[1][4],
                -_simpTable[0][2] - _simpTable[1][5],
                -_simpTable[0][2] - _simpTable[1][6],
            };


            ArraysToString(true);
            ArtificialBasisSolve();

            if (error)
            {
                OutputError();
                return;
            }

            _mLineTable = new decimal[3][];
            _mLineTable[0] = new decimal[7];
            _mLineTable[1] = new decimal[7];
            _mLineTable[2] = new decimal[7];

            for (int i = 0; i < _simpTable.Length - 1; i++)
            {
                for (int j = 0; j < _simpTable[i].Length; j++)
                {
                    _mLineTable[i][j] = _simpTable[i][j];
                }
            }

            ArraysToString(false);
            Solve();

            if (error)
            {
                OutputError();
                return;
            }

            Interpretation();
        }

        // Оптимизировать по образцу
        private void ConstOptimizeButton_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();

            basis = new int[2] { 5, 6 };

            _simpTable = new decimal[4][];
            _simpTable[0] = new decimal[] { 1, 3, 2, 2, 1, 0, 3 };
            _simpTable[1] = new decimal[] { 2, 2, 1, 1, 0, 1, 3 };
            _simpTable[2] = new decimal[] { -5, -3, -4, 1, 0, 0, 0 };
            _simpTable[3] = new decimal[] { -3, -5, -3, -3, 0, 0, -6 };
            
            _mLineTable = new decimal[3][];
            _mLineTable[0] = new decimal[7];
            _mLineTable[1] = new decimal[7];
            _mLineTable[2] = new decimal[7];

            ArraysToString(true);
            ArtificialBasisSolve();

            if (error)
            {
                OutputError();
                return;
            }


            for (int i = 0; i < _simpTable.Length - 1; i++)
            {
                for(int j = 0; j < _simpTable[i].Length; j++)
                {
                    _mLineTable[i][j] = _simpTable[i][j];
                }
            }

            ArraysToString(false);
            Solve();

            if (error)
            {
                OutputError();
                return;
            }


            Interpretation();
        }

        // Вывод симплексной таблицы
        private void ArraysToString(bool mLine)
        {
            if (mLine)
            {
                string titlesline = "xk(i)\tx1\tx2\tx3\tx4\ty1\ty2\tb";
                string lineOne = "x" + basis[0] + "\t";
                if (basis[0] > 4)
                {
                    lineOne = "y" + (basis[0] - 4) + "\t";
                }
                string lineTwo = "x" + basis[1] + "\t";
                if (basis[1] > 4)
                {
                    lineTwo = "y" + (basis[1] - 4) + "\t";
                }
                string lineM = "Z\t";
                string lineFunc = "Zm\t";
                for (int i = 0; i < _simpTable[0].Length; i++)
                {
                    lineOne += Math.Round(_simpTable[0][i], 4) + "\t";
                    lineTwo += Math.Round(_simpTable[1][i], 4) + "\t";
                    lineM += Math.Round(_simpTable[2][i], 4) + "\t";
                    lineFunc += Math.Round(_simpTable[3][i], 4) + "\t";
                }

                OutputList.Items.Add(titlesline);
                OutputList.Items.Add(lineOne);
                OutputList.Items.Add(lineTwo);
                OutputList.Items.Add(lineM);
                OutputList.Items.Add(lineFunc);
                OutputList.Items.Add("+----------------------------------------------------------------------------------------------------------------------+");
            }
            else
            {
                string titlesline = "xk(i)\tx1\tx2\tx3\tx4\ty1\ty2\tb";
                string lineOne = "x" + basis[0] + "\t";
                if (basis[0] > 4)
                {
                    lineOne = "y" + (basis[0] - 4) + "\t";
                }
                string lineTwo = "x" + basis[1] + "\t";
                if (basis[1] > 4)
                {
                    lineTwo = "y" + (basis[1] - 4) + "\t";
                }
                string lineFunc = "Z\t";
                for (int i = 0; i < _mLineTable[0].Length; i++)
                {
                    lineOne += Math.Round(_mLineTable[0][i], 4) + "\t";
                    lineTwo += Math.Round(_mLineTable[1][i], 4) + "\t";
                    lineFunc += Math.Round(_mLineTable[2][i], 4) + "\t";
                }

                OutputList.Items.Add(titlesline);
                OutputList.Items.Add(lineOne);
                OutputList.Items.Add(lineTwo);
                OutputList.Items.Add(lineFunc);
                OutputList.Items.Add("+----------------------------------------------------------------------------------------------------------------------+");
            }

            
        }

        // Вывод интерпертации результатов
        private void Interpretation()
        {
            OutputList.Items.Add("Интерпретация результатов:");
            for (int i = 1; i < 5; i++)
            {
                if (basis.Contains(i))
                {
                    int pos = 0;
                    for (int j = 0; j < basis.Length; j++)
                    {
                        if (basis[j] == i)
                            pos = j;
                    }

                    OutputList.Items.Add("Объем продукции П" + i + " должен составлять " +
                        Math.Round(_mLineTable[pos][_mLineTable[pos].Length - 1], 3) + " ед. за исследуемый временной период");
                }
                else
                {
                    OutputList.Items.Add("Объем продукции П" + i + " должен составлять " +
                        0 + " ед. за исследуемый временной период");
                }
            }

            OutputList.Items.Add("Доход от реализации продукции составит " + Math.Round(_mLineTable[2][_mLineTable[2].Length - 1], 0) +
                " ден. ед. за исследуемый временной период");

            OutputList.Items.Add("+----------------------------------------------------------------------------------------------------------------------+");
        }
        private bool CheckErrorInterpretation()
        {
            if (_simpTable[3][7] < 0)
                return false;
            for (int i = 0; i < _simpTable.Length - 1; i++)
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
            factor14.Value = rX.Next(-10, 10);
            factor21.Value = rX.Next(-10, 10);
            factor22.Value = rX.Next(-10, 10);
            factor23.Value = rX.Next(-10, 10);
            factor24.Value = rX.Next(-10, 10);
            factor41.Value = rX.Next(-10, 10);
            factor42.Value = rX.Next(-10, 10);
            factor43.Value = rX.Next(-10, 10);
            factor44.Value = rX.Next(-10, 10);
            limit1.Value = rX.Next(1, 10);
            limit2.Value = rX.Next(1, 10);
            limit4.Value = rX.Next(1, 10);
        }
    }
}
