// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateIpv4GatewayAttributeRequest : TeaModel {
        /// <summary>
        /// The new description of the IPv4 gateway.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The region ID of the IPv4 gateway whose name or description you want to modify.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Ipv4GatewayDescription")]
        [Validation(Required=false)]
        public string Ipv4GatewayDescription { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("Ipv4GatewayId")]
        [Validation(Required=false)]
        public string Ipv4GatewayId { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: checks the request without performing the operation. The system checks the required parameters, request syntax, and limits. If the request fails the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. If the request passes the check, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("Ipv4GatewayName")]
        [Validation(Required=false)]
        public string Ipv4GatewayName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
