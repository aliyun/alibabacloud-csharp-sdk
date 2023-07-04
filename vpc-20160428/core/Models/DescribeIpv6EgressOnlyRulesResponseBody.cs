// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6EgressOnlyRulesResponseBody : TeaModel {
        /// <summary>
        /// The details about the egress-only rules.
        /// </summary>
        [NameInMap("Ipv6EgressOnlyRules")]
        [Validation(Required=false)]
        public DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRules Ipv6EgressOnlyRules { get; set; }
        public class DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRules : TeaModel {
            [NameInMap("Ipv6EgressOnlyRule")]
            [Validation(Required=false)]
            public List<DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRulesIpv6EgressOnlyRule> Ipv6EgressOnlyRule { get; set; }
            public class DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRulesIpv6EgressOnlyRule : TeaModel {
                /// <summary>
                /// The description of the egress-only rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the instance to which the egress-only rule applies.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The type of the instance to which the egress-only rule applies.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The ID of the egress-only rule.
                /// </summary>
                [NameInMap("Ipv6EgressOnlyRuleId")]
                [Validation(Required=false)]
                public string Ipv6EgressOnlyRuleId { get; set; }

                /// <summary>
                /// The name of the egress-only rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the egress-only rule.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
