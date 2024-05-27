// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateIpsecServerRequest : TeaModel {
        /// <summary>
        /// The client CIDR block from which an IP address is allocated to the virtual network interface controller (NIC) of the client.
        /// 
        /// >  The client CIDR block must not overlap with the CIDR blocks of the VPC.
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a value, and you must make sure that each request has a unique token value. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to only precheck this request. Valid values:
        /// 
        /// *   **true**: prechecks the request without modifying the configurations of the IPsec server. The system checks the required parameters, request format, and service limits. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. This is the default value. If the request passes the precheck, the system modifies the configurations of the IPsec server.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// Specifies whether to delete the negotiated IPsec tunnel and initiate the negotiation again. Valid values:
        /// 
        /// *   **true**: immediately initiates negotiations after the configuration is complete.
        /// *   **false**: initiates negotiations when inbound traffic is detected.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// The configuration of Phase 1 negotiations. Valid values:
        /// 
        /// *   **IkeVersion**: The IKE version. Valid values: **ikev1** and **ikev2**.
        /// *   **IkeMode**: The IKE negotiation mode. Default value: **main**.
        /// *   **IkeEncAlg**: the encryption algorithm that is used in Phase 1 negotiation. Default value: **aes**.
        /// *   **IkeAuthAlg**: the authentication algorithm that is used in Phase 1 negotiation. Default value: **sha1**.
        /// *   **IkePfs**: The Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiations. Default value: **group2**.
        /// *   **IkeLifetime**: The SA lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// *   **LocalId**: The identifier of the IPsec server. Only FQDN and IP address formats are supported.
        /// *   **RemoteId**: the peer identifier. Only FQDN and IP address formats are supported.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

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
        /// The IPsec server ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpsecServerId")]
        [Validation(Required=false)]
        public string IpsecServerId { get; set; }

        /// <summary>
        /// The name of the IPsec server.
        /// 
        /// It must be 1 to 100 characters in length.
        /// </summary>
        [NameInMap("IpsecServerName")]
        [Validation(Required=false)]
        public string IpsecServerName { get; set; }

        /// <summary>
        /// The local CIDR blocks, which are the CIDR blocks of the virtual private cloud (VPC) for the client to access.
        /// 
        /// Multiple CIDR blocks are separated with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// The pre-shared key.
        /// 
        /// The pre-shared key that is used for authentication between the IPsec-VPN server and the client. It must be 1 to 100 characters in length.
        /// 
        /// You can call [ListIpsecServers](https://help.aliyun.com/document_detail/2794120.html) to query keys generated by the system.
        /// 
        /// >  The pre-shared key of the IPsec server key must be the same as that of the client. Otherwise, the connection between the IPsec server and the client cannot be established.
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
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
