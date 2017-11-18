using System;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboHand
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        volatile string message = "";
        public Form1()
        {
            InitializeComponent();
            DisableControls();
            GetAvailableComPorts();
            ScanPorts();
        }
        void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        private void ScanPorts()
        {
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAvailableComPorts();
            ScanPorts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                ConnectToArduino();
            }
            else
            {
                DisconnectFromArduino();
            }
        }

        private void ConnectToArduino()
        {
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);

            if (string.IsNullOrEmpty(selectedPort))
            {
                return;
            }

            isConnected = true;
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += Port_DataReceived;
            port.Open();
            button1.Text = "Disconnect";
            EnableControls();
        }

        private void DisconnectFromArduino()
        {
            isConnected = false;
            port.Close();
            button1.Text = "Connect";
            DisableControls();
            ResetDefaults();
        }

        private void DisableControls()
        {
            trackBar1.Enabled = false;
            trackBar2.Enabled = false;
            trackBar3.Enabled = false;
        }

        private void EnableControls()
        {
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;
        }

        private void ResetDefaults()
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
        }

        private string GetPreparedValue(int value)
        {
            string resValue = value.ToString();
            if (resValue.Length == 1)
            {
                return resValue = "00" + resValue;
            }
            else if (resValue.Length == 2)
            {
                return resValue = "0" + resValue;
            }
            return resValue;
        }
        private async Task SendCommand(string servo, string value)
        {
            await Task.Run(() =>
              {
                  if (isConnected)
                  {
                      port.Write($"#{servo}{value}*");
                  }
              });
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.Invoke(new EventHandler(delegate
            {
                textBox1.AppendText(port.ReadExisting());
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }));
        }

        private async void TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            string value = GetPreparedValue(trackBar1.Value);
            trackBarValueLabel1.Text = value;
            await SendCommand("01", value);
        }

        private async void TrackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            string value = GetPreparedValue(trackBar2.Value);
            trackBarValueLabel2.Text = value;
            await SendCommand("02", value);
        }

        private async void TrackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            string value = GetPreparedValue(trackBar3.Value);
            trackBarValueLabel3.Text = value;
            await SendCommand("03", value);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label1_scroll.Text = trackBar1.Value.ToString();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            label2_scroll.Text = trackBar2.Value.ToString();
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            label3_scroll.Text = trackBar3.Value.ToString();
        }
    }
}
