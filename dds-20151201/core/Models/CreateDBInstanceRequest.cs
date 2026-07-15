// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The password for the root account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>The special characters are !@#$%^&amp;\*()_+-=</para>
        /// </description></item>
        /// <item><description><para>It must be 8 to 32 characters long.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about connection failures caused by special characters in passwords, see <a href="">How do I fix a connection failure that is caused by special characters in a password?</a>.</para>
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
        /// <item><description><para><b>true</b>: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The default value. Disables auto-renewal. You must manually renew the instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is optional and takes effect only when you set the <b>ChargeType</b> parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The backup point ID. To query the backup point ID, call the <a href="">DescribeBackups</a> operation.</para>
        /// <remarks>
        /// <para>You must specify this parameter and the <b>SrcDBInstanceId</b> parameter only when you clone an instance based on a backup point.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32994****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The business information. This is an optional parameter.</para>
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
        /// <item><description><para><b>PostPaid</b>: The default value. Pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>PrePaid</b>: Subscription.</para>
        /// </description></item>
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
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token. Make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot be more than 64 characters long.</para>
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
        /// <item><description><para><b>default</b> or <b>null</b> (default): Uses a coupon.</para>
        /// </description></item>
        /// <item><description><para><b>youhuiquan_promotion_option_id_for_blank</b>: Does not use a coupon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance type. To query instance types, call the <a href="">DescribeAvailableResource</a> operation.</para>
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
        /// <item><description><para>It must start with a letter or a Chinese character.</para>
        /// </description></item>
        /// <item><description><para>It can contain letters, Chinese characters, digits, underscores (_), periods (.), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 256 characters long.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The storage space of the instance in GB.</para>
        /// <para>The value of this parameter varies based on the instance type. For more information, see <a href="">Replica set instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <remarks>
        /// <para>When you clone an instance, you can specify this parameter to clone specific databases. If you do not specify this parameter, all databases of the instance are cloned.</para>
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
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// <item><description><para><b>7.0</b></para>
        /// </description></item>
        /// <item><description><para><b>6.0</b></para>
        /// </description></item>
        /// <item><description><para><b>5.0</b></para>
        /// </description></item>
        /// <item><description><para><b>4.4</b></para>
        /// </description></item>
        /// <item><description><para><b>4.2</b></para>
        /// </description></item>
        /// <item><description><para><b>4.0</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When you clone an instance or restore an instance from the recycle bin, this parameter must be the same as the engine version of the source instance.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>Versions 3.4 and earlier are discontinued.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The global IP address whitelist templates for the instance. Separate multiple templates with commas (,). The templates cannot be repeated. This feature is in canary release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-qxieqf40xjst1ngpr3jz</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The zone where the hidden node is deployed. This parameter is used for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou-g</b>: Zone G in Hangzhou.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-h</b>: Zone H in Hangzhou.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-i</b>: Zone I in Hangzhou.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-b</b>: Zone B in Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-c</b>: Zone C in Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-d</b>: Zone D in Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-a</b>: Zone A in Ulanqab.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-b</b>: Zone B in Ulanqab.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-c</b>: Zone C in Ulanqab.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1a</b>: Zone A in Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1b</b>: Zone B in Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1c</b>: Zone C in Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5a</b>: Zone A in Jakarta.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5b</b>: Zone B in Jakarta.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5c</b>: Zone C in Jakarta.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1a</b>: Zone A in Frankfurt.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1b</b>: Zone B in Frankfurt.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1c</b>: Zone C in Frankfurt.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available when the instance uses disks.</para>
        /// </description></item>
        /// <item><description><para>The value of this parameter cannot be the same as the value of the <b>ZoneId</b> or <b>SecondaryZoneId</b> parameter.</para>
        /// </description></item>
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
        /// <para><b>VPC</b>: virtual private cloud (VPC).</para>
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
        /// <para>The subscription duration of the instance in months.</para>
        /// <para>Valid values: <b>1</b> to <b>9</b> (integers), <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is required and takes effect only when you set the <b>ChargeType</b> parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The provisioned IOPS (input/output operations per second). Valid values: 0 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1960</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The number of <b>read-only nodes</b> in the replica set instance. Valid values are integers from <b>0</b> to <b>5</b>. The default value is <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The region ID. To query the region ID, call the <a href="">DescribeRegions</a> operation.</para>
        /// <remarks>
        /// <para>When you clone an instance or restore an instance from the recycle bin, this parameter must be the same as the region ID of the source instance.</para>
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
        /// <item><description><para><b>3</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>5</b></para>
        /// </description></item>
        /// <item><description><para><b>7</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>You do not need to specify this parameter for standalone instances.</para>
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
        /// <para>The point in time to which you want to restore the instance. You can specify any point in time within the last seven days. The time must be in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and in UTC.</para>
        /// <remarks>
        /// <para>You must specify this parameter and the <b>SrcDBInstanceId</b> parameter only when you clone an instance based on a point in time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-13T12:11:14Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The method to restore an instance from a backup.</para>
        /// <list type="bullet">
        /// <item><description><para>0: Restores the instance to a specified backup set.</para>
        /// </description></item>
        /// <item><description><para>1: Restores the instance to a specified point in time.</para>
        /// </description></item>
        /// <item><description><para>2: Restores a released instance to a specified backup set.</para>
        /// </description></item>
        /// <item><description><para>3: Restores the instance to a specified geo-redundant backup set.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The zone where the secondary node is deployed. This parameter is used for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou-g</b>: Zone G in Hangzhou.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-h</b>: Zone H in Hangzhou.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-i</b>: Zone I in Hangzhou.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-b</b>: Zone B in Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-c</b>: Zone C in Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-d</b>: Zone D in Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-a</b>: Zone A in Ulanqab.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-b</b>: Zone B in Ulanqab.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-c</b>: Zone C in Ulanqab.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1a</b>: Zone A in Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1b</b>: Zone B in Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1c</b>: Zone C in Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5a</b>: Zone A in Jakarta.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5b</b>: Zone B in Jakarta.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5c</b>: Zone C in Jakarta.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1a</b>: Zone A in Frankfurt.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1b</b>: Zone B in Frankfurt.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1c</b>: Zone C in Frankfurt.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available when the instance uses disks.</para>
        /// </description></item>
        /// <item><description><para>The value of this parameter cannot be the same as the value of the <b>ZoneId</b> or <b>HiddenZoneId</b> parameter.</para>
        /// </description></item>
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
        /// <para>The IP address whitelist of the instance. Separate multiple IP addresses with commas (,). Each IP address in the whitelist must be unique. The whitelist can be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description><para>0.0.0.0/0</para>
        /// </description></item>
        /// <item><description><para>An IP address, for example, 10.23.12.24.</para>
        /// </description></item>
        /// <item><description><para>A CIDR block, for example, 10.23.12.0/24. The /24 indicates that the prefix of the CIDR block is 24 bits in length. You can set the prefix to a value from 1 to 32.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can add a maximum of 1,000 IP addresses or CIDR blocks to all IP address whitelists.</para>
        /// </description></item>
        /// <item><description><para>If you set the whitelist to 0.0.0.0/0, all IP addresses can access the instance. This is a high-risk setting. Use this with caution.</para>
        /// </description></item>
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
        /// <para>When you clone an instance, you must specify this parameter and the <b>BackupId</b> or <b>RestoreTime</b> parameter. When you restore an instance from the recycle bin, you only need to specify this parameter. You do not need to specify the <b>BackupId</b> or <b>RestoreTime</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1ee12ad351****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the source instance is located.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when RestoreType is set to 2 or 3.</description></item>
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
        /// <para>The storage engine of the instance. The value is fixed as <b>WiredTiger</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>When you clone an instance or restore an instance from the recycle bin, this parameter must be the same as the storage engine of the source instance.</para>
        /// </description></item>
        /// <item><description><para>For more information about the constraints on storage engines and database versions, see <a href="">Versions and storage engines</a>.</para>
        /// </description></item>
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
        /// <para>The storage class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cloud_essd1</b>: ESSD PL1 disk.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd2</b>: ESSD PL2 disk.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd3</b>: ESSD PL3 disk.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_auto</b>: ESSD AutoPL disk.</para>
        /// </description></item>
        /// <item><description><para><b>local_ssd</b>: Local SSD.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For standalone instances, if you pass the value cloud_essd1, an ESSD disk is used.</para>
        /// </description></item>
        /// <item><description><para>ESSD AutoPL disks are available only on the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>For instances of version 4.4 or later, the default value is <b>cloud_essd1</b>.</para>
        /// </description></item>
        /// <item><description><para>For instances of version 4.2 or earlier, the default value is <b>local_ssd</b>.</para>
        /// </description></item>
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
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> specifies the Nth tag. For example, <b>Tag.1.Key</b> specifies the key of the first tag, and <b>Tag.2.Key</b> specifies the key of the second tag.</description></item>
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
            /// <para><b>N</b> specifies the Nth tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
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
        /// <para>The zone ID. To query the zone ID, call the <a href="">DescribeRegions</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
