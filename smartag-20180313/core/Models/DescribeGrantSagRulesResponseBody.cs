// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeGrantSagRulesResponseBody : TeaModel {
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
        public DescribeGrantSagRulesResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantSagRulesResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantSagRulesResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantSagRulesResponseBodyGrantRulesGrantRule : TeaModel {
                public long? CreateTime { get; set; }
                public string SmartAGId { get; set; }
                public bool? GrantTrafficService { get; set; }
                public string InstanceId { get; set; }
                public long? CcnUid { get; set; }
                public string CcnInstanceId { get; set; }
            }
        };

    }

}
