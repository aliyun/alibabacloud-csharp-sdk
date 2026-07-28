// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class AutopilotPolicy : TeaModel {
        [NameInMap("advancedRules")]
        [Validation(Required=false)]
        public AutopilotPolicyAdvancedRules AdvancedRules { get; set; }
        public class AutopilotPolicyAdvancedRules : TeaModel {
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

        }

        [NameInMap("limits")]
        [Validation(Required=false)]
        public AutopilotPolicyLimits Limits { get; set; }
        public class AutopilotPolicyLimits : TeaModel {
            [NameInMap("coolDownMinutes")]
            [Validation(Required=false)]
            public long? CoolDownMinutes { get; set; }

            [NameInMap("jobMaxCpu")]
            [Validation(Required=false)]
            public double? JobMaxCpu { get; set; }

            [NameInMap("jobMaxMemory")]
            [Validation(Required=false)]
            public string JobMaxMemory { get; set; }

            [NameInMap("jobMaxParallelism")]
            [Validation(Required=false)]
            public int? JobMaxParallelism { get; set; }

            [NameInMap("jobMinParallelism")]
            [Validation(Required=false)]
            public int? JobMinParallelism { get; set; }

        }

        [NameInMap("scaleDownRules")]
        [Validation(Required=false)]
        public AutopilotPolicyScaleDownRules ScaleDownRules { get; set; }
        public class AutopilotPolicyScaleDownRules : TeaModel {
            [NameInMap("memoryScaleDownRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleDownRulesMemoryScaleDownRule MemoryScaleDownRule { get; set; }
            public class AutopilotPolicyScaleDownRulesMemoryScaleDownRule : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("memUsageScaleDownSampleInterval")]
                [Validation(Required=false)]
                public string MemUsageScaleDownSampleInterval { get; set; }

                [NameInMap("memUsageScaleDownThreshold")]
                [Validation(Required=false)]
                public double? MemUsageScaleDownThreshold { get; set; }

            }

            [NameInMap("slotBusyScaleDownRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleDownRulesSlotBusyScaleDownRule SlotBusyScaleDownRule { get; set; }
            public class AutopilotPolicyScaleDownRulesSlotBusyScaleDownRule : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("slotBusyScaleDownSampleInterval")]
                [Validation(Required=false)]
                public string SlotBusyScaleDownSampleInterval { get; set; }

                [NameInMap("slotBusyScaleDownThreshold")]
                [Validation(Required=false)]
                public double? SlotBusyScaleDownThreshold { get; set; }

            }

        }

        [NameInMap("scaleUpRules")]
        [Validation(Required=false)]
        public AutopilotPolicyScaleUpRules ScaleUpRules { get; set; }
        public class AutopilotPolicyScaleUpRules : TeaModel {
            [NameInMap("delayRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesDelayRule DelayRule { get; set; }
            public class AutopilotPolicyScaleUpRulesDelayRule : TeaModel {
                [NameInMap("delaySampleInterval")]
                [Validation(Required=false)]
                public string DelaySampleInterval { get; set; }

                [NameInMap("delayThreshold")]
                [Validation(Required=false)]
                public string DelayThreshold { get; set; }

                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("gcRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesGcRule GcRule { get; set; }
            public class AutopilotPolicyScaleUpRulesGcRule : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("gcSampleInterval")]
                [Validation(Required=false)]
                public string GcSampleInterval { get; set; }

                [NameInMap("gcTimeRatioThreshold")]
                [Validation(Required=false)]
                public double? GcTimeRatioThreshold { get; set; }

            }

            [NameInMap("memoryScaleUpRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesMemoryScaleUpRule MemoryScaleUpRule { get; set; }
            public class AutopilotPolicyScaleUpRulesMemoryScaleUpRule : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("memUsageScaleUpThreshold")]
                [Validation(Required=false)]
                public double? MemUsageScaleUpThreshold { get; set; }

            }

            [NameInMap("oomScaleUpRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesOomScaleUpRule OomScaleUpRule { get; set; }
            public class AutopilotPolicyScaleUpRulesOomScaleUpRule : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("slotBusyScaleUpRule")]
            [Validation(Required=false)]
            public AutopilotPolicyScaleUpRulesSlotBusyScaleUpRule SlotBusyScaleUpRule { get; set; }
            public class AutopilotPolicyScaleUpRulesSlotBusyScaleUpRule : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("slotBusyScaleUpSampleInterval")]
                [Validation(Required=false)]
                public string SlotBusyScaleUpSampleInterval { get; set; }

                [NameInMap("slotBusyScaleUpThreshold")]
                [Validation(Required=false)]
                public double? SlotBusyScaleUpThreshold { get; set; }

            }

        }

        [NameInMap("silentPeriodConfig")]
        [Validation(Required=false)]
        public AutopilotPolicySilentPeriodConfig SilentPeriodConfig { get; set; }
        public class AutopilotPolicySilentPeriodConfig : TeaModel {
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("silentPeriods")]
            [Validation(Required=false)]
            public List<AutopilotPolicySilentPeriodConfigSilentPeriods> SilentPeriods { get; set; }
            public class AutopilotPolicySilentPeriodConfigSilentPeriods : TeaModel {
                [NameInMap("beginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

    }

}
