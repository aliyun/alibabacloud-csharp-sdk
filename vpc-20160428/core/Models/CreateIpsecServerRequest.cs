// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIpsecServerRequest : TeaModel {
        /// <summary>
        /// The client CIDR block from which an IP address is allocated to the virtual network interface controller (NIC) of the client.
        /// 
        /// >  The client CIDR block must not overlap with the CIDR blocks of the VPC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

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
        /// Specifies whether to only precheck this request. Valid values:
        /// 
        /// *   **true**: prechecks the request without creating the IPsec server. The system checks the required parameters, request format, and service limits. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. This is the default value. If the request passes the precheck, the system creates the IPsec server.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// Specify whether to start connection negotiations immediately. Valid values:
        /// 
        /// *   **true**: immediately initiates negotiations after the configuration is complete.
        /// *   **false** (default): initiates negotiations when inbound traffic is detected. This is the default value.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// The configuration of Phase 1 negotiation. Valid values:
        /// 
        /// *   **IkeVersion**: the IKE version. Valid values: **ikev1** and **ikev2**. Default value: **ikev2**.
        /// *   **IkeMode**: the IKE negotiation mode. Default value: **main**.
        /// *   **IkeEncAlg**: the encryption algorithm that is used in Phase 1 negotiation. Default value: **aes**.
        /// *   **IkeAuthAlg**: the authentication algorithm that is used in Phase 1 negotiation. Default value: **sha1**.
        /// *   **IkePfs**: the Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiation. Default value: **group2**.
        /// *   **IkeLifetime**: the security association (SA) lifetime determined by Phase 1 negotiation. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// *   **LocalId**: the identifier of the IPsec server. The value can be a fully qualified domain name (FQDN) or an IP address. The default value is the public IP address of the VPN gateway.
        /// *   **RemoteId**: the peer identifier. The value can be an FQDN or an IP address. The default value is empty.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// The name of the IPsec server.
        /// 
        /// The name must be 1 to 100 characters in length.
        /// </summary>
        [NameInMap("IpSecServerName")]
        [Validation(Required=false)]
        public string IpSecServerName { get; set; }

        /// <summary>
        /// The configuration of Phase 2 negotiation. Valid values:
        /// 
        /// *   **IpsecEncAlg**: the encryption algorithm that is used in Phase 2 negotiation. Default value: **aes**.
        /// *   **IpsecAuthAlg**: the authentication algorithm that is used in Phase 2 negotiation. Default value: **sha1**.
        /// *   **IpsecPfs**: forwards packets of all protocols. The Diffie-Hellman key exchange algorithm that is used in Phase 2 negotiation. Default value: **group2**.
        /// *   **IpsecLifetime**: the SA lifetime determined by Phase 2 negotiation. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// The local CIDR blocks, which are the CIDR blocks of the virtual private cloud (VPC) for the client to access.
        /// 
        /// Multiple CIDR blocks are separated with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// The pre-shared key.
        /// 
        /// The pre-shared key is used for identity authentication between the IPsec server and the client. The key must be 1 to 100 characters in length.
        /// 
        /// If you do not specify a pre-shared key, the system randomly generates a 16-character string as the pre-shared key. You can call the [ListIpsecServers](https://help.aliyun.com/document_detail/2794120.html) operation to query the pre-shared keys that are generated by the system.
        /// 
        /// >  The pre-shared key of the IPsec server must be the same as the client key. Otherwise, the IPsec server cannot be connected to the client.
        /// </summary>
        [NameInMap("Psk")]
        [Validation(Required=false)]
        public string Psk { get; set; }

        /// <summary>
        /// Indicates whether pre-shared key authentication is enabled. If you set the value to **true**, pre-shared key authentication is enabled.
        /// 
        /// >  This parameter is required.
        /// </summary>
        [NameInMap("PskEnabled")]
        [Validation(Required=false)]
        public bool? PskEnabled { get; set; }

        /// <summary>
        /// The ID of the region where the VPN gateway is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
