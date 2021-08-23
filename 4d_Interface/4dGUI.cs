using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4d_Interface
{
    public partial class GuiForm : Form
    {

        private SerialCom connection;
        private SoundPlayer audio;
        private bool isMuted = false;
        private List<string> consoleHistory = new List<string>();

        public GuiForm()
        {
            InitializeComponent();
        }

        private void GuiForm_Load(object sender, EventArgs e)
        {
            connection = new SerialCom(this);
            foreach (string s in SerialPort.GetPortNames())
            {
                portComboBox.Items.Add(s);
            }

            baudRateBox.SelectedIndex = 6;
            playAudio();
        }

        private void playAudio()
        {
            audio = new SoundPlayer(_4d_Interface.Resources.buymode);
            audio.PlayLooping();

        }

        private void toggleSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isMuted)
            {
                audio.Stop();
                isMuted = true;
                updateConsole("4D: Sound off");
            }
            else
            {
                audio.PlayLooping();
                isMuted = false;
                updateConsole("4D: Sound on");

            }
        }

        private void reloadPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portComboBox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                portComboBox.Items.Add(s);
            }

            baudRateBox.SelectedIndex = 6;
            updateConsole("Reloaded COM ports");

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(baudRateBox.Text, out var baudRate);
            connection.Connect(portComboBox.Text, baudRate);
            if (connection.port.IsOpen)
            {
                connection.port.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
                updateConsole("4D: Connected to motherboard");
                fanA_button.Enabled = true;
                fanB_button.Enabled = true;
                activateA_radioButton.Enabled = true;
                activateB_radioButton.Enabled = true;

            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string incoming = connection.port.ReadLine();
            
            if (incoming.Length <= 20 && incoming.Length >= 10)
            {
                char[] splitters = { 't' };
                string[] values = incoming.Split(splitters);
                if (values.Length != 3)
                {
                    Console.WriteLine("COM: " + incoming);
                }
                else
                {
                    GuiUtilities.UpdateText(e1_temp, values[1]);
                    GuiUtilities.UpdateText(e2_temp, values[2]);
                }
                
            }
            else
            {
                Console.WriteLine(incoming);
            }
        }

        private void set_e1_Click(object sender, EventArgs e)
        {
            if (!checkConnection()) return;
            string msg = "a," + setTempA.Text + "," + setSpeedA.Text + "," + setStepsA.Text;
            e1_speed.Text = setSpeedA.Text + " Hz";
            connection.WriteMessage(msg);
            updateConsole("E1: Temperature: " + setTempA.Text + " °C");
            updateConsole("E1: Speed: " + setSpeedA.Text + " Hz");

        }

        private void set_e2_Click(object sender, EventArgs e)
        {
            if (!checkConnection()) return;
            string msg = "b," + setTempB.Text + "," + setSpeedB.Text + "," + setStepsB.Text;

            e2_speed.Text = setSpeedB.Text + " Hz";
            connection.WriteMessage(msg);
            updateConsole("E2: Temperature: " + setTempB.Text + " °C");
            updateConsole("E2: Speed: " + setSpeedB.Text + " Hz");
        }

        private void fanA_button_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkConnection()) return;
            string msg = "c," + Convert.ToInt32(!fanA_button.Checked) + "," + "2" + "," + "0";
            connection.WriteMessage(msg);
            updateConsole("E1: Fan " + fanA_button.Checked);
        }

        private void fanB_button_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkConnection()) return;
            string msg = "c," + "2" + "," + Convert.ToInt32(!fanB_button.Checked) + "," + "0";
            connection.WriteMessage(msg);
            updateConsole("E2: Fan " + fanB_button.Checked);

        }
        private void reverseA_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkConnection()) return;
            string msg = "c," + "2" + "," + Convert.ToInt32(!reverseA.Checked) + "," + "1";
            connection.WriteMessage(msg);
            updateConsole("E1: Rev " + reverseA.Checked);
        }

        private void reverseB_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkConnection()) return;
            string msg = "c," + Convert.ToInt32(reverseB.Checked) + "," + "2" + "," + "1";
            connection.WriteMessage(msg);
            updateConsole("E2: Rev " + reverseB.Checked);
        }

        private void activateA_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string msg = "d," + Convert.ToInt32(activateA_radioButton.Checked) + "," + Convert.ToInt32(activateB_radioButton.Checked);
            connection.WriteMessage(msg);
            if (activateA_radioButton.Checked)
            {
                updateConsole("E2: Off");
                updateConsole("E1: On");
            }
            else
            {
                updateConsole("E1: Off");
                updateConsole("E2: On");
            }

        }

        private bool checkConnection()
        {
            if (!connection.port.IsOpen)
            {
                MessageBox.Show("Connect to motherboard before proceeding");
                updateConsole("4D: Not connected...");
                fanA_button.Enabled = false;
                fanB_button.Enabled = false;
                activateA_radioButton.Enabled = false;
                activateB_radioButton.Enabled = false;
                return false;
            }

            return true;
        }
        private void updateConsole(string msg)
        {
            consoleBox.Text = msg + Environment.NewLine + consoleBox.Text;
        }

       
    }
}
