// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringSimpleEscalation : TeaModel {
        /// <summary>
        /// <para>The configuration list for multi-level triggers in cloud service monitoring. Each item defines a trigger level (such as Warning or Critical) and includes parameters such as the threshold, duration period, and notification method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;severity&quot;:&quot;CRITICAL&quot;,&quot;comparisonOperator&quot;:&quot;GT&quot;,&quot;threshold&quot;:&quot;80&quot;,&quot;times&quot;:3}]</para>
        /// </summary>
        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<CloudMonitoringSimpleEscalationEntry> Escalations { get; set; }

        /// <summary>
        /// <para>The metric name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpuUsage</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The collection period in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

    }

}
