// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSSLRequest : TeaModel {
        /// <summary>
        /// <para>The authentication method for an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cert</b></description></item>
        /// <item><description><b>prefer</b></description></item>
        /// <item><description><b>verify-ca</b></description></item>
        /// <item><description><b>verify-full</b> (supported for ApsaraDB RDS for PostgreSQL 12 and later)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter can be configured only when ClientCAEnabled is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cert</para>
        /// </summary>
        [NameInMap("ACL")]
        [Validation(Required=false)]
        public string ACL { get; set; }

        /// <summary>
        /// <para>The type of certificate for ApsaraDB RDS for MySQL and ApsaraDB RDS for PostgreSQL instances with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aliyun</b> (default): Alibaba Cloud certificate.</description></item>
        /// <item><description><b>custom</b>: Custom certificate.<remarks>
        /// <para>This parameter is required when SSLEnabled is set to <b>1</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// <para>The custom certificate content for an ApsaraDB RDS for SQL Server instance. Only the <c>pfx</c> certificate format is supported.</para>
        /// <list type="bullet">
        /// <item><description>Public endpoint: <c>oss-&lt;RegionId&gt;.aliyuncs.com:&lt;BucketName&gt;:&lt;CertificateFileName (certificate file extension)&gt;</c></description></item>
        /// <item><description>Internal endpoint: <c>oss-&lt;RegionId&gt;-internal.aliyuncs.com:&lt;BucketName&gt;:&lt;CertificateFileName (certificate file extension)&gt;</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-beijing-internal.aliyuncs.com:zhttest:test.pfx</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The client certificate authorization authority public key for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// <remarks>
        /// <para>This parameter is required when ClientCAEnabled is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****viXk=-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the client certification authority (CA) public key for an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enable.</description></item>
        /// <item><description><b>0</b>: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientCAEnabled")]
        [Validation(Required=false)]
        public int? ClientCAEnabled { get; set; }

        /// <summary>
        /// <para>The client certificate revocation certificate file for an ApsaraDB RDS for PostgreSQL instance with cloud disks.</para>
        /// <remarks>
        /// <para>This parameter is required when ClientCrlEnabled is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN X509 CRL-----MIIB****19mg==-----END X509 CRL-----</para>
        /// </summary>
        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the client certificate revocation list (CRL) for an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enable.</description></item>
        /// <item><description><b>0</b>: Disable.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter can be configured only when ClientCAEnabled is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientCrlEnabled")]
        [Validation(Required=false)]
        public int? ClientCrlEnabled { get; set; }

        /// <summary>
        /// <para>The internal or public endpoint for which you want to create or update the server certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/95715.html">SSL forced encryption switch</a> for ApsaraDB RDS for MySQL and ApsaraDB RDS for SQL Server instances. Valid values:</para>
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the custom certificate for an ApsaraDB RDS for SQL Server instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zht123456</para>
        /// </summary>
        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        /// <summary>
        /// <para>The authentication method for replication permissions on an ApsaraDB RDS for PostgreSQL instance with cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cert</b></description></item>
        /// <item><description><b>prefer</b></description></item>
        /// <item><description><b>verify-ca</b></description></item>
        /// <item><description><b>verify-full</b> (supported for ApsaraDB RDS for PostgreSQL 12 and later)<remarks>
        /// <para>This parameter can be configured only when ClientCAEnabled is set to <b>1</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cert</para>
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
        /// <para>Specifies whether to enable or disable SSL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enable.</description></item>
        /// <item><description><b>0</b>: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public int? SSLEnabled { get; set; }

        /// <summary>
        /// <para>The custom certificate content of the server for ApsaraDB RDS for MySQL and ApsaraDB RDS for PostgreSQL instances with cloud disks.</para>
        /// <remarks>
        /// <para>This parameter is required when CAType is set to <b>custom</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****QqEP-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// <para>The private key of the server certificate for ApsaraDB RDS for MySQL and ApsaraDB RDS for PostgreSQL instances with cloud disks.</para>
        /// <remarks>
        /// <para>This parameter is required when CAType is set to <b>custom</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----MIIE****ihfg==-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/95715.html">minimum TLS version</a> for an ApsaraDB RDS for SQL Server instance. Connection requests from clients with a TLS version lower than the specified version are rejected. Valid values: 1.0, 1.1, and 1.2.</para>
        /// <para>For example, if you set this parameter to 1.1, the server accepts only connection requests from clients that use TLS 1.1 or TLS 1.2. Connection requests from clients that use TLS 1.0 are rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1</para>
        /// </summary>
        [NameInMap("TlsVersion")]
        [Validation(Required=false)]
        public string TlsVersion { get; set; }

    }

}
