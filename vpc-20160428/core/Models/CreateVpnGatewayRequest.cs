// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnGatewayRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment for the VPN gateway. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The maximum bandwidth of the VPN gateway. Unit: Mbit/s.
        /// 
        /// *   If you want to create a public VPN gateway, valid values are **10**, **100**, **200**, **500**, and **1000**.
        /// *   If you want to create a private VPN gateway, valid values are **200** and **1000**.
        /// 
        /// >  The maximum bandwidth supported by VPN gateways in some regions is 200 Mbit/s. For more information, see [VPN gateway limits](~~65290~~).
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a value, and you must make sure that each request has a unique token value. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The value of **RequestId** for each API request is different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The second vSwitch with which you want to associate the VPN gateway.
        /// 
        /// *   If you call this operation in a region that supports the IPsec-VPN connections in dual-tunnel mode, this parameter is required.
        /// *   You need to specify two vSwitches in different zones in the virtual private cloud (VPC) that is associated with the VPN gateway to implement disaster recovery across zones.
        /// *   For a region that supports only one zone, disaster recovery across zones is not supported. We recommend that you specify two vSwitches in the zone to implement high availability. You can specify the same vSwitch.
        /// 
        /// For more information about the regions and zones that support the IPsec-VPN connections in dual-tunnel mode, see [IPsec-VPN connections support the dual-tunnel mode](~~2358946~~).
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// Specifies whether to enable the IPsec-VPN feature. Valid values:
        /// 
        /// *   **true** (default)
        /// *   **false**
        /// </summary>
        [NameInMap("EnableIpsec")]
        [Validation(Required=false)]
        public bool? EnableIpsec { get; set; }

        /// <summary>
        /// Specifies whether to enable the SSL-VPN feature for the VPN gateway. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("EnableSsl")]
        [Validation(Required=false)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// The billing method of the VPN gateway. Set the value to **POSTPAY**, which specifies the pay-as-you-go billing method.
        /// 
        /// > This parameter is required when you create a VPN gateway.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The name of the VPN gateway. The default value is the ID of the VPN gateway.
        /// 
        /// The name must be 2 to 100 characters in length and cannot start with `http://` or `https://`. It must start with a letter and can contain letters, digits, underscores (\_), hyphens (-), and periods (.). Other special characters are not supported.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The network type of the VPN gateway. Valid values:
        /// 
        /// *   **public** (default)
        /// *   **private**
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The subscription duration. Unit: month. Valid values: **1** to **9**, **12**, **24**, and **36**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The region ID of the VPN gateway. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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

        /// <summary>
        /// The maximum number of clients that can be connected at the same time. Valid values: **5** (default), **10**, **20**, **50**, **100**, **200**, **500**, and **1000**.
        /// </summary>
        [NameInMap("SslConnections")]
        [Validation(Required=false)]
        public int? SslConnections { get; set; }

        /// <summary>
        /// The vSwitch with which you want to associate the VPN gateway.
        /// 
        /// *   If you call this operation in a region that supports the IPsec-VPN connections in dual-tunnel mode, this parameter is required. You must specify a vSwitch and specify **DisasterRecoveryVSwitchId**.
        /// *   If you call this operation in a region that supports the IPsec-VPN connections in single-tunnel mode and do not specify a vSwitch, the system automatically specifies a vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) where you want to create the VPN gateway.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The type of the VPN gateway. Valid values:
        /// 
        /// Set the value to **Normal** (default), which specifies a standard NAT gateway.
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
