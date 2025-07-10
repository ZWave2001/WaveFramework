using System.Diagnostics;
using UnityEngine.Profiling;

namespace WaveFramework
{
    /// <summary>
    /// 游戏框架Profiler分析类
    /// </summary>
    public class WProfiler
    {
        /// <summary>
        /// 开始使用自定义采样
        /// </summary>
        /// <param name="name"></param>
        [Conditional("W_PROFILER")]
        public static void BeginSample(string name)
        {
            Profiler.BeginSample(name);
        }


        /// <summary>
        /// 结束使用自定义采样
        /// </summary>
        [Conditional("W_PROFILER")]
        public static void EndSample()
        {
            Profiler.EndSample();
        }
    }
}