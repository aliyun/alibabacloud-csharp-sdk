// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryMonitorValuesResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data returned as a JSON-formatted string. For more information, see <a href="https://help.aliyun.com/document_detail/122091.html">Monitoring parameters</a>.</para>
        /// <remarks>
        /// <para>To improve data transfer efficiency, the system returns only monitoring data for metrics with non-zero values. If a metric is not returned, its value is <b>0</b>.</para>
        /// </remarks>
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
