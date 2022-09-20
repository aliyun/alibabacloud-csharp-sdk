// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6EgressOnlyRulesResponseBody : TeaModel {
        [NameInMap("Ipv6EgressOnlyRules")]
        [Validation(Required=false)]
        public DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRules Ipv6EgressOnlyRules { get; set; }
        public class DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRules : TeaModel {
            [NameInMap("Ipv6EgressOnlyRule")]
            [Validation(Required=false)]
            public List<DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRulesIpv6EgressOnlyRule> Ipv6EgressOnlyRule { get; set; }
            public class DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRulesIpv6EgressOnlyRule : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Ipv6EgressOnlyRuleId")]
                [Validation(Required=false)]
                public string Ipv6EgressOnlyRuleId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
