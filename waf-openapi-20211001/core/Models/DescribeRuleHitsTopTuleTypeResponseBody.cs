// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopTuleTypeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The top 10 protection modules that are matched.
        /// </summary>
        [NameInMap("RuleHitsTopTuleType")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType> RuleHitsTopTuleType { get; set; }
        public class DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType : TeaModel {
            /// <summary>
            /// The number of requests that match protection rules.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The type of rule that is matched. By default, this parameter is not returned. This indicates that all types of rules that are matched are returned.
            /// 
            /// *   **waf:** basic protection rules.
            /// *   **blacklist:** IP address blacklist rules.
            /// *   **custom:** custom rules.
            /// *   **antiscan:** scan protection rules.
            /// *   **cc_system:** HTTP flood protection rules.
            /// *   **region_block:** region blacklist rules.
            /// *   **scene:** bot management rules.
            /// *   **dlp:** data leakage prevention rules.
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

    }

}
