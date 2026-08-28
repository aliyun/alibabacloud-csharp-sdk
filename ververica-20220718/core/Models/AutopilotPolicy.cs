// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class AutopilotPolicy : TeaModel {
        /// <summary>
        /// <para>The advanced rule configuration. This includes advanced parameters such as chain-break optimization, minimum parallelism, and TM CPU scaling. Disabled by default and must be explicitly enabled.</para>
        /// </summary>
        [NameInMap("advancedRules")]
        [Validation(Required=false)]
        public AutopilotPolicyAdvancedRules AdvancedRules { get; set; }
        public class AutopilotPolicyAdvancedRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable advanced rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The advanced rule parameters. An empty map indicates that internal default parameters are used. You can override specific internal parameters by using key-value pairs. The entire map is replaced.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

        }

        /// <summary>
        /// <para>The upper and lower limits for tuning resources.</para>
        /// </summary>
        [NameInMap("limits")]
        [Validation(Required=false)]
        public AutopilotPolicyLimits Limits { get; set; }
        public class AutopilotPolicyLimits : TeaModel {
            /// <summary>
            /// <para>The minimum cool-down time between two tuning operations, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("coolDownMinutes")]
            [Validation(Required=false)]
            public long? CoolDownMinutes { get; set; }

            /// <summary>
            /// <para>The maximum CPU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("jobMaxCpu")]
            [Validation(Required=false)]
            public double? JobMaxCpu { get; set; }

            /// <summary>
            /// <para>The maximum memory. Format examples: 4Gi, 256GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64GiB</para>
            /// </summary>
            [NameInMap("jobMaxMemory")]
            [Validation(Required=false)]
            public string JobMaxMemory { get; set; }

            /// <summary>
            /// <para>The maximum parallelism.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("jobMaxParallelism")]
            [Validation(Required=false)]
            public int? JobMaxParallelism { get; set; }

            /// <summary>
            /// <para>The minimum parallelism.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("jobMinParallelism")]
            [Validation(Required=false)]
            public int? JobMinParallelism { get; set; }

        }

        /// <summary>
        /// <para>The scale-down rule configuration.</para>
        /// </summary>
        [NameInMap("scaleDownRules")]
        [Validation(Required=false)]
        public AutopilotPolicyScaleDownRules ScaleDownRules { get; set; }
        public class AutopilotPolicyScaleDownRules : TeaModel {
            /// <summary>
            /// <para>The memory scale-down rule. Scale-down is triggered when memory usage falls below the threshold.</para>
            /// </summary>
            [NameInMap("memoryScaleDownRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleDownRulesMemoryScaleDownRule MemoryScaleDownRule { get; set; }
            public class AutopilotPolicyScaleDownRulesMemoryScaleDownRule : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable memory scale-down.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The memory scale-down sampling interval. Format examples: 4h, 5m.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25h</para>
                /// </summary>
                [NameInMap("memUsageScaleDownSampleInterval")]
                [Validation(Required=false)]
                public string MemUsageScaleDownSampleInterval { get; set; }

                /// <summary>
                /// <para>The memory scale-down threshold. Valid values: 0.0 to 1.0. Scale-down is triggered when memory usage falls below this value. This value must be less than the scale-up threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("memUsageScaleDownThreshold")]
                [Validation(Required=false)]
                public double? MemUsageScaleDownThreshold { get; set; }

            }

            /// <summary>
            /// <para>The slot idle scale-down rule. Scale-down is triggered when the slot busy ratio falls below the threshold.</para>
            /// </summary>
            [NameInMap("slotBusyScaleDownRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleDownRulesSlotBusyScaleDownRule SlotBusyScaleDownRule { get; set; }
            public class AutopilotPolicyScaleDownRulesSlotBusyScaleDownRule : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable slot idle scale-down.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The slot idle sampling interval. Format examples: 4h, 5m.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24h</para>
                /// </summary>
                [NameInMap("slotBusyScaleDownSampleInterval")]
                [Validation(Required=false)]
                public string SlotBusyScaleDownSampleInterval { get; set; }

                /// <summary>
                /// <para>The slot idle scale-down threshold. Valid values: 0.0 to 1.0. Scale-down is triggered when the slot busy ratio falls below this value. This value must be less than the scale-up threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("slotBusyScaleDownThreshold")]
                [Validation(Required=false)]
                public double? SlotBusyScaleDownThreshold { get; set; }

            }

        }

        /// <summary>
        /// <para>The scale-up rule configuration.</para>
        /// </summary>
        [NameInMap("scaleUpRules")]
        [Validation(Required=false)]
        public AutopilotPolicyScaleUpRules ScaleUpRules { get; set; }
        public class AutopilotPolicyScaleUpRules : TeaModel {
            /// <summary>
            /// <para>The delay detection scale-up rule. Scale-up is triggered when the job delay exceeds the threshold.</para>
            /// </summary>
            [NameInMap("delayRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesDelayRule DelayRule { get; set; }
            public class AutopilotPolicyScaleUpRulesDelayRule : TeaModel {
                /// <summary>
                /// <para>The delay sampling interval. Format examples: 3min, 5m, 1h.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3min</para>
                /// </summary>
                [NameInMap("delaySampleInterval")]
                [Validation(Required=false)]
                public string DelaySampleInterval { get; set; }

                /// <summary>
                /// <para>The latency threshold. Format examples: 1min, 10m. Scale-up is triggered when the delay continuously exceeds this threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1min</para>
                /// </summary>
                [NameInMap("delayThreshold")]
                [Validation(Required=false)]
                public string DelayThreshold { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable delay detection scale-up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The GC tuning rule. Scale-up is triggered when the GC time ratio exceeds the threshold.</para>
            /// </summary>
            [NameInMap("gcRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesGcRule GcRule { get; set; }
            public class AutopilotPolicyScaleUpRulesGcRule : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable GC tuning.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The GC sampling interval. Format examples: 3min, 5m.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3min</para>
                /// </summary>
                [NameInMap("gcSampleInterval")]
                [Validation(Required=false)]
                public string GcSampleInterval { get; set; }

                /// <summary>
                /// <para>The GC time ratio threshold. Valid values: 0.0 to 1.0. Scale-up is triggered when the GC time ratio exceeds this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("gcTimeRatioThreshold")]
                [Validation(Required=false)]
                public double? GcTimeRatioThreshold { get; set; }

            }

            /// <summary>
            /// <para>The memory scale-up rule. Scale-up is triggered when memory usage exceeds the threshold.</para>
            /// </summary>
            [NameInMap("memoryScaleUpRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesMemoryScaleUpRule MemoryScaleUpRule { get; set; }
            public class AutopilotPolicyScaleUpRulesMemoryScaleUpRule : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable memory scale-up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The memory scale-up threshold. Valid values: 0.0 to 1.0. Scale-up is triggered when memory usage exceeds this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.95</para>
                /// </summary>
                [NameInMap("memUsageScaleUpThreshold")]
                [Validation(Required=false)]
                public double? MemUsageScaleUpThreshold { get; set; }

            }

            /// <summary>
            /// <para>The OOM scale-up rule. Scale-up is triggered when an OOM risk is detected.</para>
            /// </summary>
            [NameInMap("oomScaleUpRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesOomScaleUpRule OomScaleUpRule { get; set; }
            public class AutopilotPolicyScaleUpRulesOomScaleUpRule : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable OOM scale-up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The slot busy scale-up rule. Scale-up is triggered when the slot busy ratio exceeds the threshold.</para>
            /// </summary>
            [NameInMap("slotBusyScaleUpRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesSlotBusyScaleUpRule SlotBusyScaleUpRule { get; set; }
            public class AutopilotPolicyScaleUpRulesSlotBusyScaleUpRule : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable slot busy scale-up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The slot busy sampling interval. Format examples: 6min, 5m.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6min</para>
                /// </summary>
                [NameInMap("slotBusyScaleUpSampleInterval")]
                [Validation(Required=false)]
                public string SlotBusyScaleUpSampleInterval { get; set; }

                /// <summary>
                /// <para>The slot busy scale-up threshold. Valid values: 0.0 to 1.0. Scale-up is triggered when the slot busy ratio exceeds this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("slotBusyScaleUpThreshold")]
                [Validation(Required=false)]
                public double? SlotBusyScaleUpThreshold { get; set; }

            }

        }

        /// <summary>
        /// <para>The silent period configuration. Automatic tuning operations are not performed during silent periods.</para>
        /// </summary>
        [NameInMap("silentPeriodConfig")]
        [Validation(Required=false)]
        public AutopilotPolicySilentPeriodConfig SilentPeriodConfig { get; set; }
        public class AutopilotPolicySilentPeriodConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable silent periods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of silent periods. This is a full replacement, not an append operation.</para>
            /// </summary>
            [NameInMap("silentPeriods")]
            [Validation(Required=false)]
            public List<AutopilotPolicySilentPeriodConfigSilentPeriods> SilentPeriods { get; set; }
            public class AutopilotPolicySilentPeriodConfigSilentPeriods : TeaModel {
                /// <summary>
                /// <para>The start time. For the DAY level: 0-1439, representing the minute offset of the day (for example, 540 represents 9:00). For the WEEK level: 1-7, representing the day of the week (ISO 8601, 1=Monday, 7=Sunday).</para>
                /// 
                /// <b>Example:</b>
                /// <para>540</para>
                /// </summary>
                [NameInMap("beginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>The end time. The format is the same as beginTime. For the WEEK level, if endTime is less than beginTime, it indicates a cross-week period (for example, beginTime=6, endTime=2 means silent from Saturday to the following Tuesday).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The silent level. DAY indicates daily repetition. WEEK indicates weekly repetition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAY</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

    }

}
