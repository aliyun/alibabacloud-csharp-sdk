// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The AOF parameter settings of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b> (default): enables AOF persistence.</description></item>
        /// <item><description><b>no</b>: shutdown AOF persistence.<remarks>
        /// <para>This parameter applies to classic instances. Cloud-native instances do not support specifying the AOF parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("Appendonly")]
        [Validation(Required=false)]
        public string Appendonly { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b> (default): disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal epoch. Unit: months. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>6</b>, and <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when the AutoRenew parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a voucher. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses a voucher.</description></item>
        /// <item><description><b>false</b> (default): does not use a voucher.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>You can specify the backup set ID of the source instance in this parameter. The system uses the data saved in the backup set to create the new instance. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query the BackupId. If the source instance is a cluster instance, you must enter the backup set IDs of all shards in the source instance and separate them with commas, such as &quot;10**,11**,15**&quot;.</para>
        /// <remarks>
        /// <para>If your instance is a cloud-native architecture instance and a cluster instance, we recommend that you call the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation to query the cluster backup set ID, such as &quot;cb-xx&quot;, and then enter it in the ClusterBackupId request parameter to clone the cluster instance. This saves you the trouble of entering the backup set ID of each shard.</para>
        /// </remarks>
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
        /// <para>When you call this operation, you must specify at least one of the Capacity and InstanceClass parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16384</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b> (default): pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the cluster backup set. Some new cluster architectures support cluster backup set IDs. You can call the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation to obtain the ID.</para>
        /// <list type="bullet">
        /// <item><description>If the architecture supports cluster backup sets, you can enter the specified cluster backup set ID without specifying the BackupId parameter.</description></item>
        /// <item><description>If the architecture does not support cluster backup sets, specify the backup set IDs of all shards in the source instance in the BackupId parameter and separate them with commas, such as &quot;2158\<em>\</em>\<em>\<em>20,2158\</em>\</em>\*\*22&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cb-hyxdof5x9kqb****</para>
        /// </summary>
        [NameInMap("ClusterBackupId")]
        [Validation(Required=false)]
        public string ClusterBackupId { get; set; }

        /// <summary>
        /// <para>The prefix of the endpoint. The prefix must be 8 to 40 characters in length and can contain lowercase letters and digits. It must start with a lowercase letter.</para>
        /// <remarks>
        /// <para>The endpoint format is: <Prefix>.redis.rds.aliyuncs.com.</para>
        /// </remarks>
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
        /// <para>The ID of the dedicated cluster. This parameter is required when you create an ApsaraDB for Redis instance in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-uv4fnk6r7zff****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the instance creation request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the instance. The system checks the request parameters, request format, service limits, and available resources. If the request fails the dry run, the system returns an error. If the request passes the dry run, the system returns the DryRunOperation error code.</description></item>
        /// <item><description><b>false</b> (default): sends the normal request and creates the instance after the request passes the check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The engine version of the Redis <b>classic instance</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2.8</b> (Not recommended. <a href="https://help.aliyun.com/document_detail/2674657.html">End-of-life is planned</a>.)</description></item>
        /// <item><description><b>4.0</b> (Not recommended)</description></item>
        /// <item><description><b>5.0</b></description></item>
        /// </list>
        /// <para>The engine version of the Redis <b>cloud-native instance</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>6.0</b> (Recommended)</description></item>
        /// <item><description><b>7.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>5.0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the new instance as the first child instance of a distributed instance. You can create a distributed instance in this way. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses the new instance as the first child instance.</description></item>
        /// <item><description><b>false</b> (default): does not use the new instance as the first child instance.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to <b>true</b>, the new instance must be a Tair memory-optimized instance and the DPI engine version must be 5.0.</description></item>
        /// <item><description>This parameter applies only to the China site.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GlobalInstance")]
        [Validation(Required=false)]
        public bool? GlobalInstance { get; set; }

        /// <summary>
        /// <para>The distributed instance ID. This parameter applies only to the China site.</para>
        /// <para>&lt;props=&quot;china&quot;&gt; If you want to append the new ApsaraDB for Redis instance as a new child instance to a distributed instance, this parameter is active and required. For more information and console operations, see <a href="https://help.aliyun.com/document_detail/106885.html">Add a child instance to a distributed instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// <para>The global IP address whitelist templates of the instance. Separate multiple templates with commas (,). Duplicate templates are not allowed.</para>
        /// <remarks>
        /// <para>Notice: This parameter applies only to cloud-native instances. Classic instances do not support the whitelist template feature.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>g-zsldxfiwjmti0kcm****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance type. For example, redis.master.small.default indicates a 1 GB Community Edition (classic architecture) instance with the standard architecture and two replicas. For more information, see <a href="https://help.aliyun.com/document_detail/26350.html">Overview of instance types</a>. </para>
        /// <remarks>
        /// <para>When you call this operation, you must specify at least one of the Capacity and InstanceClass parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The type of the endpoint used when you create a cloud-native dual-zone deployment read/write splitting instance. If you do not explicitly specify this parameter, the default value is AzIndependentEndpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>AzIndependentEndpoint</b>: <b>Default value</b>. Active zone-independent endpoints. The primary and secondary active zones provide independent endpoints. You can use different endpoints to implement nearest access for active zones.</description></item>
        /// <item><description><b>UnifiedEndpoint</b>: Unified endpoint. A unified endpoint is provided to access nodes in both the primary and secondary active zones, but cross-zone access may occur.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: This parameter applies only to cloud-native dual-zone deployment read/write splitting instances. For other types of instances, only active zone-independent endpoints are supported. Even if you specify UnifiedEndpoint, it does not take effect.</notice></para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: The UnifiedEndpoint parameter is currently available only to whitelisted users. If a non-whitelisted user specifies this parameter, an invocation error is returned. To apply for the permissions, submit a ticket.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AzIndependentEndpoint</para>
        /// </summary>
        [NameInMap("InstanceEndpointType")]
        [Validation(Required=false)]
        public string InstanceEndpointType { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 80 characters in length, and must start with a letter or a Chinese character. It cannot contain the following special characters: <c>@/:=”&lt;&gt;{[]}</c> and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Redis</b> (default)</description></item>
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
        /// <para>The end time of the maintenance window for the instance. Specify the time in the <i>HH:mm</i>Z format. The time must be in UTC. For example, if you want the maintenance window to end at 02:00 (UTC+8), set the value to <c>18:00Z</c>.</para>
        /// <remarks>
        /// <para>The interval between the start time and the end time must be at least 1 hour.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is 22:00 (UTC), which is 06:00 (UTC+8).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window for the instance. Specify the time in the <i>HH:mm</i>Z format. The time must be in UTC. For example, if you want the maintenance window to start at 01:00 (UTC+8), set the value to <c>17:00Z</c>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is 18:00 (UTC), which is 02:00 (UTC+8).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>03:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC). This is the default value.</description></item>
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
        /// <item><description><b>MASTER_SLAVE</b>: high-availability (two replicas)</description></item>
        /// <item><description><b>STAND_ALONE</b>: single replica</description></item>
        /// <item><description><b>double</b>: two replicas</description></item>
        /// <item><description><b>single</b>: single replica<remarks>
        /// <para>For cloud-native instances, select <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b>. For classic instances, select <b>double</b> or <b>single</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>The globally unique ID of the parameter template.&gt;Notice: This parameter applies only to cloud-native instances.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-test**</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The password of the instance. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, special characters, and digits. The allowed special characters include <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pass!123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is required and takes effect only when the ChargeType parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The service port of the instance. Valid values: <b>1</b> to <b>65535</b>. Default value: <b>6379</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6379</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The internal network IP address of the new instance.</para>
        /// <remarks>
        /// <para>The internal network IP address must be within the vSwitch CIDR block to which the instance belongs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.***</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in the primary zone. This parameter applies only to cloud-native read/write splitting instances.</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses the standard architecture, valid values are 1 to 9.</description></item>
        /// <item><description>If the instance uses the cluster architecture, valid values are 1 to 4, which indicates the number of read-only nodes per shard.<remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and the SlaveReadOnlyCount parameter to specify the number of read-only nodes in the primary and secondary zones.</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses the standard architecture, the sum of this parameter and the SlaveReadOnlyCount parameter cannot exceed 9.</description></item>
        /// <item><description>If the instance uses the cluster architecture, the sum of this parameter and the SlaveReadOnlyCount parameter cannot exceed 4.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore the account, kernel parameters, and whitelist information from the original backup set when you create an instance by using a specified backup set. For example, to restore the account information, set the value to <c>account</c>.</para>
        /// <para>Default value: empty, which indicates that the account, kernel parameters, and whitelist information are not restored from the original backup set.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud-native instances, and the original backup set must contain the account, kernel parameters, and whitelist information. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query whether the RecoverConfigMode parameter of the specified backup set contains the preceding information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist,config,account</para>
        /// </summary>
        [NameInMap("RecoverConfigMode")]
        [Validation(Required=false)]
        public string RecoverConfigMode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of secondary nodes in the primary zone. This parameter applies only to cloud-native cluster instances with multiple replicas. You can use this parameter to specify a custom number of secondary nodes. Valid values: 1 to 4.</para>
        /// <remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and the SlaveReplicaCount parameter to specify the number of secondary nodes in the primary and secondary zones. The sum of this parameter and the SlaveReplicaCount parameter cannot exceed 4.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
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
        /// <para>The point in time to which you want to restore the source instance. If the data flashback feature is enabled for the source instance, you can specify any point in time within the backup retention period of the source instance. The system uses the backup data of the source instance at the specified point in time to create the new instance. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-19T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The secondary zone ID. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// <remarks>
        /// <para>The value of this parameter cannot be the same as the value of the ZoneId parameter, and cannot be the ID of a multi-zone deployment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of shards. This parameter applies only to cloud-native instances. You can use this parameter to specify a custom number of shards.</para>
        /// <list type="bullet">
        /// <item><description>1: creates a non-cluster architecture.</description></item>
        /// <item><description>A value greater than 1: creates a cluster architecture.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of secondary nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>If you want to create a new instance based on the backup set of an instance, specify the source instance ID in this parameter first.</para>
        /// <remarks>
        /// <para>Then, specify the backup set or point in time by using the BackupId, ClusterBackupId (recommended for cloud-native cluster architecture), or RestoreTime parameter. This parameter must be used in combination with one of the preceding three parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The tag information of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> indicates the sequence number of the tag key. You can attach up to 20 tags to a single instance. For example, Tag.1.Key indicates the key of the first tag, and Tag.2.Key indicates the key of the second tag.</description></item>
            /// <item><description>If the key of the tag does not exist, the system performs automatic creation.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testkey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <remarks>
            /// <para><b>N</b> indicates the sequence number of the tag value. For example, <b>Tag.1.Value</b> indicates the value of the first tag, and <b>Tag.2.Value</b> indicates the value of the second tag.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The primary active zone ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent active zone list, and use this parameter to specify the active zone where you want to create the instance.</para>
        /// <remarks>
        /// <para>You can also specify the SecondaryZoneId parameter to set the secondary active zone. The deployment of the primary and secondary nodes is in the specified primary and secondary active zones to implement a primary/secondary architecture. For example, you can set the ZoneId parameter to &quot;cn-hangzhou-h&quot; and the SecondaryZoneId parameter to &quot;cn-hangzhou-g&quot;.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
