using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using System.Text.RegularExpressions;
using System.Globalization;
using MetroFramework;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;

namespace ArduinoPlotterDataLogger_WinForms
{
    public partial class MainWindow : Form//MetroFramework.Forms.MetroForm
    {
        
        List<int> bauds = new List<int> {
           115200        };
        DataTable DaneDT;
        public LineSeries AX { get; set; }
        public LineSeries AY { get; set; }
        public LineSeries AZ { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            BaudRateCB.DataSource = bauds;
            COMPortsCB.DataSource = new BindingSource(COMPortInfo.GetCOMPortsInfo(), null);
            COMPortsCB.DisplayMember = "Description";
            COMPortsCB.ValueMember = "Name";
            Wykres.AxisX.Add(new Axis
            {
                Title="Czas pomiaru"
            });
            Wykres.AxisY.Add(new Axis
            {
                Title = "Wartość"
            });
            Wykres.LegendLocation = LegendLocation.Right;
            
        AX = new LineSeries
            {
                Title = "a_x [m/s^2]",
                Name = "AX",
                PointGeometry = DefaultGeometries.Circle,
                Values = new ChartValues<double> { 0 },
                PointGeometrySize = 6,
                Visibility = Visibility.Visible
            };
            AY = new LineSeries
            {
                Title = "a_y [m/s^2]",
                Name = "AY",
                Values = new ChartValues<double> { 0 },
                PointGeometry = DefaultGeometries.Circle,
                Visibility = Visibility.Visible
            };
            AZ = new LineSeries
            {
                Title = "a_z [m/s^2]",
                Name = "AZ",
                Values = new ChartValues<double> { 0 },
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 15,
                Visibility = Visibility.Visible
            };
            Wykres.Series = new SeriesCollection
            {
                AX,
                AY,
                AZ
            };
            
    }
        SerialPort serialport;// = new SerialPort();
        
        
            private void MainWindow_Load(object sender, EventArgs e)
        {
            
           
        }

        private void BaudRateCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void COMPortsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            serialport = new SerialPort
            {
                PortName = COMPortsCB.SelectedValue.ToString(),
                BaudRate = (int)BaudRateCB.SelectedItem,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                RtsEnable = true

            };
            if (!serialport.IsOpen)
            {
                serialport.Open();
                ArduConnStatusLabel.Text = "Arduino podłączone na porcie " + serialport.PortName;
            }
            serialport.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler);
        }

        private void SerialDataHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = sender as SerialPort;
            string dane = port.ReadLine();
            //double[] doubles = Array.ConvertAll(dane.ToLowerInvariant().Split(','), new Converter<string, double>(Double.Parse));
            List<double> _Dane = new List<double>(); 
            foreach (string d in SplitString(dane))
            {
                try
                {
                    _Dane.Add(double.Parse(d, NumberStyles.Any, CultureInfo.InvariantCulture)); 
                    //Console.WriteLine("Converted '{0}' to {1}.", d, result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.", d);
                }
            }

            double[] daneAr = _Dane.ToArray();
            ArduinoOutputDbg.Invoke((MethodInvoker)delegate { ArduinoOutputDbg.AppendText(dane); });
            for (int i = 0; i < 3; i++)
            {
                //daneAr[i] *= 9.81;
                Wykres.Series[i].Values.Add(daneAr[i]);
            }
        }

        private void ArduinoOutputDbg_TextChanged(object sender, EventArgs e)
        {
            ArduinoOutputDbg.SelectionStart = ArduinoOutputDbg.TextLength;
            ArduinoOutputDbg.ScrollToCaret();
        }

        private string[] SplitString(string inputString)
        {
            RegexOptions options = ((System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace | System.Text.RegularExpressions.RegexOptions.Multiline)
                        | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            Regex reg = new Regex("(?:^|,)(\\\"(?:[^\\\"]+|\\\"\\\")*\\\"|[^,]*)", options);
            MatchCollection coll = reg.Matches(inputString);
            string[] items = new string[coll.Count];
            int i = 0;
            foreach (Match m in coll)
            {
                items[i++] = m.Groups[0].Value.Trim('"').Trim(',').Trim('"').Trim();
            }
            return items;
        }


        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //serialport.DataReceived
            if(serialport.IsOpen)serialport.Close();
        }

        private void DataColumnsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dcsel = sender as CheckedListBox;
            string sel="";
            foreach (var item in dcsel.SelectedItems)
            {
                sel += item.ToString() + " ";
            }
            //MessageBox.Show(sel);
        }

        private void ParametricPlotToggle_CheckedChanged(object sender, EventArgs e)
        {
             AX.Visibility = AX.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }
            
        
    }
}
