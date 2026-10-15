// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ScalingActivity : TeaModel {
        /// <summary>
        /// <para>The types of components involved in the auto scaling activity.</para>
        /// </summary>
        [NameInMap("componentTypes")]
        [Validation(Required=false)]
        public string ComponentTypes { get; set; }

        /// <summary>
        /// <para>The detailed description of the auto scaling activity, which can be used to identify the cause when the activity fails.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end time of the auto scaling activity.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Milvus instance.</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the elastic scaling policy.</para>
        /// </summary>
        [NameInMap("policyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The ID of the elastic scaling activity.</para>
        /// </summary>
        [NameInMap("scalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

        /// <summary>
        /// <para>The execution status of the auto scaling activity.</para>
        /// </summary>
        [NameInMap("scalingActivityState")]
        [Validation(Required=false)]
        public string ScalingActivityState { get; set; }

        /// <summary>
        /// <para>The ID of the elastic scaling policy.</para>
        /// </summary>
        [NameInMap("scalingPolicyId")]
        [Validation(Required=false)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// <para>The details of the elastic scaling rule.</para>
        /// </summary>
        [NameInMap("scalingRuleDetail")]
        [Validation(Required=false)]
        public string ScalingRuleDetail { get; set; }

        /// <summary>
        /// <para>The ID of the elastic scaling rule.</para>
        /// </summary>
        [NameInMap("scalingRuleId")]
        [Validation(Required=false)]
        public string ScalingRuleId { get; set; }

        /// <summary>
        /// <para>The name of the rule that triggered the auto scaling activity.</para>
        /// </summary>
        [NameInMap("scalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>The start time of the auto scaling activity.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time zone used by the elastic scaling rule.</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
