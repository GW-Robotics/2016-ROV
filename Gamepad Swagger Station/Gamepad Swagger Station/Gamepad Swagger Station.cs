using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpDX.XInput;
using System.Net.Sockets;
using System.IO;

namespace Gamepad_Swagger_Station
{
    public partial class frmMain : Form
    {
        private Controller gamepad;

        private bool[] buttonStatusesCurrent = new bool[14];
        private bool[] buttonStatusesPrevious = new bool[14];
        private float[] joystickValues = new float[6];

        private const int a = 0, b = 1, x = 2, y = 3, select = 4, start = 5, up = 6, down = 7, left = 8, right = 9, leftThumb = 10, rightThumb = 11, leftShoulder = 12, rightShoulder = 13;
        private const int leftX = 0, leftY = 1, rightX = 2, rightY = 3, leftTrigger = 4, rightTrigger = 5;

        private bool verboseJoystick = false, verboseButton = false;

        private bool useSerial = true, useTCP = false;
        
        private TcpClient tcpClient;
        private Stream stream;

        public frmMain()
        {
            InitializeComponent();
        }

        private void serialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
            netStream.Close();
            useSerial = true;
            useTCP = false;
            ConnectArduino();
        }

        private void tCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arduinoSerialPort.Close();
            useSerial = false;
            useTCP = true;
            ConnectESPDuino();
        }

        private void ConnectController()
        {
            gamepad = new Controller(UserIndex.One);
            consoleOutput(gamepad.IsConnected ? "Gamepad is connected." : "Gamepad is not connected.");
        }

        private void consoleOutput(string text)
        {
            txtOutput.AppendText(string.Format("{0}[{1}] {2}", Environment.NewLine, DateTime.Now, text));
        }

        private void ReadController()
        {
            State gamepadState = gamepad.GetState();

            buttonStatusesCurrent[a] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
            buttonStatusesCurrent[b] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
            buttonStatusesCurrent[x] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X);
            buttonStatusesCurrent[y] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);

            buttonStatusesCurrent[select] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back);
            buttonStatusesCurrent[start] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start);

            buttonStatusesCurrent[leftThumb] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftThumb);
            buttonStatusesCurrent[rightThumb] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightThumb);

            buttonStatusesCurrent[up] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);
            buttonStatusesCurrent[down] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);
            buttonStatusesCurrent[left] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);
            buttonStatusesCurrent[right] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);

            buttonStatusesCurrent[leftShoulder] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder);
            buttonStatusesCurrent[rightShoulder] = gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder);

            joystickValues[leftX] = gamepadState.Gamepad.LeftThumbX / 32768f;
            joystickValues[leftY] = gamepadState.Gamepad.LeftThumbY / 32768f;
            joystickValues[rightX] = gamepadState.Gamepad.RightThumbX / 32768f;
            joystickValues[rightY] = gamepadState.Gamepad.RightThumbY / 32768f;
            joystickValues[leftTrigger] = gamepadState.Gamepad.LeftTrigger / 255;
            joystickValues[rightTrigger] = gamepadState.Gamepad.RightTrigger / 255;
        }

        private void SendSerialInput()
        {
            for (int i = 0; i < buttonStatusesCurrent.Length; i++)
            {
                if (buttonStatusesCurrent[i] != buttonStatusesPrevious[i])
                {
                    SendSerialButtonOutput(i, buttonStatusesCurrent[i]);
                }

                buttonStatusesPrevious[i] = buttonStatusesCurrent[i];
            }

            SendSerialJoystckOutput(leftX);
            SendSerialJoystckOutput(leftY);
            SendSerialJoystckOutput(rightX);
            SendSerialJoystckOutput(rightY);
            SendSerialJoystckOutput(leftTrigger);
            SendSerialJoystckOutput(rightTrigger);
        }

        private void SendWifiInput()
        {
            for (int i = 0; i < buttonStatusesCurrent.Length; i++)
            {
                if (buttonStatusesCurrent[i] != buttonStatusesPrevious[i])
                {
                    SendWifiButtonOutput(i, buttonStatusesCurrent[i]);
                }

                buttonStatusesPrevious[i] = buttonStatusesCurrent[i];
            }

            SendWifiJoystckOutput(leftX);
            SendWifiJoystckOutput(leftY);
            SendWifiJoystckOutput(rightX);
            SendWifiJoystckOutput(rightY);
            SendWifiJoystckOutput(leftTrigger);
            SendWifiJoystckOutput(rightTrigger);
        }

        private void ReadArduino()
        {
            if (arduinoSerialPort.IsOpen)
            {
                consoleOutput("Arduino: " + arduinoSerialPort.ReadLine());
            }
        }

        private void ReadESPDuino()
        {
            if (stream.CanRead)
            {
                string message = "";
                byte[] bb = new byte[100];
                int k = stream.Read(bb, 0, 100);

                for (int i = 0; i < k; i++)
                {
                    message = string.Concat(message, Convert.ToChar(bb[i]));
                }
                consoleOutput("ESPDuino: " + message);
            }
        }

        private void SendSerialButtonOutput(int value, bool buttonState)
        {
            if (arduinoSerialPort.IsOpen)
            {
                string toSend = string.Format("!{0}:{1}<", value, buttonState.ToString());
                arduinoSerialPort.Write(toSend);
                if (verboseButton)
                {
                    consoleOutput(toSend);
                }
            }
        }

        private void SendSerialJoystckOutput(int joystick)
        {
            if (arduinoSerialPort.IsOpen)
            {
                string toSend = string.Format("#{0}:{1}<", joystick, joystickValues[joystick]);
                arduinoSerialPort.Write(toSend);
                if (verboseJoystick)
                {
                    consoleOutput(toSend);
                }
            }
        }

        private void SendWifiButtonOutput(int value, bool buttonState)
        {
            ASCIIEncoding asen = new ASCIIEncoding();
            string toSend = string.Format("!{0}:{1}<", value, buttonState.ToString());

            byte[] ba = asen.GetBytes(toSend);
            stream.Write(ba, 0, ba.Length);

            if (verboseButton)
            {
                consoleOutput(toSend);
            }
        }

        private void SendWifiJoystckOutput(int joystick)
        {
            ASCIIEncoding asen = new ASCIIEncoding();
            string toSend = string.Format("#{0}:{1}<", joystick, joystickValues[joystick]);

            byte[] ba = asen.GetBytes(toSend);
            stream.Write(ba, 0, ba.Length);

            if (verboseButton)
            {
                consoleOutput(toSend);
            }
        }

        private void UpdateStats()
        {
            clbABXY.SetItemChecked(0, buttonStatusesCurrent[a]);
            clbABXY.SetItemChecked(1, buttonStatusesCurrent[b]);
            clbABXY.SetItemChecked(2, buttonStatusesCurrent[x]);
            clbABXY.SetItemChecked(3, buttonStatusesCurrent[y]);

            clbSelectStart.SetItemChecked(0, buttonStatusesCurrent[select]);
            clbSelectStart.SetItemChecked(1, buttonStatusesCurrent[start]);

            clbThumbs.SetItemChecked(0, buttonStatusesCurrent[leftThumb]);
            clbThumbs.SetItemChecked(1, buttonStatusesCurrent[rightThumb]);

            clbDPad.SetItemChecked(0, buttonStatusesCurrent[up]);
            clbDPad.SetItemChecked(1, buttonStatusesCurrent[down]);
            clbDPad.SetItemChecked(2, buttonStatusesCurrent[left]);
            clbDPad.SetItemChecked(3, buttonStatusesCurrent[right]);

            clbShoulders.SetItemChecked(0, buttonStatusesCurrent[leftShoulder]);
            clbShoulders.SetItemChecked(1, buttonStatusesCurrent[rightShoulder]);

            pbLeftX.Value = (int)((joystickValues[leftX] * 32768) + 32768);
            pbLeftY.Value = (int)((joystickValues[leftY] * 32768) + 32768);
            pbRightX.Value = (int)((joystickValues[rightX] * 32768) + 32768);
            pbRightY.Value = (int)((joystickValues[rightY] * 32768) + 32768);
            pbLeftT.Value = (int)(joystickValues[leftTrigger] * 255);
            pbRightT.Value = (int)(joystickValues[rightTrigger] * 255);
        }

        private void ConnectArduino()
        {
            if (!arduinoSerialPort.IsOpen)
            {
                try
                {
                    arduinoSerialPort.Open();
                    if (arduinoSerialPort.IsOpen)
                    {
                        consoleOutput("Port changed to: " + arduinoSerialPort.PortName);
                    }
                }
                catch (Exception)
                {
                    consoleOutput("Invalid Port: No Arduino found");
                }
            }
        }

        private void ConnectESPDuino()
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(txtIP.Text, Int32.Parse(txtPort.Text));
                consoleOutput("Connected successfully to ESPDuino");
                stream = tcpClient.GetStream();
            }
            catch (Exception e) { }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtOutput.AppendText(string.Format("[{0}] Gamepad Swagger Station loaded", DateTime.Now));
            ConnectController();
            if (useSerial)
            {
                ConnectArduino();
            }
            else if (useTCP)
            {
                ConnectESPDuino();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            arduinoSerialPort.Close();
            tcpClient.Close();
            netStream.Close();
        }

        private void refreshGamepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectController();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            ReadController();
            UpdateStats();

            if (useSerial && !useTCP)
            {
                SendSerialInput();
                //ReadArduino();
            } else if (!useSerial && useTCP)
            {
                SendWifiInput();
                //ReadESPDuino();
            }
        }

        private void menuBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduinoSerialPort.Close();
            arduinoSerialPort.PortName = menuBoxPort.SelectedItem.ToString();
            ConnectArduino();
        }

        private void joystickInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verboseJoystick = !verboseJoystick;
        }

        private void buttonInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verboseButton = !verboseButton;
        }
    }
}
