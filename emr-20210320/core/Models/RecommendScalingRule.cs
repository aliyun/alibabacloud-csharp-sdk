// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RecommendScalingRule : TeaModel {
        /// <summary>
        /// <para>伸缩活动类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>SCALE_OUT：扩容。</description></item>
        /// <item><description>SCALE_IN：缩容。</description></item>
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
        /// <para>调整值。需要为正数，代表需要扩容或者缩容的实例数量。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>推荐的规格类型。</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>最大节约成本。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.12</para>
        /// </summary>
        [NameInMap("MaxSave")]
        [Validation(Required=false)]
        public float? MaxSave { get; set; }

        /// <summary>
        /// <para>按照负载伸缩描述。</para>
        /// <para>
        /// </summary>
        [NameInMap("MetricsTrigger")]
        [Validation(Required=false)]
        public MetricsTrigger MetricsTrigger { get; set; }

        /// <summary>
        /// <para>规则名称。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scale-out-memory</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>按照时间伸缩描述。</para>
        /// <para>
        /// </summary>
        [NameInMap("TimeTrigger")]
        [Validation(Required=false)]
        public TimeTrigger TimeTrigger { get; set; }

        /// <summary>
        /// <para>伸缩规则类型。 取值范围：</para>
        /// <list type="bullet">
        /// <item><description>TIME_TRIGGER: 按时间伸缩。</description></item>
        /// <item><description>METRICS_TRIGGER: 按负载伸缩。</description></item>
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
