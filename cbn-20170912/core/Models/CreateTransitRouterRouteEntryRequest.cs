// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterRouteEntryRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Default values:
        /// 
        /// *   **false** (default): performs a dry run and sends the request.
        /// *   **true**: performs a dry run. The system checks the required parameters and request syntax. If the request fails the dry run, an error message is returned. If the request passes the dry run, the system returns the ID of the request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The description of the route.
        /// 
        /// The description must be 2 to 256 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -. You can also leave the description empty.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryDescription")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryDescription { get; set; }

        /// <summary>
        /// The destination CIDR block of the route.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

        /// <summary>
        /// The name of the route.
        /// 
        /// The name must be 0 to 128 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryName")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryName { get; set; }

        /// <summary>
        /// The ID of the network instance connection that you want to specify as the next hop.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopId { get; set; }

        /// <summary>
        /// The type of the next hop. Valid values:
        /// 
        /// *   **BlackHole**: routes network traffic to a black hole. All packets that match this route are dropped. If you select this option, you do not need to specify the next hop information.
        /// *   **Attachment**: routes network traffic to a network instance connection. If you select this option, you must specify the ID of the network instance connection. All packets that match this route are routed to the specified network instance connection.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopType { get; set; }

        /// <summary>
        /// The route table IDs of the Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
