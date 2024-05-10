// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateForwardEntryRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// *   The EIP that can be accessed over the Internet when you configure a DNAT entry for an Internet NAT gateway.
        /// *   The NAT IP address that can be accessed by external networks when you configure a DNAT entry for a VPC NAT gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// *   The external port range that is used for port forwarding when you configure a DNAT entry for an Internet NAT gateway.
        /// 
        ///     *   Valid values: **1** to **65535**.
        ///     *   To specify a port range, separate the first port and the last port with a forward slash (/), for example, `10/20`.
        ///     *   If you set **ExternalPort** to a port range, you must also set **InternalPort** to a port range, and the number of ports specified by these parameters must be the same. For example, if you set **ExternalPort** to `10/20`, you can set **InternalPort** to `80/90`.
        /// 
        /// *   The port that can be accessed by external networks when you configure a DNAT entry for a VPC NAT gateway. Valid values: **1** to **65535**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// The name of the DNAT entry.
        /// 
        /// The name must be 2 to 128 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// The ID of the DNAT table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ForwardTableId")]
        [Validation(Required=false)]
        public string ForwardTableId { get; set; }

        /// <summary>
        /// *   The private IP address of the ECS instance that needs to communicate with the Internet when you configure a DNAT entry for an Internet NAT gateway. The private IP address must meet the following requirements:
        /// 
        ///     *   It must belong to the CIDR block of the VPC where the NAT gateway is deployed.
        ///     *   The DNAT entry takes effect only if the private IP address is assigned to an ECS instance and the ECS instance is not associated with an EIP.
        /// 
        /// *   The private IP address that uses DNAT when you add a DNAT entry to a VPC NAT gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// *   The internal port or port range that is used for port forwarding when you configure a DNAT entry for an Internet NAT gateway. Valid values: **1** to **65535**.
        /// *   The port of the destination ECS instance to be mapped when you configure a DNAT entry for a VPC NAT gateway. Valid values: **1** to **65535**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// The protocol. Valid values:
        /// 
        /// *   **TCP**
        /// *   **UDP**
        /// *   **Any** If you set **IpProtocol** to **Any**, you must also set **ExternalPort** and **InternalPort** to **Any** to implement DNAT IP mapping.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to remove limits on the port range. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// >  If a DNAT entry and an SNAT entry have the same public IP address, ou must specify a port that is larger that 1024, and set **PortBreak** to **true**.
        /// </summary>
        [NameInMap("PortBreak")]
        [Validation(Required=false)]
        public bool? PortBreak { get; set; }

        /// <summary>
        /// The region ID of the NAT gateway.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to obtain the region ID.
        /// 
        /// This parameter is required.
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
