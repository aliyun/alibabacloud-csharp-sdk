// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D350187B-EA41-4577-950B-95434C8302E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information about the SSL-VPN server.</para>
        /// </summary>
        [NameInMap("SslVpnServers")]
        [Validation(Required=false)]
        public DescribeSslVpnServersResponseBodySslVpnServers SslVpnServers { get; set; }
        public class DescribeSslVpnServersResponseBodySslVpnServers : TeaModel {
            [NameInMap("SslVpnServer")]
            [Validation(Required=false)]
            public List<DescribeSslVpnServersResponseBodySslVpnServersSslVpnServer> SslVpnServer { get; set; }
            public class DescribeSslVpnServersResponseBodySslVpnServersSslVpnServer : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AES-128-CBC</para>
                /// </summary>
                [NameInMap("Cipher")]
                [Validation(Required=false)]
                public string Cipher { get; set; }

                /// <summary>
                /// <para>The client CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.10.1.0/24</para>
                /// </summary>
                [NameInMap("ClientIpPool")]
                [Validation(Required=false)]
                public string ClientIpPool { get; set; }

                /// <summary>
                /// <para>Indicates whether data compression is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b> (default)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Compress")]
                [Validation(Required=false)]
                public bool? Compress { get; set; }

                /// <summary>
                /// <para>The total number of current connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public int? Connections { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the SSL-VPN server was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1613800884000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether two-factor authentication is enabled.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b> (default)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableMultiFactorAuth")]
                [Validation(Required=false)]
                public bool? EnableMultiFactorAuth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>app_my6g4qmvnwxzj2f****</para>
                /// </summary>
                [NameInMap("IDaaSApplicationId")]
                [Validation(Required=false)]
                public string IDaaSApplicationId { get; set; }

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
                /// <b>Example:</b>
                /// <para>EIAM 2.0</para>
                /// </summary>
                [NameInMap("IDaaSInstanceVersion")]
                [Validation(Required=false)]
                public string IDaaSInstanceVersion { get; set; }

                /// <summary>
                /// <para>The region ID of the IDaaS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("IDaaSRegionId")]
                [Validation(Required=false)]
                public string IDaaSRegionId { get; set; }

                /// <summary>
                /// <para>The public IP address of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.5.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>The local CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/24</para>
                /// </summary>
                [NameInMap("LocalSubnet")]
                [Validation(Required=false)]
                public string LocalSubnet { get; set; }

                /// <summary>
                /// <para>The maximum number of connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// <para>The name of the SSL-VPN server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The port that is used by the SSL-VPN server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1194</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol that is used by the SSL-VPN server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UDP</para>
                /// </summary>
                [NameInMap("Proto")]
                [Validation(Required=false)]
                public string Proto { get; set; }

                /// <summary>
                /// <para>The region ID of the SSL-VPN server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID of the SSL-VPN server.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzs372yg****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the SSL-VPN server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vss-bp15j3du13gq1dgey****</para>
                /// </summary>
                [NameInMap("SslVpnServerId")]
                [Validation(Required=false)]
                public string SslVpnServerId { get; set; }

                /// <summary>
                /// <para>The ID of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp1on0xae9d771ggi****</para>
                /// </summary>
                [NameInMap("VpnGatewayId")]
                [Validation(Required=false)]
                public string VpnGatewayId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
