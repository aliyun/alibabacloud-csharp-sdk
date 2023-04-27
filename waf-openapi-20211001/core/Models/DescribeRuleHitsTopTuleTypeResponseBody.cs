// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopTuleTypeResponseBody : TeaModel {
        /// <summary>
        /// The number of requests that match the rules of the protection module.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of rules. For details, see the description of **RuleType** in [DescribeRuleHitsTopRuleId](~~DescribeRuleHitsTopRuleId~~).
        /// </summary>
        [NameInMap("RuleHitsTopTuleType")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType> RuleHitsTopTuleType { get; set; }
        public class DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

    }

}
