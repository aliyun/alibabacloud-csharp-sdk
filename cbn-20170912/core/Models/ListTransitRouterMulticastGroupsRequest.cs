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
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
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
        /// Whether to query multicast members.
        /// 
        /// - **false**: No.
        /// - **true**: Yes.
        /// 
        /// > Used in conjunction with IsGroupMember.
        /// > - If neither is configured, the multicast source and members will be queried by default.
        /// > - If only one or both are configured, the configuration parameters shall prevail.
        /// </summary>
        [NameInMap("IsGroupMember")]
        [Validation(Required=false)]
        public bool? IsGroupMember { get; set; }

        /// <summary>
        /// Whether to query the multicast source.
        /// 
        /// - **false**: No.
        /// - **true**: Yes.
        /// 
        /// > Used in conjunction with IsGroupMember.
        /// > - If neither is configured, the multicast source and members will be queried by default.
        /// > - If only one or both are configured, the configuration parameters shall prevail.
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
        /// The IDs of the ENIs.
        /// 
        /// You can create only one multicast source in a multicast group.
        /// 
        /// >  This parameter is required.
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If this is your first query or no next query is to be sent, ignore this parameter.
        /// *   If a next query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
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
        /// The IDs of the inter-region multicast domains.
        /// 
        /// You can specify at most 20 inter-region multicast domain IDs.
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
        /// The IDs of the vSwitches.
        /// 
        /// You can specify at most 20 IDs.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
