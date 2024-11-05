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
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Special characters include ! # $ % ^ &amp; \* ( ) _ + - =</description></item>
        /// <item><description>The password of the account must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123456Aa</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is automatically renewed.</description></item>
        /// <item><description><b>false</b>: The instance is manually renewed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and optional when the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
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
        /// <para>When you call this operation to clone an instance based on the backup set, this parameter is required. The <b>SrcDBInstanceId</b> parameter is also required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32994****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The business information. This is an additional parameter.</para>
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
        /// <para>If you set this parameter to <b>PrePaid</b>, you must also specify the <b>Period</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated cluster to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-2x78****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Default value: null. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> or <b>null</b>: uses coupons.</description></item>
        /// <item><description><b>youhuiquan_promotion_option_id_for_blank</b>: does not use coupons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance type. You can also call the <a href="https://help.aliyun.com/document_detail/149719.html">DescribeAvailableResource</a> operation to query the instance type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.standard</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name of the instance must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name can contain digits, letters, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Unit: GB.</para>
        /// <para>The values that can be specified for this parameter vary based on the instance types. For more information, see <a href="https://help.aliyun.com/document_detail/311410.html">Replica set instance types</a>.</para>
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
        /// <para>When you call this operation to clone an instance, you can set this parameter to specify the database to clone. Otherwise, all databases of the instance are cloned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mongodbtest</para>
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable disk encryption.</para>
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
        /// <para>The database engine of the instance. Set the value to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>6.0</b></description></item>
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>4.4</b></description></item>
        /// <item><description><b>4.2</b></description></item>
        /// <item><description><b>4.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>When you call this operation to clone an instance or restore an instance from the recycle bin, set the value of this parameter to the engine version of the source instance.</para>
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
        /// <para>The global IP address whitelist template name of the instance. Multiple IP address whitelist template names are separated by commas (,) and each template name must be unique. (The template feature is available only in canary release.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-qxieqf40xjst1ngp****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The zone where the hidden node resides for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G.</description></item>
        /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H.</description></item>
        /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I.</description></item>
        /// <item><description><b>cn-hongkong-b</b>: Hongkong Zone B.</description></item>
        /// <item><description><b>cn-hongkong-c</b>: Hongkong Zone C.</description></item>
        /// <item><description><b>cn-hongkong-d</b>: Hongkong Zone D.</description></item>
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
        /// <item><description>This parameter is valid and required when the <b>EngineVersion</b> parameter is set to <b>4.4</b> or <b>5.0</b>.</description></item>
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
        /// <para>The network type of the instance. Valid value:</para>
        /// <para><b>VPC</b>: Virtual Private Cloud (VPC)</para>
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
        /// <para>The subscription period of the instance. Unit: months.</para>
        /// <para>Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <para>When you set the <b>ChargeType</b> parameter to <b>PrePaid</b>, this parameter is valid and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The provisioned IOPS. Valid values: 0 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1960</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The number of <b>read-only nodes</b> in the replica set instance. Default value: <b>0</b>. Valid values: <b>0</b> to <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of <b>nodes</b> in the replica set instance. Default value: 3. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b></description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>7</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
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
        /// <para>The point in time to which the instance is restored, which must be within seven days. The time is displayed in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format (UTC time).</para>
        /// <remarks>
        /// <para>When you call this operation to restore an instance to the specified time, this parameter is required. The <b>SrcDBInstanceId</b> parameter is also required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-13T12:11:14Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The backup restore type of the instance.</para>
        /// <list type="bullet">
        /// <item><description>0: restore an instance to the specified backup set.</description></item>
        /// <item><description>1:  restore an instance to the specified time.</description></item>
        /// <item><description>2: restore an  released instance to the specified backup set.</description></item>
        /// <item><description>3：restore an instance to the specified cross-regional backup set.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The zone where the secondary node resides for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G.</description></item>
        /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H.</description></item>
        /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I.</description></item>
        /// <item><description><b>cn-hongkong-b</b>: Hongkong Zone B.</description></item>
        /// <item><description><b>cn-hongkong-c</b>: Hongkong Zone C.</description></item>
        /// <item><description><b>cn-hongkong-d</b>: Hongkong Zone D.</description></item>
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
        /// <item><description>This parameter is valid and required when the <b>EngineVersion</b> parameter is set to <b>4.4</b> or <b>5.0</b>.</description></item>
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
        /// <para>The IP addresses in an IP address whitelist. Multiple IP addresses are separated by commas (,), and each IP address in the IP address whitelist must be unique. The following types of values are supported:</para>
        /// <list type="bullet">
        /// <item><description>0.0.0.0/0</description></item>
        /// <item><description>IP addresses, such as 10.23.12.24.</description></item>
        /// <item><description>Classless Inter-Domain Routing (CIDR) blocks, such as 10.23.12.0/24. In this case, /24 indicates that the prefix of each IP address is 24-bit long. You can replace 24 with a value within the range of 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A maximum of 1,000 IP addresses or CIDR blocks can be configured for each instance.</description></item>
        /// <item><description>If you enter 0.0.0.0/0, all IP addresses can access the instance. This may introduce security risks to the instance. Proceed with caution.</description></item>
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
        /// <para>The ID of the source instance.</para>
        /// <remarks>
        /// <para>When you call this operation to clone an instance, this parameter is required. The <b>BackupId</b> or <b>RestoreTime</b> parameter is also required. When you call this operation to restore an instance from the recycle bin, this parameter is required. The <b>BackupId</b> or <b>RestoreTime</b> parameter is not required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1ee12ad351****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when restore type is set to 2 or 3.</description></item>
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
        /// <item><description>If you call this operation to clone an instance or restore an instance from the recycle bin, set this parameter to the storage engine of the source instance.</description></item>
        /// <item><description>For more information about the limits on database versions and storage engines of an instance, see <a href="https://help.aliyun.com/document_detail/61906.html">MongoDB versions and storage engines</a>.</description></item>
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
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd1</b> :ESSD PL1.</description></item>
        /// <item><description><b>cloud_essd2</b>: ESSD PL2.</description></item>
        /// <item><description><b>cloud_essd3</b>: ESSD PL3.</description></item>
        /// <item><description><b>local_ssd</b>: local SSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The custom tags added to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <para><b>N</b> specifies the serial number of the tag. For example, <b>Tag.1.Key</b> specifies the key of the first tag and <b>Tag.2.Key</b> specifies the key of the second tag.</para>
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
            /// <para><b>N</b> specifies the serial number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
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
        /// <para>The ID of the vSwitch to which the instance is connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp175iuvg8nxqraf2****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
