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

namespace Gamepad_Swagger_Station
{
    public partial class frmMain : Form
    {
        private Controller gamepad;

        public frmMain()
        {
            InitializeComponent();
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

        private void updateStats()
        {
            State gamepadState = gamepad.GetState();

            clbABXY.SetItemChecked(0, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A));
            clbABXY.SetItemChecked(1, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B));
            clbABXY.SetItemChecked(2, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X));
            clbABXY.SetItemChecked(3, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y));

            clbSelectStart.SetItemChecked(0, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back));
            clbSelectStart.SetItemChecked(1, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start));

            clbThumbs.SetItemChecked(0, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftThumb));
            clbThumbs.SetItemChecked(1, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightThumb));

            clbDPad.SetItemChecked(0, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp));
            clbDPad.SetItemChecked(1, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown));
            clbDPad.SetItemChecked(2, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft));
            clbDPad.SetItemChecked(3, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight));

            clbShoulders.SetItemChecked(0, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder));
            clbShoulders.SetItemChecked(1, gamepadState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder));

            pbLeftX.Value = gamepadState.Gamepad.LeftThumbX + 32768;
            pbLeftY.Value = gamepadState.Gamepad.LeftThumbY + 32768;
            pbRightX.Value = gamepadState.Gamepad.RightThumbX + 32768;
            pbRightY.Value = gamepadState.Gamepad.RightThumbY + 32768;
            pbLeftT.Value = gamepadState.Gamepad.LeftTrigger;
            pbRightT.Value = gamepadState.Gamepad.RightTrigger;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtOutput.AppendText(string.Format("[{0}] Gamepad Swagger Station loaded", DateTime.Now));
            ConnectController();
        }

        private void refreshGamepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectController();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            updateStats();
        }

        private void menuBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduinoSerialPort.PortName = menuBoxPort.SelectedItem.ToString();
            consoleOutput("Port changed to " + arduinoSerialPort.PortName);
        }
    }
}
