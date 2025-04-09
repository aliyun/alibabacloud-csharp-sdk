// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateShardingDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The password of the root account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The password contains at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>The following special characters are supported: ! @ # $ % ^ &amp; \* ( ) _ + - =.</description></item>
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about how to resolve failed database connections due to special characters, see <a href="https://help.aliyun.com/document_detail/471568.html">What do I do if my instance is not connected due to special characters in the password in the connection string of the instance?</a></para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and optional if you set the value of <b>ChargeType</b> to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the backup set. </para>
        /// <remarks>
        /// <para>When you call this operation to clone an instance based on the backup set, this parameter is required. The <b>SrcDBInstanceId</b> parameter is also required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cb-xxx</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PostPaid</b> (default): pay-as-you-go</description></item>
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>PrePaid</b>, you must also configure the <b>Period</b> parameter.</para>
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

        /// <summary>
        /// <para>The ConfigServer nodes of the instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfigServer")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestConfigServer> ConfigServer { get; set; }
        public class CreateShardingDBInstanceRequestConfigServer : TeaModel {
            /// <summary>
            /// <para>The instance type of the ConfigServer node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mdb.shard.2x.xlarge.d</b>: 4 cores, 8 GB (dedicated). Only instances that run MongoDB 4.4 and later support this instance type.</description></item>
            /// <item><description><b>dds.cs.mid</b> :1 core, 2 GB (general-purpose). Only instances that run MongoDB 4.2 and earlier support this instance type.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mdb.shard.2x.xlarge.d</para>
            /// </summary>
            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            /// <summary>
            /// <para>The storage space of the ConfigServer node. Unit: GB.</para>
            /// <remarks>
            /// <para>The values that can be specified for this parameter vary based on the instance types. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

        }

        /// <summary>
        /// <para>The name of the instance. The name of the instance must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>It can contain digits, letters, underscores (_), and hyphens (-).</description></item>
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
        /// <para>The region of the backup set used for the cross-region backup and restoration.</para>
        /// <remarks>
        /// <para> This parameter is required when you set the RestoreType parameter to 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>7.0</b></description></item>
        /// <item><description><b>6.0</b></description></item>
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>4.4</b></description></item>
        /// <item><description><b>4.2</b></description></item>
        /// <item><description><b>4.0</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>For more information about the limits on database versions and storage engines, see <a href="https://help.aliyun.com/document_detail/61906.html">MongoDB versions and storage engines</a>.</para>
        /// </description></item>
        /// <item><description><para>If you call this operation to clone an instance, set the value of this parameter to the database engine version of the source instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The global IP address whitelist template of the instance. Separate multiple templates with commas (,). The template name must be globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-qxieqf40xjst1ngp****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of secondary zone 2 for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G</description></item>
        /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H</description></item>
        /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I</description></item>
        /// <item><description><b>cn-hongkong-b</b>: Hong Kong Zone B</description></item>
        /// <item><description><b>cn-hongkong-c</b>: Hong Kong Zone C</description></item>
        /// <item><description><b>cn-hongkong-d</b>: Hong Kong Zone D</description></item>
        /// <item><description><b>cn-wulanchabu-a</b>: Ulanqab Zone A</description></item>
        /// <item><description><b>cn-wulanchabu-b</b>: Ulanqab Zone B</description></item>
        /// <item><description><b>cn-wulanchabu-c</b>: Ulanqab Zone C</description></item>
        /// <item><description><b>ap-southeast-1a</b>: Singapore Zone A</description></item>
        /// <item><description><b>ap-southeast-1b</b>: Singapore Zone B</description></item>
        /// <item><description><b>ap-southeast-1c</b>: Singapore Zone C</description></item>
        /// <item><description><b>ap-southeast-5a</b>: Jakarta Zone A</description></item>
        /// <item><description><b>ap-southeast-5b</b>: Jakarta Zone B</description></item>
        /// <item><description><b>ap-southeast-5c</b>: Jakarta Zone C</description></item>
        /// <item><description><b>eu-central-1a</b>: Frankfurt Zone A</description></item>
        /// <item><description><b>eu-central-1b</b>: Frankfurt Zone B</description></item>
        /// <item><description><b>eu-central-1c</b>: Frankfurt Zone C</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required if you set the value of <b>EngineVersion</b> to <b>4.4</b> or <b>5.0</b>.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the value of <b>ZoneId</b> or <b>SecondaryZoneId</b>.</description></item>
        /// <item><description>For more information about the multi-zone deployment policy of a sharded cluster instance, see <a href="https://help.aliyun.com/document_detail/117865.html">Create a multi-zone sharded cluster instance</a>.</description></item>
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
        /// <para>The mongos nodes of the instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mongos")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestMongos> Mongos { get; set; }
        public class CreateShardingDBInstanceRequestMongos : TeaModel {
            /// <summary>
            /// <para>The instance type of the mongos node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> specifies the serial number of the mongos node for which the instance type is specified. For example, <b>Mongos.2.Class</b> specifies the instance type of the second mongos node.</description></item>
            /// <item><description>Valid values for <b>N</b>: <b>2</b> to <b>32</b>.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mdb.shard.2x.xlarge.d</para>
            /// </summary>
            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

        }

        /// <summary>
        /// <para>The network type of the instance. Set the value to VPC.</para>
        /// <hr>
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
        /// <para>The access protocol type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mongodb</b></description></item>
        /// <item><description><b>dynamodb</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mongodb</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The provisioned IOPS of the instance:</para>
        /// 
        /// <b>Example:</b>
        /// <para>1960</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

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
        /// <para>The information of the shard component.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReplicaSet")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestReplicaSet> ReplicaSet { get; set; }
        public class CreateShardingDBInstanceRequestReplicaSet : TeaModel {
            /// <summary>
            /// <para>The instance type of the shard component. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para><b>N</b> specifies the serial number of the shard component for which the instance type is specified. For example, <b>ReplicaSet.2.Class</b> specifies the instance type of the second shard component.</para>
            /// </description></item>
            /// <item><description><para>Valid values of <b>N</b>: <b>2</b> to <b>32</b>.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dds.shard.standard</para>
            /// </summary>
            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            /// <summary>
            /// <para>The number of read-only nodes in the shard component.</para>
            /// <para>Valid values: <b>0</b>, <b>1, 2, 3, 4, and 5</b>. Default value: <b>0</b>.</para>
            /// <remarks>
            /// <para> <b>N</b> specifies the serial number of the shard component for which you want to set the number of read-only nodes. <b>ReplicaSet.2.ReadonlyReplicas</b> specifies the number of read-only nodes in the second shard component.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReadonlyReplicas")]
            [Validation(Required=false)]
            public int? ReadonlyReplicas { get; set; }

            /// <summary>
            /// <para>The storage capacity of the shard component. Unit: GB.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The values that can be specified for this parameter vary based on the instance types. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// </description></item>
            /// <item><description><para><b>N</b> specifies the serial number of the shard component for which the storage capacity is specified. For example, <b>ReplicaSet.2.Storage</b> specifies the storage capacity of the second shard component.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

        }

        /// <summary>
        /// <para>The resource group ID. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
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
        /// <para>The point in time to restore the instance, which must be within seven days. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in Coordinated Universal Time (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required only if you call this operation to clone an instance. If you specify this parameter, you must also specify <b>SrcDBInstanceId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-08T02:30:25Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: restores the instance data to the specified point in time.</description></item>
        /// <item><description>2: restores the data of the released instance to the specified backup set.</description></item>
        /// <item><description>3: restores the instance data to the specified cross-region backup set.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The ID of secondary zone 1 for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G</description></item>
        /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H</description></item>
        /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I</description></item>
        /// <item><description><b>cn-hongkong-b</b>: Hong Kong Zone B</description></item>
        /// <item><description><b>cn-hongkong-c</b>: Hong Kong Zone C</description></item>
        /// <item><description><b>cn-hongkong-d</b>: Hong Kong Zone D</description></item>
        /// <item><description><b>cn-wulanchabu-a</b>: Ulanqab Zone A</description></item>
        /// <item><description><b>cn-wulanchabu-b</b>: Ulanqab Zone B</description></item>
        /// <item><description><b>cn-wulanchabu-c</b>: Ulanqab Zone C</description></item>
        /// <item><description><b>ap-southeast-1a</b>: Singapore Zone A</description></item>
        /// <item><description><b>ap-southeast-1b</b>: Singapore Zone B</description></item>
        /// <item><description><b>ap-southeast-1c</b>: Singapore Zone C</description></item>
        /// <item><description><b>ap-southeast-5a</b>: Jakarta Zone A</description></item>
        /// <item><description><b>ap-southeast-5b</b>: Jakarta Zone B</description></item>
        /// <item><description><b>ap-southeast-5c</b>: Jakarta Zone C</description></item>
        /// <item><description><b>eu-central-1a</b>: Frankfurt Zone A</description></item>
        /// <item><description><b>eu-central-1b</b>: Frankfurt Zone B</description></item>
        /// <item><description><b>eu-central-1c</b>: Frankfurt Zone C</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required if you set the value of <b>EngineVersion</b> to <b>4.4</b> or <b>5.0</b>.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the value of <b>ZoneId</b> or <b>HiddenZoneId</b>.</description></item>
        /// <item><description>For more information about the multi-zone deployment policy of a sharded cluster instance, see <a href="https://help.aliyun.com/document_detail/117865.html">Create a multi-zone sharded cluster instance</a>.</description></item>
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
        /// <para>The IP addresses in an IP address whitelist of the instance. Multiple IP addresses are separated by commas (,), and each IP address in the IP address whitelist must be unique. The following types of values are supported:</para>
        /// <list type="bullet">
        /// <item><description>0.0.0.0/0</description></item>
        /// <item><description>IP addresses, such as 10.23.12.24.</description></item>
        /// <item><description>CIDR blocks, such as 10.23.12.0/24. In this case, 24 indicates that the prefix of each IP address is 24-bit long. You can replace 24 with a value within the range of 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A maximum of 1,000 IP addresses and CIDR blocks can be configured for each instance.</description></item>
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
        /// <para>The source instance ID.</para>
        /// <remarks>
        /// <para>This parameter is required only if you call this operation to clone an instance. If you specify this parameter, you must also specify <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp11483712c1****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <para>This parameter is required when restore type is set to 2 or 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

        /// <summary>
        /// <para>The storage engine of the instance. Set the value to <b>WiredTiger</b>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you call this operation to clone an instance, set the value of this parameter to the storage engine of the source instance.</para>
        /// </description></item>
        /// <item><description><para>For more information about the limits on database versions and storage engines, see <a href="https://help.aliyun.com/document_detail/61906.html">MongoDB versions and storage engines</a>.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>cloud_essd1</b>: ESSD PL1</description></item>
        /// <item><description><b>cloud_essd2</b>: ESSD PL2</description></item>
        /// <item><description><b>cloud_essd3</b>: ESSD PL3</description></item>
        /// <item><description><b>local_ssd</b>: local SSD</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Instances of MongoDB 4.4 and later support only cloud disks. <b>cloud_essd1</b> is selected if you leave this parameter empty.</description></item>
        /// <item><description>Instances of MongoDB 4.2 and earlier support only local disks. <b>local_ssd</b> is selected if you leave this parameter empty.</description></item>
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
        /// <para>The custom tags that you want to add to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestTag> Tag { get; set; }
        public class CreateShardingDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <para> <b>N</b> specifies the serial number of the tag. For example, <b>Tag.1.Key</b> specifies the key of the first tag and <b>Tag.2.Key</b> specifies the key of the second tag.</para>
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
            /// <para> <b>N</b> specifies the serial number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag and Tag.2.Value specifies the value of the second tag.</para>
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
        /// <para>The vSwitch ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1vj604nj5a9zz74****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1n3i15v90el48nx****</para>
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
