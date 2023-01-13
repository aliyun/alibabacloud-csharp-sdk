// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastGroupsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If the value returned of **NextToken** is empty, it indicates that no next query is to be sent.
        /// *   If **NextToken** is not empty, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
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
        /// The information about the multicast group.
        /// </summary>
        [NameInMap("TransitRouterMulticastGroups")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastGroupsResponseBodyTransitRouterMulticastGroups> TransitRouterMulticastGroups { get; set; }
        public class ListTransitRouterMulticastGroupsResponseBodyTransitRouterMulticastGroups : TeaModel {
            /// <summary>
            /// The IP address of the multicast group to which the multicast resource belongs.
            /// </summary>
            [NameInMap("GroupIpAddress")]
            [Validation(Required=false)]
            public string GroupIpAddress { get; set; }

            /// <summary>
            /// Indicates whether the multicast resource is a multicast member. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("GroupMember")]
            [Validation(Required=false)]
            public bool? GroupMember { get; set; }

            /// <summary>
            /// Indicates whether the multicast resource is a multicast source. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("GroupSource")]
            [Validation(Required=false)]
            public bool? GroupSource { get; set; }

            /// <summary>
            /// The type of the multicast source.
            /// 
            /// If the value is **Static**, the multicast source is manually specified.
            /// </summary>
            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// The ID of the ENI, which is a multicast resource.
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// The ID of the multicast domain associated with the multicast resource that is deployed across regions.
            /// </summary>
            [NameInMap("PeerTransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string PeerTransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// The ID of the resource associated with the multicast resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the multicast resource belongs.
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// The type of the multicast resource. Valid values:
            /// 
            /// *   **VPC**: The multicast resource is in a VPC.
            /// *   **TR**: The multicast resource is deployed across regions.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The type of the multicast member.
            /// 
            /// If the value is **Static**, the multicast member is manually specified.
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The status of the multicast resource. Valid values:
            /// 
            /// *   **Registering**: being created
            /// *   **Registered**: available
            /// *   **Deregistering**: being deleted
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the network instance connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// The ID of the multicast domain.
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the multicast resource belongs.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

    }

}
