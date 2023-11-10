// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyEndpointAddressRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The network type of the proxy endpoint. Valid values:
        /// 
        /// *   **Public**: Internet
        /// *   **VPC**: virtual private cloud (VPC)
        /// *   **Classic**: classic network
        /// 
        /// If the instance runs MySQL, the default value of this parameter is **Classic**.
        /// 
        /// > If the instance runs PostgreSQL, you must set this parameter to **Public** or **VPC**.
        /// </summary>
        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        /// <summary>
        /// The ID of the dedicated proxy endpoint. You can call the DescribeDBProxyEndpoint operation to query the ID of the proxy endpoint.
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The new prefix of the proxy endpoint. Enter a prefix.
        /// 
        /// > You must specify at least one of the **DBProxyNewConnectString** and **DBProxyNewConnectStringPort** parameters.
        /// </summary>
        [NameInMap("DBProxyNewConnectString")]
        [Validation(Required=false)]
        public string DBProxyNewConnectString { get; set; }

        /// <summary>
        /// The port number that is associated with the proxy endpoint. Enter a port number.
        /// 
        /// > You must specify at least one of the **DBProxyNewConnectString** and **DBProxyNewConnectStringPort** parameters.
        /// </summary>
        [NameInMap("DBProxyNewConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyNewConnectStringPort { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
