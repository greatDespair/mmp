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
        private double[][] _simpTable;
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
        }

        private void Solve()
        {
            // STEP 1
            if (!CanOptimize())
            {
                return;
            }

            // STEP 2

            int basisColumn = ChooseBasisColumn();

            // STEP 3

            if (!CheckUnlimTargetFunction(basisColumn))
            {
                return;
            }

            // STEP 4

            double[] simplexLinks = new double[3];

            for(int i = 0; i < 3; i++)
            {
                if(_simpTable[i][basisColumn] > 0)
                    simplexLinks[i] = limits[i] / _simpTable[i][basisColumn];
                else
                    simplexLinks[i] = -1;
            }

            // STEP 5

            int basisLine = ChooseBasisLine(simplexLinks);

            // STEP 6

            basis[basisLine] = basisColumn + 1;
            
            // STEP 7

            for(int i = 0; i < _simpTable.Length; i++)
            {
                for(int j = 0; j < _simpTable[i].Length; j++)
                {
                    if (i == basisLine)
                    {
                        _simpTable[i][j] = _simpTable[basisLine][j] / _simpTable[basisLine][basisColumn];
                    }
                    else
                    {
                        _simpTable[i][j] = _simpTable[i][j] + _simpTable[basisLine][j] * (-_simpTable[i][basisColumn]);
                    }
                }
            }

            for(int i = 0; i < limits.Length; i++)
            {
                if(i == basisLine)
                {
                    limits[i] = limits[i] / _simpTable[basisLine][basisColumn];
                }
                else
                {
                    limits[i] = limits[i] + limits[basisLine] * (-_simpTable[i][basisColumn]);
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
            double minValue = simplexLinks[0];
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
