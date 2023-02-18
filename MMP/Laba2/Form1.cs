using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {

        private decimal[][] _simpTable;
        private int[] basis = new int[3] { 5, 6, 7 };
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Solve()
        {
            while (true)
            {
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

                decimal[] simplexLinks = new decimal[3];

                for (int i = 0; i < 3; i++)
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
                for(int i = 0; i < 4; i++)
                {
                    _simpTableCopy[i] = new decimal[_simpTable[i].Length];
                    Array.Copy(_simpTable[i], _simpTableCopy[i], _simpTable[i].Length);
                }

                // а) Вычисления для разрещающей строки

                for(int j = 0; j < _simpTable[basisLine].Length; j++)
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

                ArraysToString();
            }
        }
        private int ChooseBasisColumn()
        {
            decimal minValue = 0;
            int position = 0;
            for (int i = 0; i < _simpTable[3].Length; i++)
            {
                if (_simpTable[3][i] < minValue)
                {
                    minValue = _simpTable[3][i];
                    position = i;
                }
            }
            return position;
        }

        private int ChooseBasisLine(decimal[] simplexLinks)
        {
            int position = 0;
            decimal minValue = decimal.MaxValue;
            for(int i = 0; i < simplexLinks.Length; i++)
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
            for(int i = 0; i < _simpTable[3].Length; i++)
            {
                if(Math.Round(_simpTable[3][i], 7) < 0)
                    return true;
            }
            return false;
        }

        private bool CheckUnlimTargetFunction(int basis)
        {
            int negativeCounter = 0;
            for( int i = 0; i < _simpTable.Length - 1; i++)
            {
                if(_simpTable[i][basis] <= 0)
                    negativeCounter++;
            }
            if (negativeCounter < 3)
                return true;
            return false;
        }

        // Оптимизировать согласно введенным данным
        private void OptimizeButton_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();

            _simpTable = new decimal[4][];

            _simpTable[0] = new decimal[] { factor11.Value, factor12.Value, factor13.Value, factor14.Value, 1, 0, 0, limit1.Value };
            _simpTable[1] = new decimal[] { factor21.Value, factor22.Value, factor23.Value, factor24.Value, 0, 1, 0, limit2.Value };
            _simpTable[2] = new decimal[] { factor31.Value, factor32.Value, factor33.Value, factor34.Value, 0, 0, 1, limit3.Value };
            _simpTable[3] = new decimal[] { factor41.Value, factor42.Value, factor43.Value, factor44.Value, 0, 0, 0, limit4.Value };

            basis = new int[3] { 5, 6, 7 };

            ArraysToString();
            Solve();
            Interpretation();
        }

        // Оптимизировать согласно варианту
        private void ConstOptimizeButton_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();

            _simpTable = new decimal[4][];

            _simpTable[0] = new decimal[] { 1, 2, 4, 8, 1, 0, 0, 24 };
            _simpTable[1] = new decimal[] { 3, 5, 1, 0, 0, 1, 0, 12 };
            _simpTable[2] = new decimal[] { 6, 0, 3, 1, 0, 0, 1, 35 };
            _simpTable[3] = new decimal[] { -4, -2, -5, -8, 0, 0, 0, 0 };

            basis = new int[3] { 5, 6, 7 };

            ArraysToString();
            Solve();
            Interpretation();
        }

        // Вывод симплексной таблицы
        private void ArraysToString()
        {
            string titlesline = "xk(i)\tx1\tx2\tx3\tx4\tx5\tx6\tx7\tb";
            string lineOne = "x" + basis[0] + "\t";
            string lineTwo = "x" + basis[1] + "\t";
            string lineThree = "x" + basis[2] + "\t";
            string lineFunc = "Z\t";
            for(int i = 0; i < _simpTable[0].Length; i++)
            {
                lineOne +=   Math.Round(_simpTable[0][i], 4) + "\t";
                lineTwo +=   Math.Round(_simpTable[1][i], 4) + "\t";
                lineThree += Math.Round(_simpTable[2][i], 4) + "\t";
                lineFunc +=  Math.Round(_simpTable[3][i], 4) + "\t";
            }

            OutputList.Items.Add(titlesline);
            OutputList.Items.Add(lineOne);
            OutputList.Items.Add(lineTwo);
            OutputList.Items.Add(lineThree);
            OutputList.Items.Add(lineFunc);
            OutputList.Items.Add("+----------------------------------------------------------------------------------------------------------------------+");
        }

        // Вывод интерпертации результатов
        private void Interpretation()
        {
            OutputList.Items.Add("Интерпретация результатов:");
            for(int i = 1; i < 5; i++)
            {
                if (basis.Contains(i)) 
                {
                    int pos = 0;
                    for(int j = 0; j < basis.Length; j++)
                    {
                        if (basis[j] == i)
                            pos = j;
                    }

                    OutputList.Items.Add("Объем продукции П" + i + " должен составлять " +
                        _simpTable[pos][_simpTable[pos].Length - 1] + " ед. за исследуемый временной период"); 
                }
                else
                {
                    OutputList.Items.Add("Объем продукции П" + i + " должен составлять " +
                        0 + " ед. за исследуемый временной период");
                }
            }

            OutputList.Items.Add("Доход от реализации продукции составит " + _simpTable[3][_simpTable[3].Length - 1] +
                " ден. ед. за исследуемый временной период");
            
            OutputList.Items.Add("+----------------------------------------------------------------------------------------------------------------------+");
        }
    }
}
