// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnGatewayRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the IPsec-VPN feature. Valid values:
        /// 
        /// *   **true** (default): yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable the SSL-VPN feature for the VPN gateway. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// The maximum number of clients that can be connected at the same time. Valid values: **5** (default), **10**, **20**, **50**, **100**, **200**, **500**, and **1000**.
        /// </summary>
        [NameInMap("EnableIpsec")]
        [Validation(Required=false)]
        public bool? EnableIpsec { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the VPN gateway belongs.
        /// </summary>
        [NameInMap("EnableSsl")]
        [Validation(Required=false)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payment for the VPN gateway. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The billing method of the VPN gateway. Set the value to **POSTPAY**, which specifies the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the request.
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
        /// The maximum bandwidth of the VPN gateway. Unit: Mbit/s.
        /// 
        /// *   If you want to create a public VPN gateway, valid values are **10**, **100**, **200**, **500**, and **1000**.
        /// *   If you want to create a private VPN gateway, valid values are **200** and **1000**.
        /// 
        /// >  In some regions, the maximum bandwidth supported by a VPN gateway is 200 Mbit/s. For more information, see [Limits on VPN gateways](~~65290~~).
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) where you want to create the VPN gateway.
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
        /// The type of the VPN gateway. Valid values:
        /// 
        /// *   **Normal** (default): standard
        /// </summary>
        [NameInMap("SslConnections")]
        [Validation(Required=false)]
        public int? SslConnections { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system sets **ClientToken** to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The subscription duration. Unit: months. Valid values: **1** to **9**, **12**, **24**, and **36**.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The network type of the VPN gateway. Valid values:
        /// 
        /// *   **public** (default): public VPN gateway
        /// *   **private**: private VPN gateway
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
