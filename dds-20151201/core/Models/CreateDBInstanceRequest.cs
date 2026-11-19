// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The password of the root account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Special characters include !@#$%^&amp;*()_+-=.</description></item>
        /// <item><description>It must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about how to resolve the issue where database connection fails due to special characters in the account password in the connection string, see <a href="https://help.aliyun.com/document_detail/471568.html">What do I do if the connection to an ApsaraDB for MongoDB instance fails because the username or password in the connection string contains special characters?</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456Aa</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal. In this case, you must manually renew the instance. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and optional only when the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the backup set. You can call the <a href="https://help.aliyun.com/document_detail/62172.html">DescribeBackups</a> operation to query the backup set ID.</para>
        /// <remarks>
        /// <para>This parameter is required only when you call this operation to clone an instance from a backup set. You must also specify the <b>SrcDBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32994****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The additional parameter for business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PostPaid</b>: pay-as-you-go. This is the default value.</description></item>
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When this parameter is set to <b>PrePaid</b>, you must also specify the <b>Period</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and can be up to 64 ASCII characters in length. The value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> or <b>null</b>: uses a coupon. This is the default value.</description></item>
        /// <item><description><b>youhuiquan_promotion_option_id_for_blank</b>: does not use a coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance type. You can call the <a href="https://help.aliyun.com/document_detail/149719.html">DescribeAvailableResource</a> operation to query the available instance types.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.standard</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It must start with a letter or a Chinese character.</description></item>
        /// <item><description>It can contain digits, letters, Chinese characters, underscores (_), periods (.), and hyphens (-).</description></item>
        /// <item><description>It must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance storage. Unit: GB.</para>
        /// <para>The valid values are subject to the instance type. For details, see <a href="https://help.aliyun.com/document_detail/311410.html">Replica set instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <remarks>
        /// <para>When you call this operation to clone an instance, you can specify this parameter to specify the databases to be cloned. If you do not specify this parameter, all databases of the instance are cloned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mongodbtest</para>
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run without calling the operation. The system checks items such as request parameters, request format, business limits, and inventory. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false (default): sends a normal request. After the check succeeds, the operation is directly executed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cloud disk encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the custom key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2axxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The database engine. Set the value to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>8.0</b></description></item>
        /// <item><description><b>7.0</b></description></item>
        /// <item><description><b>6.0</b></description></item>
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>4.4</b></description></item>
        /// <item><description><b>4.2</b></description></item>
        /// <item><description><b>4.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>When you call this operation to clone clone instance or restore clone instance from the recycle bin, the value of this parameter must be the same as that of the source instance.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: Versions 3.4 and earlier are no longer available for sale.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The global IP address whitelist templates of the instance. Separate multiple templates with commas (,). Duplicate templates are not allowed. This feature is in canary release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-qxieqf40xjst1ngpr3jz</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The zone where the hidden node resides. You can specify this parameter for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G.</description></item>
        /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H.</description></item>
        /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I.</description></item>
        /// <item><description><b>cn-hongkong-b</b>: Hong Kong (China) Zone B.</description></item>
        /// <item><description><b>cn-hongkong-c</b>: Hong Kong (China) Zone C.</description></item>
        /// <item><description><b>cn-hongkong-d</b>: Hong Kong (China) Zone D.</description></item>
        /// <item><description><b>cn-wulanchabu-a</b>: Ulanqab Zone A.</description></item>
        /// <item><description><b>cn-wulanchabu-b</b>: Ulanqab Zone B.</description></item>
        /// <item><description><b>cn-wulanchabu-c</b>: Ulanqab Zone C.</description></item>
        /// <item><description><b>ap-southeast-1a</b>: Singapore Zone A.</description></item>
        /// <item><description><b>ap-southeast-1b</b>: Singapore Zone B.</description></item>
        /// <item><description><b>ap-southeast-1c</b>: Singapore Zone C.</description></item>
        /// <item><description><b>ap-southeast-5a</b>: Jakarta Zone A.</description></item>
        /// <item><description><b>ap-southeast-5b</b>: Jakarta Zone B.</description></item>
        /// <item><description><b>ap-southeast-5c</b>: Jakarta Zone C.</description></item>
        /// <item><description><b>eu-central-1a</b>: Frankfurt Zone A.</description></item>
        /// <item><description><b>eu-central-1b</b>: Frankfurt Zone B.</description></item>
        /// <item><description><b>eu-central-1c</b>: Frankfurt Zone C.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is active only when the instance uses cloud disks.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the value of the <b>ZoneId</b> or <b>SecondaryZoneId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("HiddenZoneId")]
        [Validation(Required=false)]
        public string HiddenZoneId { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <para><b>VPC</b>: Virtual Private Cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. Unit: month.</para>
        /// <para>Valid values: <b>1</b> to <b>9</b> (integers), <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is required and valid only when the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The provisioned performance (IOPS). Valid values: 0 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1960</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The number of <b>read-only nodes</b> in the replica set instance. Valid values: <b>0</b> to <b>5</b> (integers). Default value: <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <remarks>
        /// <para>When you call this operation to clone clone instance or restore clone instance from the recycle bin, the value of this parameter must be the same as that of the source instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of <b>primary and secondary nodes</b> in the replica set instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b> (default)</description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>7</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: You do not need to specify this parameter for a standalone instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

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
        /// <para>The point in time to which you want to restore the instance. You can specify any point in time within the last seven days. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter is required only when you call this operation to clone an instance to a specific point in time. You must also specify the <b>SrcDBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-13T12:11:14Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The backup restoration type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: restores the instance to a specified backup set</description></item>
        /// <item><description>1: restores the instance to a specified point in time</description></item>
        /// <item><description>2: restores a released instance to a specified backup set</description></item>
        /// <item><description>3: restores the instance to a specified geo-redundancy backup set</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The zone where the secondary node resides. You can specify this parameter for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G.</description></item>
        /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H.</description></item>
        /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I.</description></item>
        /// <item><description><b>cn-hongkong-b</b>: Hong Kong (China) Zone B.</description></item>
        /// <item><description><b>cn-hongkong-c</b>: Hong Kong (China) Zone C.</description></item>
        /// <item><description><b>cn-hongkong-d</b>: Hong Kong (China) Zone D.</description></item>
        /// <item><description><b>cn-wulanchabu-a</b>: Ulanqab Zone A.</description></item>
        /// <item><description><b>cn-wulanchabu-b</b>: Ulanqab Zone B.</description></item>
        /// <item><description><b>cn-wulanchabu-c</b>: Ulanqab Zone C.</description></item>
        /// <item><description><b>ap-southeast-1a</b>: Singapore Zone A.</description></item>
        /// <item><description><b>ap-southeast-1b</b>: Singapore Zone B.</description></item>
        /// <item><description><b>ap-southeast-1c</b>: Singapore Zone C.</description></item>
        /// <item><description><b>ap-southeast-5a</b>: Jakarta Zone A.</description></item>
        /// <item><description><b>ap-southeast-5b</b>: Jakarta Zone B.</description></item>
        /// <item><description><b>ap-southeast-5c</b>: Jakarta Zone C.</description></item>
        /// <item><description><b>eu-central-1a</b>: Frankfurt Zone A.</description></item>
        /// <item><description><b>eu-central-1b</b>: Frankfurt Zone B.</description></item>
        /// <item><description><b>eu-central-1c</b>: Frankfurt Zone C.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is active only when the instance uses cloud disks.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the value of the <b>ZoneId</b> or <b>HiddenZoneId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist of the instance. Separate multiple IP addresses with commas (,). Duplicate IP addresses are not allowed. The following three formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>0.0.0.0/0</description></item>
        /// <item><description>IP address format, such as 10.23.12.24.</description></item>
        /// <item><description>CIDR format, such as 10.23.12.0/24. 24 indicates the length of the prefix in the CIDR block, and the valid range is 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can add up to 1,000 IP addresses or CIDR blocks to each instance. The total number of IP addresses or CIDR blocks in all IP address whitelist groups cannot exceed 1,000.</description></item>
        /// <item><description>0.0.0.0/0 indicates that all IP addresses can access the databases of the instance. This is a high-risk setting. Proceed with caution.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.xx,192.168.xx.xx</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The source instance ID.</para>
        /// <remarks>
        /// <para>When you call this operation to clone an instance, you must specify this parameter and the <b>BackupId</b> or <b>RestoreTime</b> parameter. When you call this operation to restore a revoked instance, you only need to specify this parameter, and you do not need to specify the <b>BackupId</b> or <b>RestoreTime</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1ee12ad351****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the source instance resides.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the backup restoration type is 2 or 3.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

        /// <summary>
        /// <para>The storage engine of the instance. Set the value to <b>WiredTiger</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you call this operation to clone clone instance or restore clone instance from the recycle bin, the value of this parameter must be the same as that of the source instance.</description></item>
        /// <item><description>For more information about the constraints on the selection of storage engines and versions, see <a href="https://help.aliyun.com/document_detail/61906.html">Versions and storage engines</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WiredTiger</para>
        /// </summary>
        [NameInMap("StorageEngine")]
        [Validation(Required=false)]
        public string StorageEngine { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd1</b>: PL1 ESSD.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>cloud_auto</b>: ESSD AutoPL cloud disk.</description></item>
        /// <item><description><b>local_ssd</b>: local SSD.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify cloud_essd1 when you purchase a standalone instance, the instance actually uses a cloud_essd cloud disk.</description></item>
        /// <item><description>ESSD AutoPL cloud disks are supported only on the Alibaba Cloud China site.</description></item>
        /// <item><description>The default value for instances of version 4.4 and later is <b>cloud_essd1</b>.</description></item>
        /// <item><description>The default value for instances of version 4.2 and earlier is <b>local_ssd</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable TTL index cleanup for the restored instance. A value of true or an empty value indicates that cleanup is enabled.</para>
        /// </summary>
        [NameInMap("TTLEnabled")]
        [Validation(Required=false)]
        public bool? TTLEnabled { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> specifies the sequence number of the tag. For example, <b>Tag.1.Key</b> specifies the key of the first tag, and <b>Tag.2.Key</b> specifies the key of the second tag.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testdatabase</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <remarks>
            /// <para><b>N</b> specifies the sequence number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>apitest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp175iuvg8nxqraf2****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
