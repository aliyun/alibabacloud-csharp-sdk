// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopClientIpResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of the top 10 IP addresses from which attacks are initiated.
        /// </summary>
        [NameInMap("RuleHitsTopClientIp")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopClientIpResponseBodyRuleHitsTopClientIp> RuleHitsTopClientIp { get; set; }
        public class DescribeRuleHitsTopClientIpResponseBodyRuleHitsTopClientIp : TeaModel {
            /// <summary>
            /// The IP address of the service client.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// The number of attacks that are initiated from the IP address.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

    }

}
