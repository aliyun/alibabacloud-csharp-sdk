// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateIpsecServerRequest : TeaModel {
        /// <summary>
        /// The client CIDR block. It refers to the CIDR block that is used to allocate an IP address to the client.
        /// 
        /// >  The client CIDR block must not overlap with the CIDR block of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to precheck the request without performing the operation. Valid values:
        /// 
        /// *   **true**: only prechecks the request. After the request passes the precheck, the system does not modify the configurations of the IPsec server. The system checks whether the required parameters are set, whether the values are in valid formats, and the service limits. If the request fails to pass the precheck, a corresponding error code is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): prechecks the request. After the request passes the precheck, the system modifies the configurations of the IPsec server.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// Specifies whether to delete the current IPsec tunnel and reinitiate negotiations. Valid values:
        /// 
        /// *   **true**: starts the negotiation immediately after the configuration is completed.
        /// *   **false** (default): initiates negotiations when inbound traffic is detected.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// The configuration of Phase 1 negotiations. Valid values:
        /// 
        /// *   **IkeVersion**: the IKE version. Valid values: **ikev1** and **ikev2**. Default value: **ikev2**.
        /// *   **IkeMode**: the IKE negotiation mode. Default value: **main**.
        /// *   **IkeEncAlg**: the encryption algorithm that is used in Phase 1 negotiations. Default value: **aes**.
        /// *   **IkeAuthAlg**: the authentication algorithm that is used in Phase 1 negotiations. Default value: **sha1**.
        /// *   **IkePfs**: the Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiations. Default value: **group2**.
        /// *   **IkeLifetime**: the SA lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// *   **LocalId**: the ID of the IPsec server. The value can be a fully qualified domain name (FQDN) or an IP address. By default, the ID of the IPsec server is the public IP address of the VPN gateway.
        /// *   **RemoteId**: the identifier of the customer gateway. The value can be an FQDN or an IP address. By default, this parameter is not specified.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// The configuration of Phase 2 negotiations. Valid values:
        /// 
        /// *   **IpsecEncAlg**: the encryption algorithm that is used in Phase 2 negotiations. Default value: **aes**.
        /// *   **IpsecAuthAlg**: the authentication algorithm that is used in Phase 2 negotiations. Default value: **sha1**.
        /// *   **IpsecPfs**: forwards packets of all protocols. The Diffie-Hellman key exchange algorithm used in Phase 2 negotiations. Default value: **group2**.
        /// *   **IpsecLifetime**: the SA lifetime determined by Phase 2 negotiations. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// The ID of the IPsec server.
        /// </summary>
        [NameInMap("IpsecServerId")]
        [Validation(Required=false)]
        public string IpsecServerId { get; set; }

        /// <summary>
        /// The name of the IPsec server.
        /// 
        /// The name must be 1 to 100 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("IpsecServerName")]
        [Validation(Required=false)]
        public string IpsecServerName { get; set; }

        /// <summary>
        /// The local CIDR blocks, which refer to the CIDR blocks on the virtual private cloud (VPC) side.
        /// 
        /// Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// The pre-shared key.
        /// 
        /// Enter the pre-shared key that is used for identity authentication between the IPsec server and the client. The key must be 1 to 100 characters in length.
        /// 
        /// If you do not specify a pre-shared key, the system randomly generates a 16-character string as the pre-shared key. You can call the [ListIpsecServers](~~205453~~) operation to query the pre-shared keys that are generated by the system.
        /// 
        /// >  The pre-shared key of the IPsec server must be the same as the authentication key of the client. Otherwise, a connection cannot be established between the IPsec server and the client.
        /// </summary>
        [NameInMap("Psk")]
        [Validation(Required=false)]
        public string Psk { get; set; }

        /// <summary>
        /// Specifies whether to enable pre-shared key authentication. If you set the value to **true**, pre-shared key authentication is enabled.
        /// </summary>
        [NameInMap("PskEnabled")]
        [Validation(Required=false)]
        public bool? PskEnabled { get; set; }

        /// <summary>
        /// The ID of the region where the IPsec server is created.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
