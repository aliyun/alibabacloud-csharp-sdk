// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpsecServersResponseBody : TeaModel {
        /// <summary>
        /// The list of IPsec servers.
        /// </summary>
        [NameInMap("IpsecServers")]
        [Validation(Required=false)]
        public List<ListIpsecServersResponseBodyIpsecServers> IpsecServers { get; set; }
        public class ListIpsecServersResponseBodyIpsecServers : TeaModel {
            /// <summary>
            /// The client CIDR block. It refers to the CIDR block that is allocated to the virtual interface of the client.
            /// </summary>
            [NameInMap("ClientIpPool")]
            [Validation(Required=false)]
            public string ClientIpPool { get; set; }

            /// <summary>
            /// The time when the IPsec server was created.
            /// 
            /// T is used as a delimiter. Z indicates that the time is in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Indicates whether the current IPsec tunnel is deleted and negotiations are reinitiated. Valid values:
            /// 
            /// *   **true**: immediately initiates negotiations after the configuration is completed.
            /// *   **false**: initiates negotiations when inbound traffic is detected.
            /// </summary>
            [NameInMap("EffectImmediately")]
            [Validation(Required=false)]
            public bool? EffectImmediately { get; set; }

            /// <summary>
            /// The ID of the IDaaS instance.
            /// </summary>
            [NameInMap("IDaaSInstanceId")]
            [Validation(Required=false)]
            public string IDaaSInstanceId { get; set; }

            /// <summary>
            /// The configurations of Phase 1 negotiations.
            /// </summary>
            [NameInMap("IkeConfig")]
            [Validation(Required=false)]
            public ListIpsecServersResponseBodyIpsecServersIkeConfig IkeConfig { get; set; }
            public class ListIpsecServersResponseBodyIpsecServersIkeConfig : TeaModel {
                /// <summary>
                /// The IKE authentication algorithm.
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// The IKE encryption algorithm.
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// The IKE lifetime. Unit: seconds.
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// The IKE negotiation mode. Valid values:
                /// 
                /// **main**: This mode offers higher security during negotiations.
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// The Diffie-Hellman key exchange algorithm.
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// The IKE version.
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// The ID of the IPsec server. The default value is the public IP address of the VPN gateway. Both FQDNs and IP addresses are supported.
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// The identifier of the customer gateway. Both fully qualified domain names (FQDNs) and IP addresses are supported. By default, this parameter is empty.
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// The public IP address of the VPN gateway.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The configurations of Phase 2 negotiations.
            /// </summary>
            [NameInMap("IpsecConfig")]
            [Validation(Required=false)]
            public ListIpsecServersResponseBodyIpsecServersIpsecConfig IpsecConfig { get; set; }
            public class ListIpsecServersResponseBodyIpsecServersIpsecConfig : TeaModel {
                /// <summary>
                /// The IPsec authentication algorithm.
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// The IPsec encryption algorithm.
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// The IPsec lifetime. Unit: seconds.
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// The Diffie-Hellman key exchange algorithm.
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

            /// <summary>
            /// The IPsec server ID.
            /// </summary>
            [NameInMap("IpsecServerId")]
            [Validation(Required=false)]
            public string IpsecServerId { get; set; }

            /// <summary>
            /// The name of the IPsec server.
            /// </summary>
            [NameInMap("IpsecServerName")]
            [Validation(Required=false)]
            public string IpsecServerName { get; set; }

            /// <summary>
            /// The local CIDR blocks, which refer to the CIDR blocks on the virtual private cloud (VPC) side.
            /// </summary>
            [NameInMap("LocalSubnet")]
            [Validation(Required=false)]
            public string LocalSubnet { get; set; }

            /// <summary>
            /// The number of SSL-VPN connections supported by the VPN gateway.
            /// 
            /// >  The number of SSL-VPN connections specified in this parameter includes both SSL-VPN and IPsec-VPN connections. For example, you have five SSL-VPN connections and three SSL clients occupy three SSL-VPN connections. In this case, two clients can connect to the IPsec server.
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// Indicates whether two-factor authentication is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**: The feature is disabled.
            /// </summary>
            [NameInMap("MultiFactorAuthEnabled")]
            [Validation(Required=false)]
            public bool? MultiFactorAuthEnabled { get; set; }

            /// <summary>
            /// The number of clients that are connected to the IPsec server.
            /// </summary>
            [NameInMap("OnlineClientCount")]
            [Validation(Required=false)]
            public int? OnlineClientCount { get; set; }

            /// <summary>
            /// The pre-shared key.
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// Indicates whether pre-shared key authentication is enabled. Only **true** may be returned, which indicates that pre-shared key authentication is enabled.
            /// </summary>
            [NameInMap("PskEnabled")]
            [Validation(Required=false)]
            public bool? PskEnabled { get; set; }

            /// <summary>
            /// The ID of the region where the IPsec server is created.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the IPsec server belongs.
            /// 
            /// You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query the resource group information.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ID of the VPN gateway.
            /// </summary>
            [NameInMap("VpnGatewayId")]
            [Validation(Required=false)]
            public string VpnGatewayId { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
