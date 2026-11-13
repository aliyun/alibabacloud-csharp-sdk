// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication method for an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cert</b></description></item>
        /// <item><description><b>prefer</b></description></item>
        /// <item><description><b>verify-ca</b></description></item>
        /// <item><description><b>verify-full</b> (supported by ApsaraDB RDS for PostgreSQL 12 and later)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cert</para>
        /// </summary>
        [NameInMap("ACL")]
        [Validation(Required=false)]
        public string ACL { get; set; }

        /// <summary>
        /// <para>The type of the server certificate for an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aliyun</b>: cloud certificate.</description></item>
        /// <item><description><b>custom</b>: custom certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// <para>The public key of the client certificate authority (CA) for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****viXk=-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// <para>The expiration time of the public key of the client certificate authority (CA) for an ApsaraDB RDS for PostgreSQL instance with cloud disks. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// <para>This parameter is not supported. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-11-09T00:00:00Z</para>
        /// </summary>
        [NameInMap("ClientCACertExpireTime")]
        [Validation(Required=false)]
        public string ClientCACertExpireTime { get; set; }

        /// <summary>
        /// <para>The client certificate revocation list file for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN X509 CRL-----MIIB****19mg==-----END X509 CRL-----</para>
        /// </summary>
        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        /// <summary>
        /// <para>The SSL-protected endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp162dfr55g47****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>Indicates whether the <a href="https://help.aliyun.com/document_detail/95715.html">forced SSL encryption</a> feature is enabled for an ApsaraDB RDS for SQL Server instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled.</description></item>
        /// <item><description><b>0</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ForceEncryption")]
        [Validation(Required=false)]
        public string ForceEncryption { get; set; }

        /// <summary>
        /// <para>The current SSL configuration status for an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: successful.</description></item>
        /// <item><description><b>setting</b>: configuring.</description></item>
        /// <item><description><b>failed</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>setting</para>
        /// </summary>
        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        /// <summary>
        /// <para>The reason for the current SSL configuration status of an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modify DB Instance SSL Config.</para>
        /// </summary>
        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        /// <summary>
        /// <para>The authentication method for the replication permission of an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cert</b></description></item>
        /// <item><description><b>prefer</b></description></item>
        /// <item><description><b>verify-ca</b></description></item>
        /// <item><description><b>verify-full</b> (supported by ApsaraDB RDS for PostgreSQL 12 and later)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cert</para>
        /// </summary>
        [NameInMap("ReplicationACL")]
        [Validation(Required=false)]
        public string ReplicationACL { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7705151C-E242-55AF-9929-2A3C39D979D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the SSL certificate needs to be updated. Valid values:</para>
        /// <remarks>
        /// <para>The validity period of an SSL certificate is one year. If you do not update the certificate after it expires, client programs that use encrypted connections cannot connect to the instance.</para>
        /// </remarks>
        /// <details>
        /// <summary>MySQL and SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>No</b>: The certificate does not need to be updated.</description></item>
        /// <item><description><b>Yes</b>: The certificate needs to be updated.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>0</b>: The certificate does not need to be updated.</description></item>
        /// <item><description><b>1</b>: The certificate needs to be updated.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>Yes</para>
        /// </summary>
        [NameInMap("RequireUpdate")]
        [Validation(Required=false)]
        public string RequireUpdate { get; set; }

        /// <summary>
        /// <para>The list of server certificates that need to be updated for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("RequireUpdateItem")]
        [Validation(Required=false)]
        public string RequireUpdateItem { get; set; }

        /// <summary>
        /// <para>The reason why the certificate needs to be updated for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The server certificate is about to expire</para>
        /// </summary>
        [NameInMap("RequireUpdateReason")]
        [Validation(Required=false)]
        public string RequireUpdateReason { get; set; }

        /// <summary>
        /// <para>The time when the server certificate was created for an ApsaraDB RDS for PostgreSQL instance with cloud disks. This parameter is valid only when CAType is set to aliyun.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("SSLCreateTime")]
        [Validation(Required=false)]
        public string SSLCreateTime { get; set; }

        /// <summary>
        /// <para>The SSL encryption status. Valid values:</para>
        /// <details>
        /// <summary>MySQL and SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>Yes</b>: enabled.</description></item>
        /// <item><description><b>No</b>: disabled.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>Yes</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

        /// <summary>
        /// <para>The expiration time of the SSL certificate. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-16T08:16:43Z</para>
        /// </summary>
        [NameInMap("SSLExpireTime")]
        [Validation(Required=false)]
        public string SSLExpireTime { get; set; }

        /// <summary>
        /// <para>The URL of the CA certificate that issued the server certificate for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/rds/server-ca.pem">https://example.com/rds/server-ca.pem</a></para>
        /// </summary>
        [NameInMap("ServerCAUrl")]
        [Validation(Required=false)]
        public string ServerCAUrl { get; set; }

        /// <summary>
        /// <para>The content of the server certificate for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****QqEP-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// <para>The private key of the server certificate for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----MIIE****ihfg==-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

        /// <summary>
        /// <para>The specified <a href="https://help.aliyun.com/document_detail/95715.html">minimum TLS version</a> for an ApsaraDB RDS for SQL Server instance. Valid values: 1.0, 1.1, and 1.2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1</para>
        /// </summary>
        [NameInMap("TlsVersion")]
        [Validation(Required=false)]
        public string TlsVersion { get; set; }

    }

}
