using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RAM_Cleaner_Pro
{
    public partial class MainWindow : Form
    {
        private static long total, free, used, startfree, endfree, partfree1, partfree2;
        Thread Tgetram, Tfill;
        int runcount;
        TimeSpan elapsed, remain, estimated;
        private List<byte[]> alist = new List<byte[]>();
        private DateTime startdate, enddate;
        bool busy = false;


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Tfill != null && Tfill.IsAlive)
            {
                Tfill.Abort();
            }
            if (Tgetram != null && Tgetram.IsAlive)
            {
                Tgetram.Abort();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Smart clean's goal to free up as much RAM as possible without any user interaction.\n\n" +
                "It will run until each consequent run produces at least as much freed memory as selected in percent.", "Smart cleaning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbl_ramStat_Paint(object sender, PaintEventArgs e)
        {
            ShowRamStats();
        }

        public MainWindow()
        {
            InitializeComponent();
            Tgetram = new Thread(new ThreadStart(GetRamStats));
            Tgetram.IsBackground = true;
            Tgetram.Start();
        }

        private void Fill()
        {
            startfree = free;
            partfree2 = startfree;
            this.Invoke((MethodInvoker)delegate
            {
                lbl_estimatedFast.Text = "";
                lbl_estimatedNormal.Text = "";
                lbl_estimatedDeep.Text = "";
                lbl_ramAfter_data.Text = "";
                lbl_cleanedRam_data.Text = "";
                lbl_finishDate_data.Text = "";
                lbl_elapsedTime_data.Text = "";
                lbl_ramBefore_data.Text = Math.Round((double)(total - startfree) / total * 100).ToString() + " %";
                prg_progressbar.Maximum = (int)((total) * 1.1) * runcount;
                remain = estimated;
                if (rb_smart.Checked)
                {
                    lbl_smart.Visible = true;
                    lbl_progress.Visible = false;
                }
                else
                {
                    lbl_smart.Visible = false;
                    lbl_progress.Visible = true;
                }
            });
            int count = 0;
            for (int j = runcount; j >= 1; j--)
            {
                count++;
                for (int i = 0; i < (int)((total) * 1.1); i++)
                {
                    elapsed = (DateTime.Now - startdate);
                    if (elapsed > remain)
                    {
                        remain = elapsed;
                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        lbl_smart.Text = "Running smart cleaning - Run#" + count;
                        prg_progressbar.Value = (!rb_smart.Checked) ? prg_progressbar.Value + 1 : prg_progressbar.Maximum;
                        lbl_progress.Text = "Progress: " + Math.Round((double)prg_progressbar.Value / prg_progressbar.Maximum * 100).ToString() + "% - Estimated remaining time: " + (remain - elapsed).ToString().Substring(3, 5);
                        lbl_elapsedTime_data.Text = elapsed.ToString().Substring(3, 5);
                    });
                    if (free > 100)
                    {
                        byte[] data = new byte[(int)1024 * 1024];
                        Array.Clear(data, 0, data.Length);
                        alist.Add(data);
                    }
                    else
                    { Thread.Sleep(10); }
                }
                alist.Clear();
                GC.Collect();
                Thread.Sleep(1000);
                partfree1 = free;
                if (rb_smart.Checked && Math.Round(((double)partfree1 / total * 100) - ((double)partfree2 / total * 100)) >= (double)num_smart.Value)
                {
                    j++;
                    partfree2 = partfree1;
                }
                this.Invoke((MethodInvoker)delegate
                {
                    lbl_ramAfter_data.Text = Math.Round((double)(total - partfree1) / total * 100).ToString() + " %";
                });
                remain = TimeSpan.FromMilliseconds((free * 1.1 + (total - free) * 10) * j + (j + 1) * 1000);
            }
            Clear();
            this.Invoke((MethodInvoker)delegate
            {
                rb_fast.Enabled = true;
                rb_normal.Enabled = true;
                rb_deep.Enabled = true;
                rb_smart.Enabled = true;
                lbl_smart.Visible = false;
                this.UseWaitCursor = false;
            });
        }

        public void Clear()
        {
            alist.Clear();
            GC.Collect();
            Thread.Sleep(1000);
            endfree = free;
            enddate = DateTime.Now;
            this.Invoke((MethodInvoker)delegate
            {
                lbl_ramAfter_data.Text = Math.Round((double)(total - endfree) / total * 100).ToString() + " %";
                lbl_cleanedRam_data.Text = Math.Max(0, (endfree - startfree)).ToString() + " MB";
                lbl_finishDate_data.Text = enddate.ToString();
                lbl_elapsedTime_data.Text = (enddate - startdate).ToString().Substring(3, 5);
            });
            this.Invoke((MethodInvoker)delegate
            {
                prg_progressbar.Value = 0;
                lbl_progress.Visible = false;
                btn_startClean.Text = "Start";
            });
            busy = false;
        }
        private void btn_startClean_Click(object sender, EventArgs e)
        {

            if (!busy)
            {
                this.UseWaitCursor = true;
                btn_startClean.Text = "Stop";
                startdate = DateTime.Now;
                lbl_startDate_data.Text = startdate.ToString();
                Tfill = new Thread(new ThreadStart(Fill));
                Tfill.IsBackground = true;
                busy = true;
                if (rb_fast.Checked)
                {
                    runcount = 1;
                    Tfill.Start();
                }
                else if (rb_normal.Checked)
                {
                    runcount = 2;
                    Tfill.Start();
                }
                else if (rb_deep.Checked)
                {
                    runcount = 3;
                    Tfill.Start();
                }
                else if (rb_smart.Checked)
                {
                    runcount = 1;
                    Tfill.Start();
                }
                rb_fast.Enabled = false;
                rb_normal.Enabled = false;
                rb_deep.Enabled = false;
                rb_smart.Enabled = false;
            }
            else
            {

                if (Tfill != null && Tfill.IsAlive)
                {
                    Tfill.Abort();
                }
                Clear();
                lbl_ramBefore_data.Text = "";
                lbl_ramAfter_data.Text = "";
                lbl_cleanedRam_data.Text = "";
                lbl_finishDate_data.Text = "";
                lbl_elapsedTime_data.Text = "";
                lbl_startDate_data.Text = "";
                lbl_ramAfter_data.Text = "";
                lbl_cleanedRam_data.Text = "";
                lbl_finishDate_data.Text = "";
                lbl_elapsedTime_data.Text = "";
                rb_fast.Enabled = true;
                rb_normal.Enabled = true;
                rb_deep.Enabled = true;
                rb_smart.Enabled = true;
                lbl_smart.Visible = false;
                this.UseWaitCursor = false;
            }
        }

        private void PrgColor(ProgressBar prg)
        {
            int[] prgColor = { 0, 0, 0 };

            prgColor[0] = (int)(prg.Value * 2.5d);
            prgColor[1] = 255 - prgColor[0];
            this.Invoke((MethodInvoker)delegate
            {
                prg.ForeColor = Color.FromArgb(prgColor[0], prgColor[1], prgColor[2]);
            });
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetRamStats()
        {
            while (true)
            {
                total = PerformanceInfo.GetTotalMemoryInMiB();
                free = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
                used = total - free;
                ShowRamStats();
                estimated = TimeSpan.FromMilliseconds(free * 1.1 + (total - free) * 11 + 1000);
                Thread.Sleep(100);
            }
        }

        private void ShowRamStats()
        {
            this.Invoke((MethodInvoker)delegate
            {
                prg_ramUsage.Value = (int)((double)used / total * 100);
                tbl_01.Text = free.ToString() + " MB";
                tbl_11.Text = used.ToString() + " MB";
                tbl_21.Text = total.ToString() + " MB";
                tbl_02.Text = (Math.Round((double)free / total * 100)).ToString() + " %";
                tbl_12.Text = (Math.Round((double)used / total * 100)).ToString() + " %";
                tbl_22.Text = (Math.Round((double)total / total * 100)).ToString() + " %";
                if (!busy)
                {
                    lbl_estimatedFast.Text = "(~" + estimated.ToString().Substring(3, 5) + ")";
                    lbl_estimatedNormal.Text = "(~" + (estimated + estimated + (TimeSpan.FromSeconds(1))).ToString().Substring(3, 5) + ")";
                    lbl_estimatedDeep.Text = "(~" + (estimated + estimated + estimated + (TimeSpan.FromSeconds(1))).ToString().Substring(3, 5) + ")";
                }
            });
            PrgColor(prg_ramUsage);
        }
    }
}
