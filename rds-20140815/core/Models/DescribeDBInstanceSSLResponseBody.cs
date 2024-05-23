// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// The method that is used to verify the identities of clients. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:
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
        /// The type of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:
        /// 
        /// *   **aliyun**: a cloud certificate
        /// *   **custom**: a custom certificate
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// The public key of the CA that issues client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks.
        /// </summary>
        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// The time when the public key of the CA that issues client certificates expires. This parameter is supported only when the instance runs PostgreSQL with cloud disks. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. This parameter is not supported now.
        /// </summary>
        [NameInMap("ClientCACertExpireTime")]
        [Validation(Required=false)]
        public string ClientCACertExpireTime { get; set; }

        /// <summary>
        /// The certificate revocation list (CRL) that contains revoked client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks.
        /// </summary>
        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        /// <summary>
        /// The endpoint that is protected by SSL encryption.
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Indicates whether the forceful SSL encryption feature is enabled. This parameter is supported only for ApsaraDB RDS for SQL Server instances. For more information, see [Configure the SSL encryption feature](https://help.aliyun.com/document_detail/95715.html).
        /// 
        /// *   **1**: enabled
        /// *   **0**: The feature is disabled.
        /// </summary>
        [NameInMap("ForceEncryption")]
        [Validation(Required=false)]
        public string ForceEncryption { get; set; }

        /// <summary>
        /// The status of the SSL link. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:
        /// 
        /// *   **success**
        /// *   **setting**
        /// *   **failed**
        /// </summary>
        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        /// <summary>
        /// The reason why the SSL link stays in the current state. This parameter is supported only when the instance runs PostgreSQL with cloud disks.
        /// </summary>
        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        /// <summary>
        /// The method that is used to verify the replication permission. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:
        /// 
        /// *   **cert**
        /// *   **perfer**
        /// *   **verify-ca**
        /// *   **verify-full** (supported only when the instance runs PostgreSQL 12 or later)
        /// </summary>
        [NameInMap("ReplicationACL")]
        [Validation(Required=false)]
        public string ReplicationACL { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the server certificate needs to be updated.
        /// 
        /// *   Valid values for ApsaraDB RDS for MySQL instances and ApsaraDB RDS for SQL Server instances:
        /// 
        ///     *   **No**
        ///     *   **Yes**
        /// 
        /// *   Valid values for ApsaraDB RDS for PostgreSQL instances:
        /// 
        ///     *   **0**: no
        ///     *   **1**: yes
        /// </summary>
        [NameInMap("RequireUpdate")]
        [Validation(Required=false)]
        public string RequireUpdate { get; set; }

        /// <summary>
        /// The server certificate that needs to be updated. This parameter is supported only when the instance runs PostgreSQL with cloud disk.
        /// </summary>
        [NameInMap("RequireUpdateItem")]
        [Validation(Required=false)]
        public string RequireUpdateItem { get; set; }

        /// <summary>
        /// The reason why the server certificate needs to be updated. This parameter is supported only when the instance runs PostgreSQL with cloud disks.
        /// </summary>
        [NameInMap("RequireUpdateReason")]
        [Validation(Required=false)]
        public string RequireUpdateReason { get; set; }

        /// <summary>
        /// The time when the server certificate was created. This parameter is supported only when the instance runs PostgreSQL with cloud disks. In addition, this parameter is valid only when the CAType parameter value is aliyun.
        /// </summary>
        [NameInMap("SSLCreateTime")]
        [Validation(Required=false)]
        public string SSLCreateTime { get; set; }

        /// <summary>
        /// Indicates whether SSL encryption is enabled.
        /// 
        /// *   Valid values for ApsaraDB RDS for MySQL instances and ApsaraDB RDS for SQL Server instances:
        /// 
        ///     *   **Yes**
        ///     *   **No**
        /// 
        /// *   Valid values for ApsaraDB RDS for PostgreSQL instances:
        /// 
        ///     *   **on**: enabled
        ///     *   **off**: disabled
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

        /// <summary>
        /// The time when the server certificate expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("SSLExpireTime")]
        [Validation(Required=false)]
        public string SSLExpireTime { get; set; }

        /// <summary>
        /// The URL of the certificate that is used to issue the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disk.
        /// </summary>
        [NameInMap("ServerCAUrl")]
        [Validation(Required=false)]
        public string ServerCAUrl { get; set; }

        /// <summary>
        /// The content of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks.
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// The private key of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks.
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

        /// <summary>
        /// The minimum Transport Layer Security (TLS) version. Valid values: 1.0, 1.1, and 1.2. This parameter is supported only for ApsaraDB RDS for SQL Server instances. For more information, see [Configure the SSL encryption feature](https://help.aliyun.com/document_detail/95715.html).
        /// </summary>
        [NameInMap("TlsVersion")]
        [Validation(Required=false)]
        public string TlsVersion { get; set; }

    }

}
