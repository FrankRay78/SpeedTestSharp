using System;
using System.Threading.Tasks;
using SpeedTestSharp.DataTypes.External;
using SpeedTestSharp.Enums;

namespace SpeedTestSharp.Client
{
    public interface ISpeedTestClient
    {
        public TestStage CurrentStage { get; }
        public SpeedUnit SpeedUnit { get; }
        public event EventHandler<TestStage>? StageChanged;
        public event EventHandler<ProgressInfo>? ProgressChanged;
        public Task<SpeedTestResult> TestSpeedAsync(SpeedUnit speedUnit,
            int parallelTasks = 8,
            bool testLatency = true,
            bool testDownload = true,
            bool testUpload = true);
    }
}