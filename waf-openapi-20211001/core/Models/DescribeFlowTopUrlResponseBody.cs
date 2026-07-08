// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowTopUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>520D4E4C-B8EC-5602-ACB6-4D378ACBA28D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The top 10 URLs that are most frequently accessed.</para>
        /// </summary>
        [NameInMap("RuleHitsTopUrl")]
        [Validation(Required=false)]
        public List<DescribeFlowTopUrlResponseBodyRuleHitsTopUrl> RuleHitsTopUrl { get; set; }
        public class DescribeFlowTopUrlResponseBodyRuleHitsTopUrl : TeaModel {
            /// <summary>
            /// <para>The total number of requests for the URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>181174784</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The requested URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com/path1">www.aliyundoc.com/path1</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
