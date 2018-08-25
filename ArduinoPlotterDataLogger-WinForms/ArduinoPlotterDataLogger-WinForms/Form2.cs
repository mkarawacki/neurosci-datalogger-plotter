using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace ArduinoPlotterDataLogger_WinForms
{
    public partial class BasicLineExample : MetroFramework.Forms.MetroForm
    {
        List<int> bauds = new List<int> {
           115200        };
        SerialPort serialport;
        public BasicLineExample()
        {
            InitializeComponent();
             BaudRateCB.DataSource = bauds;
            COMPortsCB.DataSource = new BindingSource(COMPortInfo.GetCOMPortsInfo(), null);
        COMPortsCB.DisplayMember = "Description";
            COMPortsCB.ValueMember = "Name";
            

            
        }

        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }

        private void BasicLineExample_Load(object sender, EventArgs e)
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


            };
            serialport.RtsEnable = true;
            if (!serialport.IsOpen) serialport.Open();
        }
    }
}