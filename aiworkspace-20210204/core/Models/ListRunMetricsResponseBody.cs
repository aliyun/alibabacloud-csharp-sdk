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
        /// <para>The pagination token. Leave this parameter empty when you query the first page. The response returns the token for the next page. A value of 0 indicates that all results have been retrieved. You can obtain the token for the next page from the <b>NextPageToken</b> field in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public long? NextPageToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADF6D849-*****-7E7030F0CE53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
