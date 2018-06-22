using System;
using System.Windows.Forms;

using Demo_EposCmd.Properties;

using EposCmd.Net;
using EposCmd.Net.DeviceCmdSet.Operation;

namespace Demo_EposCmd
{
    public partial class Form1 : Form
    {
        private DeviceManager _connector_A;
        private Device _epos_A;
        private DeviceManager _connector_B;
        private Device _epos_B;

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
            if (_connector_A != null)
            {
                /*
                 * Important notice:
                 * It's recommended to call the Dispose function before application close
                 */
                _connector_A.Dispose();
            }
            if (_connector_B != null)
            {
                /*
                 * Important notice:
                 * It's recommended to call the Dispose function before application close
                 */
                _connector_B.Dispose();
            }
            Close();
        }

        /// <summary>
        /// Handles the Click event of the buttonSettings control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonSettings_A_Click(object sender, EventArgs ea)
        {
            try
            {
                _connector_A = new DeviceManager();

                // Get baudrate info
                uint b = _connector_A.Baudrate;

                // Set connection properties
                _connector_A.Baudrate = b;
                _connector_A.Timeout = 500;

                buttonEnable_A.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh_A();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_A();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonSettings_B_Click(object sender, EventArgs ea)
        {
            try
            {
                _connector_B = new DeviceManager();

                // Get baudrate info
                uint b = _connector_B.Baudrate;

                // Set connection properties
                _connector_B.Baudrate = b;
                _connector_B.Timeout = 500;

                buttonEnable_B.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh_B();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_B();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonEnable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonEnable_A_Click(object sender, EventArgs ea)
        {
            try
            {
                _epos_A = _connector_A.CreateDevice(Convert.ToUInt16(textBoxNodeId_A.Text));

                textBoxAOM_A.Text = _epos_A.Operation.OperationMode.GetOperationModeAsString();

                StateMachine sm = _epos_A.Operation.StateMachine;

                if (sm.GetFaultState())
                {
                    sm.ClearFault();
                }

                sm.SetEnableState();

                buttonSettings_A.Enabled = false;
                buttonEnable_A.Enabled = false;
                buttonDisable_A.Enabled = true;
                buttonMove_A.Enabled = true;
                buttonHalt_A.Enabled = true;

                timer_A.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh_A();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_A();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonEnable_B_Click(object sender, EventArgs ea)
        {
            try
            {
                _epos_B = _connector_B.CreateDevice(Convert.ToUInt16(textBoxNodeId_B.Text));

                textBoxAOM_B.Text = _epos_B.Operation.OperationMode.GetOperationModeAsString();

                StateMachine sm_B = _epos_B.Operation.StateMachine;

                if (sm_B.GetFaultState())
                {
                    sm_B.ClearFault();
                }

                sm_B.SetEnableState();

                buttonSettings_B.Enabled = false;
                buttonEnable_B.Enabled = false;
                buttonDisable_B.Enabled = true;
                buttonMove_B.Enabled = true;
                buttonHalt_B.Enabled = true;

                timer_B.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh_B();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_B();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonDisable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonDisable_A_Click(object sender, EventArgs ea)
        {
            try
            {
                StateMachine sm = _epos_A.Operation.StateMachine;

                if (sm.GetFaultState())
                {
                    sm.ClearFault();
                }

                if (!sm.GetDisableState())
                {
                    sm.SetDisableState();
                }

                buttonSettings_A.Enabled = true;
                buttonEnable_A.Enabled = true;
                buttonDisable_A.Enabled = false;
                buttonMove_A.Enabled = false;
                buttonHalt_A.Enabled = false;
            }
            catch (DeviceException e)
            {
                StopRefresh_A();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_A();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonDisable_B_Click(object sender, EventArgs ea)
        {
            try
            {
                StateMachine sm = _epos_B.Operation.StateMachine;

                if (sm.GetFaultState())
                {
                    sm.ClearFault();
                }

                if (!sm.GetDisableState())
                {
                    sm.SetDisableState();
                }

                buttonSettings_B.Enabled = true;
                buttonEnable_B.Enabled = true;
                buttonDisable_B.Enabled = false;
                buttonMove_B.Enabled = false;
                buttonHalt_B.Enabled = false;
            }
            catch (DeviceException e)
            {
                StopRefresh_B();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_B();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonMove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonMove_A_Click(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _epos_A.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

               textBoxAOM_A.Text = _epos_A.Operation.OperationMode.GetOperationModeAsString();

               textBoxPositionStart_A.Text = string.Format("{0}", _epos_A.Operation.MotionInfo.GetPositionIs());

               ppm.MoveToPosition(Convert.ToInt32(textBoxTargetPosition_A.Text), radioButtonAbsoluteMove_A.Checked, true);
            }
            catch (DeviceException e)
            {
                StopRefresh_A();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_A();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonMove_B_Click(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _epos_B.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

                textBoxAOM_B.Text = _epos_B.Operation.OperationMode.GetOperationModeAsString();

                textBoxPositionStart_B.Text = string.Format("{0}", _epos_B.Operation.MotionInfo.GetPositionIs());

                ppm.MoveToPosition(Convert.ToInt32(textBoxTargetPosition_B.Text), radioButtonAbsoluteMove_B.Checked, true);
            }
            catch (DeviceException e)
            {
                StopRefresh_B();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_B();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonHalt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonHalt_A_Click(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _epos_A.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

                textBoxAOM_A.Text = _epos_A.Operation.OperationMode.GetOperationModeAsString();

                ppm.HaltPositionMovement();
            }
            catch (DeviceException e)
            {
                StopRefresh_A();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_A();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonHalt_B_Click(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _epos_B.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

                textBoxAOM_B.Text = _epos_B.Operation.OperationMode.GetOperationModeAsString();

                ppm.HaltPositionMovement();
            }
            catch (DeviceException e)
            {
                StopRefresh_B();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_B();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Stops the refresh.
        /// </summary>
        private void StopRefresh_A()
        {
            try
            {
                timer_A.Enabled  = false;

                _epos_A = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void StopRefresh_B()
        {
            try
            {
                timer_B.Enabled = false;

                _epos_B = null;
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
            radioButtonRelativeMode_A.Checked = true;
            timer_A.Interval = 500;
            timer_A.Enabled = false;

            radioButtonRelativeMode_B.Checked = true;
            timer_B.Interval = 500;
            timer_B.Enabled = false;
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Timer_A_Tick(object sender, EventArgs ea)
        {
            try
            {
                if (_epos_A != null)
                {
                    textBoxPositionActualValue_A.Text = string.Format("{0}", _epos_A.Operation.MotionInfo.GetPositionIs());

                    if (_epos_A.Operation.StateMachine.GetEnableState())
                    {
                        buttonSettings_A.Enabled = false;
                        buttonEnable_A.Enabled = false;
                        buttonDisable_A.Enabled = true;
                        buttonMove_A.Enabled = true;
                        buttonHalt_A.Enabled = true;
                    }
                    else
                    {
                        buttonSettings_A.Enabled = true;
                        buttonEnable_A.Enabled = true;
                        buttonDisable_A.Enabled = false;
                        buttonMove_A.Enabled = false;
                        buttonHalt_A.Enabled = false;
                    }
                }
            }
            catch (DeviceException e)
            {
                StopRefresh_A();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_A();

                MessageBox.Show(e.Message);
            }
        }
        private void Timer_B_ick(object sender, EventArgs ea)
        {
            try
            {
                if (_epos_B != null)
                {
                    textBoxPositionActualValue_B.Text = string.Format("{0}", _epos_B.Operation.MotionInfo.GetPositionIs());

                    if (_epos_B.Operation.StateMachine.GetEnableState())
                    {
                        buttonSettings_B.Enabled = false;
                        buttonEnable_B.Enabled = false;
                        buttonDisable_B.Enabled = true;
                        buttonMove_B.Enabled = true;
                        buttonHalt_B.Enabled = true;
                    }
                    else
                    {
                        buttonSettings_B.Enabled = true;
                        buttonEnable_B.Enabled = true;
                        buttonDisable_B.Enabled = false;
                        buttonMove_B.Enabled = false;
                        buttonHalt_B.Enabled = false;
                    }
                }
            }
            catch (DeviceException e)
            {
                StopRefresh_B();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh_B();

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
