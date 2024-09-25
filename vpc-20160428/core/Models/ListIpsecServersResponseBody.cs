// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpsecServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of IPsec servers.</para>
        /// </summary>
        [NameInMap("IpsecServers")]
        [Validation(Required=false)]
        public List<ListIpsecServersResponseBodyIpsecServers> IpsecServers { get; set; }
        public class ListIpsecServersResponseBodyIpsecServers : TeaModel {
            /// <summary>
            /// <para>The client CIDR block. It refers to the CIDR block that is allocated to the virtual interface of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("ClientIpPool")]
            [Validation(Required=false)]
            public string ClientIpPool { get; set; }

            /// <summary>
            /// <para>The time when the IPsec server was created.</para>
            /// <para>T is used as a delimiter. Z indicates that the time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-03T10:11:55Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the current IPsec tunnel is deleted and negotiations are reinitiated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: immediately initiates negotiations after the configuration is completed.</description></item>
            /// <item><description><b>false</b>: initiates negotiations when inbound traffic is detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EffectImmediately")]
            [Validation(Required=false)]
            public bool? EffectImmediately { get; set; }

            /// <summary>
            /// <para>The ID of the IDaaS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas-cn-hangzhou-****</para>
            /// </summary>
            [NameInMap("IDaaSInstanceId")]
            [Validation(Required=false)]
            public string IDaaSInstanceId { get; set; }

            /// <summary>
            /// <para>The configurations of Phase 1 negotiations.</para>
            /// </summary>
            [NameInMap("IkeConfig")]
            [Validation(Required=false)]
            public ListIpsecServersResponseBodyIpsecServersIkeConfig IkeConfig { get; set; }
            public class ListIpsecServersResponseBodyIpsecServersIkeConfig : TeaModel {
                /// <summary>
                /// <para>The IKE authentication algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sha1</para>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// <para>The IKE encryption algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// <para>The IKE lifetime. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// <para>The IKE negotiation mode. Valid values:</para>
                /// <para><b>main</b>: This mode offers higher security during negotiations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The IKE version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev2</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The ID of the IPsec server. The default value is the public IP address of the VPN gateway. Both FQDNs and IP addresses are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.64.XX.XX</para>
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// <para>The identifier of the customer gateway. Both fully qualified domain names (FQDNs) and IP addresses are supported. By default, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139.67.XX.XX</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The public IP address of the VPN gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.22.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The configurations of Phase 2 negotiations.</para>
            /// </summary>
            [NameInMap("IpsecConfig")]
            [Validation(Required=false)]
            public ListIpsecServersResponseBodyIpsecServersIpsecConfig IpsecConfig { get; set; }
            public class ListIpsecServersResponseBodyIpsecServersIpsecConfig : TeaModel {
                /// <summary>
                /// <para>The IPsec authentication algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sha1</para>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// <para>The IPsec encryption algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// <para>The IPsec lifetime. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

            /// <summary>
            /// <para>The IPsec server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iss-bp1bo3xuvcxo7ixll****</para>
            /// </summary>
            [NameInMap("IpsecServerId")]
            [Validation(Required=false)]
            public string IpsecServerId { get; set; }

            /// <summary>
            /// <para>The name of the IPsec server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IpsecServerName")]
            [Validation(Required=false)]
            public string IpsecServerName { get; set; }

            /// <summary>
            /// <para>The local CIDR blocks, which refer to the CIDR blocks on the virtual private cloud (VPC) side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16,172.17.0.0/16</para>
            /// </summary>
            [NameInMap("LocalSubnet")]
            [Validation(Required=false)]
            public string LocalSubnet { get; set; }

            /// <summary>
            /// <para>The number of SSL-VPN connections supported by the VPN gateway.</para>
            /// <remarks>
            /// <para> The number of SSL-VPN connections specified in this parameter includes both SSL-VPN and IPsec-VPN connections. For example, you have five SSL-VPN connections and three SSL clients occupy three SSL-VPN connections. In this case, two clients can connect to the IPsec server.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// <para>Indicates whether two-factor authentication is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b>: The feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MultiFactorAuthEnabled")]
            [Validation(Required=false)]
            public bool? MultiFactorAuthEnabled { get; set; }

            /// <summary>
            /// <para>The number of clients that are connected to the IPsec server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OnlineClientCount")]
            [Validation(Required=false)]
            public int? OnlineClientCount { get; set; }

            /// <summary>
            /// <para>The pre-shared key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgw6dy7d****</para>
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// <para>Indicates whether pre-shared key authentication is enabled. Only <b>true</b> may be returned, which indicates that pre-shared key authentication is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PskEnabled")]
            [Validation(Required=false)]
            public bool? PskEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the region where the IPsec server is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the IPsec server belongs.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the resource group information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzs372yg****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the VPN gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
            /// </summary>
            [NameInMap("VpnGatewayId")]
            [Validation(Required=false)]
            public string VpnGatewayId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next queries are sent.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B457</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
