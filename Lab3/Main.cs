using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Main : Form
    {
        List<string> _lawOfDistributions = new List<string>()
        {
            "Равномерный",
            "Нормальный",
            "Степенной",
            "Двухмодальный"
        };

        List<string> _divisionRules = new List<string>()
        {
            "Старджесса",
            "Брукса-Каррузера",
            "Хайнхольда-Гайде",
            "Ручной ввод"
        };

        Random _random = new Random();

        int _count = 100;

        LawOfDistribution _lawOfDistribution = LawOfDistribution.Uniform;
        DivisionRule _divisionRule = DivisionRule.Starges;

        double _m = 0.5;
        double _sigma = 0;

        List<double> _sampling = new List<double>();

        public Main()
        {
            InitializeComponent();

            _lawDistributionComboBox.DataSource = _lawOfDistributions;
            _divisionRuleComboBox.DataSource = _divisionRules;

            _samplingListBox.DataSource = _sampling;
        }

        private void _lawDistributionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lawOfDistribution = (LawOfDistribution)_lawDistributionComboBox.SelectedIndex;

            switch (_lawOfDistribution)
            {
                case LawOfDistribution.Normal:
                case LawOfDistribution.Bimodal:
                    _paramGroupBox.Visible = true;
                    break;
                default:
                    _paramGroupBox.Visible = false;
                    break;
            }
        }

        private void _divisionRuleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _divisionRule = (DivisionRule)_divisionRuleComboBox.SelectedIndex;

            switch (_divisionRule)
            {
                case DivisionRule.ManualInput:
                    _columnsCountNumericUpDown.Enabled = true;
                    _columnsCountTrackBar.Enabled = true;
                    break;
                default:
                    _columnsCountNumericUpDown.Enabled = false;
                    _columnsCountTrackBar.Enabled = false;
                    break;
            }
        }

        private void _countNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _count = (int)_countNumericUpDown.Value;
        }

        private void _mNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _m = (double)_mNumericUpDown.Value;
        }

        private void _sigmaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _sigma = (double)_sigmaNumericUpDown.Value;
        }

        private void _columnsCountTrackBar_Scroll(object sender, EventArgs e)
        {
            _columnsCountNumericUpDown.Value = _columnsCountTrackBar.Value;
        }

        private void _columnsCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _columnsCountTrackBar.Value = (int)_columnsCountNumericUpDown.Value;
        }

        private void _calcButton_Click(object sender, EventArgs e)
        {
            _sampling.Clear();

            switch (_lawOfDistribution)
            {
                case LawOfDistribution.Uniform:
                    GetUniformLawDistribution();
                    break;
                case LawOfDistribution.Normal:
                    GetNormalLawDistribution();
                    break;
                case LawOfDistribution.Stepwise:
                    GetStepwiseLawDistribution();
                    break;
                case LawOfDistribution.Bimodal:
                    GetBimodalLawDistribution();
                    break;
                default:
                    return;
            }

            _samplingListBox.DataSource = null;
            _samplingListBox.DataSource = _sampling;

            DrawSampling();
            CalcCharacteristics();
            DistAssessment();

            _rebuildButtom_Click(sender, e);
        }

        private void _rebuildButtom_Click(object sender, EventArgs e)
        {
            _barChart.Series[0].Points.Clear();

            int columnsCount;

            switch (_divisionRule)
            {
                case DivisionRule.Starges:
                    columnsCount = StargesDivisionRule();
                    break;
                case DivisionRule.BrooksCarruther:
                    columnsCount = BrooksCarrutherDivisionRule();
                    break;
                case DivisionRule.HeinholdHeide:
                    columnsCount = HeinholdHeideDivisionRule();
                    break;
                case DivisionRule.ManualInput:
                    columnsCount = ManualInputDivisionRule();
                    break;
                default:
                    return;
            }

            double columnsWidth = 1d / columnsCount;

            for (int i = 0; i < columnsCount; i++)
            {
                int pointsCount = 0;

                double min = i * columnsWidth;

                foreach (double x in _sampling)
                {
                    if (min <= x && x < min + columnsWidth)
                        pointsCount++;
                }

                _barChart.Series[0].Points.AddXY(min + columnsWidth / 2, (double)pointsCount / _count / columnsWidth);
            }
        }

        private void DrawSampling()
        {
            _samplingChart.Series[0].Points.DataBindY(_sampling);
        }

        private void CalcCharacteristics()
        {
            double xSR = 0;

            for (int i = 0; i < _count; i++)
                xSR += _sampling[i];

            xSR /= _count;

            double d = 0;
            double aS = 0;
            double eX = 0;

            for (int i = 0; i < _count; i++)
            {
                d += Math.Pow(_sampling[i] - xSR, 2);
                aS += Math.Pow(_sampling[i] - xSR, 3);
                eX += Math.Pow(_sampling[i] - xSR, 4);
            }
            
            d /= _count - 1;

            double sigma = Math.Sqrt(d);

            aS /= _count * Math.Pow(sigma, 3);
            eX = eX / (_count * Math.Pow(sigma, 4)) - 3;

            _xTextBox.Text = xSR.ToString();
            _DTextBox.Text = d.ToString();
            _sigmaTextBox.Text = sigma.ToString();
            _AsTextBox.Text = aS.ToString();
            _ExTextBox.Text = eX.ToString();
        }

        private void DistAssessment()
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 0; i < 1000; i++)
            {
                double x = i / 1000d;

                listX.Add(x);

                double v = 0;

                foreach (double xi in _sampling)
                {
                    if (x - xi >= 0)
                        v++;
                }

                v /= _count;

                listY.Add(v);
            }

            _distChart.Series[0].Points.DataBindXY(listX, listY);
        }

        private void GetUniformLawDistribution()
        {
            for (int i = 0; i < _count; i++)
            {
                _sampling.Add(_random.NextDouble());
            }
        }

        private void GetNormalLawDistribution()
        {
            for (int i = 0; i < _count; i++)
            {
                double sumP = 0;

                for (int j = 0; j < 12; j++)
                    sumP += _random.NextDouble();

                _sampling.Add(_m + _sigma * (sumP - 6));
            }
        }

        private void GetStepwiseLawDistribution()
        {
            for (int i = 0; i < _count; i++)
            {
                _sampling.Add(Math.Pow(_random.NextDouble(), 1d / 2d));
            }
        }

        private void GetBimodalLawDistribution()
        {
            for (int i = 0; i < _count; i++)
            {
                double sumP = 0;

                for (int j = 0; j < 12; j++)
                    sumP += _random.NextDouble();

                if (_random.NextDouble() > _m)
                    _sampling.Add(_m - 0.25d + _sigma * (sumP - 6));
                else
                    _sampling.Add(_m + 0.25d + _sigma * (sumP - 6));
            }
        }

        private int StargesDivisionRule()
        {
            return (int)(Math.Log(_count) / Math.Log(2) + 1);
        }

        private int BrooksCarrutherDivisionRule()
        {
            return (int)(5 * Math.Log(_count));
        }

        private int HeinholdHeideDivisionRule()
        {
            return (int)(Math.Sqrt(_count));
        }

        private int ManualInputDivisionRule()
        {
            return (int)_columnsCountNumericUpDown.Value;
        }
    }

    enum LawOfDistribution
    {
        Uniform,
        Normal,
        Stepwise,
        Bimodal
    }

    enum DivisionRule
    {
        Starges,
        BrooksCarruther,
        HeinholdHeide,
        ManualInput
    }
}
