// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDdrInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set used for restoration from a backup set. You can call the DescribeCrossRegionBackups operation to query backup set IDs.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>BackupSet</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>14****</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The region where the backup set resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("BackupSetRegion")]
        [Validation(Required=false)]
        public string BackupSetRegion { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The access mode of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b> (default): standard access mode</description></item>
        /// <item><description><b>Safe</b>: database proxy mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// <para>The instance type of the target instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mysql.s1.small</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the target instance. The name must be 2 to 256 characters in length. The name must start with a letter or a Chinese character and can contain digits, Chinese characters, letters, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>The name cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The network connectivity type of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: public network connection</description></item>
        /// <item><description><b>Intranet</b>: internal network connection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <para>The instance storage capacity of the target instance. Valid values: <b>5 to 2000</b>. The value is incremented in steps of 5 GB. Unit: GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type of the target instance. Valid values:</para>
        /// <remarks>
        /// <para>Use the same storage type as the source instance.</para>
        /// </remarks>
        /// <details>
        /// <summary>ApsaraDB RDS for MySQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>local_ssd: Premium Local SSDs (default)</description></item>
        /// <item><description>cloud_essd: PL1 ESSD cloud disk</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD cloud disk</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD cloud disk</description></item>
        /// <item><description>cloud_ssd: standard SSD cloud disk (discontinued)</details></description></item>
        /// </list>
        /// <details>
        /// <summary>ApsaraDB RDS for SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>cloud_essd: PL1 ESSD cloud disk</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD cloud disk</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD cloud disk</description></item>
        /// <item><description>local_ssd: Premium Local SSDs (discontinued)</description></item>
        /// <item><description>cloud_ssd: standard SSD cloud disk (discontinued)</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>ApsaraDB RDS for PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>cloud_essd: PL1 ESSD cloud disk</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD cloud disk</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD cloud disk</description></item>
        /// <item><description>local_ssd: Premium Local SSDs (discontinued)</description></item>
        /// <item><description>cloud_ssd: standard SSD cloud disk (discontinued)</description></item>
        /// </list>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The ID of the custom key used for cloud disk encryption for <b>SQL Server instances</b>. Specifying this parameter enables cloud disk encryption (which cannot be disabled after it is enabled). You must also specify <b>RoleARN</b>.
        /// You can view the key ID in the Key Management Service (KMS) console or <a href="https://help.aliyun.com/document_detail/181610.html">create a new key</a>.</para>
        /// <remarks>
        /// <para>You can also leave this parameter empty and specify only <b>RoleARN</b> to set the cloud disk encryption type to the RDS-managed service key (Default Service CMK).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The type of the destination database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the destination database engine. The valid values vary based on the value of <b>Engine</b>:</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>5.5/5.6/5.7/8.0</b></description></item>
        /// <item><description>SQL Server: <b>2008r2 (Premium Local SSDs, discontinued)/08r2_ent_ha (cloud disks, discontinued)/2012/2012_ent_ha/2012_std_ha/2012_web/2014_std_ha/2016_ent_ha/2016_std_ha/2016_web/2017_std_ha/2017_ent/2019_std_ha/2019_ent</b></description></item>
        /// <item><description>PostgreSQL: <b>10.0/11.0/12.0/13.0/14.0/15.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>For SQL Server instances, <c>_ent</c> indicates Cluster Edition, <c>_ent_ha</c> indicates Enterprise Edition, <c>_std_ha</c> indicates Standard Edition, and <c>_web</c> indicates Web Edition.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The network type of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC</description></item>
        /// <item><description><b>Classic</b>: classic network (offline)</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>VPC</b>, you must also specify the <b>VpcId</b> and <b>VSwitchId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Classic</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: upfront (subscription)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the upfront subscription duration for the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly subscription</description></item>
        /// <item><description><b>Month</b>: monthly subscription</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when PayType is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>Settings for the internal network IP address of the target instance. The IP address must be within the IP address range of the specified vSwitch. By default, the system automatically allocates an internal network IP address based on the values of <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.69</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the destination region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data when you restore data to a point in time. The point in time must be earlier than the current time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>BackupTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-30T03:29:10Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BackupSet</b>: restores data from a backup set. The data in the backup set is restored to the new instance. You must also specify the <b>BackupSetId</b> parameter.</description></item>
        /// <item><description><b>BackupTime</b>: restores data to a point in time within the log backup retention period. You must also specify the <b>RestoreTime</b>, <b>SourceRegion</b>, and <b>SourceDBInstanceName</b> parameters.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupSet</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The global resource descriptor (ARN) that provides authorization for the RDS cloud service account to access Key Management Service (KMS) for <b>SQL Server instances</b>. You can call the <a href="https://help.aliyun.com/document_detail/2628797.html">CheckCloudResourceAuthorized</a> operation to query the ARN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP whitelist</a> of the target instance. Separate multiple IP addresses with commas (,). IP addresses cannot be duplicated. You can specify up to 1,000 IP addresses. The following two formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address format, such as 10.23.12.24.</description></item>
        /// <item><description>CIDR format, such as 10.23.12.24/24 (Classless Inter-Domain Routing. 24 indicates the length of the prefix in the address. The value ranges from 1 to 32).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The ID of the source instance for point-in-time restoration.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>BackupTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the source region for point-in-time restoration.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>BackupTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The character set of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>utf8</b></description></item>
        /// <item><description><b>gbk</b></description></item>
        /// <item><description><b>latin1</b></description></item>
        /// <item><description><b>utf8mb4</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uft8</para>
        /// </summary>
        [NameInMap("SystemDBCharset")]
        [Validation(Required=false)]
        public string SystemDBCharset { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the valid values of UsedTime are <b>1 to 3</b>.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the valid values of UsedTime are <b>1 to 9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when PayType is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID of the target instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>InstanceNetworkType</b> is set to <b>VPC</b>.</description></item>
        /// <item><description>If you specify this parameter, you must also specify the <b>ZoneId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the target instance. Separate multiple values with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>InstanceNetworkType</b> is set to <b>VPC</b>.</description></item>
        /// <item><description>If you specify this parameter, you must also specify the <b>ZoneId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The active zone ID of the target instance. Separate multiple zones with colons (:).</para>
        /// <remarks>
        /// <para>If you specify a VPC and a vSwitch, this parameter is required to match the zone of the specified vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
