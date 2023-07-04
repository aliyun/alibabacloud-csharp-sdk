// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatIpRequest : TeaModel {
        /// <summary>
        /// The ID of the CIDR block to which the NAT IP address belongs.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The CIDR block to which the NAT IP address belongs.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The description of the NAT IP address.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The NAT IP address.
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// The NAT IP address that you want to create.
        /// 
        /// If you do not specify an IP address, the system selects a random IP address from the specified CIDR block.
        /// </summary>
        [NameInMap("NatIpCidr")]
        [Validation(Required=false)]
        public string NatIpCidr { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("NatIpDescription")]
        [Validation(Required=false)]
        public string NatIpDescription { get; set; }

        /// <summary>
        /// Specifies whether only to precheck this request. Valid values:
        /// 
        /// *   **true**: sends the precheck request but does not create the NAT IP address. The system checks your AccessKey pair, the Resource Access Management (RAM) user permissions, and the required parameters. If the request fails the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. If the request passes the precheck, a 2xx HTTP status code is returned and the NAT IP address is created.
        /// </summary>
        [NameInMap("NatIpName")]
        [Validation(Required=false)]
        public string NatIpName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The name of the NAT IP address.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter. It cannot start with `http://` or `https://`.
        /// </summary>
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
