// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBEndpointAddressRequest : TeaModel {
        /// <summary>
        /// The prefix of the new endpoint. The prefix must meet the following requirements:
        /// 
        /// *   It can contain lowercase letters, digits, and hyphens (-).
        /// *   It must start with a letter and end with a digit or a letter.
        /// *   It must be 6 to 30 characters in length.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The ID of cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~98094~~) operation to query the details of the clusters that belong to your Alibaba Cloud account, such as cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the endpoint.
        /// 
        /// > You can call the [DescribeDBClusterEndpoints](~~98205~~) operation to query endpoint IDs.
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// The network type of the endpoint. Valid values:
        /// 
        /// *   **Public**
        /// *   **Private**
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The port number. Valid values: 3000 to 5999.
        /// 
        /// > This parameter is valid only for PolarDB for MySQL clusters. If you leave this parameter empty, the default port 3306 is used.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The prefix of the private domain name. The prefix must meet the following requirements:
        /// 
        /// *   The prefix can contain lowercase letters, digits, and hyphens (-).
        /// *   The prefix must start with a letter and end with a digit or a letter.
        /// *   The prefix must be 6 to 30 characters in length.
        /// 
        /// >- You can bind each internal endpoint of PolarDB to a private domain name. The private domain name takes effect only in the specified virtual private clouds (VPCs) in the current region. Private domain names are managed by using PrivateZone. You can use the CNAME record of PrivateZone to map domain names to PolarDB. You are charged a small fee for this feature. For more information, see [Pricing](~~71338~~).
        /// >- This parameter takes effect only if you set **NetType** to Private.
        /// </summary>
        [NameInMap("PrivateZoneAddressPrefix")]
        [Validation(Required=false)]
        public string PrivateZoneAddressPrefix { get; set; }

        /// <summary>
        /// The name of the private zone.
        /// 
        /// > This parameter takes effect only when **NetType** is set to Private.
        /// </summary>
        [NameInMap("PrivateZoneName")]
        [Validation(Required=false)]
        public string PrivateZoneName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
