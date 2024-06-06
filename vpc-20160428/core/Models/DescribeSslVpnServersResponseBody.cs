// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnServersResponseBody : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The detailed information about the SSL-VPN server.
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
                /// The encryption algorithm.
                /// </summary>
                [NameInMap("Cipher")]
                [Validation(Required=false)]
                public string Cipher { get; set; }

                /// <summary>
                /// The client CIDR block.
                /// </summary>
                [NameInMap("ClientIpPool")]
                [Validation(Required=false)]
                public string ClientIpPool { get; set; }

                /// <summary>
                /// Indicates whether data compression is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false** (default)
                /// </summary>
                [NameInMap("Compress")]
                [Validation(Required=false)]
                public bool? Compress { get; set; }

                /// <summary>
                /// The total number of current connections.
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public int? Connections { get; set; }

                /// <summary>
                /// The timestamp generated when the SSL-VPN server was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// Indicates whether two-factor authentication is enabled.
                /// 
                /// *   **true**
                /// *   **false** (default)
                /// </summary>
                [NameInMap("EnableMultiFactorAuth")]
                [Validation(Required=false)]
                public bool? EnableMultiFactorAuth { get; set; }

                [NameInMap("IDaaSApplicationId")]
                [Validation(Required=false)]
                public string IDaaSApplicationId { get; set; }

                /// <summary>
                /// The ID of the IDaaS instance.
                /// </summary>
                [NameInMap("IDaaSInstanceId")]
                [Validation(Required=false)]
                public string IDaaSInstanceId { get; set; }

                [NameInMap("IDaaSInstanceVersion")]
                [Validation(Required=false)]
                public string IDaaSInstanceVersion { get; set; }

                /// <summary>
                /// The region ID of the IDaaS instance.
                /// </summary>
                [NameInMap("IDaaSRegionId")]
                [Validation(Required=false)]
                public string IDaaSRegionId { get; set; }

                /// <summary>
                /// The public IP address of the VPN gateway.
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// The local CIDR block.
                /// </summary>
                [NameInMap("LocalSubnet")]
                [Validation(Required=false)]
                public string LocalSubnet { get; set; }

                /// <summary>
                /// The maximum number of connections.
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// The name of the SSL-VPN server.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The port that is used by the SSL-VPN server.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol that is used by the SSL-VPN server.
                /// </summary>
                [NameInMap("Proto")]
                [Validation(Required=false)]
                public string Proto { get; set; }

                /// <summary>
                /// The region ID of the SSL-VPN server.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource group ID of the SSL-VPN server.
                /// 
                /// You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query resource groups.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the SSL-VPN server.
                /// </summary>
                [NameInMap("SslVpnServerId")]
                [Validation(Required=false)]
                public string SslVpnServerId { get; set; }

                /// <summary>
                /// The ID of the VPN gateway.
                /// </summary>
                [NameInMap("VpnGatewayId")]
                [Validation(Required=false)]
                public string VpnGatewayId { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
