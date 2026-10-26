// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDdrInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set used for restoration. You can call the DescribeCrossRegionBackups operation to query backup set IDs.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the token, but you must ensure that the token is unique among different requests. The token can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The access mode of the destination instance. Valid values:</para>
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
        /// <para>The instance type of the destination instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mysql.s1.small</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the destination instance. The name must be 2 to 256 characters in length. It must start with a letter or a Chinese character and can contain letters, Chinese characters, digits, underscores (_), and hyphens (-).</para>
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
        /// <para>The network connection type of the destination instance. Valid values:</para>
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
        /// <para>The storage capacity of the destination instance. Valid values: <b>5 to 2000</b>. The increment is 5 GB. Unit: GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the destination instance. Valid values:</para>
        /// <remarks>
        /// <para>We recommend that you keep the storage type consistent with that of the source instance.</para>
        /// </remarks>
        /// <details>
        /// <summary>ApsaraDB RDS for MySQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>local_ssd: Premium Local SSD (default)</description></item>
        /// <item><description>cloud_essd: PL1 ESSD</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD</description></item>
        /// <item><description>cloud_ssd: standard SSD (discontinued)</details></description></item>
        /// </list>
        /// <details>
        /// <summary>ApsaraDB RDS for SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>cloud_essd: PL1 ESSD</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD</description></item>
        /// <item><description>local_ssd: Premium Local SSD (discontinued)</description></item>
        /// <item><description>cloud_ssd: standard SSD (discontinued)</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>ApsaraDB RDS for PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>cloud_essd: PL1 ESSD</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD</description></item>
        /// <item><description>local_ssd: Premium Local SSD (discontinued)</description></item>
        /// <item><description>cloud_ssd: standard SSD (discontinued)</description></item>
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
        /// <para>The ID of the custom key used for cloud disk encryption of the <b>SQL Server instance</b>. If you specify this parameter, cloud disk encryption is enabled and cannot be disabled. You must also specify the <b>RoleARN</b> parameter.
        /// You can view service key ID in service key Management Service (KMS) console or <a href="https://help.aliyun.com/document_detail/181610.html">create a key</a>.</para>
        /// <remarks>
        /// <para>You can also choose not to specify this parameter and only specify the <b>RoleARN</b> parameter. This sets the cloud disk encryption type of the instance to the default service customer master key (CMK) managed by ApsaraDB RDS.</para>
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
        /// <para>The version of the destination database engine. Valid values vary based on the <b>Engine</b> parameter:</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>5.5/5.6/5.7/8.0</b></description></item>
        /// <item><description>SQL Server: <b>2008r2 (Premium Local SSD, discontinued)/08r2_ent_ha (Cloud disk edition, discontinued)/2012/2012_ent_ha/2012_std_ha/2012_web/2014_std_ha/2016_ent_ha/2016_std_ha/2016_web/2017_std_ha/2017_ent/2019_std_ha/2019_ent</b></description></item>
        /// <item><description>PostgreSQL: <b>10.0/11.0/12.0/13.0/14.0/15.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>For SQL Server instances, <c>_ent</c> indicates Enterprise Cluster Edition, <c>_ent_ha</c> indicates Enterprise Edition, <c>_std_ha</c> indicates Standard Edition, and <c>_web</c> indicates Web Edition.</para>
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
        /// <para>The network type of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC</description></item>
        /// <item><description><b>Classic</b>: classic network (discontinued)</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you select <b>VPC</b>, you must also specify the <b>VpcId</b> and <b>VSwitchId</b> parameters.</para>
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
        /// <para>The billing method of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
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
        /// <para>Specifies the subscription period of the destination instance as yearly or monthly. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly</description></item>
        /// <item><description><b>Month</b>: monthly</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the billing method is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal IP address of the destination instance. The IP address must be within the CIDR block of the specified vSwitch. By default, the system automatically allocates an IP address based on the <b>VPCId</b> and <b>VSwitchId</b> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.69</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the destination region. You can call the DescribeRegions operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The point in time to which you want to restore data. The time must be earlier than the current time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
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
        /// <item><description><b>BackupSet</b>: restores data from a backup set to the new instance. You must also specify the <b>BackupSetId</b> parameter.</description></item>
        /// <item><description><b>BackupTime</b>: restores data to a specific point in time within the log backup retention period. You must also specify the <b>RestoreTime</b>, <b>SourceRegion</b>, and <b>SourceDBInstanceName</b> parameters.</description></item>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) used for the authorization of the Alibaba Cloud account to grant the ApsaraDB RDS service account access to KMS for the <b>SQL Server instance</b>. You can call the <a href="https://help.aliyun.com/document_detail/2628797.html">CheckCloudResourceAuthorized</a> operation to query the ARN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP address whitelist</a> of the destination instance. Separate multiple IP addresses with commas (,). You can add up to 1,000 unique IP addresses. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address format. Example: 10.23.12.24.</description></item>
        /// <item><description>CIDR block format. Example: 10.23.12.24/24 (Classless Inter-Domain Routing, where 24 indicates the length of the prefix in the IP address, and the prefix length ranges from 1 to 32).</description></item>
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
        /// <para>The character set of the destination instance. Valid values:</para>
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
        /// <item><description>If the <b>Period</b> parameter is set to <b>Year</b>, valid values are <b>1 to 3</b>.</description></item>
        /// <item><description>If the <b>Period</b> parameter is set to <b>Month</b>, valid values are <b>1 to 9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the billing method is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID of the destination instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>InstanceNetworkType</b> is set to <b>VPC</b>.</description></item>
        /// <item><description>After you specify this parameter, you must also specify the <b>ZoneId</b> parameter.</description></item>
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
        /// <para>The vSwitch ID of the destination instance. Separate multiple vSwitch IDs with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>InstanceNetworkType</b> is set to <b>VPC</b>.</description></item>
        /// <item><description>After you specify this parameter, you must also specify the <b>ZoneId</b> parameter.</description></item>
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
        /// <para>The zone ID of the destination instance. Separate multiple zone IDs with colons (:).</para>
        /// <remarks>
        /// <para>If you specify a VPC and a vSwitch, this parameter is required to match the zone of the vSwitch.</para>
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
