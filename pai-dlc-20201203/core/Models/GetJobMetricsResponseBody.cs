// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-*******</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The list of node monitoring data.</para>
        /// </summary>
        [NameInMap("PodMetrics")]
        [Validation(Required=false)]
        public List<PodMetric> PodMetrics { get; set; }

        /// <summary>
        /// <para>The request ID of this call, used for diagnostics and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
