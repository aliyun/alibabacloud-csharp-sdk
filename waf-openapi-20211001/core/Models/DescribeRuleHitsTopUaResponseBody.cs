// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopUaResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of the top 10 user agents that are used to initiate attacks.
        /// </summary>
        [NameInMap("RuleHitsTopUa")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopUaResponseBodyRuleHitsTopUa> RuleHitsTopUa { get; set; }
        public class DescribeRuleHitsTopUaResponseBodyRuleHitsTopUa : TeaModel {
            /// <summary>
            /// The number of attacks that are initiated from the IP address.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The user agent.
            /// </summary>
            [NameInMap("Ua")]
            [Validation(Required=false)]
            public string Ua { get; set; }

        }

    }

}
