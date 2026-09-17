// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringCompositeEscalation : TeaModel {
        /// <summary>
        /// <para>The multi-condition configuration list for the cloud service monitoring composite trigger. The list contains multiple sub-causes that are combined by using logical operators (AND/OR) to determine whether to trigger an alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;metricName&quot;:&quot;cpu_total&quot;,&quot;comparisonOperator&quot;:&quot;GreaterThanThreshold&quot;,&quot;threshold&quot;:&quot;90&quot;,&quot;times&quot;:3}]</para>
        /// </summary>
        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<CloudMonitoringCompositeEscalationEntry> Escalations { get; set; }

        /// <summary>
        /// <para>The logical relationship between conditions (AND/OR).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRITICAL</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The number of consecutive times the condition is met before the alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
