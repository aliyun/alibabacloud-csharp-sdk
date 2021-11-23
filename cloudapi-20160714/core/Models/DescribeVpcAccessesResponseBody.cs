// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeVpcAccessesResponseBody : TeaModel {
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

        [NameInMap("VpcAccessAttributes")]
        [Validation(Required=false)]
        public DescribeVpcAccessesResponseBodyVpcAccessAttributes VpcAccessAttributes { get; set; }
        public class DescribeVpcAccessesResponseBodyVpcAccessAttributes : TeaModel {
            [NameInMap("VpcAccessAttribute")]
            [Validation(Required=false)]
            public List<DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttribute> VpcAccessAttribute { get; set; }
            public class DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttribute : TeaModel {
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
                public int? Port { get; set; }
                public string RegionId { get; set; }
                public string VpcId { get; set; }
            }
        };

    }

}
