// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryMonitorValuesResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring information returned in the JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/122091.html">View performance monitoring data</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>Only metrics whose values are not 0 are returned. This improves data transmission efficiency. Metrics that are not displayed are represented by the <b>0</b> default value.</para>
        /// </description></item>
        /// <item><description><para>The query result is aligned with the data aggregation frequency. If the specified time range to query is less than or equal to 10 minutes and the data is aggregated once every 5 seconds, query results are returned at an interval of 5 seconds. If the specified StartTime value does not coincide with a point in time for data aggregation, the system returns the latest point in time for data aggregation as the first point in time. For example, if you set the StartTime parameter to 2022-01-20T12:01:48Z, the first point in time returned is 2022-01-20T12:01:45Z.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;2022-11-06T00:00:00Z\&quot;:{\&quot;memoryUsage\&quot;:\&quot;6.67\&quot;},\&quot;2022-11-06T00:00:05Z\&quot;:{\&quot;memoryUsage\&quot;:\&quot;6.67\&quot;},\&quot;2022-11-06T00:00:10Z\&quot;:{\&quot;memoryUsage\&quot;:\&quot;6.67\&quot;},\&quot;2022-11-06T00:00:15Z\&quot;:{\&quot;memoryUsage\&quot;:\&quot;6.67\&quot;},\&quot;2022-11-06T00:00:20Z\&quot;:{\&quot;memoryUsage\&quot;:\&quot;6.67\&quot;},\&quot;2022-11-06T00:00:25Z\&quot;:{\&quot;memoryUsage\&quot;:\&quot;6.67\&quot;}}&quot;</para>
        /// </summary>
        [NameInMap("MonitorHistory")]
        [Validation(Required=false)]
        public string MonitorHistory { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0997EE8-F4C2-4503-9168-85177ED7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
