// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeHaVipsResponseBody : TeaModel {
        [NameInMap("HaVips")]
        [Validation(Required=false)]
        public List<DescribeHaVipsResponseBodyHaVips> HaVips { get; set; }
        public class DescribeHaVipsResponseBodyHaVips : TeaModel {
            [NameInMap("AssociatedEipAddresses")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsAssociatedEipAddresses> AssociatedEipAddresses { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsAssociatedEipAddresses : TeaModel {
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                [NameInMap("EipId")]
                [Validation(Required=false)]
                public string EipId { get; set; }

            }

            [NameInMap("AssociatedInstances")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsAssociatedInstances> AssociatedInstances { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsAssociatedInstances : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            [NameInMap("HaVipId")]
            [Validation(Required=false)]
            public string HaVipId { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
