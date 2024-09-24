// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The method that is used to verify the identities of clients. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cert</b></description></item>
        /// <item><description><b>prefer</b></description></item>
        /// <item><description><b>verify-ca</b></description></item>
        /// <item><description><b>verify-full</b> (supported only when the instance runs PostgreSQL 12 or later)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cert</para>
        /// </summary>
        [NameInMap("ACL")]
        [Validation(Required=false)]
        public string ACL { get; set; }

        /// <summary>
        /// <para>The type of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aliyun</b>: a cloud certificate</description></item>
        /// <item><description><b>custom</b>: a custom certificate</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// <para>The public key of the CA that issues client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****viXk=-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// <para>The time when the public key of the CA that issues client certificates expires. This parameter is supported only when the instance runs PostgreSQL with cloud disks. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. This parameter is not supported now.</para>
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
        /// <para>The certificate revocation list (CRL) that contains revoked client certificates. This parameter is supported only when the instance runs PostgreSQL with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN X509 CRL-----MIIB****19mg==-----END X509 CRL-----</para>
        /// </summary>
        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        /// <summary>
        /// <para>The endpoint that is protected by SSL encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp162dfr55g47****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>Indicates whether the forceful SSL encryption feature is enabled. This parameter is supported only for ApsaraDB RDS for SQL Server instances. For more information, see <a href="https://help.aliyun.com/document_detail/95715.html">Configure the SSL encryption feature</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: The feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ForceEncryption")]
        [Validation(Required=false)]
        public string ForceEncryption { get; set; }

        /// <summary>
        /// <para>The status of the SSL link. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>setting</b></description></item>
        /// <item><description><b>failed</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>setting</para>
        /// </summary>
        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        /// <summary>
        /// <para>The reason why the SSL link stays in the current state. This parameter is supported only when the instance runs PostgreSQL with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modify DB Instance SSL Config.</para>
        /// </summary>
        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        /// <summary>
        /// <para>The method that is used to verify the replication permission. This parameter is supported only when the instance runs PostgreSQL with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cert</b></description></item>
        /// <item><description><b>prefer</b></description></item>
        /// <item><description><b>verify-ca</b></description></item>
        /// <item><description><b>verify-full</b> (supported only when the instance runs PostgreSQL 12 or later)</description></item>
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
        /// <para>Indicates whether the server certificate needs to be updated.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for ApsaraDB RDS for MySQL instances and ApsaraDB RDS for SQL Server instances:</para>
        /// <list type="bullet">
        /// <item><description><b>No</b></description></item>
        /// <item><description><b>Yes</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for ApsaraDB RDS for PostgreSQL instances:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Yes</para>
        /// </summary>
        [NameInMap("RequireUpdate")]
        [Validation(Required=false)]
        public string RequireUpdate { get; set; }

        /// <summary>
        /// <para>The server certificate that needs to be updated. This parameter is supported only when the instance runs PostgreSQL with cloud disk.</para>
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
        /// <para>The reason why the server certificate needs to be updated. This parameter is supported only when the instance runs PostgreSQL with cloud disks.</para>
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
        /// <para>The time when the server certificate was created. This parameter is supported only when the instance runs PostgreSQL with cloud disks. In addition, this parameter is valid only when the CAType parameter value is aliyun.</para>
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
        /// <para>Indicates whether SSL encryption is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for ApsaraDB RDS for MySQL instances and ApsaraDB RDS for SQL Server instances:</para>
        /// <list type="bullet">
        /// <item><description><b>Yes</b></description></item>
        /// <item><description><b>No</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for ApsaraDB RDS for PostgreSQL instances:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled</description></item>
        /// <item><description><b>off</b>: disabled</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Yes</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

        /// <summary>
        /// <para>The time when the server certificate expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-11T08:16:43Z</para>
        /// </summary>
        [NameInMap("SSLExpireTime")]
        [Validation(Required=false)]
        public string SSLExpireTime { get; set; }

        /// <summary>
        /// <para>The URL of the certificate that is used to issue the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disk.</para>
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
        /// <para>The content of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****QqEP-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// <para>The private key of the server certificate. This parameter is supported only when the instance runs PostgreSQL with cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----MIIE****ihfg==-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

        /// <summary>
        /// <para>The minimum Transport Layer Security (TLS) version. Valid values: 1.0, 1.1, and 1.2. This parameter is supported only for ApsaraDB RDS for SQL Server instances. For more information, see <a href="https://help.aliyun.com/document_detail/95715.html">Configure the SSL encryption feature</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1</para>
        /// </summary>
        [NameInMap("TlsVersion")]
        [Validation(Required=false)]
        public string TlsVersion { get; set; }

    }

}
