// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouteTableAggregationRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **false** (default): performs a dry run and sends the request.
        /// *   **true**: performs a dry run. The system checks the required parameters and request syntax. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
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
        /// The destination CIDR block of the aggregate route.
        /// 
        /// >  The following CIDR blocks are not supported:
        /// 
        /// *   CIDR blocks that start with 0 or 100.64.
        /// *   Multicast CIDR blocks, including 224.0.0.1 to 239.255.255.254.
        /// </summary>
        [NameInMap("TransitRouteTableAggregationCidr")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationCidr { get; set; }

        /// <summary>
        /// The description of the aggregate route.
        /// 
        /// The description must be 2 to 256 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -. You can also leave the description empty.
        /// </summary>
        [NameInMap("TransitRouteTableAggregationDescription")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationDescription { get; set; }

        /// <summary>
        /// The name of the aggregate route.
        /// 
        /// The name must be 1 to 128 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -. You can also leave the name empty.
        /// </summary>
        [NameInMap("TransitRouteTableAggregationName")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationName { get; set; }

        /// <summary>
        /// The scope of networks that you want to advertise the aggregate route.
        /// 
        /// Set the value to **VPC**, which specified that the aggregate route is advertised to VPCs that are in associated forwarding relationship with a route table of the Enterprise Edition transit router and have route synchronization enabled.
        /// </summary>
        [NameInMap("TransitRouteTableAggregationScope")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationScope { get; set; }

        /// <summary>
        /// The ID of the route table of the Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouteTableId { get; set; }

    }

}
