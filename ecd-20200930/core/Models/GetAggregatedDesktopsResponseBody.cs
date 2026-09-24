// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetAggregatedDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of aggregation field information.</para>
        /// <remarks>
        /// <para>Notice: When you use an aggregate query, only aggregation results are returned. The list of matched metadata is not returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public GetAggregatedDesktopsResponseBodyAggregations Aggregations { get; set; }
        public class GetAggregatedDesktopsResponseBodyAggregations : TeaModel {
            /// <summary>
            /// <para>The aggregation results.</para>
            /// </summary>
            [NameInMap("DesktopAggregation")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> DesktopAggregation { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3147E094-C1F7-5001-8F04-C8CEE75D6552</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
