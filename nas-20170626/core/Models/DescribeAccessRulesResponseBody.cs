// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessRulesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("AccessRules")]
        [Validation(Required=false)]
        public DescribeAccessRulesResponseBodyAccessRules AccessRules { get; set; }
        public class DescribeAccessRulesResponseBodyAccessRules : TeaModel {
            [NameInMap("AccessRule")]
            [Validation(Required=false)]
            public List<DescribeAccessRulesResponseBodyAccessRulesAccessRule> AccessRule { get; set; }
            public class DescribeAccessRulesResponseBodyAccessRulesAccessRule : TeaModel {
                public string AccessRuleId { get; set; }
                public string SourceCidrIp { get; set; }
                public string Ipv6SourceCidrIp { get; set; }
                public string RWAccess { get; set; }
                public string UserAccess { get; set; }
                public int? Priority { get; set; }
            }
        };

    }

}
