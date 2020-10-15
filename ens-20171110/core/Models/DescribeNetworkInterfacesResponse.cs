// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkInterfacesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("NetworkInterfaceSets")]
        [Validation(Required=true)]
        public DescribeNetworkInterfacesResponseNetworkInterfaceSets NetworkInterfaceSets { get; set; }
        public class DescribeNetworkInterfacesResponseNetworkInterfaceSets : TeaModel {
            [NameInMap("NetworkInterfaceSet")]
            [Validation(Required=true)]
            public List<DescribeNetworkInterfacesResponseNetworkInterfaceSetsNetworkInterfaceSet> NetworkInterfaceSet { get; set; }
            public class DescribeNetworkInterfacesResponseNetworkInterfaceSetsNetworkInterfaceSet : TeaModel {
                public string Status { get; set; }
                public string PrimaryIp { get; set; }
                public string EnsRegionId { get; set; }
                public string InstanceId { get; set; }
                public string VSwitchId { get; set; }
                public string NetworkInterfaceId { get; set; }
                public string MacAddress { get; set; }
                public string CreationTime { get; set; }
                public string PrimaryIpType { get; set; }
            }
        };

    }

}
