// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToResourceResponseBody : TeaModel {
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public List<DescribeGrantRulesToResourceResponseBodyGrantRules> GrantRules { get; set; }
        public class DescribeGrantRulesToResourceResponseBodyGrantRules : TeaModel {
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("CenOwnerId")]
            [Validation(Required=false)]
            public long? CenOwnerId { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
