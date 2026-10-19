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
        /// <item><description>Must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Special characters include !@#$%^&amp;*()_+-=.</description></item>
        /// <item><description>Must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For information about how to database connection failures caused by special characters in the password, see <a href="https://help.aliyun.com/document_detail/471568.html">How do I database connection failures caused by special characters in the connection string?</a>.</para>
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
        /// <item><description><b>false</b>: default value. Disables auto-renewal. You must manually renew the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and optional when <b>ChargeType</b> is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The backup ID. You can invoke the <a href="https://help.aliyun.com/document_detail/62172.html">DescribeBackups</a> operation to query the backup ID.</para>
        /// <remarks>
        /// <para>This parameter is required only when you invoke this operation to clone a clone instance from a backup point. You must also configure the <b>SrcDBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32994****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The additional information about the business.</para>
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
        /// <item><description><b>PostPaid</b>: default value. Pay-as-you-go.</description></item>
        /// <item><description><b>PrePaid</b>: Subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>PrePaid</b>, you must also configure the <b>Period</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <item><description><b>default</b> or <b>null</b> (default): uses a coupon.</description></item>
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
        /// <para>The instance name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Must start with a Chinese character or a letter.</description></item>
        /// <item><description>Can contain digits, Chinese characters, letters, underscores (_), periods (.), and hyphens (-).</description></item>
        /// <item><description>Must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance storage capacity. Unit: GB.</para>
        /// <para>The valid values depend on the instance type. For details, see <a href="https://help.aliyun.com/document_detail/311410.html">Replica set instance specifications</a>.</para>
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
        /// <para>When you invoke this operation to clone a clone instance, you can specify this parameter to clone specific databases. If you do not specify this parameter, all databases are cloned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mongodbtest</para>
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

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
        /// <para>The custom key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2axxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The database engine. The value is fixed as <b>MongoDB</b>.</para>
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
        /// <para>If you call this operation to clone clone instance or restore clone instance from the recycle bin, set this parameter to the same value as that of the source instance.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: Versions 3.4 and earlier are no longer available for purchase.</para>
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
        /// <para>The global IP whitelist templates for the instance. Separate multiple templates with commas (,). Duplicate templates are not allowed. (This feature is in canary release.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-qxieqf40xjst1ngpr3jz</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The zone where the hidden node is deployed to implement multi-zone deployment. Valid values:</para>
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
        /// <item><description>This parameter is available when the instance uses cloud disks.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the values of <b>ZoneId</b> and <b>SecondaryZoneId</b>.</description></item>
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
        /// <para>The network type of the instance. Valid values:</para>
        /// <para><b>VPC</b>: Virtual Private Cloud.</para>
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
        /// <para>The subscription duration of the instance. Unit: months.</para>
        /// <para>Valid values: <b>1</b> to <b>9</b> (integers), <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is available and required when <b>ChargeType</b> is set to <b>PrePaid</b>.</para>
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
        /// <para>The <b>number of read-only nodes</b> in the replica set instance. Valid values: <b>0</b> to <b>5</b> (integers). Default value: <b>0</b>.</para>
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
        /// <para>If you call this operation to clone clone instance or restore clone instance from the recycle bin, set this parameter to the same value as that of the source instance.</para>
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
        /// <para>The <b>number of primary and secondary nodes</b> in the replica set instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b> (default)</description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>7</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: This parameter is not required for single-node instances.</para>
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
        /// <para>The point in time to recover the instance to. You can specify any point in time within the last 7 days. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter is required only when you invoke this operation to clone a clone instance to a point in time. You must also configure the <b>SrcDBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-13T12:11:14Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The backup restoration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: recovers the instance to a specified backup set.</description></item>
        /// <item><description>1: recovers the instance to a specified point in time.</description></item>
        /// <item><description>2: recovers a released instance to a specified backup set.</description></item>
        /// <item><description>3: recovers the instance to a specified geo-redundancy backup set.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The zone where the secondary node is deployed to implement multi-zone deployment. Valid values:</para>
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
        /// <item><description>This parameter is available when the instance uses cloud disks.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the values of <b>ZoneId</b> and <b>HiddenZoneId</b>.</description></item>
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
        /// <para>The IP whitelist of the instance. Separate multiple IP addresses with commas (,). Duplicate IP addresses are not allowed. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>0.0.0.0/0</description></item>
        /// <item><description>IP address format, such as 10.23.12.24.</description></item>
        /// <item><description>CIDR block format, such as 10.23.12.0/24. In this example, 24 indicates that the prefix of the CIDR block is 24 bits in length. The prefix length ranges from 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Each instance supports a maximum of 1,000 IP addresses or CIDR blocks across all IP whitelist groups.</description></item>
        /// <item><description>0.0.0.0/0 allows all IP addresses to access the instance database. This is a high-risk setting. Proceed with caution.</description></item>
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
        /// <para>If you call this operation to clone clone instance, you must configure this parameter along with the <b>BackupId</b> or <b>RestoreTime</b> parameter. If you call this operation to restore clone instance from the recycle bin, you only need to configure this parameter. The <b>BackupId</b> and <b>RestoreTime</b> parameters are not required.</para>
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
        /// <para>This parameter is required when the restoration type is 2 or 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

        /// <summary>
        /// <para>The storage engine of the instance. The value is fixed as <b>WiredTiger</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you call this operation to clone clone instance or restore clone instance from the recycle bin, set this parameter to the same value as that of the source instance.</description></item>
        /// <item><description>For information about the constraints on storage engines and versions, see <a href="https://help.aliyun.com/document_detail/61906.html">Versions and storage engines</a>.</description></item>
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
        /// <item><description><b>cloud_auto</b>: ESSD AutoPL disk.</description></item>
        /// <item><description><b>local_ssd</b>: local SSD.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For single-node instances, if you specify cloud_essd1, the instance uses a cloud_essd disk.</description></item>
        /// <item><description>ESSD AutoPL disks are currently available only on the China site.</description></item>
        /// <item><description>For instances running version 4.4 or later, the default value is <b>cloud_essd1</b>.</description></item>
        /// <item><description>For instances running version 4.2 or earlier, the default value is <b>local_ssd</b>.</description></item>
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
        /// <para>The user-defined tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> indicates the sequence number of the tag key. For example, <b>Tag.1.Key</b> indicates the key of the first tag, and <b>Tag.2.Key</b> indicates the key of the second tag.</description></item>
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
            /// <para>The tag value.</para>
            /// <remarks>
            /// <para><b>N</b> indicates the sequence number of the tag value. For example, <b>Tag.1.Value</b> indicates the value of the first tag, and <b>Tag.2.Value</b> indicates the value of the second tag.</para>
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
