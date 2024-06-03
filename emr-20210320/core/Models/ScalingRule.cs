// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRule : TeaModel {
        /// <summary>
        /// 伸缩活动类型。取值范围：
        /// - SCALE_OUT：扩容。
        /// - SCALE_IN：缩容。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// 调整值。需要为正数，代表需要扩容或者缩容的实例数量。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// 按照负载伸缩描述。
        /// <p>
        /// </summary>
        [NameInMap("MetricsTrigger")]
        [Validation(Required=false)]
        public MetricsTrigger MetricsTrigger { get; set; }

        /// <summary>
        /// 规则名称。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// 按照时间伸缩描述。
        /// <p>
        /// </summary>
        [NameInMap("TimeTrigger")]
        [Validation(Required=false)]
        public TimeTrigger TimeTrigger { get; set; }

        /// <summary>
        /// 伸缩规则类型。 取值范围：
        /// - TIME_TRIGGER: 按时间伸缩。
        /// - METRICS_TRIGGER: 按负载伸缩。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
