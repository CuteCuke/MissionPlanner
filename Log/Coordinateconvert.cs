using log4net;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Log
{
    public partial class Coordinateconvert : Form
    {
        private string logfilename;
        private static string lastLogDir;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        DFLogBuffer logdata;
        DFLog dflog;

        public Coordinateconvert()
        {
            InitializeComponent();
            ThemeManager.ApplyThemeTo(this);
        }

        private void bt_loadlog_Click(object sender, EventArgs e)
        {
            if (!File.Exists(logfilename))
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    openFileDialog1.Filter = "Log Files|*.log;*.bin;*.BIN;*.LOG";
                    openFileDialog1.FilterIndex = 2;
                    openFileDialog1.Multiselect = true;
                    openFileDialog1.InitialDirectory = lastLogDir ?? Settings.Instance.LogDir;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        lastLogDir = Path.GetDirectoryName(openFileDialog1.FileName);

                        int a = 0;
                        foreach (var fileName in openFileDialog1.FileNames)
                        {
                            Loading.ShowLoading(fileName, this);

                            if (a == 0)
                            {
                                // load first file
                                logfilename = fileName;
                                ThreadPool.QueueUserWorkItem(o => LoadLog(logfilename));
                            }
                            else
                            {
                                // load additional files in new windows
                                if (File.Exists(fileName))
                                {
                                    LogBrowse browse = new LogBrowse();
                                    browse.logfilename = fileName;
                                    browse.Show(this);
                                }
                            }

                            a++;
                        }
                    }
                    else
                    {
                        this.BeginInvoke((Action)delegate { this.Close(); });
                        return;
                    }
                }
            }
            else
            {
                ThreadPool.QueueUserWorkItem(o => LoadLog(logfilename));
            }
        }
        private int colcount;
        const int typecoloum = 2;
        public void LoadLog(string FileName)
        {
            while (!this.IsHandleCreated)
                Thread.Sleep(100);

            Loading.ShowLoading(Strings.Scanning_File, this);

            try
            {
                log.Info("before read " + (GC.GetTotalMemory(false) / 1024.0 / 1024.0));

                logdata = new DFLogBuffer(FileName);

                dflog = logdata.dflog;

                log.Info("got log lines " + (GC.GetTotalMemory(false) / 1024.0 / 1024.0));

                log.Info("process to datagrid " + (GC.GetTotalMemory(false) / 1024.0 / 1024.0));

                Loading.ShowLoading("Scanning coloum widths", this);

                colcount = 0;

                foreach (var msgid in logdata.FMT)
                {
                    if (msgid.Value.Item4 == null)
                        continue;
                    var colsplit = msgid.Value.Item4.FirstOrDefault().ToString().Split(',').Length;
                    colcount = Math.Max(colcount, (msgid.Value.Item4.Length + typecoloum + colsplit));
                }

                log.Info("Done " + (GC.GetTotalMemory(false) / 1024.0 / 1024.0));

                //this.BeginInvokeIfRequired(() => { LoadLog2(FileName, logdata, colcount); });
            }
            catch (Exception ex)
            {
                MsgBox.CustomMessageBox.Show("Failed to read File: " + ex.ToString());
                return;
            }

            log.Info("LoadLog Done");
        }
       
        

    }
}
