// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasAISearchProxy20260424.Models
{
    public class WebSearchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1754973000000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("excludeDomain")]
        [Validation(Required=false)]
        public List<string> ExcludeDomain { get; set; }

        [NameInMap("includeDomain")]
        [Validation(Required=false)]
        public List<string> IncludeDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;entityFilter\&quot;:{\&quot;domain\&quot;:\&quot;synthetics\&quot;,\&quot;filters\&quot;:[],\&quot;type\&quot;:\&quot;synthetics.task\&quot;},\&quot;metric\&quot;:\&quot;availability\&quot;,\&quot;metricSet\&quot;:\&quot;synthetics.metric.task\&quot;,\&quot;type\&quot;:\&quot;METRIC_SET_QUERY\&quot;}</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-03-06 10:04:45</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
