// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceTDERequest : TeaModel {
        /// <summary>
        /// <para>The certificate file.</para>
        /// <para>Format:</para>
        /// <list type="bullet">
        /// <item><description>Public endpoint: <c>oss-&lt;region ID&gt;.aliyuncs.com:&lt;bucket name&gt;:&lt;certificate file name with extension&gt;</c></description></item>
        /// <item><description>Internal network address: <c>oss-&lt;region ID&gt;-internal.aliyuncs.com:&lt;bucket name&gt;:&lt;certificate file name with extension&gt;</c></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is active only for SQL Server 2019 Standard Edition, SQL Server 2022 Standard Edition, SQL Server 2025 Standard Edition, and SQL Server Enterprise instance.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query active region IDs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-ap-southeast-1.aliyuncs.com:****:key.cer</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The names of the databases for which you want to enable TDE. You can specify multiple database names separated by commas (,). A maximum of 50 database names can be specified.</para>
        /// <remarks>
        /// <para>This parameter is required and active only for SQL Server 2019 Standard Edition, SQL Server 2022 Standard Edition, SQL Server 2025 Standard Edition, and SQL Server Enterprise instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The ID of the custom key.</para>
        /// <remarks>
        /// <para>This parameter is available only for RDS MySQL or RDS PostgreSQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to rotate the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Rotates the key.</description></item>
        /// <item><description><b>false</b>: Does not rotate the key. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is applicable only to RDS PostgreSQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsRotate")]
        [Validation(Required=false)]
        public bool? IsRotate { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the certificate.</para>
        /// <remarks>
        /// <para>This parameter is active only for SQL Server 2019 Standard Edition, SQL Server 2022 Standard Edition, SQL Server 2025 Standard Edition, and SQL Server Enterprise instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1qaz@WSX</para>
        /// </summary>
        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        /// <summary>
        /// <para>The private key file.</para>
        /// <para>Format:</para>
        /// <list type="bullet">
        /// <item><description>Public endpoint: <c>oss-&lt;region ID&gt;.aliyuncs.com:&lt;bucket name&gt;:&lt;private key file name with extension&gt;</c></description></item>
        /// <item><description>Internal network address: <c>oss-&lt;region ID&gt;-internal.aliyuncs.com:&lt;bucket name&gt;:&lt;private key file name with extension&gt;</c></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is active only for SQL Server 2019 Standard Edition, SQL Server 2022 Standard Edition, SQL Server 2025 Standard Edition, and SQL Server Enterprise instance.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query active region IDs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-ap-southeast-1.aliyuncs.com:****:key.pvk</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The global resource descriptor of the role, which is used to specify the role. For details, see <a href="https://help.aliyun.com/document_detail/93689.html">RAM role overview</a>.</para>
        /// <remarks>
        /// <para>This parameter is active only for ApsaraDB RDS for MySQL and ApsaraDB RDS for PostgreSQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406926****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The TDE status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b> </description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
