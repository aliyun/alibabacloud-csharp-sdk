// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantMetricsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Metrics&quot;:[ {&quot;request_queue_rt&quot;:0.0,&quot;TimeStamp&quot;:&quot;2022-02-23T01:58:00Z&quot;}]</para>
        /// </summary>
        [NameInMap("TenantMetrics")]
        [Validation(Required=false)]
        public string TenantMetrics { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
