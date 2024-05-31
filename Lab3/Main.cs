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
        private List<string> _lawOfDistributions = new List<string>()
        {
            "Равномерный",
            "Нормальный",
            "Степенной",
            "Двухмодальный"
        };

        private List<string> _divisionRules = new List<string>()
        {
            "Старджесса",
            "Брукса-Каррузера",
            "Хайнхольда-Гайде",
            "Ручной ввод"
        };

        private List<string> _kernelFunctions = new List<string>()
        {
            "Равномерное",
            "Треугольное",
            "Епанечниково",
            "Биквадратное",
            "Триквадратное",
            "Трикубическое",
            "Гауссово",
            "Косинусоидальное",
            "Логистическое",
            "Сигмоидальное"
        };

        private List<string> _autoCList = new List<string>()
        {
            "Оптимальное",
            "W(c) - не работает!!!",
            "L(c)",
            "Ручной ввод"
        };

        private Random _random = new Random();

        private int _count = 100;

        private LawOfDistribution _lawOfDistribution = LawOfDistribution.Uniform;
        private DivisionRule _divisionRule = DivisionRule.Starges;
        private KernelFunction _kernelFunction = KernelFunction.Uniform;
        private AutoC _autoC = AutoC.Auto;

        private double _m = 0.5;
        private double _sigma = 0.01;

        private List<double> _sampling = new List<double>();

        private double _min;
        private double _max;

        private double _kernelX = 0.5;
        private double _kernelC = 0;

        private double _kernelSigma = 0;

        private Func<double, double> _kernelFunc;

        public Main()
        {
            InitializeComponent();

            _lawDistributionComboBox.DataSource = _lawOfDistributions;
            _divisionRuleComboBox.DataSource = _divisionRules;
            _kernelComboBox.DataSource = _kernelFunctions;
            _autoCComboBox.DataSource = _autoCList;

            _samplingListBox.DataSource = _sampling;

            _kernelFunc = GetUniformKernel;
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

        private void _kernelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _kernelFunction = (KernelFunction)_kernelComboBox.SelectedIndex;

            switch (_kernelFunction)
            {
                default:
                case KernelFunction.Uniform:
                    _kernelFunc = GetUniformKernel;
                    break;
                case KernelFunction.Triangular:
                    _kernelFunc = GetTriangularKernel;
                    break;
                case KernelFunction.Epanechnikov:
                    _kernelFunc = GetEpanechnikovKernel;
                    break;
                case KernelFunction.Quartic:
                    _kernelFunc = GetQuarticKernel;
                    break;
                case KernelFunction.Triweight:
                    _kernelFunc = GetTriweightKernel;
                    break;
                case KernelFunction.Tricube:
                    _kernelFunc = GetTricubeKernel;
                    break;
                case KernelFunction.Gaussian:
                    _kernelFunc = GetGaussianKernel;
                    break;
                case KernelFunction.Cosine:
                    _kernelFunc = GetCosineKernel;
                    break;
                case KernelFunction.Logistic:
                    _kernelFunc = GetLogisticKernel;
                    break;
                case KernelFunction.SigmoidFunction:
                    _kernelFunc = GetSigmoidFunctionKernel;
                    break;
            }
        }

        private void _autoCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _autoC = (AutoC)_autoCComboBox.SelectedIndex;

            switch (_autoC)
            {
                case AutoC.Manual:
                    _kernelNumericUpDown.Enabled = true;
                    break;
                default:
                    _kernelNumericUpDown.Enabled = false;
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

        private void _nXTrackBar_Scroll(object sender, EventArgs e)
        {
            _kernelX = _kernelXTrackBar.Value / 100d;
            _kernelXLabel.Text = _kernelX.ToString();

            Kernel();
        }

        private void _kernelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _kernelC = (double)_kernelNumericUpDown.Value;

            _kernelButton_Click(sender, e);
        }

        private void _kernelProgressBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _kernelWorker.CancelAsync();
            }
        }

        private void _calcButton_Click(object sender, EventArgs e)
        {
            if (_calcWorker.IsBusy != true)
            {
                _calcProgressBar.Visible = true;
                _calcWorker.RunWorkerAsync();
            }
        }

        private void _rebuildButtom_Click(object sender, EventArgs e)
        {
            if (_sampling.Count == 0)
                return;

            _barChart.Series[0].Points.Clear();
            _kernelChart.Series[1].Points.Clear();

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

            double columnsWidth = (_max - _min) / columnsCount;

            for (int i = 0; i < columnsCount; i++)
            {
                int pointsCount = 0;

                double min = i * columnsWidth + _min;

                foreach (double x in _sampling)
                {
                    if (min <= x && x < min + columnsWidth)
                        pointsCount++;
                }

                _barChart.Series[0].Points.AddXY(min + columnsWidth / 2, (double)pointsCount / _count / columnsWidth);
                _kernelChart.Series[1].Points.AddXY(min + columnsWidth / 2, (double)pointsCount / _count / columnsWidth);
            }
        }

        private void _kernelButton_Click(object sender, EventArgs e)
        {
            if (_sampling.Count == 0)
                return;

            _kernelProgressBar.Visible = true;
            _kernelButton.Enabled = false;

            if (_kernelWorker.IsBusy != true)
                _kernelWorker.RunWorkerAsync();
        }

        private void DrawSampling()
        {
            _samplingChart.Series[0].Points.DataBindY(_sampling);
        }

        private void CalcCharacteristics()
        {
            double xSR = 0;

            _min = double.MaxValue;
            _max = double.MinValue;

            foreach (double v in _sampling)
            {
                xSR += v;

                _min = Math.Min(v, _min);
                _max = Math.Max(v, _max);
            }

            xSR /= _count;

            double d = 0;
            double aS = 0;
            double eX = 0;

            foreach (double v in _sampling)
            {
                d += Math.Pow(v - xSR, 2);
                aS += Math.Pow(v - xSR, 3);
                eX += Math.Pow(v - xSR, 4);
            }

            d /= _count - 1;

            double sigma = Math.Sqrt(d);

            _kernelSigma = sigma;

            aS /= _count * Math.Pow(sigma, 3);
            eX = eX / (_count * Math.Pow(sigma, 4)) - 3;

            _xTextBox.Text = xSR.ToString();
            _DTextBox.Text = d.ToString();
            _sigmaTextBox.Text = sigma.ToString();
            _AsTextBox.Text = aS.ToString();
            _ExTextBox.Text = eX.ToString();

            _kernelX = (_max + _min) / 2;
            _kernelXTrackBar.Minimum = (int)(_min * 100);
            _kernelXTrackBar.Maximum = (int)(_max * 100);
            _kernelXTrackBar.Value = (int)(_kernelX * 100);
            _kernelXLabel.Text = _kernelX.ToString();
        }

        private void DistAssessment()
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (double x = _min; x < _max; x += 0.001d)
            {
                listX.Add(x);
                listY.Add(DistAsmt(x));
            }

            _distChart.Series[0].Points.DataBindXY(listX, listY);
        }

        private double DistAsmt(double x)
        {
            double result = 0;

            foreach (double xi in _sampling)
            {
                if (x - xi >= 0)
                    result++;
            }

            result /= _count;

            return result;
        }

        private void GetUniformLawDistribution(BackgroundWorker worker)
        {
            for (int i = 0; i < _count; i++)
            {
                _sampling.Add(_random.NextDouble());

                worker.ReportProgress((int)((i + 1) / (double)_count * 100));
            }
        }

        private void GetNormalLawDistribution(BackgroundWorker worker)
        {
            for (int i = 0; i < _count; i++)
            {
                double sumP = 0;

                for (int j = 0; j < 12; j++)
                    sumP += _random.NextDouble();

                _sampling.Add(_m + _sigma * (sumP - 6));

                worker.ReportProgress((int)((i + 1) / (double)_count * 100));
            }
        }

        private void GetStepwiseLawDistribution(BackgroundWorker worker)
        {
            for (int i = 0; i < _count; i++)
            {
                _sampling.Add(Math.Pow(_random.NextDouble(), 1d / 2d));

                worker.ReportProgress((int)(i / (double)_count * 100));
            }
        }

        private void GetBimodalLawDistribution(BackgroundWorker worker)
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

                worker.ReportProgress((int)((i + 1) / (double)_count * 100));
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

        private double GetUniformKernel(double u)
        {
            return Math.Abs(u) <= 1 ? 0.5 : 0;
        }

        private double GetTriangularKernel(double u)
        {
            return Math.Abs(u) <= 1 ? 1 - Math.Abs(u) : 0;
        }

        private double GetEpanechnikovKernel(double u)
        {
            return Math.Abs(u) <= 1 ? 3d / 4d * (1 - Math.Pow(u, 2)) : 0;
        }

        private double GetQuarticKernel(double u)
        {
            return Math.Abs(u) <= 1 ? 15d / 16d * Math.Pow(1 - Math.Pow(u, 2), 2) : 0;
        }

        private double GetTriweightKernel(double u)
        {
            return Math.Abs(u) <= 1 ? 35d / 32d * Math.Pow(1 - Math.Pow(u, 2), 3) : 0;
        }

        private double GetTricubeKernel(double u)
        {
            return Math.Abs(u) <= 1 ? 70d / 81d * Math.Pow(1 - Math.Pow(Math.Abs(u), 3), 3) : 0;
        }

        private double GetGaussianKernel(double u)
        {
            return 1 / Math.Sqrt(2 * Math.PI) * Math.Exp(-Math.Pow(u, 2) / 2);
        }

        private double GetCosineKernel(double u)
        {
            return Math.Abs(u) <= 1 ? Math.PI / 4 * Math.Cos(Math.PI / 2 * u) : 0;
        }

        private double GetLogisticKernel(double u)
        {
            return 1 / (Math.Exp(u) + 2 + Math.Exp(-u));
        }

        private double GetSigmoidFunctionKernel(double u)
        {
            return 2 / Math.PI * 1 / (Math.Exp(u) + Math.Exp(-u));
        }

        private double GetKernelC(BackgroundWorker worker)
        {
            switch (_autoC)
            {
                default:
                case AutoC.Auto:
                    return GetAutoC(worker);
                case AutoC.W:
                    return GetWC(worker);
                case AutoC.L:
                    return GetLC(worker);
                case AutoC.Manual:
                    worker.ReportProgress(100);
                    return (double)_kernelNumericUpDown.Value;
            }
        }

        private double GetAutoC(BackgroundWorker worker)
        {
            worker.ReportProgress(25);

            double[] betta = new double[]
            {
                1.064, 1.049, 1.059,
                0.908, 0.895, 0.904,
                0.728, 0.717, 0.724,
                0.896, 0.883, 0.892,
                0.926, 0.913, 0.922,
                1.226, 1.208, 1.22
            };

            worker.ReportProgress(50);

            double result = 0;

            worker.ReportProgress(75);

            foreach (double v in betta)
                result += v;

            worker.ReportProgress(100);

            return result / betta.Length * _kernelSigma * Math.Pow(_sampling.Count, -1d / 5d); ;
        }

        private double GetWC(BackgroundWorker worker)
        {
            double minV = double.MaxValue;
            double minC = double.MaxValue;

            for (int i = 1; i < 200; i++)
            {
                if (worker.CancellationPending)
                    break;

                double c = i / 1000d;
                double v = W(c);

                if (v < minV)
                {
                    minV = v;
                    minC = c;
                }

                worker.ReportProgress((int)((i + 1) / (double)200 * 100));
            }

            return minC;

            double W(double c)
            {
                double sm = 0;

                for (int i = 0; i < _count; i++)
                {
                    for (int j = 0; j < _count; j++)
                        sm += _kernelFunc((_sampling[j] - _sampling[i]) / c);
                }

                double pSum = 0;

                for (int j = 0; j < _count; j++)
                {
                    double s = 0;

                    for (int i = 0; i < _count; i++)
                    {
                        if (i != j)
                            s += _kernelFunc((_sampling[j] - _sampling[i]) / c);
                    }

                    pSum += s * 1 / (_count * c);
                }

                return 1 / Math.Pow(_count * c, 2) * sm - 2 / _count * pSum;
            }
        }

        private double GetLC(BackgroundWorker worker)
        {
            double maxV = double.MinValue;
            double maxC = double.MinValue;

            for (int i = 1; i < 200; i++)
            {
                if (worker.CancellationPending)
                    break;

                double c = i / 1000d;
                double v = L(c);

                if (v > maxV)
                {
                    maxV = v;
                    maxC = c;
                }

                worker.ReportProgress((int)((i + 1) / (double)200 * 100));
            }

            return maxC;

            double L(double c)
            {
                double result = 1;

                for (int j = 0; j < _count; j++)
                {
                    double sm = 0;

                    for (int i = 0; i < _count; i++)
                    {
                        if (j != i)
                            sm += _kernelFunc((_sampling[j] - _sampling[i]) / c);
                    }

                    result *= 1 / ((_count - 1) * c) * sm;
                }

                return result;
            }
        }

        private double GetKernelGrade(double kernelX)
        {
            double result = 0;

            foreach (double x in _sampling)
                result += _kernelFunc((kernelX - x) / _kernelC);

            return result / (_sampling.Count * _kernelC);
        }

        private void Kernel()
        {
            _kernelChart.Series[0].Points.Clear();

            double kernelGrade = GetKernelGrade(_kernelX);

            _kernelChart.Series[0].Points.AddXY(_kernelX - _kernelC, kernelGrade);
            _kernelChart.Series[0].Points.AddXY(_kernelX + _kernelC, kernelGrade);
        }

        private void DrawKernelChart()
        {
            _kernelChart.Series[2].Points.Clear();

            for (int i = 0; i < 100; i++)
            {
                double x = (i / 100d) * (_max - _min) + _min;
                double kernelGrade = GetKernelGrade(x);

                _kernelChart.Series[2].Points.AddXY(x, kernelGrade);
            }
        }

        private void _calcWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            _sampling.Clear();

            switch (_lawOfDistribution)
            {
                case LawOfDistribution.Uniform:
                    GetUniformLawDistribution(worker);
                    break;
                case LawOfDistribution.Normal:
                    GetNormalLawDistribution(worker);
                    break;
                case LawOfDistribution.Stepwise:
                    GetStepwiseLawDistribution(worker);
                    break;
                case LawOfDistribution.Bimodal:
                    GetBimodalLawDistribution(worker);
                    break;
                default:
                    return;
            }
        }

        private void _kernelWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            _kernelC = GetKernelC(worker);
        }

        private void _calc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _samplingListBox.DataSource = null;
            _samplingListBox.DataSource = _sampling;

            DrawSampling();
            CalcCharacteristics();
            DistAssessment();

            _rebuildButtom_Click(sender, e);
            _kernelButton_Click(sender, e);

            _calcProgressBar.Visible = false;
            _calcProgressBar.Value = 0;
        }

        private void _kernelWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _kernelNumericUpDown.Value = (decimal)_kernelC;

            Kernel();
            DrawKernelChart();

            _kernelProgressBar.Visible = false;
            _kernelProgressBar.Value = 0;

            _kernelButton.Enabled = true;
        }

        private void _calc_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _calcProgressBar.Value = e.ProgressPercentage;
        }

        private void _kernelWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _kernelProgressBar.Value = e.ProgressPercentage;
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

    enum KernelFunction
    {
        Uniform,
        Triangular,
        Epanechnikov,
        Quartic,
        Triweight,
        Tricube,
        Gaussian,
        Cosine,
        Logistic,
        SigmoidFunction
    }

    enum AutoC
    {
        Auto,
        W,
        L,
        Manual
    }
}
