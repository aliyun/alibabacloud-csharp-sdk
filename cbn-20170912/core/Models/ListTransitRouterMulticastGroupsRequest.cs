// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastGroupsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The token can contain only ASCII characters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The IP address of the multicast group.
        /// 
        /// Each multicast group is identified by its IP address.
        /// </summary>
        [NameInMap("GroupIpAddress")]
        [Validation(Required=false)]
        public string GroupIpAddress { get; set; }

        /// <summary>
        /// Specified whether to query the multicast members. Valid values:
        /// 
        /// *   **false**: no
        /// *   **true**: yes
        /// 
        /// >- This parameter can be set together with the IsGroupMember parameter.
        /// >- If you do not set IsGroupMember or IsGroupSource, both the multicast sources and members are queried.
        /// >- If you set only one of them or both of them, the specified values prevail.
        /// </summary>
        [NameInMap("IsGroupMember")]
        [Validation(Required=false)]
        public bool? IsGroupMember { get; set; }

        /// <summary>
        /// Specifies whether to query the multicast sources. Valid values:
        /// 
        /// *   **false**: no
        /// *   **true**: yes
        /// 
        /// >- This parameter can be set together with the IsGroupMember parameter.
        /// >- If you do not set IsGroupSource or IsGroupMember, both the multicast sources and members are queried.
        /// >- If you set only one of them or both of them, the specified values prevail.
        /// </summary>
        [NameInMap("IsGroupSource")]
        [Validation(Required=false)]
        public bool? IsGroupSource { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The IDs of ENIs.
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If this is your first query and no next queries are to be sent, ignore this parameter.
        /// *   If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the inter-region multicast domain.
        /// </summary>
        [NameInMap("PeerTransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<string> PeerTransitRouterMulticastDomains { get; set; }

        /// <summary>
        /// The ID of the resource associated with the multicast resource.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the multicast resource. Valid values:
        /// 
        /// *   **VPC**: queries multicast resources by VPC.
        /// *   **TR**: queries multicast resources that are also deployed in a different region.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

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
        /// The vSwitch IDs.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
