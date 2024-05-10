// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeForwardTableEntriesRequest : TeaModel {
        /// <summary>
        /// *   The elastic IP addresses (EIPs) that can be accessed over the Internet when you query DNAT entries of Internet NAT gateways.
        /// *   The NAT IP addresses that can be accessed by external networks when you query DNAT entries of Virtual Private Cloud (VPC) NAT gateways.
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// *   The external port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways.
        /// 
        ///     *   Valid values: **1** to **65535**.
        ///     *   If you want to query a port range, separate the first port and last port with a forward slash (/), such as `10/20`.
        ///     *   If you set **ExternalPort** to a port range, you must also set **InternalPort** to a port range, and the number of ports specified by these parameters must be the same. For example, if you set **ExternalPort** to `10/20`, you can set **InternalPort** to `80/90`.
        /// 
        /// *   The port that is used when the NAT IP address can be accessed by external networks when you query DNAT entries of VPC NAT gateways. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// The ID of the DNAT entry.
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// The name of the DNAT entry.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// The ID of the DNAT table.
        /// 
        /// **
        /// 
        /// **Description** You must specify at least one of **ForwardTableId** and **NatGatewayId**.
        /// </summary>
        [NameInMap("ForwardTableId")]
        [Validation(Required=false)]
        public string ForwardTableId { get; set; }

        /// <summary>
        /// The private IP address.
        /// 
        /// *   The private IP address of the ECS instance that uses DNAT entries to communicate with the Internet when you query DNAT entries of Internet NAT gateways.
        /// *   The private IP address that uses DNAT entries for communication when you query DNAT entries of VPC NAT gateways.
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// *   The internal port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways. Valid values: **1** to **65535**.
        /// *   The port of the destination ECS instance to be mapped when you query DNAT entries of VPC NAT gateways. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// The protocol. Valid values:
        /// 
        /// *   **TCP**
        /// *   **UDP**
        /// *   **Any**
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// The ID of the NAT gateway.
        /// 
        /// **
        /// 
        /// **Description** You must specify at least one of **ForwardTableId** and **NatGatewayId**.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where you want to create the NAT gateway.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
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
