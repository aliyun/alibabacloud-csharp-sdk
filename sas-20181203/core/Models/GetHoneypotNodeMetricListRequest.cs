// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotNodeMetricListRequest : TeaModel {
        /// <summary>
        /// <para>The end time. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// <item><description>Formatted time: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-30 00:10:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expression used to perform real-time calculations on the query results.</para>
        /// <remarks>
        /// <para>Currently, only groupby (similar to the GROUP BY clause in databases) is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;groupby&quot;:[&quot;userId&quot;,&quot;instanceId&quot;]}</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page for paging in a paged query.</para>
        /// <remarks>
        /// <para>The maximum value of Length for a single request is 1440.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The name of the monitoring metric for the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The data namespace of the cloud service. Naming convention: acs_ServiceName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the management node.</para>
        /// <para>This parameter is required. If you do not specify this parameter, the API returns an IllegalParam error (HTTP 400).</para>
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
        /// <para>The start time. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// <item><description>Formatted time: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// <item><description>The interval between StartTime and EndTime must be less than or equal to 31 days.</description></item>
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
