// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesToCenResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule : TeaModel {
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                [NameInMap("ChildInstanceId")]
                [Validation(Required=false)]
                public string ChildInstanceId { get; set; }

                [NameInMap("ChildInstanceOwnerId")]
                [Validation(Required=false)]
                public long? ChildInstanceOwnerId { get; set; }

                [NameInMap("ChildInstanceRegionId")]
                [Validation(Required=false)]
                public string ChildInstanceRegionId { get; set; }

                [NameInMap("ChildInstanceType")]
                [Validation(Required=false)]
                public string ChildInstanceType { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
