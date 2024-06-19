// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopUrlResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The top 10 URLs that match protection rules.
        /// </summary>
        [NameInMap("RuleHitsTopUrl")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopUrlResponseBodyRuleHitsTopUrl> RuleHitsTopUrl { get; set; }
        public class DescribeRuleHitsTopUrlResponseBodyRuleHitsTopUrl : TeaModel {
            /// <summary>
            /// The number of requests that match protection rules.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The request URL.
            /// 
            /// >  The value is Base64-encoded.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
