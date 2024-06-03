// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class MetricsTrigger : TeaModel {
        /// <summary>
        /// 多指标逻辑关系。默认：Or。取值范围：
        /// - And:与
        /// - Or：或
        /// </summary>
        [NameInMap("ConditionLogicOperator")]
        [Validation(Required=false)]
        public string ConditionLogicOperator { get; set; }

        /// <summary>
        /// 指标触发条件列表。
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<TriggerCondition> Conditions { get; set; }

        /// <summary>
        /// 冷却时间。 单位为秒
        /// </summary>
        [NameInMap("CoolDownInterval")]
        [Validation(Required=false)]
        public int? CoolDownInterval { get; set; }

        /// <summary>
        /// 统计次数。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// 时间限制。
        /// </summary>
        [NameInMap("TimeConstraints")]
        [Validation(Required=false)]
        public List<TimeConstraint> TimeConstraints { get; set; }

        /// <summary>
        /// 统计窗口。单位为秒。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeWindow")]
        [Validation(Required=false)]
        public int? TimeWindow { get; set; }

    }

}
