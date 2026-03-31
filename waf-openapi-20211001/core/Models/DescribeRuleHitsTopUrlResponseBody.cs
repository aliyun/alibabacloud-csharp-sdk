// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D8AF43B-08EB-51CE-B33A-93AA****9B0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The top 10 URLs that match protection rules.</para>
        /// </summary>
        [NameInMap("RuleHitsTopUrl")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopUrlResponseBodyRuleHitsTopUrl> RuleHitsTopUrl { get; set; }
        public class DescribeRuleHitsTopUrlResponseBodyRuleHitsTopUrl : TeaModel {
            /// <summary>
            /// <para>The number of requests that match protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21862</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The request URL.</para>
            /// <remarks>
            /// <para> The value is Base64-encoded.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>d3d3LmFsaXl1bmRvYy5jb20vcGF0aDM=</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
