// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TriggerCondition : TeaModel {
        /// <summary>
        /// <para>The comparison operator. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EQ: equal to</description></item>
        /// <item><description>NE: not equal to</description></item>
        /// <item><description>GT: greater than</description></item>
        /// <item><description>LT: less than</description></item>
        /// <item><description>GE: greater than or equal to</description></item>
        /// <item><description>LE: less than or equal to</description></item>
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
        /// <para>The name of the metric. This parameter is required and cannot be an empty string. You can view the metric name in <a href="https://help.aliyun.com/document_detail/445658.html">Add Auto Scaling Rules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yarn_resourcemanager_queue_PendingVCores</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The name of the statistic. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAX</description></item>
        /// <item><description>MIN</description></item>
        /// <item><description>AVG</description></item>
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
        /// <para>The tags for the metrics of a partition. This parameter is available for only metrics that contain ByPartition. For other metrics, leave this parameter empty.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The trigger threshold. This parameter is required.</para>
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
