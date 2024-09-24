// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceTDERequest : TeaModel {
        /// <summary>
        /// <para>The file that contains the certificate.\
        /// Format:</para>
        /// <list type="bullet">
        /// <item><description>Public endpoint: <c>oss-&lt;The ID of the region&gt;.aliyuncs.com:&lt;The name of the bucket&gt;:&lt;The name of the certificate file&gt;</c> (The file name contains the extension.)</description></item>
        /// <item><description>Internal endpoint: <c>oss-&lt;The ID of the region&gt;-internal.aliyuncs.com:&lt;The name of the bucket&gt;:&lt;The name of the certificate file&gt;</c> (The file name contains the extension.)</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available when the instance runs SQL Server 2019 SE or an Enterprise Edition of SQL Server.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query the most recent region list.</description></item>
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
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database for which you want to enable TDE. You can specify up to 50 database names in a single request. If you specify multiple database names, separate the database names with commas (,).</para>
        /// <remarks>
        /// <para>This parameter is available and must be specified only when the instance runs SQL Server 2019 SE or an Enterprise Edition of SQL Server.</para>
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
        /// <para>This parameter is available when the instance runs MySQL or PostgreSQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to replace the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available for only ApsaraDB RDS for PostgreSQL instances.</para>
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
        /// <para>This parameter is available when the instance runs SQL Server 2019 SE or an Enterprise Edition of SQL Server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1qaz@WSX</para>
        /// </summary>
        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        /// <summary>
        /// <para>The file that contains the private key of the certificate.\
        /// Format:</para>
        /// <list type="bullet">
        /// <item><description>Public endpoint: <c>oss-&lt;The ID of the region&gt;.aliyuncs.com:&lt;The name of the bucket&gt;:&lt;The name of the file that contains the private key&gt;</c> (The file name contains the extension.)</description></item>
        /// <item><description>Internal endpoint: <c>oss-&lt;The ID of the region&gt;-internal.aliyuncs.com:&lt;The name of the bucket&gt;:&lt;The name of the file that contains the private key&gt;</c> (The file name contains the extension.)</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available when the instance runs SQL Server 2019 SE or an Enterprise Edition of SQL Server.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query the most recent region list.</description></item>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role. A RAM role is a virtual identity that you can create within your Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/93689.html">RAM role overview</a>.</para>
        /// <remarks>
        /// <para>This parameter is available when the instance runs MySQL or PostgreSQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406926****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The status of TDE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
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
