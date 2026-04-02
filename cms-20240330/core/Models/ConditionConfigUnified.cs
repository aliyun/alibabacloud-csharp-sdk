// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ConditionConfigUnified : TeaModel {
        /// <summary>
        /// <para>聚合函数（APM_SIMPLE_CONDITION）</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>多条比较（APM_COMPOSITE_CONDITION）</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<ApmCompositeCompareConfig> CompareList { get; set; }

        /// <summary>
        /// <para>持续时间（秒），PROMETHEUS_SIMPLE / UMODEL_METRICSET 使用</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>比较操作符（UMODEL_METRICSET_CONDITION 或 APM_SIMPLE_CONDITION）</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>条件间逻辑关系（APM_COMPOSITE_CONDITION）</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>严重等级（UMODEL / PROMETHEUS_SIMPLE / APM_COMPOSITE）</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>阈值（UMODEL_METRICSET_CONDITION）</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        /// <summary>
        /// <para>多阈值列表（APM_SIMPLE_CONDITION）</para>
        /// </summary>
        [NameInMap("thresholdList")]
        [Validation(Required=false)]
        public List<ApmThresholdConfig> ThresholdList { get; set; }

        /// <summary>
        /// <para>检测条件类型</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
