using MissionPlanner.ArduPilot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class Parametermodification : UserControl
    {

        public Parametermodification()
        {
            InitializeComponent();
            enabletrue();
            getparams();
        }
        public void enabletrue()
        {

            //pitch：俯仰      pid
            Q_A_ANG_PIT_P.Enabled=true;
            Q_A_RAT_PIT_P.Enabled = true;
            Q_A_RAT_PIT_I.Enabled = true;
            Q_A_RAT_PIT_D.Enabled = true;
            //roll：横滚       pid 
            Q_A_ANG_RLL_P.Enabled = true;
            Q_A_RAT_RLL_P.Enabled = true;
            Q_A_RAT_RLL_I.Enabled = true;
            Q_A_RAT_RLL_D.Enabled = true;
            //yaw：航向       pid
            Q_A_ANG_YAW_P.Enabled = true;
            Q_A_RAT_YAW_P.Enabled = true;
            Q_A_RAT_YAW_I.Enabled = true;
            Q_A_RAT_YAW_D.Enabled = true;
            //左倾转舵机：   
            SERVO9_MIN.Enabled = true;
            SERVO9_MAX.Enabled = true;
            //右倾转舵机：
            SERVO10_MIN.Enabled = true;
            SERVO10_MAX.Enabled = true;
            //左升降舵机： 
            SERVO2_MIN.Enabled = true;
            SERVO2_TRIM.Enabled = true;
            SERVO2_MAX.Enabled = true;
            //右升降舵机：
            SERVO3_MIN.Enabled = true;
            SERVO3_TRIM.Enabled = true;
            SERVO3_MAX.Enabled = true;
            //垂直方向舵机：
            SERVO4_MIN.Enabled = true;
            SERVO4_TRIM.Enabled = true;
            SERVO4_MAX.Enabled = true;

        }
        public void getparams()
        {
            if (MainV2.comPort.BaseStream.IsOpen)
            {

                try
                {

                    //pitch：俯仰      pid
                    //Q_A_ANG_PIT_P.setup(0,0,1,0, "Q_A_ANG_PIT_P", MainV2.comPort.MAV.param);
                    //Q_A_RAT_PIT_P.setup(0, 0, 1, 0, "Q_A_RAT_PIT_P", MainV2.comPort.MAV.param);
                    //Q_A_RAT_PIT_I.setup(0, 0, 1, 0, "Q_A_RAT_PIT_I", MainV2.comPort.MAV.param);
                    //Q_A_RAT_PIT_D.setup(0, 0, 1, 0, "Q_A_RAT_PIT_D", MainV2.comPort.MAV.param);
                    Q_A_ANG_PIT_P.Value = (decimal)MainV2.comPort.GetParam("Q_A_ANG_PIT_P");
                    Q_A_RAT_PIT_P.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_PIT_P");
                    Q_A_RAT_PIT_I.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_PIT_I");
                    Q_A_RAT_PIT_D.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_PIT_D");
                    //roll：横滚       pid 
                    //Q_A_ANG_RLL_P.setup(0, 0, 1, 0, "Q_A_ANG_RLL_P", MainV2.comPort.MAV.param);
                    //Q_A_RAT_RLL_P.setup(0, 0, 1, 0, "Q_A_RAT_RLL_P", MainV2.comPort.MAV.param);
                    //Q_A_RAT_RLL_I.setup(0, 0, 1, 0, "Q_A_RAT_RLL_I", MainV2.comPort.MAV.param);
                    //Q_A_RAT_RLL_D.setup(0, 0, 1, 0, "Q_A_RAT_RLL_D", MainV2.comPort.MAV.param);
                    Q_A_ANG_RLL_P.Value = (decimal)MainV2.comPort.GetParam("Q_A_ANG_RLL_P");
                    Q_A_RAT_RLL_P.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_RLL_P");
                    Q_A_RAT_RLL_I.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_RLL_I");
                    Q_A_RAT_RLL_D.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_RLL_D");
                    //yaw：航向       pid
                    //Q_A_ANG_YAW_P.setup(0, 0, 1, 0, "Q_A_ANG_YAW_P", MainV2.comPort.MAV.param);
                    //Q_A_RAT_YAW_P.setup(0, 0, 1, 0, "Q_A_RAT_YAW_P", MainV2.comPort.MAV.param);
                    //Q_A_RAT_YAW_I.setup(0, 0, 1, 0, "Q_A_RAT_YAW_I", MainV2.comPort.MAV.param);
                    //Q_A_RAT_YAW_D.setup(0, 0, 1, 0, "Q_A_RAT_YAW_D", MainV2.comPort.MAV.param);
                    Q_A_ANG_YAW_P.Value = (decimal)MainV2.comPort.GetParam("Q_A_ANG_YAW_P");
                    Q_A_RAT_YAW_P.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_YAW_P");
                    Q_A_RAT_YAW_I.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_YAW_I");
                    Q_A_RAT_YAW_D.Value = (decimal)MainV2.comPort.GetParam("Q_A_RAT_YAW_D");
                    //左倾转舵机：   
                    //SERVO9_MIN.setup(0, 0, 1, 0, "SERVO9_MIN", MainV2.comPort.MAV.param);
                    //SERVO9_MAX.setup(0, 0, 1, 0, "SERVO9_MAX", MainV2.comPort.MAV.param);
                    SERVO9_MIN.Value = (decimal)MainV2.comPort.GetParam("SERVO9_MIN");
                    SERVO9_MAX.Value = (decimal)MainV2.comPort.GetParam("SERVO9_MAX");
                    //右倾转舵机：
                    //SERVO10_MIN.setup(0, 0, 1, 0, "SERVO10_MIN", MainV2.comPort.MAV.param);
                    //SERVO10_MAX.setup(0, 0, 1, 0, "SERVO10_MAX", MainV2.comPort.MAV.param);
                    SERVO10_MIN.Value = (decimal)MainV2.comPort.GetParam("SERVO10_MIN");
                    SERVO10_MAX.Value = (decimal)MainV2.comPort.GetParam("SERVO10_MAX");
                    //左升降舵机： 
                    //SERVO2_MIN.setup(0, 0, 1, 0, "SERVO2_MIN", MainV2.comPort.MAV.param);
                    //SERVO2_MAX.setup(0, 0, 1, 0, "SERVO2_MAX", MainV2.comPort.MAV.param);
                    //SERVO2_TRIM.setup(0, 0, 1, 0, "SERVO2_TRIM", MainV2.comPort.MAV.param);
                    SERVO2_MIN.Value = (decimal)MainV2.comPort.GetParam("SERVO2_MIN");
                    SERVO2_TRIM.Value = (decimal)MainV2.comPort.GetParam("SERVO2_TRIM");
                    SERVO2_MAX.Value = (decimal)MainV2.comPort.GetParam("SERVO2_MAX");
                    //右升降舵机：
                    //SERVO3_MIN.setup(0, 0, 1, 0, "SERVO3_MIN", MainV2.comPort.MAV.param);
                    //SERVO3_MAX.setup(0, 0, 1, 0, "SERVO3_MAX", MainV2.comPort.MAV.param);
                    //SERVO3_TRIM.setup(0, 0, 1, 0, "SERVO3_TRIM", MainV2.comPort.MAV.param);
                    SERVO3_MIN.Value = (decimal)MainV2.comPort.GetParam("SERVO3_MIN");
                    SERVO3_TRIM.Value = (decimal)MainV2.comPort.GetParam("SERVO3_TRIM");
                    SERVO3_MAX.Value = (decimal)MainV2.comPort.GetParam("SERVO3_MAX");
                    //垂直方向舵机：
                    //SERVO4_MIN.setup(0, 0, 1, 0, "SERVO4_MIN", MainV2.comPort.MAV.param);
                    //SERVO4_MAX.setup(0, 0, 1, 0, "SERVO4_MAX", MainV2.comPort.MAV.param);
                    //SERVO4_TRIM.setup(0, 0, 1, 0, "SERVO4_TRIM", MainV2.comPort.MAV.param);
                    SERVO4_MIN.Value = (decimal)MainV2.comPort.GetParam("SERVO4_MIN");
                    SERVO4_TRIM.Value = (decimal)MainV2.comPort.GetParam("SERVO4_TRIM");
                    SERVO4_MAX.Value = (decimal)MainV2.comPort.GetParam("SERVO4_MAX");
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }

        }
        public void writeparams()
        {
            if (MainV2.comPort.BaseStream.IsOpen)
            {

                try
                {
                    //pitch：俯仰      pid
                    MainV2.comPort.setParam("Q_A_ANG_PIT_P", (double)Q_A_ANG_PIT_P.Value);
                    MainV2.comPort.setParam("Q_A_RAT_PIT_P", (double)Q_A_RAT_PIT_P.Value);
                    MainV2.comPort.setParam("Q_A_RAT_PIT_I", (double)Q_A_RAT_PIT_I.Value);
                    MainV2.comPort.setParam("Q_A_RAT_PIT_D", (double)Q_A_RAT_PIT_D.Value);

                    //roll：横滚       pid 
                    MainV2.comPort.setParam("Q_A_ANG_RLL_P", (double)Q_A_ANG_RLL_P.Value);
                    MainV2.comPort.setParam("Q_A_RAT_RLL_P", (double)Q_A_RAT_RLL_P.Value);
                    MainV2.comPort.setParam("Q_A_RAT_RLL_I", (double)Q_A_RAT_RLL_I.Value);
                    MainV2.comPort.setParam("Q_A_RAT_RLL_D", (double)Q_A_RAT_RLL_D.Value);

                    //yaw：航向       pid
                    MainV2.comPort.setParam("Q_A_ANG_YAW_P", (double)Q_A_ANG_YAW_P.Value);
                    MainV2.comPort.setParam("Q_A_RAT_YAW_P", (double)Q_A_RAT_YAW_P.Value);
                    MainV2.comPort.setParam("Q_A_RAT_YAW_I", (double)Q_A_RAT_YAW_I.Value);
                    MainV2.comPort.setParam("Q_A_RAT_YAW_D", (double)Q_A_RAT_YAW_D.Value);

                    //左倾转舵机：   
                    MainV2.comPort.setParam("SERVO9_MIN", (double)SERVO9_MIN.Value);
                    MainV2.comPort.setParam("SERVO9_MAX", (double)SERVO9_MAX.Value);

                    //右倾转舵机：
                    MainV2.comPort.setParam("SERVO10_MIN", (double)SERVO10_MIN.Value);
                    MainV2.comPort.setParam("SERVO10_MAX", (double)SERVO10_MAX.Value);

                    //左升降舵机： 
                    MainV2.comPort.setParam("SERVO2_MIN", (double)SERVO2_MIN.Value);
                    MainV2.comPort.setParam("SERVO2_TRIM", (double)SERVO2_TRIM.Value);
                    MainV2.comPort.setParam("SERVO2_MAX", (double)SERVO2_MAX.Value);

                    //右升降舵机：
                    MainV2.comPort.setParam("SERVO3_MIN", (double)SERVO2_MIN.Value);
                    MainV2.comPort.setParam("SERVO3_TRIM", (double)SERVO2_TRIM.Value);
                    MainV2.comPort.setParam("SERVO3_MAX", (double)SERVO2_MAX.Value);

                    //垂直方向舵机：
                    MainV2.comPort.setParam("SERVO4_MIN", (double)SERVO2_MIN.Value);
                    MainV2.comPort.setParam("SERVO4_TRIM", (double)SERVO2_TRIM.Value);
                    MainV2.comPort.setParam("SERVO4_MAX", (double)SERVO2_MAX.Value);

                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            btn_refresh.Enabled = false;
            getparams();
            btn_refresh.Enabled = true;
        }

        private void btn_writeparams_Click(object sender, EventArgs e)
        {
           
        }

        private void Q_A_ANG_PIT_P_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_ANG_PIT_P", (double)Q_A_ANG_PIT_P.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_ANG_YAW_P_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_ANG_RLL_P", (double)Q_A_ANG_RLL_P.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_ANG_RLL_P_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                MainV2.comPort.setParam("Q_A_ANG_YAW_P", (double)Q_A_ANG_YAW_P.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_PIT_P_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_RAT_PIT_P", (double)Q_A_RAT_PIT_P.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_PIT_I_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_RAT_PIT_I", (double)Q_A_RAT_PIT_I.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_PIT_D_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_RAT_PIT_D", (double)Q_A_RAT_PIT_D.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_YAW_P_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                MainV2.comPort.setParam("Q_A_RAT_YAW_P", (double)Q_A_RAT_YAW_P.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_YAW_I_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                MainV2.comPort.setParam("Q_A_RAT_YAW_I", (double)Q_A_RAT_YAW_I.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_YAW_D_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                MainV2.comPort.setParam("Q_A_RAT_YAW_D", (double)Q_A_RAT_YAW_D.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_RLL_P_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_RAT_RLL_P", (double)Q_A_RAT_RLL_P.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_RLL_I_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_RAT_RLL_I", (double)Q_A_RAT_RLL_I.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void Q_A_RAT_RLL_D_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("Q_A_RAT_RLL_D", (double)Q_A_RAT_RLL_D.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO9_MIN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO9_MIN", (double)SERVO9_MIN.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO9_MAX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO9_MAX", (double)SERVO9_MAX.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO10_MIN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO10_MIN", (double)SERVO10_MIN.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO10_MAX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO10_MAX", (double)SERVO10_MAX.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO2_MIN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO2_MIN", (double)SERVO2_MIN.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO2_MAX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO2_MAX", (double)SERVO2_MAX.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO2_TRIM_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO2_TRIM", (double)SERVO2_TRIM.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO3_MIN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO3_MIN", (double)SERVO3_MIN.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO3_MAX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO3_MAX", (double)SERVO3_MAX.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }

        }

        private void SERVO3_TRIM_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO3_TRIM", (double)SERVO3_TRIM.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO4_MIN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO4_MIN", (double)SERVO4_MIN.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO4_MAX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO4_MAX", (double)SERVO4_MAX.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void SERVO4_TRIM_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("SERVO4_TRIM", (double)SERVO4_TRIM.Value);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }


    }
}
