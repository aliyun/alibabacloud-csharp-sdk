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
        /// <item><description>It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Special characters include !@#$%^&amp;*()_+-=.</description></item>
        /// <item><description>It must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about how to troubleshoot connection failures caused by special characters in database connection string, see <a href="https://help.aliyun.com/document_detail/471568.html">What do I do if database connection to an ApsaraDB for MongoDB instance fails because the username or password in database connection string contains special characters?</a>.</para>
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
        /// <item><description><b>true</b>: Enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: Disables auto-renewal. You must manually renew the instance. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and optional only when the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the cluster backup.</para>
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
        /// <item><description><b>PostPaid</b>: Pay-as-you-go. This is the default value.</description></item>
        /// <item><description><b>PrePaid</b>: Subscription.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the token, but you must ensure that the token is unique among different requests. The token can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The information about the ConfigServer nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfigServer")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestConfigServer> ConfigServer { get; set; }
        public class CreateShardingDBInstanceRequestConfigServer : TeaModel {
            /// <summary>
            /// <para>The specifications of the ConfigServer node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mdb.shard.2x.xlarge.d</b>: 4 cores, 8 GB (dedicated). This specification is supported only for instances of version 4.4 and later.</description></item>
            /// <item><description><b>dds.cs.mid</b>: 1 core, 2 GB (general-purpose). This specification is supported only for instances of version 4.2 and earlier.</description></item>
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
            /// <para>The storage capacity of the ConfigServer node. Unit: GB.</para>
            /// <remarks>
            /// <para>The valid values are subject to the instance specifications. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
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
        /// <para>The region where the cross-region backup is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database version number. Valid values:</para>
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
        /// <list type="bullet">
        /// <item><description>For more information about the constraints on storage engines and versions, see <a href="https://help.aliyun.com/document_detail/61906.html">Versions and storage engines</a>.</description></item>
        /// <item><description>When you call this operation to clone an instance, the value of this parameter must be the same as that of the source instance.</description></item>
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
        /// <para>The global IP address whitelist templates of the instance. Separate multiple templates with commas (,). Duplicate templates are not supported.</para>
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
        /// <item><description>This parameter is available only when the instance uses cloud disks.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the value of <b>ZoneId</b> or <b>SecondaryZoneId</b>.</description></item>
        /// <item><description>For more information about the multi-zone deployment policy for sharded cluster instances, see <a href="https://help.aliyun.com/document_detail/117865.html">Create a multi-zone sharded cluster instance</a>.</description></item>
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
        /// <para>The information about the mongos nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mongos")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestMongos> Mongos { get; set; }
        public class CreateShardingDBInstanceRequestMongos : TeaModel {
            /// <summary>
            /// <para>The specifications of the mongos node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> in the parameter name specifies the sequence number of the mongos node. For example, <b>Mongos.2.Class</b> specifies the specifications of the second mongos node.</description></item>
            /// <item><description>Valid values of <b>N</b>: <b>2</b> to <b>32</b>.</description></item>
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
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC.</description></item>
        /// </list>
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
        /// <para>Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is required and takes effect only when the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The type of the access protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mongodb</b>: MongoDB protocol.</description></item>
        /// <item><description><b>dynamodb</b>: DynamoDB protocol.</description></item>
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
        /// <para>The information about the shard nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReplicaSet")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestReplicaSet> ReplicaSet { get; set; }
        public class CreateShardingDBInstanceRequestReplicaSet : TeaModel {
            /// <summary>
            /// <para>The specifications of the shard node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> in the parameter name specifies the sequence number of the shard node. For example, <b>ReplicaSet.2.Class</b> specifies the specifications of the second shard node.</description></item>
            /// <item><description>Valid values of <b>N</b>: <b>2</b> to <b>32</b>.</description></item>
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
            /// <para>Valid values: <b>0</b> to <b>5</b>. Default value: <b>0</b>.</para>
            /// <remarks>
            /// <para><b>N</b> in the parameter name specifies the sequence number of the shard node. For example, <b>ReplicaSet.2.ReadonlyReplicas</b> specifies the number of read-only nodes in the second shard node.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReadonlyReplicas")]
            [Validation(Required=false)]
            public int? ReadonlyReplicas { get; set; }

            /// <summary>
            /// <para>The storage capacity of the shard node. Unit: GB.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The valid values are subject to the instance specifications. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</description></item>
            /// <item><description><b>N</b> in the parameter name specifies the sequence number of the shard node. For example, <b>ReplicaSet.2.Storage</b> specifies the storage capacity of the second shard node.</description></item>
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
        /// <para>The point in time to which you want to restore the instance. You can specify any point in time within the last seven days. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter is required only when you call this operation to clone an instance. You must also specify the <b>SrcDBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-08T02:30:25Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The backup restoration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Restore the instance to a specified point in time.</description></item>
        /// <item><description>2: Restore a released instance to a specified backup set.</description></item>
        /// <item><description>3: Restore the instance to a specified cross-region backup set.</description></item>
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
        /// <item><description><b>eu-central-1c</b>: Frankfurt Zone C.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only when the instance uses cloud disks.</description></item>
        /// <item><description>The value of this parameter cannot be the same as the value of <b>ZoneId</b> or <b>HiddenZoneId</b>.</description></item>
        /// <item><description>For more information about the multi-zone deployment policy for sharded cluster instances, see <a href="https://help.aliyun.com/document_detail/117865.html">Create a multi-zone sharded cluster instance</a>.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist of the instance. Separate multiple IP addresses with commas (,). Duplicate IP addresses are not supported. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>0.0.0.0/0</description></item>
        /// <item><description>IP addresses, such as 10.23.12.24.</description></item>
        /// <item><description>CIDR blocks, such as 10.23.12.0/24. 24 indicates the length of the prefix in the CIDR block, and the prefix length ranges from 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can add up to 1,000 IP addresses or CIDR blocks to the whitelist of an instance. The total number of IP addresses or CIDR blocks in all whitelist groups cannot exceed 1,000.</description></item>
        /// <item><description>0.0.0.0/0 indicates that all IP addresses can access the instance. This is a high-risk setting. Configure this parameter with caution.</description></item>
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
        /// <para>This parameter is required only when you call this operation to clone an instance. You must also specify the <b>RestoreTime</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp11483712c1****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the source instance is located.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the backup restoration type is rebuilding a deleted instance.</description></item>
        /// <item><description>This parameter is required when the backup restoration type is cross-region backup cloning.</description></item>
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
        /// <item><description>When you call this operation to clone an instance, the value of this parameter must be the same as that of the source instance.</description></item>
        /// <item><description>For more information about the constraints on storage engines and versions, see <a href="https://help.aliyun.com/document_detail/61906.html">Versions and storage engines</a>.</description></item>
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
        /// <para>The storage type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd1</b>: PL1 ESSD.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>local_ssd</b>: local SSD.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Instances of version 4.4 and later support only cloud disks. If you do not specify this parameter, <b>cloud_essd1</b> is selected by default.</description></item>
        /// <item><description>Instances of version 4.2 and earlier support only local disks. If you do not specify this parameter, <b>local_ssd</b> is selected by default.</description></item>
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
            /// <item><description><b>N</b> in the parameter name specifies the sequence number of the tag. For example, <b>Tag.1.Key</b> specifies the key of the first tag, and <b>Tag.2.Key</b> specifies the key of the second tag.</description></item>
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
            /// <para><b>N</b> in the parameter name specifies the sequence number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
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
        /// <para>vsw-bp1vj604nj5a9zz74****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
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
