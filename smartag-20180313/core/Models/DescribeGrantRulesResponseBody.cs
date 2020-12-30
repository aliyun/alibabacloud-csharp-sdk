// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeGrantRulesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantRulesResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantRulesResponseBodyGrantRulesGrantRule : TeaModel {
                public string CenInstanceId { get; set; }
                public long? CenUid { get; set; }
                public long? GmtCreate { get; set; }
                public string GrantRuleId { get; set; }
                public bool? GrantTrafficService { get; set; }
                public long? GmtModified { get; set; }
                public long? CcnUid { get; set; }
                public string RegionId { get; set; }
                public string CcnInstanceId { get; set; }
            }
        };

    }

}
