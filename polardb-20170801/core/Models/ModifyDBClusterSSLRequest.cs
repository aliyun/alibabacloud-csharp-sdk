// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterSSLRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the endpoint.
        /// 
        /// > 
        /// 
        /// *   This parameter is required for a PolarDB for MySQL cluster.
        /// 
        /// *   This parameter is not required for a PolarDB for Oracle or PolarDB for PostgreSQL cluster. By default, SSL encryption is enabled for all endpoints.
        /// *   You can call the [DescribeDBClusterSSL](~~153414~~) operation to view the details of the endpoint.
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// The network type supported by the endpoint that is specified by **DBEndpointId**. Valid values:
        /// 
        /// *   **Public**
        /// *   **Private**
        /// *   **Inner**
        /// 
        /// > 
        /// 
        /// *   This parameter is required for a PolarDB for MySQL cluster.
        /// 
        /// *   This parameter is not required for a PolarDB for Oracle or PolarDB for PostgreSQL cluster. By default, SSL encryption is enabled for all endpoints.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether automatic rotation of SSL certificates is enabled.
        /// 
        /// *   **Enable**: The feature is enabled.
        /// *   **Disable**: The feature is disabled.
        /// </summary>
        [NameInMap("SSLAutoRotate")]
        [Validation(Required=false)]
        public string SSLAutoRotate { get; set; }

        /// <summary>
        /// The SSL encryption status. Valid values:
        /// 
        /// *   **Disable**: SSL encryption is disabled.
        /// *   **Enable**: SSL encryption is enabled.
        /// *   **Update**: The SSL certificate is updated.
        /// 
        /// > After you enable SSL encryption or update the SSL certificate, you must download and configure the certificate. For more information, see [Configure SSL encryption](~~153182~~).
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

    }

}
