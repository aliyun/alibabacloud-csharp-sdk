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
        /// <item><description><para>It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>Special characters include !@#$%^&amp;\*()_+-=</para>
        /// </description></item>
        /// <item><description><para>It must be 8 to 32 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For information about how to resolve connection failures caused by special characters in passwords, see <a href="https://help.aliyun.com/document_detail/471568.html">How do I fix connection failures caused by special characters in a password?</a>.</para>
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
        /// <item><description><para><b>true</b>: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Auto-renewal is disabled. You must manually renew the instance. This is the default value.</para>
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
        /// <para>The cluster backup ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only when RestoreType is set to 2 or 3.</description></item>
        /// </list>
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
        /// <item><description><para><b>PostPaid</b>: pay-as-you-go. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>PrePaid</b>: subscription.</para>
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
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The information of Configserver nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfigServer")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestConfigServer> ConfigServer { get; set; }
        public class CreateShardingDBInstanceRequestConfigServer : TeaModel {
            /// <summary>
            /// <para>The instance type of the Configserver node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>mdb.shard.2x.xlarge.d</b>: 4-core 8 GB (dedicated). This instance type is available only for instances that run MongoDB 4.4 or later.</para>
            /// </description></item>
            /// <item><description><para><b>dds.cs.mid</b>: 1-core 2 GB (general-purpose). This instance type is available only for instances that run MongoDB 4.2 or earlier.</para>
            /// </description></item>
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
            /// <para>The storage space of the Configserver node. Unit: GB.</para>
            /// <remarks>
            /// <para>The value of this parameter is constrained by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
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
        /// <para>The name of the instance. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must start with a Chinese character or a letter.</para>
        /// </description></item>
        /// <item><description><para>It can contain digits, Chinese characters, letters, underscores (_), periods (.), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 256 characters in length.</para>
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
        /// <para>The region where the geo-redundant backup is stored.</para>
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
        /// <para>The custom key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2axxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The database engine. Set the value to <b>MongoDB</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database version. Valid values:</para>
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
        /// <list type="bullet">
        /// <item><description><para>For more information about the constraints on storage engines and database versions, see <a href="https://help.aliyun.com/document_detail/61906.html">Versions and storage engines</a>.</para>
        /// </description></item>
        /// <item><description><para>When you clone an instance by calling this operation, the value of this parameter must be the same as that of the source instance.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The global IP address whitelist templates of the instance. Separate multiple templates with commas (,). Each template must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-qxieqf40xjst1ngpr3jz</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The secondary zone 2 for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou-g</b>: Hangzhou Zone G.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-h</b>: Hangzhou Zone H.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-i</b>: Hangzhou Zone I.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-b</b>: Hong Kong (China) Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-c</b>: Hong Kong (China) Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-d</b>: Hong Kong (China) Zone D.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-a</b>: Ulanqab Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-b</b>: Ulanqab Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-c</b>: Ulanqab Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1a</b>: Singapore Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1b</b>: Singapore Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1c</b>: Singapore Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5a</b>: Jakarta Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5b</b>: Jakarta Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5c</b>: Jakarta Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1a</b>: Frankfurt Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1b</b>: Frankfurt Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1c</b>: Frankfurt Zone C.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available for disk-based instances.</para>
        /// </description></item>
        /// <item><description><para>The value of this parameter cannot be the same as the value of <b>ZoneId</b> or <b>SecondaryZoneId</b>.</para>
        /// </description></item>
        /// <item><description><para>For more information about the multi-zone deployment policy for sharded cluster instances, see <a href="https://help.aliyun.com/document_detail/117865.html">Create a multi-zone sharded cluster instance</a>.</para>
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
        /// <para>The information of Mongos nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mongos")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestMongos> Mongos { get; set; }
        public class CreateShardingDBInstanceRequestMongos : TeaModel {
            /// <summary>
            /// <para>The instance type of the Mongos node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para><b>N</b> in the parameter name specifies the serial number of the Mongos node. For example, <b>Mongos.2.Class</b> specifies the instance type of the second Mongos node.</para>
            /// </description></item>
            /// <item><description><para>The value of <b>N</b> ranges from <b>2</b> to <b>32</b>.</para>
            /// </description></item>
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
        /// <para>The network type of the instance. Valid values:</para>
        /// <para><b>VPC</b>: virtual private cloud.</para>
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
        /// <para>Valid values: <b>1</b> to <b>9</b> (integer), <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
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
        /// <para>The protocol type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>mongodb</b>: MongoDB protocol.</para>
        /// </description></item>
        /// <item><description><para><b>dynamodb</b>: DynamoDB protocol.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mongodb</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The provisioned IOPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1960</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The information of shard nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReplicaSet")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestReplicaSet> ReplicaSet { get; set; }
        public class CreateShardingDBInstanceRequestReplicaSet : TeaModel {
            /// <summary>
            /// <para>The instance type of the shard node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para><b>N</b> in the parameter name specifies the serial number of the shard node. For example, <b>ReplicaSet.2.Class</b> specifies the instance type of the second shard node.</para>
            /// </description></item>
            /// <item><description><para>The value of <b>N</b> ranges from <b>2</b> to <b>32</b>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dds.shard.standard</para>
            /// </summary>
            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            /// <summary>
            /// <para>The number of read-only nodes in the shard node.</para>
            /// <para>Valid values: <b>0</b> to <b>5</b>. The default value is <b>0</b>.</para>
            /// <remarks>
            /// <para><b>N</b> in the parameter name specifies the serial number of the shard node. For example, <b>ReplicaSet.2.ReadonlyReplicas</b> specifies the number of read-only nodes in the second shard node.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReadonlyReplicas")]
            [Validation(Required=false)]
            public int? ReadonlyReplicas { get; set; }

            /// <summary>
            /// <para>The storage space of the shard node. Unit: GB.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The value of this parameter is constrained by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// </description></item>
            /// <item><description><para><b>N</b> in the parameter name specifies the serial number of the shard node. For example, <b>ReplicaSet.2.Storage</b> specifies the storage space of the second shard node.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

        }

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
        /// <para>The point in time to which you want to restore data. You can specify any point in time within the last seven days. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is in Coordinated Universal Time (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required only when you clone an instance by calling this operation. You must also specify the <b>SrcDBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-08T02:30:25Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The backup-based instance restoration method.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Restore the instance to a specific point in time.</para>
        /// </description></item>
        /// <item><description><para>2: Restore a released instance from a specific backup set.</para>
        /// </description></item>
        /// <item><description><para>3: Restore the instance from a specific geo-redundant backup set.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The secondary zone 1 for multi-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou-g</b>: Hangzhou Zone G.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-h</b>: Hangzhou Zone H.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-i</b>: Hangzhou Zone I.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-b</b>: Hong Kong (China) Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-c</b>: Hong Kong (China) Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong-d</b>: Hong Kong (China) Zone D.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-a</b>: Ulanqab Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-b</b>: Ulanqab Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>cn-wulanchabu-c</b>: Ulanqab Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1a</b>: Singapore Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1b</b>: Singapore Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1c</b>: Singapore Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5a</b>: Jakarta Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5b</b>: Jakarta Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5c</b>: Jakarta Zone C.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1a</b>: Frankfurt Zone A.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1b</b>: Frankfurt Zone B.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1c</b>: Frankfurt Zone C.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available for disk-based instances.</para>
        /// </description></item>
        /// <item><description><para>The value of this parameter cannot be the same as the value of <b>ZoneId</b> or <b>HiddenZoneId</b>.</para>
        /// </description></item>
        /// <item><description><para>For more information about the multi-zone deployment policy for sharded cluster instances, see <a href="https://help.aliyun.com/document_detail/117865.html">Create a multi-zone sharded cluster instance</a>.</para>
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
        /// <para>The IP address whitelist of the instance. Separate multiple IP addresses with commas (,). Each IP address in the whitelist must be unique. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>0.0.0.0/0</para>
        /// </description></item>
        /// <item><description><para>IP addresses, such as 10.23.12.24.</para>
        /// </description></item>
        /// <item><description><para>CIDR blocks, such as 10.23.12.0/24. The /24 part indicates the prefix length of the CIDR block. The prefix length ranges from 1 to 32.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can add a maximum of 1,000 IP addresses or CIDR blocks to all IP address whitelists.</para>
        /// </description></item>
        /// <item><description><para>The 0.0.0.0/0 entry allows access from all IP addresses. This is a high-risk setting. Configure it with caution.</para>
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
        /// <para>This parameter is required only when you clone an instance by calling this operation. You must also specify the <b>RestoreTime</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp11483712c1****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The region of the source instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when you recreate a released instance from a backup.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when you clone an instance from a geo-redundant backup.</para>
        /// </description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description><para>When you clone an instance by calling this operation, the value of this parameter must be the same as that of the source instance.</para>
        /// </description></item>
        /// <item><description><para>For more information about the constraints on storage engines and database versions, see <a href="https://help.aliyun.com/document_detail/61906.html">Versions and storage engines</a>.</para>
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
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cloud_essd1</b>: enhanced SSD (ESSD) PL1.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd2</b>: ESSD PL2.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd3</b>: ESSD PL3.</para>
        /// </description></item>
        /// <item><description><para><b>local_ssd</b>: local SSD.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Instances that run MongoDB 4.4 or later support only disks. If you do not specify this parameter, <b>cloud_essd1</b> is used.</para>
        /// </description></item>
        /// <item><description><para>Instances that run MongoDB 4.2 or earlier support only local disks. If you do not specify this parameter, <b>local_ssd</b> is used.</para>
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
        public List<CreateShardingDBInstanceRequestTag> Tag { get; set; }
        public class CreateShardingDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> specifies the serial number of the tag. For example, <b>Tag.1.Key</b> specifies the key of the first tag, and <b>Tag.2.Key</b> specifies the key of the second tag.</description></item>
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
            /// <para><b>N</b> specifies the serial number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
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
        /// <para>The virtual switch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1vj604nj5a9zz74****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1n3i15v90el48nx****</para>
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
