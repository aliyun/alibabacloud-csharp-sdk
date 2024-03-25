// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class RegisterTransitRouterMulticastGroupMembersRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The IP address of the multicast group to which the multicast members belong. Valid values: **224.0.0.1** to **239.255.255.254**.
        /// 
        /// If the multicast group does not exist in the specified multicast domain, the system automatically creates the multicast group in the multicast domain.
        /// </summary>
        [NameInMap("GroupIpAddress")]
        [Validation(Required=false)]
        public string GroupIpAddress { get; set; }

        /// <summary>
        /// The IDs of ENIs.
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The IDs of the multicast domains that are in different regions.
        /// </summary>
        [NameInMap("PeerTransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<string> PeerTransitRouterMulticastDomains { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the multicast domain to which the multicast members belong.
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainId")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainId { get; set; }

        /// <summary>
        /// The ID of the VPC to which the ENI belongs.
        /// 
        /// *   If the ENI belongs to the current Alibaba Cloud account, ignore this parameter.
        /// *   If the ENI belongs to a different Alibaba Cloud account, you must set this parameter.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
