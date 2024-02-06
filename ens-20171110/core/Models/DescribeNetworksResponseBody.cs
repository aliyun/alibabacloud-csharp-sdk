// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworksResponseBody : TeaModel {
        /// <summary>
        /// The list of networks.
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public DescribeNetworksResponseBodyNetworks Networks { get; set; }
        public class DescribeNetworksResponseBodyNetworks : TeaModel {
            [NameInMap("Network")]
            [Validation(Required=false)]
            public List<DescribeNetworksResponseBodyNetworksNetwork> Network { get; set; }
            public class DescribeNetworksResponseBodyNetworksNetwork : TeaModel {
                /// <summary>
                /// The IPv4 CIDR block of the network.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// The timestamp when the instance was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The description of the network.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the edge node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The ID of the network access control list (ACL).
                /// </summary>
                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                /// <summary>
                /// The ID of the network.
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// The name of the network.
                /// </summary>
                [NameInMap("NetworkName")]
                [Validation(Required=false)]
                public string NetworkName { get; set; }

                /// <summary>
                /// The route table ID.
                /// </summary>
                [NameInMap("RouterTableId")]
                [Validation(Required=false)]
                public string RouterTableId { get; set; }

                /// <summary>
                /// The status of the network. Valid values:
                /// 
                /// *   Pending
                /// *   Available
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The list of vSwitches in the network.
                /// </summary>
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

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries in the list.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
