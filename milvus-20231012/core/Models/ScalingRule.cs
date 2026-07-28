// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ScalingRule : TeaModel {
        /// <summary>
        /// <para>The adjustment information of the scaling rule.</para>
        /// </summary>
        [NameInMap("adjustInfos")]
        [Validation(Required=false)]
        public List<ScalingRuleAdjustInfos> AdjustInfos { get; set; }
        public class ScalingRuleAdjustInfos : TeaModel {
            /// <summary>
            /// <para>The type of the component to be adjusted.</para>
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <para>The target value for the adjustment.</para>
            /// </summary>
            [NameInMap("targetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

        }

        /// <summary>
        /// <para>The cron expression for the scaling schedule.</para>
        /// </summary>
        [NameInMap("cronStr")]
        [Validation(Required=false)]
        public string CronStr { get; set; }

        /// <summary>
        /// <para>Indicates whether the scaling rule is disabled.</para>
        /// </summary>
        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>The end time of the scaling rule. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the scaling rule.</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the scaling rule.</para>
        /// </summary>
        [NameInMap("scalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>The start time of the scaling rule. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The time zone of the scaling rule.</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
