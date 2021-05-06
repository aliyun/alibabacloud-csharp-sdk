// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesToCenResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule : TeaModel {
                public string ChildInstanceType { get; set; }
                public string ChildInstanceRegionId { get; set; }
                public long? ChildInstanceOwnerId { get; set; }
                public string ChildInstanceId { get; set; }
                public string CenId { get; set; }
            }
        };

    }

}
