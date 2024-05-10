// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifySslVpnServerResponseBody : TeaModel {
        /// <summary>
        /// The encryption algorithm.
        /// </summary>
        [NameInMap("Cipher")]
        [Validation(Required=false)]
        public string Cipher { get; set; }

        /// <summary>
        /// The client IP address pool.
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// Indicates whether data compression is enabled.
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
        /// The time when the SSL server was created.
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
        /// The public IP address.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// The CIDR block of the client.
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
        /// The name of the SSL server.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The port that is used by the SSL server.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The protocol that is used by the SSL server.
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// The ID of the region where the SSL server is created.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the SSL server belongs.
        /// 
        /// The SSL server and the VPN gateway associated with the SSL server belong to the same resource group. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query resource groups.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the SSL server.
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
