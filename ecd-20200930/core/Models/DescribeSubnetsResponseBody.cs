// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSubnetsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Subnets")]
        [Validation(Required=false)]
        public List<DescribeSubnetsResponseBodySubnets> Subnets { get; set; }
        public class DescribeSubnetsResponseBodySubnets : TeaModel {
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public int? TotalEdsCount { get; set; }

            [NameInMap("TotalEdsCountForGroup")]
            [Validation(Required=false)]
            public int? TotalEdsCountForGroup { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
