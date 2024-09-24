// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDdrInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID that you want to use for the restoration. You can call the DescribeCrossRegionBackups operation to query backup set ID.</para>
        /// <remarks>
        /// <para> This parameter is required when you set the <b>RestoreType</b> parameter to <b>BackupSet</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>14***</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The connection mode of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: standard mode</description></item>
        /// <item><description><b>Safe</b>: database proxy mode</description></item>
        /// </list>
        /// <para>Default value: <b>Standard</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// <para>The instance type of the destination instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mysql.s1.small</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 256 characters in length. The value can contain letters, digits, underscores (_), and hyphens (-), and must start with a letter.</para>
        /// <remarks>
        /// <para> The value cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test database</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The network connection type of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b></description></item>
        /// <item><description><b>Intranet</b></description></item>
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
        /// <para>The storage capacity of the destination instance. Valid values: <b>5 to 2000</b>. Unit: GB. You can increase the storage capacity at a step size of 5 GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the destination instance. Only the local SSD storage type is supported. Default value: <b>local_ssd</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The ID of the customer master key (CMK) for cloud disk encryption. If this parameter is specified, cloud disk encryption is enabled and you must also specify the <b>RoleARN</b> parameter. Cloud disk encryption cannot be disabled after it is enabled. You can obtain the ID of the key in the KMS console or create a key. For more information, see <a href="https://help.aliyun.com/document_detail/181610.html">Create a key</a>.</para>
        /// <para>**</para>
        /// <para><b>Notes</b></para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// </description></item>
        /// <item><description><para>You can leave this parameter empty. If you do not specify this parameter, you only need to specify the <b>RoleARN</b> to use the service key that is managed by ApsaraDB RDS to encrypt cloud disks.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The database engine of the destination instance. Valid values:</para>
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
        /// <para>The major engine version of the destination instance. The value of this parameter varies based on the value of <b>Engine</b>.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when Engine is set to MySQL: <b>5.5, 5.6, 5.7, and 8.0</b></description></item>
        /// <item><description>Valid values when Engine is set to SQLServer: <b>2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, and 2019_ent</b></description></item>
        /// <item><description>Valid values when Engine is set to PostgreSQL: <b>9.4, 10.0, 11.0, 12.0, and 13.0</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// <item><description><b>Classic</b></description></item>
        /// </list>
        /// <para>Default value: Classic.</para>
        /// <remarks>
        /// <para>If you set this parameter to <b>VPC</b>, you must also specify <b>VpcId</b> and <b>VSwitchId</b>.</para>
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
        /// <para>The billing method of the instance. Valid values:</para>
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
        /// <para>The unit that is used to measure the subscription duration of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set PayType to <b>Prepaid</b>, you must specify UsedTime.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The private IP address of the destination instance. The private IP address must be within the CIDR block that is supported by the specified vSwitch. The system automatically assigns an internal IP address based on the values of the <b>VPCId</b> and <b>VSwitchId</b> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XXX.XXX.69</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the destination instance. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>rg-acfmyxxxxxxxxxx</para>
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
        /// <para>The point in time to which you want to restore data. The point in time that you specify must be earlier than the current time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>If <b>RestoreType</b> is set to <b>BackupTime</b>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-30T03:29:10Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration method that you want to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BackupSet</b>: restores data from a backup set. If you use this value, you must also specify <b>BackupSetId</b>.</description></item>
        /// <item><description><b>BackupTime</b>: restores data to a point in time. If you use this value, you must also specify <b>RestoreTime</b>, <b>SourceRegion</b>, and <b>SourceDBInstanceName</b>.</description></item>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) that is provided by your Alibaba Cloud account for Resource Access Management (RAM) users. RAM users can use the ARN to connect to ApsaraDB RDS to Key Management Service (KMS). You can call the <a href="https://help.aliyun.com/document_detail/2628797.html">CheckCloudResourceAuthorized</a> operation to query the ARN.</para>
        /// <remarks>
        /// <para> This parameter is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The IP address whitelist of the destination instance. If you want to add more than one entry to the IP address whitelist, separate the entries with commas (,). Each entry must be unique. You can add a maximum of 1,000 entries. For more information, see <a href="https://help.aliyun.com/document_detail/43185.html">Configure an IP address whitelist for an ApsaraDB RDS for MySQL instance</a>. The entries in the IP address whitelist must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>IP address. Example: 10.23.12.24.</description></item>
        /// <item><description>CIDR block. Example: 10.23.12.24/24. In this example, 24 indicates that the prefix of the CIDR block is 24 bits in length. You can replace 24 with a value that ranges from 1 to 32.</description></item>
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
        /// <para>The source instance ID, which is used if you want to restore data to a point in time.</para>
        /// <remarks>
        /// <para> This parameter is required when you set the <b>RestoreType</b> parameter to <b>BackupTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID of the source instance if you want to restore data to a point in time.</para>
        /// <remarks>
        /// <para>If you set <b>RestoreType</b> to <b>BackupTime</b>, you must specify this parameter.</para>
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
        /// <para>The subscription duration of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>Period</b> to <b>Year</b>, the value of UsedTime ranges from <b>1 to 3</b>.</description></item>
        /// <item><description>If you set <b>Period</b> to <b>Month</b>, the value of UsedTime ranges from <b>1 to 9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set PayType to <b>Prepaid</b>, you must specify UsedTime.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID of the destination instance. This parameter is available only when you set the <b>InstanceNetworkType</b> parameter to <b>VPC</b>.</para>
        /// <remarks>
        /// <para> If you specify this parameter, you must also specify the <b>ZoneId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the destination instance. If you specify more than one vSwitch, separate the IDs of the vSwitches with commas (,). This parameter is available only when you set the <b>InstanceNetworkType</b> parameter to <b>VPC</b>.</para>
        /// <remarks>
        /// <para> If you specify this parameter, you must also specify the <b>ZoneId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the destination instance. If the destination instance is deployed in multiple zones, separate the IDs of the zones with colons (:).</para>
        /// <remarks>
        /// <para>If you specify a virtual private cloud (VPC) and a vSwitch, you must specify this parameter to identify the zone for the vSwitch.</para>
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
