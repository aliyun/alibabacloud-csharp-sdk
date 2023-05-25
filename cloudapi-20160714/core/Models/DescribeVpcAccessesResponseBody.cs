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
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("VpcAccessId")]
                [Validation(Required=false)]
                public string VpcAccessId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcTargetHostName")]
                [Validation(Required=false)]
                public string VpcTargetHostName { get; set; }

            }

        }

    }

}
