// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DeregisterTransitRouterMulticastGroupMembersRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether only to precheck the request. Valid values:
        /// 
        /// *   **true**: only prechecks the request but does not remove the multicast members. The system checks the required parameters, the request format, and the service limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the API request. After the request passes the precheck, the multicast members are removed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The IP address of the multicast group to which the multicast members belong.
        /// </summary>
        [NameInMap("GroupIpAddress")]
        [Validation(Required=false)]
        public string GroupIpAddress { get; set; }

        /// <summary>
        /// The IDs of the elastic network interfaces (ENI).
        /// 
        /// You can specify multiple ENIs. Make sure that the total number of specified ENIs and multicast domains does not exceed five.
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
        /// The IDs of the multicast domains that is in a different region.
        /// 
        /// You can specify multiple multicast domains. Make sure that the total number of specified ENIs and multicast domains does not exceed five.
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

    }

}
