// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopRuleIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of the IDs of the top 10 rules that are matched by requests.
        /// </summary>
        [NameInMap("RuleHitsTopRuleId")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopRuleIdResponseBodyRuleHitsTopRuleId> RuleHitsTopRuleId { get; set; }
        public class DescribeRuleHitsTopRuleIdResponseBodyRuleHitsTopRuleId : TeaModel {
            /// <summary>
            /// The number of requests that match the rule.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The protected object.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
