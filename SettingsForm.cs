using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace de.mastersign.mapmap
{
    public partial class SettingsForm : Form
    {
        private Bitmap bitmap;
        private bool initializing;
        private bool automatic;
        private bool canceled;

        public SettingsForm(CaptureSettings cs)
        {
            InitializeComponent();
            if (Screen.AllScreens.Length > 1)
            {
                numPrestartWaitTime.Value = 0.1M;
            }
            Initialize(cs);
        }

        private void ValueChangeHandler(object sender, EventArgs e)
        {
            if (initializing) return;
            var dr = DragRegion;
            var tr = TileRegion;
            var s = TotalSize;
            lblDragRegionSize.Text = string.Format("{0} x {1} px",
                dr.Width, dr.Height);
            lblCaptureRegionSize.Text = string.Format("{0} x {1} px",
                tr.Width, tr.Height);
            lblDragSteps.Text = string.Format("{0} x {1}",
                MouseDragStepsX.Count(), MouseDragStepsY.Count());
            lblTotalSize.Text = string.Format("{0} x {1} px",
                s.Width, s.Height);

            if (radMouseControl.Checked)
            {
                var totalTime = new TimeSpan(0, 0, 0, (int)Math.Ceiling(
                    ((TilesX * TilesY * TileWaitTime) +
                     ((TilesX - 1) * 2 * (TilesY - 1) * MouseDragStepsX.Count() +
                      (TilesY - 1) * MouseDragStepsY.Count()) * DragStepTime +
                     PrestartWaitTime + StartWaitTime)
                    / 1000.0));
                lblTotalTime.Text = totalTime.ToString(@"h\:mm\:ss");
            }
            if (radKeyboardControl.Checked)
            {
                var totalTime = new TimeSpan(0, 0, 0, (int)Math.Ceiling(
                    ((TilesX * TilesY * TileWaitTime) +
                     ((TilesX - 1) * 2 * (TilesY - 1) * KeyboardDragStepsX +
                      (TilesY - 1) * KeyboardDragStepsY) * DragStepTime +
                     PrestartWaitTime + StartWaitTime)
                    / 1000.0));
                lblTotalTime.Text = totalTime.ToString(@"h\:mm\:ss");
            }

            lblDragRegion.Enabled = radMouseControl.Checked;
            numDragDistTop.Enabled = radMouseControl.Checked;
            numDragDistRight.Enabled = radMouseControl.Checked;
            numDragDistBottom.Enabled = radMouseControl.Checked;
            numDragDistLeft.Enabled = radMouseControl.Checked;
            lblDragStepSize.Enabled = radMouseControl.Checked;
            numDragStepSize.Enabled = radMouseControl.Checked;

            lblKeyStepX.Enabled = radKeyboardControl.Checked;
            numKeyStepX.Enabled = radKeyboardControl.Checked;
            lblKeyStepY.Enabled = radKeyboardControl.Checked;
            numKeyStepY.Enabled = radKeyboardControl.Checked;
        }

        private void Initialize(CaptureSettings ss)
        {
            initializing = true;
            if (ss.CaptureRegionTop.HasValue) numCapDistTop.Value = ss.CaptureRegionTop.Value;
            if (ss.CaptureRegionRight.HasValue) numCapDistRight.Value = ss.CaptureRegionRight.Value;
            if (ss.CaptureRegionBottom.HasValue) numCapDistBottom.Value = ss.CaptureRegionBottom.Value;
            if (ss.CaptureRegionLeft.HasValue) numCapDistLeft.Value = ss.CaptureRegionLeft.Value;
            if (ss.TilesX.HasValue) numTilesX.Value = ss.TilesX.Value;
            if (ss.TilesY.HasValue) numTilesY.Value = ss.TilesY.Value;
            if (ss.ControlMode.HasValue)
            {
                switch (ss.ControlMode.Value)
                {
                    case CaptureSettings.ControlModes.Mouse:
                        radMouseControl.Checked = true;
                        break;
                    case CaptureSettings.ControlModes.Keyboard:
                        radKeyboardControl.Checked = true;
                        break;
                }
            }
            if (ss.MouseDragRegionTop.HasValue) numDragDistTop.Value = ss.MouseDragRegionTop.Value;
            if (ss.MouseDragRegionRight.HasValue) numDragDistRight.Value = ss.MouseDragRegionRight.Value;
            if (ss.MouseDragRegionBottom.HasValue) numDragDistBottom.Value = ss.MouseDragRegionBottom.Value;
            if (ss.MouseDragRegionLeft.HasValue) numDragDistLeft.Value = ss.MouseDragRegionLeft.Value;
            if (ss.MouseDragStepSize.HasValue) numDragStepSize.Value = ss.MouseDragStepSize.Value;
            if (ss.KeyboardStepSizeX.HasValue) numKeyStepX.Value = ss.KeyboardStepSizeX.Value;
            if (ss.KeyboardStepSizeY.HasValue) numKeyStepY.Value = ss.KeyboardStepSizeY.Value;
            if (ss.TileWaitTime.HasValue) numTileWaitTime.Value = ss.TileWaitTime.Value;
            if (ss.StepWaitTime.HasValue) numStepWaitTime.Value = ss.StepWaitTime.Value;
            if (ss.PrestartWaitTime.HasValue) numPrestartWaitTime.Value = ss.PrestartWaitTime.Value;
            if (ss.StartWaitTime.HasValue) numStartWaitTime.Value = ss.StartWaitTime.Value;
            if (ss.ReturnToStart.HasValue) chkReturnToStart.Checked = ss.ReturnToStart.Value;
            if (ss.Automatic.HasValue) automatic = ss.Automatic.Value;
            initializing = false;
            ValueChangeHandler(this, EventArgs.Empty);

            if (automatic)
            {
                RunAutomatic();   
            }
        }

        private CaptureSettings BuildCaptureSettings()
        {
            var cs = new CaptureSettings
            {
                CaptureRegionTop = (int)numCapDistTop.Value,
                CaptureRegionRight = (int)numCapDistRight.Value,
                CaptureRegionBottom = (int)numCapDistBottom.Value,
                CaptureRegionLeft = (int)numCapDistLeft.Value,
                TilesX = (int)numTilesX.Value,
                TilesY = (int)numTilesY.Value,
                ControlMode = radKeyboardControl.Checked ? CaptureSettings.ControlModes.Keyboard : CaptureSettings.ControlModes.Mouse,
                MouseDragRegionTop = (int)numDragDistTop.Value,
                MouseDragRegionRight = (int)numDragDistRight.Value,
                MouseDragRegionBottom = (int)numDragDistBottom.Value,
                MouseDragRegionLeft = (int)numDragDistLeft.Value,
                MouseDragStepSize = (int)numDragStepSize.Value,
                KeyboardStepSizeX = (int)numKeyStepX.Value,
                KeyboardStepSizeY = (int)numKeyStepY.Value,
                TileWaitTime = numTileWaitTime.Value,
                StepWaitTime = numStepWaitTime.Value,
                PrestartWaitTime = numPrestartWaitTime.Value,
                StartWaitTime = numStartWaitTime.Value,
                ReturnToStart = chkReturnToStart.Checked,
            };
            return cs;
        }

        private Rectangle ScreenRegion
        {
            get { return Screen.PrimaryScreen.WorkingArea; }
        }

        private Rectangle DragRegion
        {
            get
            {
                if (radMouseControl.Checked)
                {
                    var sr = ScreenRegion;
                    return new Rectangle(
                        sr.Left + (int)numDragDistLeft.Value,
                        sr.Top + (int)numDragDistTop.Value,
                        sr.Width - (int)numDragDistLeft.Value - (int)numDragDistRight.Value,
                        sr.Height - (int)numDragDistTop.Value - (int)numDragDistBottom.Value);
                }
                if (radKeyboardControl.Checked)
                {
                    var tr = TileRegion;
                    return new Rectangle(
                        tr.Location,
                        new Size(
                            KeyboardDragStepsX * KeyboardDragStepX,
                            KeyboardDragStepsY * KeyboardDragStepY));
                }
                throw new NotSupportedException();
            }
        }

        private IEnumerable<int> MouseDragSteps(int length)
        {
            var s = (int)numDragStepSize.Value;
            var p = 0;
            do
            {
                var d = Math.Max(0, Math.Min(s, length - p));
                if (d > 0) yield return d;
                p += d;
            } while (p < length);
        }

        private IEnumerable<int> MouseDragStepsX { get { return MouseDragSteps(DragRegion.Width); } }

        private IEnumerable<int> MouseDragStepsY { get { return MouseDragSteps(DragRegion.Height); } }

        private int KeyboardDragStepX { get { return (int)numKeyStepX.Value; } }

        private int KeyboardDragStepsX { get { return TileRegion.Width / KeyboardDragStepX; } }

        private int KeyboardDragStepY { get { return (int)numKeyStepY.Value; } }

        private int KeyboardDragStepsY { get { return TileRegion.Height / KeyboardDragStepY; } }

        private int DragStepTime { get { return (int)(numStepWaitTime.Value * 1000); } }

        private int TilesX { get { return (int)numTilesX.Value; } }

        private int TilesY { get { return (int)numTilesY.Value; } }

        private Rectangle TileRegion
        {
            get
            {
                var sr = ScreenRegion;
                return new Rectangle(
                    sr.Left + (int)numCapDistLeft.Value,
                    sr.Top + (int)numCapDistTop.Value,
                    sr.Width - (int)numCapDistLeft.Value - (int)numCapDistRight.Value,
                    sr.Height - (int)numCapDistTop.Value - (int)numCapDistBottom.Value);
            }
        }

        private int TileWaitTime { get { return (int)(numTileWaitTime.Value * 1000); } }

        private int PrestartWaitTime { get { return (int)(numPrestartWaitTime.Value * 1000); } }

        private int StartWaitTime { get { return (int)(numStartWaitTime.Value * 1000); } }

        private Size TotalSize
        {
            get
            {
                var tr = TileRegion;
                var dr = DragRegion;
                return new Size(
                    tr.Width + dr.Width * (TilesX - 1),
                    tr.Height + dr.Height * (TilesY - 1));
            }
        }

        private void DragX(bool reverse = true)
        {
            var dr = DragRegion;
            var y = dr.Top + dr.Height / 2;
            Application.DoEvents();
            if (radMouseControl.Checked)
            {
                Cursor.Position = new Point(reverse ? dr.Right : dr.Left, y);
                MouseController.MouseDown();
                foreach (var sx in MouseDragStepsX)
                {
                    var d = sx * (reverse ? -1 : 1);
                    Cursor.Position = new Point(Cursor.Position.X + d, y);
                    Thread.Sleep(DragStepTime);
                    if (IsCanceled) break;
                }
                MouseController.MouseUp();
            }
            else if (radKeyboardControl.Checked)
            {
                for (var i = 0; i < KeyboardDragStepsX; i++)
                {
                    SendKeys.SendWait(reverse ? "{RIGHT}" : "{LEFT}");
                    Thread.Sleep(DragStepTime);
                    if (IsCanceled) break;
                }
            }
        }

        private void DragY(bool reverse = true)
        {
            var dr = DragRegion;
            var x = dr.Left + dr.Width / 2;
            Application.DoEvents();
            if (radMouseControl.Checked)
            {
                Cursor.Position = new Point(x, reverse ? dr.Bottom : dr.Top);
                MouseController.MouseDown();
                foreach (var sy in MouseDragStepsY)
                {
                    var d = sy * (reverse ? -1 : 1);
                    Cursor.Position = new Point(x, Cursor.Position.Y + d);
                    Thread.Sleep(DragStepTime);
                    if (IsCanceled) break;
                }
                MouseController.MouseUp();
            }
            else if (radKeyboardControl.Checked)
            {
                for (var i = 0; i < KeyboardDragStepsY; i++)
                {
                    SendKeys.SendWait(reverse ? "{DOWN}" : "{UP}");
                    Thread.Sleep(DragStepTime);
                    if (IsCanceled) break;
                }
            }
        }

        private void CaptureMapRegion(Bitmap bmp, int x, int y)
        {
            if (bmp == null) return;
            var tr = TileRegion;
            using (var g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(tr.Left, tr.Top, x, y, tr.Size);
            }
        }

        private void UpdatePreview(Bitmap bmp)
        {
            pictureBox.Image = bmp;
            Application.DoEvents();
        }

        private bool IsCanceled
        {
            get
            {
                if (ModifierKeys == Keys.Alt)
                {
                    canceled = true;
                }
                return canceled;
            }
        }

        private void RunAutomatic()
        {
            Visible = false;
            btnStart_Click(btnStart, EventArgs.Empty);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            canceled = false;
            btnStart.Enabled = false;
            var dr = DragRegion;
            var s = TotalSize;
            var bmp = new Bitmap(s.Width, s.Height, PixelFormat.Format24bppRgb);
            UpdatePreview(bmp);
            pictureBox.ViewFit();
            Application.DoEvents();
            Thread.Sleep(PrestartWaitTime);
            Application.DoEvents();
            if (!IsCanceled)
            {
                Cursor.Position = new Point(dr.X + dr.Width / 2, dr.Y + dr.Height / 2);
                MouseController.Click();
                Application.DoEvents();
                Thread.Sleep(StartWaitTime);
                Application.DoEvents();
                if (!IsCanceled)
                {

                    var reverse = true;
                    for (var ty = 0; ty < TilesY; ty++)
                    {
                        var py = ty * dr.Height;
                        for (var tx = 0; tx < TilesX; tx++)
                        {
                            var px = reverse ? tx * dr.Width : (TilesX - 1 - tx) * dr.Width;
                            Thread.Sleep(TileWaitTime);

                            if (IsCanceled) break;

                            CaptureMapRegion(bmp, px, py);
                            if (!automatic)
                            {
                                UpdatePreview(bmp);
                            }
                            if (tx == TilesX - 1) continue;
                            DragX(reverse);

                            if (IsCanceled) break;
                        }
                        if (IsCanceled) break;

                        reverse = !reverse;
                        if (ty == TilesY - 1) continue;
                        DragY();

                        if (IsCanceled) break;
                    }

                    if (chkReturnToStart.Checked)
                    {
                        if (TilesY % 2 == 1)
                        {
                            for (var tx = 0; tx < TilesX - 1; tx++)
                            {
                                DragX(false);
                            }
                        }
                        for (var ty = 0; ty < TilesY - 1; ty++)
                        {
                            DragY(false);
                        }
                    }

                    bitmap = bmp;
                    UpdatePreview(bitmap);
                    btnSave.Enabled = true;
                }
            }
            btnStart.Enabled = true;
            Visible = true;
            Activate();
            if (canceled)
            {
                MessageBox.Show(this,
                    "The capturing was interrupted by the user. The result is incomplete.",
                    "Captureing canceled",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bitmap == null) return;
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mastersign/MapMap/blob/master/README.md");
        }

        private void btnCreateShortcut_Click(object sender, EventArgs e)
        {
            var cs = BuildCaptureSettings();
            if (MessageBox.Show(this, 
                    "Would you activate the automatic start for the shortcut?", 
                    "Automatic start",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                cs.Automatic = true;
            }

            var sfdlg = new SaveFileDialog();
            sfdlg.Title = "Create shortcut...";
            sfdlg.Filter = "Shortcut|*.lnk";
            sfdlg.DefaultExt = "lnk";
            sfdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfdlg.FileName = "MapMap";
            if (sfdlg.ShowDialog(this) == DialogResult.OK)
            {
                var shortcut = new ShellShortcut(sfdlg.FileName);
                shortcut.Path = Application.ExecutablePath;
                shortcut.IconPath = Application.ExecutablePath;
                shortcut.IconIndex = 0;
                shortcut.Arguments = cs.BuildCommandLineArguments();
                shortcut.Save();
            }
        }
    }
}
