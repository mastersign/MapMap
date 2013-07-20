using System.Diagnostics;
using System.Security.AccessControl;
using de.mastersign.controls;

namespace MapMap
{
    partial class SettingsForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.numTilesX = new System.Windows.Forms.NumericUpDown();
            this.numTilesY = new System.Windows.Forms.NumericUpDown();
            this.lblTilesX = new System.Windows.Forms.Label();
            this.lblTilesY = new System.Windows.Forms.Label();
            this.numDragDistLeft = new System.Windows.Forms.NumericUpDown();
            this.lblDragRegion = new System.Windows.Forms.Label();
            this.numDragDistTop = new System.Windows.Forms.NumericUpDown();
            this.numDragDistRight = new System.Windows.Forms.NumericUpDown();
            this.numDragDistBottom = new System.Windows.Forms.NumericUpDown();
            this.lblDragRegionRect = new System.Windows.Forms.Label();
            this.numDragStepSize = new System.Windows.Forms.NumericUpDown();
            this.lblDragStepSize = new System.Windows.Forms.Label();
            this.lblDragStepTime = new System.Windows.Forms.Label();
            this.numDragStepTime = new System.Windows.Forms.NumericUpDown();
            this.numTileWaitTime = new System.Windows.Forms.NumericUpDown();
            this.lblTileWaitTime = new System.Windows.Forms.Label();
            this.numCapDistBottom = new System.Windows.Forms.NumericUpDown();
            this.numCapDistTop = new System.Windows.Forms.NumericUpDown();
            this.numCapDistRight = new System.Windows.Forms.NumericUpDown();
            this.numCapDistLeft = new System.Windows.Forms.NumericUpDown();
            this.lblCaptureRegion = new System.Windows.Forms.Label();
            this.lblCaptureRegionRect = new System.Windows.Forms.Label();
            this.lblDragRegionSizeLabel = new System.Windows.Forms.Label();
            this.lblDragRegionSize = new System.Windows.Forms.Label();
            this.lblCaptureRegionSizeLabel = new System.Windows.Forms.Label();
            this.lblCaptureRegionSize = new System.Windows.Forms.Label();
            this.lblDragStepsLabel = new System.Windows.Forms.Label();
            this.lblDragSteps = new System.Windows.Forms.Label();
            this.lblTotalTimeLabel = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblTotalSizeLabel = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblStartWaitTime1 = new System.Windows.Forms.Label();
            this.numStartWaitTime1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new de.mastersign.controls.ZoomPictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radMouseControl = new System.Windows.Forms.RadioButton();
            this.radKeyboardControl = new System.Windows.Forms.RadioButton();
            this.numKeyStepX = new System.Windows.Forms.NumericUpDown();
            this.numKeyStepY = new System.Windows.Forms.NumericUpDown();
            this.lblKeyStepX = new System.Windows.Forms.Label();
            this.lblKeyStepY = new System.Windows.Forms.Label();
            this.lblStartWaitTime2 = new System.Windows.Forms.Label();
            this.numStartWaitTime2 = new System.Windows.Forms.NumericUpDown();
            this.chkReturnToStart = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTilesX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTilesY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragStepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragStepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTileWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWaitTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyStepX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyStepY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWaitTime2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(551, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numTilesX
            // 
            this.numTilesX.Location = new System.Drawing.Point(114, 90);
            this.numTilesX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTilesX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTilesX.Name = "numTilesX";
            this.numTilesX.Size = new System.Drawing.Size(56, 20);
            this.numTilesX.TabIndex = 1;
            this.numTilesX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTilesX.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numTilesY
            // 
            this.numTilesY.Location = new System.Drawing.Point(114, 114);
            this.numTilesY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTilesY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTilesY.Name = "numTilesY";
            this.numTilesY.Size = new System.Drawing.Size(56, 20);
            this.numTilesY.TabIndex = 2;
            this.numTilesY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTilesY.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // lblTilesX
            // 
            this.lblTilesX.AutoSize = true;
            this.lblTilesX.Location = new System.Drawing.Point(12, 92);
            this.lblTilesX.Name = "lblTilesX";
            this.lblTilesX.Size = new System.Drawing.Size(56, 13);
            this.lblTilesX.TabIndex = 3;
            this.lblTilesX.Text = "Tiles (hor.)";
            // 
            // lblTilesY
            // 
            this.lblTilesY.AutoSize = true;
            this.lblTilesY.Location = new System.Drawing.Point(12, 116);
            this.lblTilesY.Name = "lblTilesY";
            this.lblTilesY.Size = new System.Drawing.Size(59, 13);
            this.lblTilesY.TabIndex = 3;
            this.lblTilesY.Text = "Tiles (vert.)";
            // 
            // numDragDistLeft
            // 
            this.numDragDistLeft.Location = new System.Drawing.Point(83, 199);
            this.numDragDistLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDragDistLeft.Name = "numDragDistLeft";
            this.numDragDistLeft.Size = new System.Drawing.Size(56, 20);
            this.numDragDistLeft.TabIndex = 5;
            this.numDragDistLeft.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDragDistLeft.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // lblDragRegion
            // 
            this.lblDragRegion.AutoSize = true;
            this.lblDragRegion.Location = new System.Drawing.Point(12, 175);
            this.lblDragRegion.Name = "lblDragRegion";
            this.lblDragRegion.Size = new System.Drawing.Size(67, 13);
            this.lblDragRegion.TabIndex = 3;
            this.lblDragRegion.Text = "Drag Region";
            // 
            // numDragDistTop
            // 
            this.numDragDistTop.Location = new System.Drawing.Point(114, 173);
            this.numDragDistTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDragDistTop.Name = "numDragDistTop";
            this.numDragDistTop.Size = new System.Drawing.Size(56, 20);
            this.numDragDistTop.TabIndex = 5;
            this.numDragDistTop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDragDistTop.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numDragDistRight
            // 
            this.numDragDistRight.Location = new System.Drawing.Point(145, 199);
            this.numDragDistRight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDragDistRight.Name = "numDragDistRight";
            this.numDragDistRight.Size = new System.Drawing.Size(56, 20);
            this.numDragDistRight.TabIndex = 5;
            this.numDragDistRight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDragDistRight.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numDragDistBottom
            // 
            this.numDragDistBottom.Location = new System.Drawing.Point(114, 225);
            this.numDragDistBottom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDragDistBottom.Name = "numDragDistBottom";
            this.numDragDistBottom.Size = new System.Drawing.Size(56, 20);
            this.numDragDistBottom.TabIndex = 5;
            this.numDragDistBottom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDragDistBottom.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // lblDragRegionRect
            // 
            this.lblDragRegionRect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDragRegionRect.Location = new System.Drawing.Point(98, 183);
            this.lblDragRegionRect.Name = "lblDragRegionRect";
            this.lblDragRegionRect.Size = new System.Drawing.Size(89, 53);
            this.lblDragRegionRect.TabIndex = 6;
            // 
            // numDragStepSize
            // 
            this.numDragStepSize.Location = new System.Drawing.Point(114, 251);
            this.numDragStepSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDragStepSize.Name = "numDragStepSize";
            this.numDragStepSize.Size = new System.Drawing.Size(56, 20);
            this.numDragStepSize.TabIndex = 7;
            this.numDragStepSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numDragStepSize.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // lblDragStepSize
            // 
            this.lblDragStepSize.AutoSize = true;
            this.lblDragStepSize.Location = new System.Drawing.Point(12, 253);
            this.lblDragStepSize.Name = "lblDragStepSize";
            this.lblDragStepSize.Size = new System.Drawing.Size(47, 13);
            this.lblDragStepSize.TabIndex = 3;
            this.lblDragStepSize.Text = "Stepsize";
            // 
            // lblDragStepTime
            // 
            this.lblDragStepTime.AutoSize = true;
            this.lblDragStepTime.Location = new System.Drawing.Point(12, 394);
            this.lblDragStepTime.Name = "lblDragStepTime";
            this.lblDragStepTime.Size = new System.Drawing.Size(59, 13);
            this.lblDragStepTime.TabIndex = 3;
            this.lblDragStepTime.Text = "Step Delay";
            // 
            // numDragStepTime
            // 
            this.numDragStepTime.DecimalPlaces = 3;
            this.numDragStepTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numDragStepTime.Location = new System.Drawing.Point(114, 392);
            this.numDragStepTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDragStepTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numDragStepTime.Name = "numDragStepTime";
            this.numDragStepTime.Size = new System.Drawing.Size(56, 20);
            this.numDragStepTime.TabIndex = 7;
            this.numDragStepTime.Value = new decimal(new int[] {
            33,
            0,
            0,
            196608});
            this.numDragStepTime.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numTileWaitTime
            // 
            this.numTileWaitTime.DecimalPlaces = 3;
            this.numTileWaitTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numTileWaitTime.Location = new System.Drawing.Point(114, 368);
            this.numTileWaitTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTileWaitTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numTileWaitTime.Name = "numTileWaitTime";
            this.numTileWaitTime.Size = new System.Drawing.Size(56, 20);
            this.numTileWaitTime.TabIndex = 7;
            this.numTileWaitTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTileWaitTime.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // lblTileWaitTime
            // 
            this.lblTileWaitTime.AutoSize = true;
            this.lblTileWaitTime.Location = new System.Drawing.Point(12, 370);
            this.lblTileWaitTime.Name = "lblTileWaitTime";
            this.lblTileWaitTime.Size = new System.Drawing.Size(54, 13);
            this.lblTileWaitTime.TabIndex = 3;
            this.lblTileWaitTime.Text = "Tile Delay";
            // 
            // numCapDistBottom
            // 
            this.numCapDistBottom.Location = new System.Drawing.Point(114, 64);
            this.numCapDistBottom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCapDistBottom.Name = "numCapDistBottom";
            this.numCapDistBottom.Size = new System.Drawing.Size(56, 20);
            this.numCapDistBottom.TabIndex = 9;
            this.numCapDistBottom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCapDistBottom.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numCapDistTop
            // 
            this.numCapDistTop.Location = new System.Drawing.Point(114, 12);
            this.numCapDistTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCapDistTop.Name = "numCapDistTop";
            this.numCapDistTop.Size = new System.Drawing.Size(56, 20);
            this.numCapDistTop.TabIndex = 10;
            this.numCapDistTop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCapDistTop.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numCapDistRight
            // 
            this.numCapDistRight.Location = new System.Drawing.Point(145, 38);
            this.numCapDistRight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCapDistRight.Name = "numCapDistRight";
            this.numCapDistRight.Size = new System.Drawing.Size(56, 20);
            this.numCapDistRight.TabIndex = 11;
            this.numCapDistRight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCapDistRight.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numCapDistLeft
            // 
            this.numCapDistLeft.Location = new System.Drawing.Point(83, 38);
            this.numCapDistLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCapDistLeft.Name = "numCapDistLeft";
            this.numCapDistLeft.Size = new System.Drawing.Size(56, 20);
            this.numCapDistLeft.TabIndex = 12;
            this.numCapDistLeft.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCapDistLeft.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // lblCaptureRegion
            // 
            this.lblCaptureRegion.AutoSize = true;
            this.lblCaptureRegion.Location = new System.Drawing.Point(12, 14);
            this.lblCaptureRegion.Name = "lblCaptureRegion";
            this.lblCaptureRegion.Size = new System.Drawing.Size(81, 13);
            this.lblCaptureRegion.TabIndex = 8;
            this.lblCaptureRegion.Text = "Capture Region";
            // 
            // lblCaptureRegionRect
            // 
            this.lblCaptureRegionRect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCaptureRegionRect.Location = new System.Drawing.Point(98, 22);
            this.lblCaptureRegionRect.Name = "lblCaptureRegionRect";
            this.lblCaptureRegionRect.Size = new System.Drawing.Size(89, 53);
            this.lblCaptureRegionRect.TabIndex = 13;
            // 
            // lblDragRegionSizeLabel
            // 
            this.lblDragRegionSizeLabel.AutoSize = true;
            this.lblDragRegionSizeLabel.Location = new System.Drawing.Point(214, 33);
            this.lblDragRegionSizeLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblDragRegionSizeLabel.Name = "lblDragRegionSizeLabel";
            this.lblDragRegionSizeLabel.Size = new System.Drawing.Size(70, 13);
            this.lblDragRegionSizeLabel.TabIndex = 14;
            this.lblDragRegionSizeLabel.Text = "Drag Region:";
            // 
            // lblDragRegionSize
            // 
            this.lblDragRegionSize.AutoSize = true;
            this.lblDragRegionSize.Location = new System.Drawing.Point(297, 33);
            this.lblDragRegionSize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblDragRegionSize.Name = "lblDragRegionSize";
            this.lblDragRegionSize.Size = new System.Drawing.Size(44, 13);
            this.lblDragRegionSize.TabIndex = 15;
            this.lblDragRegionSize.Text = "0 x 0 px";
            // 
            // lblCaptureRegionSizeLabel
            // 
            this.lblCaptureRegionSizeLabel.AutoSize = true;
            this.lblCaptureRegionSizeLabel.Location = new System.Drawing.Point(214, 14);
            this.lblCaptureRegionSizeLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblCaptureRegionSizeLabel.Name = "lblCaptureRegionSizeLabel";
            this.lblCaptureRegionSizeLabel.Size = new System.Drawing.Size(84, 13);
            this.lblCaptureRegionSizeLabel.TabIndex = 14;
            this.lblCaptureRegionSizeLabel.Text = "Capture Region:";
            // 
            // lblCaptureRegionSize
            // 
            this.lblCaptureRegionSize.AutoSize = true;
            this.lblCaptureRegionSize.Location = new System.Drawing.Point(297, 14);
            this.lblCaptureRegionSize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblCaptureRegionSize.Name = "lblCaptureRegionSize";
            this.lblCaptureRegionSize.Size = new System.Drawing.Size(44, 13);
            this.lblCaptureRegionSize.TabIndex = 15;
            this.lblCaptureRegionSize.Text = "0 x 0 px";
            // 
            // lblDragStepsLabel
            // 
            this.lblDragStepsLabel.AutoSize = true;
            this.lblDragStepsLabel.Location = new System.Drawing.Point(214, 52);
            this.lblDragStepsLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblDragStepsLabel.Name = "lblDragStepsLabel";
            this.lblDragStepsLabel.Size = new System.Drawing.Size(65, 13);
            this.lblDragStepsLabel.TabIndex = 14;
            this.lblDragStepsLabel.Text = "Steps/Drag:";
            // 
            // lblDragSteps
            // 
            this.lblDragSteps.AutoSize = true;
            this.lblDragSteps.Location = new System.Drawing.Point(297, 52);
            this.lblDragSteps.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblDragSteps.Name = "lblDragSteps";
            this.lblDragSteps.Size = new System.Drawing.Size(30, 13);
            this.lblDragSteps.TabIndex = 15;
            this.lblDragSteps.Text = "0 x 0";
            // 
            // lblTotalTimeLabel
            // 
            this.lblTotalTimeLabel.AutoSize = true;
            this.lblTotalTimeLabel.Location = new System.Drawing.Point(379, 33);
            this.lblTotalTimeLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblTotalTimeLabel.Name = "lblTotalTimeLabel";
            this.lblTotalTimeLabel.Size = new System.Drawing.Size(60, 13);
            this.lblTotalTimeLabel.TabIndex = 14;
            this.lblTotalTimeLabel.Text = "Total Time:";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(452, 33);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(43, 13);
            this.lblTotalTime.TabIndex = 15;
            this.lblTotalTime.Text = "0:00:00";
            // 
            // lblTotalSizeLabel
            // 
            this.lblTotalSizeLabel.AutoSize = true;
            this.lblTotalSizeLabel.Location = new System.Drawing.Point(379, 14);
            this.lblTotalSizeLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblTotalSizeLabel.Name = "lblTotalSizeLabel";
            this.lblTotalSizeLabel.Size = new System.Drawing.Size(57, 13);
            this.lblTotalSizeLabel.TabIndex = 14;
            this.lblTotalSizeLabel.Text = "Total Size:";
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(452, 14);
            this.lblTotalSize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(44, 13);
            this.lblTotalSize.TabIndex = 15;
            this.lblTotalSize.Text = "0 x 0 px";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.Filter = "PNG Bilddatei (*.png)|*.png";
            // 
            // lblStartWaitTime1
            // 
            this.lblStartWaitTime1.AutoSize = true;
            this.lblStartWaitTime1.Location = new System.Drawing.Point(12, 418);
            this.lblStartWaitTime1.Name = "lblStartWaitTime1";
            this.lblStartWaitTime1.Size = new System.Drawing.Size(73, 13);
            this.lblStartWaitTime1.TabIndex = 3;
            this.lblStartWaitTime1.Text = "Prestart Delay";
            // 
            // numStartWaitTime1
            // 
            this.numStartWaitTime1.DecimalPlaces = 3;
            this.numStartWaitTime1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numStartWaitTime1.Location = new System.Drawing.Point(114, 416);
            this.numStartWaitTime1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numStartWaitTime1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numStartWaitTime1.Name = "numStartWaitTime1";
            this.numStartWaitTime1.Size = new System.Drawing.Size(56, 20);
            this.numStartWaitTime1.TabIndex = 7;
            this.numStartWaitTime1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numStartWaitTime1.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // pictureBox
            // 
            this.pictureBox.AllowLineSelection = false;
            this.pictureBox.AllwaysShowOverlay = false;
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.ButtonBack1 = System.Drawing.SystemColors.Control;
            this.pictureBox.ButtonBack2 = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.ButtonBackDisabled1 = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.ButtonBackDisabled2 = System.Drawing.SystemColors.Control;
            this.pictureBox.ButtonBackHover1 = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.ButtonBackHover2 = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.ButtonBackSwitched1 = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.ButtonBackSwitched2 = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.ButtonBorder = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.ButtonBorderDisabled = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.ButtonBorderHover = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox.ButtonBorderSwitched = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox.Image = null;
            this.pictureBox.ImageOffset = ((System.Drawing.PointF)(resources.GetObject("pictureBox.ImageOffset")));
            this.pictureBox.InfoBackgroundColor = System.Drawing.SystemColors.Window;
            this.pictureBox.InfoForegroundColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pictureBox.IsBoundToMaster = false;
            this.pictureBox.Location = new System.Drawing.Point(217, 75);
            this.pictureBox.Master = null;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.OrientationBackgroundColor = System.Drawing.SystemColors.Window;
            this.pictureBox.OrientationForegroundColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox.Overlay = de.mastersign.controls.ZoomPictureBox.OverlayMode.Compass;
            this.pictureBox.Rotation = 0F;
            this.pictureBox.ShowMeasureTools = false;
            this.pictureBox.ShowRotationTools = true;
            this.pictureBox.ShowSelectionTools = false;
            this.pictureBox.ShowZoomLevelTools = true;
            this.pictureBox.Size = new System.Drawing.Size(414, 385);
            this.pictureBox.SuppressInterpolation = true;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.WaitAnimationInterval = 50;
            this.pictureBox.WaitingAnimation = false;
            this.pictureBox.WaitingAnimationBlend = false;
            this.pictureBox.Zoom = 0F;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(551, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radMouseControl
            // 
            this.radMouseControl.AutoSize = true;
            this.radMouseControl.Location = new System.Drawing.Point(15, 150);
            this.radMouseControl.Name = "radMouseControl";
            this.radMouseControl.Size = new System.Drawing.Size(93, 17);
            this.radMouseControl.TabIndex = 17;
            this.radMouseControl.Text = "Mouse Control";
            this.radMouseControl.UseVisualStyleBackColor = true;
            this.radMouseControl.CheckedChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // radKeyboardControl
            // 
            this.radKeyboardControl.AutoSize = true;
            this.radKeyboardControl.Checked = true;
            this.radKeyboardControl.Location = new System.Drawing.Point(12, 285);
            this.radKeyboardControl.Name = "radKeyboardControl";
            this.radKeyboardControl.Size = new System.Drawing.Size(106, 17);
            this.radKeyboardControl.TabIndex = 17;
            this.radKeyboardControl.TabStop = true;
            this.radKeyboardControl.Text = "Keyboard Control";
            this.radKeyboardControl.UseVisualStyleBackColor = true;
            this.radKeyboardControl.CheckedChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numKeyStepX
            // 
            this.numKeyStepX.Location = new System.Drawing.Point(114, 308);
            this.numKeyStepX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKeyStepX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKeyStepX.Name = "numKeyStepX";
            this.numKeyStepX.Size = new System.Drawing.Size(56, 20);
            this.numKeyStepX.TabIndex = 1;
            this.numKeyStepX.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numKeyStepX.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // numKeyStepY
            // 
            this.numKeyStepY.Location = new System.Drawing.Point(114, 332);
            this.numKeyStepY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKeyStepY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKeyStepY.Name = "numKeyStepY";
            this.numKeyStepY.Size = new System.Drawing.Size(56, 20);
            this.numKeyStepY.TabIndex = 2;
            this.numKeyStepY.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numKeyStepY.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // lblKeyStepX
            // 
            this.lblKeyStepX.AutoSize = true;
            this.lblKeyStepX.Location = new System.Drawing.Point(12, 310);
            this.lblKeyStepX.Name = "lblKeyStepX";
            this.lblKeyStepX.Size = new System.Drawing.Size(57, 13);
            this.lblKeyStepX.TabIndex = 3;
            this.lblKeyStepX.Text = "Stepsize X";
            // 
            // lblKeyStepY
            // 
            this.lblKeyStepY.AutoSize = true;
            this.lblKeyStepY.Location = new System.Drawing.Point(12, 334);
            this.lblKeyStepY.Name = "lblKeyStepY";
            this.lblKeyStepY.Size = new System.Drawing.Size(57, 13);
            this.lblKeyStepY.TabIndex = 3;
            this.lblKeyStepY.Text = "Stepsize Y";
            // 
            // lblStartWaitTime2
            // 
            this.lblStartWaitTime2.AutoSize = true;
            this.lblStartWaitTime2.Location = new System.Drawing.Point(12, 442);
            this.lblStartWaitTime2.Name = "lblStartWaitTime2";
            this.lblStartWaitTime2.Size = new System.Drawing.Size(59, 13);
            this.lblStartWaitTime2.TabIndex = 3;
            this.lblStartWaitTime2.Text = "Start Delay";
            // 
            // numStartWaitTime2
            // 
            this.numStartWaitTime2.DecimalPlaces = 3;
            this.numStartWaitTime2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numStartWaitTime2.Location = new System.Drawing.Point(114, 440);
            this.numStartWaitTime2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numStartWaitTime2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numStartWaitTime2.Name = "numStartWaitTime2";
            this.numStartWaitTime2.Size = new System.Drawing.Size(56, 20);
            this.numStartWaitTime2.TabIndex = 7;
            this.numStartWaitTime2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numStartWaitTime2.ValueChanged += new System.EventHandler(this.ValueChangeHandler);
            // 
            // chkReturnToStart
            // 
            this.chkReturnToStart.AutoSize = true;
            this.chkReturnToStart.Checked = true;
            this.chkReturnToStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReturnToStart.Location = new System.Drawing.Point(382, 51);
            this.chkReturnToStart.Name = "chkReturnToStart";
            this.chkReturnToStart.Size = new System.Drawing.Size(119, 17);
            this.chkReturnToStart.TabIndex = 18;
            this.chkReturnToStart.Text = "Return to start point";
            this.chkReturnToStart.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 472);
            this.Controls.Add(this.chkReturnToStart);
            this.Controls.Add(this.radKeyboardControl);
            this.Controls.Add(this.radMouseControl);
            this.Controls.Add(this.lblCaptureRegionSize);
            this.Controls.Add(this.lblCaptureRegionSizeLabel);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblTotalSizeLabel);
            this.Controls.Add(this.lblTotalTimeLabel);
            this.Controls.Add(this.lblDragSteps);
            this.Controls.Add(this.lblDragStepsLabel);
            this.Controls.Add(this.lblDragRegionSize);
            this.Controls.Add(this.lblDragRegionSizeLabel);
            this.Controls.Add(this.numCapDistBottom);
            this.Controls.Add(this.numCapDistTop);
            this.Controls.Add(this.numCapDistRight);
            this.Controls.Add(this.numCapDistLeft);
            this.Controls.Add(this.lblCaptureRegion);
            this.Controls.Add(this.lblCaptureRegionRect);
            this.Controls.Add(this.numStartWaitTime2);
            this.Controls.Add(this.numStartWaitTime1);
            this.Controls.Add(this.numTileWaitTime);
            this.Controls.Add(this.numDragStepTime);
            this.Controls.Add(this.numDragStepSize);
            this.Controls.Add(this.numDragDistBottom);
            this.Controls.Add(this.lblStartWaitTime2);
            this.Controls.Add(this.numDragDistTop);
            this.Controls.Add(this.lblStartWaitTime1);
            this.Controls.Add(this.numDragDistRight);
            this.Controls.Add(this.lblTileWaitTime);
            this.Controls.Add(this.lblDragStepTime);
            this.Controls.Add(this.numDragDistLeft);
            this.Controls.Add(this.lblDragStepSize);
            this.Controls.Add(this.lblKeyStepY);
            this.Controls.Add(this.lblTilesY);
            this.Controls.Add(this.lblDragRegion);
            this.Controls.Add(this.lblKeyStepX);
            this.Controls.Add(this.lblTilesX);
            this.Controls.Add(this.numKeyStepY);
            this.Controls.Add(this.numTilesY);
            this.Controls.Add(this.numKeyStepX);
            this.Controls.Add(this.numTilesX);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDragRegionRect);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 510);
            this.Name = "SettingsForm";
            this.Text = "MapMap";
            ((System.ComponentModel.ISupportInitialize)(this.numTilesX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTilesY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragDistBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragStepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDragStepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTileWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapDistLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWaitTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyStepX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyStepY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWaitTime2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numTilesX;
        private System.Windows.Forms.NumericUpDown numTilesY;
        private System.Windows.Forms.Label lblTilesX;
        private System.Windows.Forms.Label lblTilesY;
        private System.Windows.Forms.NumericUpDown numDragDistLeft;
        private System.Windows.Forms.Label lblDragRegion;
        private System.Windows.Forms.NumericUpDown numDragDistTop;
        private System.Windows.Forms.NumericUpDown numDragDistRight;
        private System.Windows.Forms.NumericUpDown numDragDistBottom;
        private System.Windows.Forms.Label lblDragRegionRect;
        private System.Windows.Forms.NumericUpDown numDragStepSize;
        private System.Windows.Forms.Label lblDragStepSize;
        private System.Windows.Forms.Label lblDragStepTime;
        private System.Windows.Forms.NumericUpDown numDragStepTime;
        private System.Windows.Forms.NumericUpDown numTileWaitTime;
        private System.Windows.Forms.Label lblTileWaitTime;
        private System.Windows.Forms.NumericUpDown numCapDistBottom;
        private System.Windows.Forms.NumericUpDown numCapDistTop;
        private System.Windows.Forms.NumericUpDown numCapDistRight;
        private System.Windows.Forms.NumericUpDown numCapDistLeft;
        private System.Windows.Forms.Label lblCaptureRegion;
        private System.Windows.Forms.Label lblCaptureRegionRect;
        private System.Windows.Forms.Label lblDragRegionSizeLabel;
        private System.Windows.Forms.Label lblDragRegionSize;
        private System.Windows.Forms.Label lblCaptureRegionSizeLabel;
        private System.Windows.Forms.Label lblCaptureRegionSize;
        private System.Windows.Forms.Label lblDragStepsLabel;
        private System.Windows.Forms.Label lblDragSteps;
        private System.Windows.Forms.Label lblTotalTimeLabel;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblTotalSizeLabel;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblStartWaitTime1;
        private System.Windows.Forms.NumericUpDown numStartWaitTime1;
        private de.mastersign.controls.ZoomPictureBox pictureBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radMouseControl;
        private System.Windows.Forms.RadioButton radKeyboardControl;
        private System.Windows.Forms.NumericUpDown numKeyStepX;
        private System.Windows.Forms.NumericUpDown numKeyStepY;
        private System.Windows.Forms.Label lblKeyStepX;
        private System.Windows.Forms.Label lblKeyStepY;
        private System.Windows.Forms.Label lblStartWaitTime2;
        private System.Windows.Forms.NumericUpDown numStartWaitTime2;
        private System.Windows.Forms.CheckBox chkReturnToStart;
    }
}

