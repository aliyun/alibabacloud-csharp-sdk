// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication method of the ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
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
        /// <para>The server certificate type of the ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aliyun</b>: The cloud certificate is used.</description></item>
        /// <item><description><b>custom</b>: A custom certificate is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// <para>The public key of the client certificate authority (CA) for the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****viXk=-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// <para>The expiration time of the public key of the client certificate authorization authority (CA) for the ApsaraDB RDS for PostgreSQL instance with cloud disks. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// <para>This parameter is not supported. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClientCACertExpireTime")]
        [Validation(Required=false)]
        public string ClientCACertExpireTime { get; set; }

        /// <summary>
        /// <para>The client certificate revocation certificate file of the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN X509 CRL-----MIIB****19mg==-----END X509 CRL-----</para>
        /// </summary>
        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        /// <summary>
        /// <para>The endpoint that is protected by SSL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp162dfr55g47****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>Indicates whether the <a href="https://help.aliyun.com/document_detail/95715.html">forced Secure Sockets Layer (SSL) encryption feature</a> is enabled for the ApsaraDB RDS for SQL Server instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ForceEncryption")]
        [Validation(Required=false)]
        public string ForceEncryption { get; set; }

        /// <summary>
        /// <para>The current SSL link configuration status of the ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: Successful.</description></item>
        /// <item><description><b>setting</b>: Being configured.</description></item>
        /// <item><description><b>failed</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>setting</para>
        /// </summary>
        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        /// <summary>
        /// <para>The reason for the current SSL link configuration status of the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modify DB Instance SSL Config.</para>
        /// </summary>
        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        /// <summary>
        /// <para>The authentication method for replication permissions of the ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
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
        /// <para>The request ID.</para>
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
        /// <para>The SSL certificate is valid for one year. If the certificate is not renewed after it expires, client programs that use encrypted connections cannot connect to the instance.</para>
        /// </remarks>
        /// <details>
        /// <summary>MySQL and SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>No</b>: No update is required.</description></item>
        /// <item><description><b>Yes</b>: An update is required.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>0</b>: No update is required.</description></item>
        /// <item><description><b>1</b>: An update is required.</description></item>
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
        /// <para>The list of server certificates that need to be updated for the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
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
        /// <para>The reason why the certificates need to be updated for the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("RequireUpdateReason")]
        [Validation(Required=false)]
        public string RequireUpdateReason { get; set; }

        /// <summary>
        /// <para>The creation time of the server certificate for the ApsaraDB RDS for PostgreSQL instance with cloud disks. This parameter is valid only when CAType is set to aliyun.</para>
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
        /// <item><description><b>Yes</b>: Enabled.</description></item>
        /// <item><description><b>No</b>: Disabled.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
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
        /// <para>The URL of the CA certificate that is used to issue the server certificate for the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ServerCAUrl")]
        [Validation(Required=false)]
        public string ServerCAUrl { get; set; }

        /// <summary>
        /// <para>The content of the server certificate for the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****QqEP-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// <para>The private key of the server certificate for the ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----MIIE****ihfg==-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

        /// <summary>
        /// <para>The specified <a href="https://help.aliyun.com/document_detail/95715.html">minimum TLS version</a> for the ApsaraDB RDS for SQL Server instance. Valid values: 1.0, 1.1, and 1.2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1</para>
        /// </summary>
        [NameInMap("TlsVersion")]
        [Validation(Required=false)]
        public string TlsVersion { get; set; }

    }

}
