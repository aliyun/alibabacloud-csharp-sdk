// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworksResponseBody : TeaModel {
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public DescribeNetworksResponseBodyNetworks Networks { get; set; }
        public class DescribeNetworksResponseBodyNetworks : TeaModel {
            [NameInMap("Network")]
            [Validation(Required=false)]
            public List<DescribeNetworksResponseBodyNetworksNetwork> Network { get; set; }
            public class DescribeNetworksResponseBodyNetworksNetwork : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                [NameInMap("NetworkName")]
                [Validation(Required=false)]
                public string NetworkName { get; set; }

                [NameInMap("RouterTableId")]
                [Validation(Required=false)]
                public string RouterTableId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeNetworksResponseBodyNetworksNetworkVSwitchIds VSwitchIds { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

            }

        }

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

    }

}
