// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRule : TeaModel {
        /// <summary>
        /// <para>The type of the scaling activity. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SCALE_OUT: scale-out.</para>
        /// </description></item>
        /// <item><description><para>SCALE_IN: scale-in.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_IN</para>
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// <para>The adjustment value. This parameter is required and must be a positive integer. It specifies the number of instances to add for a scale-out activity or remove for a scale-in activity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>The configurations for load-based scaling.</para>
        /// </summary>
        [NameInMap("MetricsTrigger")]
        [Validation(Required=false)]
        public MetricsTrigger MetricsTrigger { get; set; }

        /// <summary>
        /// <para>The minimum number of instances to add during a scale-out activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAdjustmentValue")]
        [Validation(Required=false)]
        public int? MinAdjustmentValue { get; set; }

        /// <summary>
        /// <para>The name of the rule. This parameter is required and cannot be an empty string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalingByYarnMemory</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The configurations for time-based scaling.</para>
        /// </summary>
        [NameInMap("TimeTrigger")]
        [Validation(Required=false)]
        public TimeTrigger TimeTrigger { get; set; }

        /// <summary>
        /// <para>The type of the scaling rule. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>TIME_TRIGGER: time-based scaling.</para>
        /// </description></item>
        /// <item><description><para>METRICS_TRIGGER: load-based scaling.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TIME_TRIGGER</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
