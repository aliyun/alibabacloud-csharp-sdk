// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcPeer20220101.Models
{
    public class ListVpcPeerConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If the value of **NextToken** is returned, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The details of the VPC peering connections.
        /// </summary>
        [NameInMap("VpcPeerConnects")]
        [Validation(Required=false)]
        public List<ListVpcPeerConnectionsResponseBodyVpcPeerConnects> VpcPeerConnects { get; set; }
        public class ListVpcPeerConnectionsResponseBodyVpcPeerConnects : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the accepter VPC belongs.
            /// </summary>
            [NameInMap("AcceptingOwnerUid")]
            [Validation(Required=false)]
            public int? AcceptingOwnerUid { get; set; }

            /// <summary>
            /// The region ID of the accepter VPC.
            /// </summary>
            [NameInMap("AcceptingRegionId")]
            [Validation(Required=false)]
            public string AcceptingRegionId { get; set; }

            /// <summary>
            /// The details of the accepter VPC.
            /// </summary>
            [NameInMap("AcceptingVpc")]
            [Validation(Required=false)]
            public ListVpcPeerConnectionsResponseBodyVpcPeerConnectsAcceptingVpc AcceptingVpc { get; set; }
            public class ListVpcPeerConnectionsResponseBodyVpcPeerConnectsAcceptingVpc : TeaModel {
                /// <summary>
                /// The CIDR block of the accepter VPC.
                /// </summary>
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// The IPv6 CIDR block of the accepter VPC.
                /// </summary>
                [NameInMap("Ipv6Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv6Cidrs { get; set; }

                /// <summary>
                /// The ID of the accepter VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The bandwidth of the VPC peering connection. Unit: Mbit/s. The value is an integer greater than 0.
            /// 
            /// >  If the value is set to -1, it indicates that no limit is imposed on the bandwidth.
            /// 
            /// Default value:
            /// 
            /// *   The default bandwidth of an inter-region VPC peering connection is **1024** Mbit/s.
            /// *   The default bandwidth of an intra-region VPC peering connection is **-1** Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The business status of the VPC peering connection. Valid values:
            /// 
            /// *   **Normal**
            /// *   **FinancialLocked**
            /// </summary>
            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// The description of the VPC peering connection.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the VPC peering connection was created. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format in UTC.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The expiration time of the VPC peering connection. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format in UTC.
            /// 
            /// The expiration time is returned only when the **Status** of the VPC peering connection is **Accepting** or **Expired**. Otherwise, **null** is returned.
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// The time when the VPC peering connection was modified. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format in UTC.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the VPC peering connection.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the VPC peering connection.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the requester VPC belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public int? OwnerId { get; set; }

            /// <summary>
            /// The region ID of the requester VPC.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The status of the VPC peering connection. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Accepting**
            /// *   **Updating**
            /// *   **Rejected**
            /// *   **Expired**
            /// *   **Activated**
            /// *   **Deleting**
            /// *   **Deleted**
            /// 
            /// For more information about the status of VPC peering connections, see [Overview of VPC peering connections](~~418507~~).
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag list.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcPeerConnectionsResponseBodyVpcPeerConnectsTags> Tags { get; set; }
            public class ListVpcPeerConnectionsResponseBodyVpcPeerConnectsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The details of the requester VPC.
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public ListVpcPeerConnectionsResponseBodyVpcPeerConnectsVpc Vpc { get; set; }
            public class ListVpcPeerConnectionsResponseBodyVpcPeerConnectsVpc : TeaModel {
                /// <summary>
                /// The CIDR block of the requester VPC.
                /// </summary>
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// The IPv6 CIDR block of the requester VPC.
                /// </summary>
                [NameInMap("Ipv6Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv6Cidrs { get; set; }

                /// <summary>
                /// The ID of the requester VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

    }

}
