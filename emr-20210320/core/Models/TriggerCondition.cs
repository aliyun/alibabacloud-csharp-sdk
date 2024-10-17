// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TriggerCondition : TeaModel {
        /// <summary>
        /// <para>比较符。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>EQ:等于。</description></item>
        /// <item><description>NE:不等于。</description></item>
        /// <item><description>GT:大于。</description></item>
        /// <item><description>LT:小于。</description></item>
        /// <item><description>GE:大于等于。</description></item>
        /// <item><description>LE:小于等于。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LT</para>
        /// </summary>
        [NameInMap("ComparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>指标名称。指标名称需要在 ListAutoScalingMetrics 接口返回的指标名称列表中。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yarn_resourcemanager_root_availablememoryusage</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>统计量名称。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>MAX：最大值。</description></item>
        /// <item><description>MIN：最小值。</description></item>
        /// <item><description>AVG：平均值。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVG</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>指标Tag。</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>阈值。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.5</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
