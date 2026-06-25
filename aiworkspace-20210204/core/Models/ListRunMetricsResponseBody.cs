// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListRunMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of metrics.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<RunMetric> Metrics { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. A value of 0 indicates that all results have been returned. Use the value of this parameter for the \<c>PageToken\\</c> parameter in your next request to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public long? NextPageToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADF6D849-*****-7E7030F0CE53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
