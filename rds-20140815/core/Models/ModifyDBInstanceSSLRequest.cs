// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSSLRequest : TeaModel {
        /// <summary>
        /// The method that is used to verify the identities of clients. This parameter is supported only when the instance runs PostgreSQL with cloud disks. In addition, this parameter is available only when the public key of the CA that issues client certificates is enabled. Valid values:
        /// 
        /// *   **cert**
        /// *   **perfer**
        /// *   **verify-ca**
        /// *   **verify-full** (supported only when the instance runs PostgreSQL 12 or later)
        /// </summary>
        [NameInMap("ACL")]
        [Validation(Required=false)]
        public string ACL { get; set; }

        /// <summary>
        /// The type of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks. If you set SSLEnabled to **1**, the default value of this parameter is **aliyun**. Valid values:
        /// 
        /// *   **aliyun**: a cloud certificate
        /// *   **custom**: a custom certificate
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// The public key of the CA that issues client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks. This parameter must be specified when ClientCAEbabled is set to **1**.
        /// </summary>
        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// Specifies whether to enable the public key of the CA that issues client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:
        /// 
        /// *   **1**: enables the public key.
        /// *   **0**: disables the public key.
        /// </summary>
        [NameInMap("ClientCAEnabled")]
        [Validation(Required=false)]
        public int? ClientCAEnabled { get; set; }

        /// <summary>
        /// The CRL that contains revoked client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks. This parameter must be specified when ClientCrlEnabled is set to **1**.
        /// </summary>
        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        /// <summary>
        /// Specifies whether to enable a certificate revocation list (CRL) that contains revoked client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks. In addition, this parameter is available only when the public key of the CA that issues client certificates is enabled. Valid values:
        /// 
        /// *   **1**: enables the CRL.
        /// *   **0**: disables the CRL.
        /// </summary>
        [NameInMap("ClientCrlEnabled")]
        [Validation(Required=false)]
        public int? ClientCrlEnabled { get; set; }

        /// <summary>
        /// The internal or public endpoint for which the server certificate needs to be created or updated.
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The method that is used to verify the replication permission. This parameter is supported only when the instance runs PostgreSQL with cloud disks. In addition, this parameter is available only when the public key of the CA that issues client certificates is enabled. Valid values:
        /// 
        /// *   **cert**
        /// *   **perfer**
        /// *   **verify-ca**
        /// *   **verify-full** (supported only when the instance runs PostgreSQL 12 or later)
        /// </summary>
        [NameInMap("ReplicationACL")]
        [Validation(Required=false)]
        public string ReplicationACL { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to enable or disable the SSL encryption feature. Valid values:
        /// 
        /// *   **1**: enables the feature.
        /// *   **0**: disables the feature.
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public int? SSLEnabled { get; set; }

        /// <summary>
        /// The content of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks. This parameter must be specified when CAType is set to **custom**.
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// The private key of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks. This parameter must be specified when CAType is set to **custom**.
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

    }

}
