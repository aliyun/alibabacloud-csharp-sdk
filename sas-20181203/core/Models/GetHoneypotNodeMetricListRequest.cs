// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotNodeMetricListRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC</description></item>
        /// <item><description>Date format: YYYY-MM-DDThh:mm:ssZ</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-30 00:10:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expression that is used to compute the query results in real time.</para>
        /// <remarks>
        /// <para> Only the groupby expression is supported. This expression is similar to the GROUP BY statement that applies to databases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;groupby&quot;:[&quot;userId&quot;,&quot;instanceId&quot;]}</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <remarks>
        /// <para> The maximum value of the Length parameter in a request is 1440.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The metric that is used to monitor the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service. Format: acs_cloud service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The management node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc427e14-f257-4670-9d2b-d83bbbe7****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The time interval. Unit: seconds. Valid values: 60, 300, and 900.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC</description></item>
        /// <item><description>Date format: YYYY-MM-DDThh:mm:ssZ</description></item>
        /// <item><description>The interval between the start time and the end time is less than or equal to 31 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-30 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
