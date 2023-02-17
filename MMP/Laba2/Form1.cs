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
        /*private double[][] _simpTable;
        private int[] basis = new int[3] {5, 6, 7};
        private double[] limits = new double[4] {24, 12, 35, 0};
        public Form1()
        {
            _simpTable = new double[4][];

            _simpTable[0] = new double[] { 1, 2, 4, 8, 1, 0, 0 };
            _simpTable[1] = new double[] { 3, 5, 1, 0, 0, 1, 0 };
            _simpTable[2] = new double[] { 6, 0, 3, 1, 0, 0, 1 };
            _simpTable[3] = new double[] { -4, -2, -5, -8, 0, 0, 0 };

            Solve();
            InitializeComponent();
        }*/

        private double[][] _simpTable;
        private int[] basis = new int[3] { 4, 5, 6 };
        public Form1()
        {
            _simpTable = new double[4][];

            _simpTable[0] = new double[] { 2, -1, 1, 1, 0, 0, 1 };
            _simpTable[1] = new double[] { -4, 2, -1, 0, 1, 0, 2 };
            _simpTable[2] = new double[] { 3, 0, 1, 0, 0, 1, 5 };
            _simpTable[3] = new double[] { 1, -1, -3, 0, 0, 0, 0 };

            Solve();
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

                double[] simplexLinks = new double[3];

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

                double[][] _simpTableCopy = new double[4][];
                for(int i = 0; i < 4; i++)
                {
                    _simpTableCopy[i] = new double[7];
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
            }
        }
        private int ChooseBasisColumn()
        {
            double minValue = 0;
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

        private int ChooseBasisLine(double[] simplexLinks)
        {
            int position = 0;
            double minValue = double.MaxValue;
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
                if(_simpTable[3][i] < 0)
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
    }
}
