using System;
using System.Windows.Forms;

using Demo_EposCmd.Properties;

using EposCmd.Net;
using EposCmd.Net.DeviceCmdSet.Operation;

namespace Demo_EposCmd
{
    public partial class Form1 : Form
    {
        private DeviceManager _connector;
        private Device _epos;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            if (_connector != null)
            {
                /*
                 * Important notice:
                 * It's recommended to call the Dispose function before application close
                 */
                _connector.Dispose();
            }

            Close();
        }

        /// <summary>
        /// Handles the Click event of the buttonSettings control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonSettingsClick(object sender, EventArgs ea)
        {
            try
            {
                _connector = new DeviceManager();

                // Get baudrate info
                uint b = _connector.Baudrate;

                // Set connection properties
                _connector.Baudrate = b;
                _connector.Timeout = 500;

                buttonEnable.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonEnable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonEnableClick(object sender, EventArgs ea)
        {
            try
            {
                _epos = _connector.CreateDevice(Convert.ToUInt16(textBoxNodeId.Text));

                textBoxAOM.Text = _epos.Operation.OperationMode.GetOperationModeAsString();

                StateMachine sm = _epos.Operation.StateMachine;

                if (sm.GetFaultState())
                {
                    sm.ClearFault();
                }

                sm.SetEnableState();

                buttonSettings.Enabled = false;
                buttonEnable.Enabled = false;
                buttonDisable.Enabled = true;
                buttonMove.Enabled = true;
                buttonHalt.Enabled = true;

                timer1.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonDisable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonDisableClick(object sender, EventArgs ea)
        {
            try
            {
                StateMachine sm = _epos.Operation.StateMachine;

                if (sm.GetFaultState())
                {
                    sm.ClearFault();
                }

                if (!sm.GetDisableState())
                {
                    sm.SetDisableState();
                }

                buttonSettings.Enabled = true;
                buttonEnable.Enabled = true;
                buttonDisable.Enabled = false;
                buttonMove.Enabled = false;
                buttonHalt.Enabled = false;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonMove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonMoveClick(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _epos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

               textBoxAOM.Text = _epos.Operation.OperationMode.GetOperationModeAsString();

               textBoxPositionStart.Text = string.Format("{0}", _epos.Operation.MotionInfo.GetPositionIs());

               ppm.MoveToPosition(Convert.ToInt32(textBoxTargetPosition.Text), radioButtonAbsoluteMove.Checked, true);
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonHalt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonHaltClick(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _epos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

                textBoxAOM.Text = _epos.Operation.OperationMode.GetOperationModeAsString();

                ppm.HaltPositionMovement();
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Stops the refresh.
        /// </summary>
        private void StopRefresh()
        {
            try
            {
                timer1.Enabled  = false;

                _epos = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonRelativeMode.Checked = true;
            timer1.Interval = 500;
            timer1.Enabled = false;
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TimerTick(object sender, EventArgs ea)
        {
            try
            {
                if (_epos != null)
                {
                    textBoxPositionActualValue.Text = string.Format("{0}", _epos.Operation.MotionInfo.GetPositionIs());

                    if (_epos.Operation.StateMachine.GetEnableState())
                    {
                        buttonSettings.Enabled = false;
                        buttonEnable.Enabled = false;
                        buttonDisable.Enabled = true;
                        buttonMove.Enabled = true;
                        buttonHalt.Enabled = true;
                    }
                    else
                    {
                        buttonSettings.Enabled = true;
                        buttonEnable.Enabled = true;
                        buttonDisable.Enabled = false;
                        buttonMove.Enabled = false;
                        buttonHalt.Enabled = false;
                    }
                }
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Shows Error Message
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="errorCode">The error code.</param>
        private void ShowMessageBox(string text, uint errorCode)
        {
            var msg = string.Format("{0}\nErrorCode: {1:X8}", text, errorCode);

            MessageBox.Show(msg, Resources.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
