using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace de.mastersign.mapmap
{
    public class CaptureSettings
    {
        public enum ControlModes { Mouse, Keyboard }

        public int? CaptureRegionTop { get; set; }

        public int? CaptureRegionRight { get; set; }

        public int? CaptureRegionBottom { get; set; }

        public int? CaptureRegionLeft { get; set; }

        public int? TilesX { get; set; }

        public int? TilesY { get; set; }

        public ControlModes? ControlMode { get; set; }

        public int? MouseDragRegionTop { get; set; }

        public int? MouseDragRegionRight { get; set; }

        public int? MouseDragRegionBottom { get; set; }

        public int? MouseDragRegionLeft { get; set; }

        public int? MouseDragStepSize { get; set; }

        public int? KeyboardStepSizeX { get; set; }

        public int? KeyboardStepSizeY { get; set; }

        public decimal? TileWaitTime { get; set; }

        public decimal? StepWaitTime { get; set; }

        public decimal? PrestartWaitTime { get; set; }

        public decimal? StartWaitTime { get; set; }

        public bool? ReturnToStart { get; set; }

        public string TargetPath { get; set; }

        public bool? Automatic { get; set; }

        public CaptureSettings() { }

        public CaptureSettings(string[] args)
        {
            Parse(args);
        }

        private void Parse(string[] args)
        {
            if (args == null || args.Length == 0) return;
            int pOld, p = 0;
            do
            {
                pOld = p;
                p = Parse(args, p);
            } while (p > pOld && p < args.Length);
        }

        private int Parse(string[] args, int pos)
        {
            pos++;
            switch (args[pos - 1])
            {
                case "crt":
                    CaptureRegionTop = ParseInt32(args, ref pos) ?? CaptureRegionTop;
                    break;
                case "crr":
                    CaptureRegionRight = ParseInt32(args, ref pos) ?? CaptureRegionRight;
                    break;
                case "crb":
                    CaptureRegionBottom = ParseInt32(args, ref pos) ?? CaptureRegionBottom;
                    break;
                case "crl":
                    CaptureRegionLeft = ParseInt32(args, ref pos) ?? CaptureRegionLeft;
                    break;
                case "tx":
                    TilesX = ParseInt32(args, ref pos) ?? TilesX;
                    break;
                case "ty":
                    TilesY = ParseInt32(args, ref pos) ?? TilesY;
                    break;
                case "cm":
                    ControlMode = ParseEnum<ControlModes>(args, ref pos) ?? ControlMode;
                    break;
                case "drt":
                    MouseDragRegionTop = ParseInt32(args, ref pos) ?? MouseDragRegionTop;
                    break;
                case "drr":
                    MouseDragRegionRight = ParseInt32(args, ref pos) ?? MouseDragRegionRight;
                    break;
                case "drb":
                    MouseDragRegionBottom = ParseInt32(args, ref pos) ?? MouseDragRegionBottom;
                    break;
                case "drl":
                    MouseDragRegionLeft = ParseInt32(args, ref pos) ?? MouseDragRegionLeft;
                    break;
                case "dss":
                    MouseDragStepSize = ParseInt32(args, ref pos) ?? MouseDragStepSize;
                    break;
                case "ds":
                    MouseDragStepSize = ParseInt32(args, ref pos) ?? MouseDragStepSize;
                    break;
                case "ksx":
                    KeyboardStepSizeX = ParseInt32(args, ref pos) ?? KeyboardStepSizeX;
                    break;
                case "ksy":
                    KeyboardStepSizeY = ParseInt32(args, ref pos) ?? KeyboardStepSizeY;
                    break;
                case "dls":
                    StepWaitTime = ParseDecimal(args, ref pos) ?? StepWaitTime;
                    break;
                case "dlt":
                    TileWaitTime = ParseDecimal(args, ref pos) ?? TileWaitTime;
                    break;
                case "dl1":
                    PrestartWaitTime = ParseDecimal(args, ref pos) ?? PrestartWaitTime;
                    break;
                case "dl2":
                    StartWaitTime = ParseDecimal(args, ref pos) ?? StartWaitTime;
                    break;
                case "rts":
                    ReturnToStart = ParseBoolean(args, ref pos) ?? ReturnToStart;
                    break;
                case "tp":
                    TargetPath = ParseString(args, ref pos) ?? TargetPath;
                    break;
                case "auto":
                    Automatic = ParseBoolean(args, ref pos) ?? Automatic;
                    break;
            }
            return pos;
        }

        private static int? ParseInt32(string[] args, ref int pos)
        {
            if (args.Length <= pos) return null;
            pos++;
            int v;
            return int.TryParse(args[pos - 1], NumberStyles.Integer, CultureInfo.InvariantCulture, out v)
                ? (int?)v
                : null;
        }

        private static decimal? ParseDecimal(string[] args, ref int pos)
        {
            if (args.Length <= pos) return null;
            pos++;
            decimal v;
            return decimal.TryParse(args[pos - 1], NumberStyles.Float, CultureInfo.InvariantCulture, out v)
                ? (decimal?)v
                : null;
        }

        private static bool? ParseBoolean(string[] args, ref int pos)
        {
            if (args.Length <= pos) return null;
            pos++;
            bool v;
            return bool.TryParse(args[pos - 1], out v)
                ? (bool?)v
                : null;
        }

        private static T? ParseEnum<T>(string[] args, ref int pos) where T : struct
        {
            if (args.Length <= pos) return null;
            pos++;
            T v;
            return Enum.TryParse(args[pos - 1], true, out v)
                ? (T?)v
                : null;
        }

        private static string ParseString(string[] args, ref int pos)
        {
            if (args.Length <= pos) return null;
            pos++;
            return args[pos - 1];
        }

        public string BuildCommandLineArguments()
        {
            var ci = CultureInfo.InvariantCulture;
            var sb = new StringBuilder();
            if (CaptureRegionTop.HasValue) sb.AppendFormat("crt {0} ", CaptureRegionTop.Value.ToString(ci));
            if (CaptureRegionRight.HasValue) sb.AppendFormat("crr {0} ", CaptureRegionRight.Value.ToString(ci));
            if (CaptureRegionBottom.HasValue) sb.AppendFormat("crb {0} ", CaptureRegionBottom.Value.ToString(ci));
            if (CaptureRegionLeft.HasValue) sb.AppendFormat("crl {0} ", CaptureRegionLeft.Value.ToString(ci));
            if (TilesX.HasValue) sb.AppendFormat("tx {0} ", TilesX.Value.ToString(ci));
            if (TilesY.HasValue) sb.AppendFormat("ty {0} ", TilesY.Value.ToString(ci));
            if (ControlMode.HasValue) sb.AppendFormat("cm {0} ", ControlMode.Value);
            if (MouseDragRegionTop.HasValue) sb.AppendFormat("drt {0} ", MouseDragRegionTop.Value.ToString(ci));
            if (MouseDragRegionRight.HasValue) sb.AppendFormat("drr {0} ", MouseDragRegionRight.Value.ToString(ci));
            if (MouseDragRegionBottom.HasValue) sb.AppendFormat("drb {0} ", MouseDragRegionBottom.Value.ToString(ci));
            if (MouseDragRegionLeft.HasValue) sb.AppendFormat("drl {0} ", MouseDragRegionLeft.Value.ToString(ci));
            if (MouseDragStepSize.HasValue) sb.AppendFormat("dss {0} ", MouseDragStepSize.Value.ToString(ci));
            if (KeyboardStepSizeX.HasValue) sb.AppendFormat("ksx {0} ", KeyboardStepSizeX.Value.ToString(ci));
            if (KeyboardStepSizeY.HasValue) sb.AppendFormat("ksy {0} ", KeyboardStepSizeY.Value.ToString(ci));
            if (StepWaitTime.HasValue) sb.AppendFormat("dls {0} ", StepWaitTime.Value.ToString(ci));
            if (TileWaitTime.HasValue) sb.AppendFormat("dlt {0} ", TileWaitTime.Value.ToString(ci));
            if (PrestartWaitTime.HasValue) sb.AppendFormat("dl1 {0} ", PrestartWaitTime.Value.ToString(ci));
            if (StartWaitTime.HasValue) sb.AppendFormat("dl2 {0} ", StartWaitTime.Value.ToString(ci));
            if (ReturnToStart.HasValue) sb.AppendFormat("rts {0} ", ReturnToStart.Value.ToString(ci));
            if (Automatic.HasValue) sb.AppendFormat("auto {0} ", Automatic.Value.ToString(ci));
            return sb.ToString().TrimEnd();
        }
    }
}
