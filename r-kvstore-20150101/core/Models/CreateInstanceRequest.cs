// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable append-only file (AOF) persistence for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b> (default): enables AOF persistence.</description></item>
        /// <item><description><b>no</b>: disables AOF persistence.</description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Description</b> This parameter is applicable to classic instances, and is unavailable for cloud-native instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("Appendonly")]
        [Validation(Required=false)]
        public string Appendonly { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The subscription duration that is supported by auto-renewal. Unit: months. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>6</b>, and <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only if the <b>AutoRenew</b> parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses a coupon.</description></item>
        /// <item><description><b>false</b>: does not use a coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>If your instance is a cloud-native cluster instance, we recommend that you use <a href="https://help.aliyun.com/document_detail/2679158.html">DescribeClusterBackupList</a> to query the backup set ID of the cluster instance, such as cb-xx. Then, set the ClusterBackupId request parameter to the backup set ID to clone the cluster instance. This eliminates the need to specify the backup set ID of each shard.</para>
        /// <para>You can set the BackupId parameter to the backup set ID of the source instance. The system uses the data stored in the backup set to create an instance. You can call the <a href="https://help.aliyun.com/document_detail/61081.html">DescribeBackups</a> operation to query backup set IDs. If the source instance is a cluster instance, set the BackupId parameter to the backup set IDs of all shards of the source instance, separated by commas (,). Example: &quot;10\<em>\</em>,11\<em>\</em>,15\<em>\</em>&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The ID of the promotional event or business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Unit: MB.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>Capacity</b> and <b>InstanceClass</b> parameters when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16384</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Default value: PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>This parameter is supported for specific new cluster instances. You can query the backup set ID by using the <a href="https://help.aliyun.com/document_detail/2679158.html">DescribeClusterBackupList</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is supported, you can specify the backup set ID. In this case, you do not need to specify the <b>BackupId</b> parameter.</description></item>
        /// <item><description>If this parameter is not supported, set the BackupId parameter to the IDs of backup sets for all shards of the source instance, separated by commas (,). Example: &quot;2158\<em>\</em>\<em>\<em>20,2158\</em>\</em>\*\*22&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cb-hyxdof5x9kqbtust</para>
        /// </summary>
        [NameInMap("ClusterBackupId")]
        [Validation(Required=false)]
        public string ClusterBackupId { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>AllocateInstancePublicConnection</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: <c>default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated cluster. This parameter is required if you create an instance in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-uv4fnk6r7zff****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not create the instance. The system prechecks the request parameters, request format, service limits, and available resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: performs a dry run and sends the request. If the request passes the dry run, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The engine version. Valid values for <b>classic instances</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>2.8</b> (not recommended due to <a href="https://help.aliyun.com/document_detail/2674657.html">scheduled EOFS</a>)</description></item>
        /// <item><description><b>4.0</b> (not recommended)</description></item>
        /// <item><description><b>5.0</b></description></item>
        /// </list>
        /// <para>Valid values for <b>cloud-native instances</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>6.0</b> (recommended)</description></item>
        /// <item><description><b>7.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>5.0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the new instance as the first child instance of the distributed instance. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: uses the new instance as the first child instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not use the new instance as the first child instance.</para>
        /// </description></item>
        /// <item><description><para>If you want to create an ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance that runs Redis 5.0, you must set this parameter to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only on the China site (aliyun.com).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GlobalInstance")]
        [Validation(Required=false)]
        public bool? GlobalInstance { get; set; }

        /// <summary>
        /// <para>The ID of the distributed instance. This parameter is available only on the China site (aliyun.com).</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// <para>The global IP whitelist template for the instance. Multiple IP whitelist templates should be separated by English commas (,) and cannot be duplicated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-zsldxfiwjmti0kcm****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance type. For example, redis.master.small.default indicates a Community Edition standard master-replica instance that has 1 GB of memory. For more information, see <a href="https://help.aliyun.com/document_detail/26350.html">Overview</a>.</para>
        /// <para>**</para>
        /// <para><b>Description</b> You must specify at least one of the <b>Capacity</b> and <b>InstanceClass</b> parameters when you call the CreateInstance operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 80 characters in length and must start with a letter. It cannot contain spaces or specific special characters. These special characters include <c>@ / : = &quot; &lt; &gt; { [ ] }</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The category of the instance. Default value: Redis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Redis</b></description></item>
        /// <item><description><b>Memcache</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Default value: VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MASTER_SLAVE</b>: high availability (master-replica)</description></item>
        /// <item><description><b>STAND_ALONE</b>: standalone</description></item>
        /// <item><description><b>double</b>: master-replica</description></item>
        /// <item><description><b>single</b>: standalone</description></item>
        /// </list>
        /// <remarks>
        /// <para> To create a cloud-native instance, set this parameter to <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b>. To create a classic instance, set this parameter to <b>double</b> or <b>single</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>STAND_ALONE</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The parameter template ID, which must be globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-test**</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The password that is used to connect to the instance. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and specific special characters. These special characters include <c>! @ # $ % ^ &amp; * ( ) _ + - =</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>Pass!123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values: <b>1</b>, 2, 3, 4, 5, 6, 7, 8, <b>9</b>, <b>12</b>, <b>24</b>,<b>36</b>, and <b>60</b>. Unit: months.</para>
        /// <remarks>
        /// <para>This parameter is available and required only if the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The port number that is used to connect to the instance. Valid values: <b>1024</b> to <b>65535</b>. Default value: <b>6379</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6379</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance.</para>
        /// <remarks>
        /// <para>The private IP address must be available within the CIDR block of the vSwitch to which to connect the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.***</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the primary zone. This parameter applies only to read/write splitting instances that use cloud disks. You can use this parameter to customize the number of read replicas. Valid values: 1 to 9.</para>
        /// <remarks>
        /// <para> The sum of the values of this parameter and SlaveReadOnlyCount cannot be greater than 9.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        [NameInMap("RecoverConfigMode")]
        [Validation(Required=false)]
        public string RecoverConfigMode { get; set; }

        /// <summary>
        /// <para>The ID of the region where you want to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/61012.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-resourcegroupid1</para>
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
        /// <para>If data flashback is enabled for the source instance, you can use this parameter to specify a point in time within the backup retention period of the source instance. The system uses the backup data of the source instance at the point in time to create an instance. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-19T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The secondary zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/472448.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// <remarks>
        /// <para>If you specify this parameter, the master node and replica node of the instance can be deployed in different zones and disaster recovery is implemented across zones. The instance can withstand failures in data centers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>系统自动生成的安全 Token，无需传入</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of data shards. This parameter is available only if you create a cluster instance that uses cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the secondary zone. This parameter is used to create a read/write splitting instance that is deployed across multiple zones. The sum of the values of this parameter and ReadOnlyCount cannot be greater than 9.</para>
        /// <remarks>
        /// <para>When you create a multi-zone read/write splitting instance, you must specify both SlaveReadOnlyCount and SecondaryZoneId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>If you want to create an instance based on the backup set of an existing instance, set this parameter to the ID of the source instance.</para>
        /// <remarks>
        /// <para> After you specify the SrcDBInstanceId parameter, use the <b>BackupId</b>, <b>ClusterBackupId</b> (recommended for cloud-native cluster instances), or <b>RestoreTime</b> parameter to specify the backup set or the specific point in time that you want to use to create an instance. The SrcDBInstanceId parameter must be used in combination with one of the preceding three parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The keys of the tags that are added to the instance.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para><b>N</b> specifies the serial number of the tag. Up to 20 tags can be added to a single instance. For example, Tag.1.Key specifies the key of the first tag and Tag.2.Key specifies the key of the second tag.</para>
            /// </description></item>
            /// <item><description><para>If the key of the tag does not exist, the tag is automatically created.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testkey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The values of the tags that are added to the instance.</para>
            /// <remarks>
            /// <para><b>N</b> specifies the serial number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the token is unique among different requests. The token is case-sensitive. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which you want the instance to connect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The primary zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61012.html">DescribeRegions</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
