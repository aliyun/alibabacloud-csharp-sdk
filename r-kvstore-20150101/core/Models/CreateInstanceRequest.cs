// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The Append Only File (AOF) persistence parameter settings for the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b> (default): enables AOF persistence.</description></item>
        /// <item><description><b>no</b>: disables AOF persistence.<remarks>
        /// <para>This parameter is applicable to classic instances. Cloud-native instances do not support specifying the AOF parameter.</para>
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
        /// <item><description><b>false</b> (default): does not enable auto-renewal.</description></item>
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
        /// <para>This parameter is required when <b>AutoRenew</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses a coupon.</description></item>
        /// <item><description><b>false</b> (default): does not use a coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The ID of the backup set of the source instance. The system uses the data stored in the backup set to create the instance. You can invoke <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> to query the BackupId. If the source instance is a cluster instance, specify the backup set IDs of all shards of the source instance, separated by commas (,). Example: &quot;10\<em>\</em>,11\<em>\</em>,15\<em>\</em>&quot;.</para>
        /// <remarks>
        /// <para>If your instance is a cloud-native architecture cluster instance, use <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> to query the cluster backup set ID, such as &quot;cb-xx&quot;, and specify it in the ClusterBackupId request parameter to clone the cluster instance. This eliminates the need to specify individual shard backup set IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>111111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The activity ID and business information.</para>
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
        /// <para>The cluster backup set ID, which is supported by some new cluster architecture instances. You can call <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> to obtain the ID.</para>
        /// <list type="bullet">
        /// <item><description>If supported, specify the cluster backup set ID. You do not need to specify the <b>BackupId</b> parameter.</description></item>
        /// <item><description>If not supported, specify the backup set IDs of all shards of the source instance in the BackupId parameter, separated by commas (,). Example: &quot;2158\<em>\</em>\<em>\<em>20,2158\</em>\</em>\*\*22&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cb-hyxdof5x9kqb****</para>
        /// </summary>
        [NameInMap("ClusterBackupId")]
        [Validation(Required=false)]
        public string ClusterBackupId { get; set; }

        /// <summary>
        /// <para>The prefix of the endpoint. The prefix must consist of lowercase letters and digits, start with a lowercase letter, and be 8 to 40 characters in length.</para>
        /// <remarks>
        /// <para>The endpoint is in the format of: <prefix>.redis.rds.aliyuncs.com.</para>
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
        /// <para>The ID of the dedicated cluster. This parameter is required when you create an instance in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-uv4fnk6r7zff****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this instance creation request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the instance. The system checks items such as the request parameters, request format, service limits, and available resources. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. After the request passes the check, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Redis <b>classic</b> engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2.8</b> (not recommended, <a href="https://help.aliyun.com/document_detail/2674657.html">planned for end of support</a>)</description></item>
        /// <item><description><b>4.0</b> (not recommended)</description></item>
        /// <item><description><b>5.0</b></description></item>
        /// </list>
        /// <para>Redis <b>cloud-native</b> engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>6.0</b> (recommended)</description></item>
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
        /// <para>Specifies whether to use the new instance as the first child instance of a distributed instance. This allows you to create a distributed instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses the instance as the first child instance.</description></item>
        /// <item><description><b>false</b> (default): does not use the instance as the first child instance.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To set this parameter to <b>true</b>, the new instance must be a Tair memory-optimized instance with a database DPI engine version of 5.0.</description></item>
        /// <item><description>This parameter is applicable only to Chinese site (aliyun.com).</description></item>
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
        /// <para>The instance ID of the distributed instance. This parameter is applicable only to Chinese site (aliyun.com).</para>
        /// <para>&lt;props=&quot;china&quot;&gt; To append the new Redis instance as a child instance of a distributed instance, this parameter is active and required. For more information and console operations, see <a href="https://help.aliyun.com/document_detail/106885.html">Add a child instance to a distributed instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// <para>The global IP whitelist templates for the instance. Separate multiple templates with commas (,). Duplicates are not allowed.</para>
        /// <remarks>
        /// <para>Notice: This parameter is applicable only to cloud-native instances. Classic instances do not support the whitelist template feature.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>g-zsldxfiwjmti0kcm****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance type. For example, redis.master.small.default specifies a Community Edition (classic) standard architecture dual-replica 1 GB instance. For more information, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance type overview</a>. </para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>Capacity</b> and <b>InstanceClass</b> parameters when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The endpoint type used when you create a cloud-native dual-zone deployment read/write splitting instance. If this parameter is not explicitly committed, the default value is AzIndependentEndpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>AzIndependentEndpoint</b>: <b>default value</b>. Zone-independent endpoints. The primary and secondary zones provide independent endpoints, which allow nearest access through different endpoints.</description></item>
        /// <item><description><b>UnifiedEndpoint</b>: unified endpoint. A unified endpoint is provided to access nodes in both the primary and secondary zones, but cross-zone access may occur.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: This parameter is applicable only to cloud-native dual-zone deployment read/write splitting instances. For other instance types, only zone-independent endpoints are supported. Even if UnifiedEndpoint is specified, it does not take effect.</notice></para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: The UnifiedEndpoint option is available only to users on the whitelist. If you are not on the whitelist and specify this parameter, the invocation returns an error. To request access, submit a ticket.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AzIndependentEndpoint</para>
        /// </summary>
        [NameInMap("InstanceEndpointType")]
        [Validation(Required=false)]
        public string InstanceEndpointType { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 80 characters in length and must start with a letter or a Chinese character. The name cannot contain <c>@/:=&quot;&lt;&gt;{[]}</c> or spaces.</para>
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
        /// <para>The end time of the maintenance window. Specify the time in the <i>HH:mm</i>Z format in UTC. For example, to set the end time to 02:00 (UTC+8), specify <c>18:00Z</c>.</para>
        /// <remarks>
        /// <para>The interval between the start time and end time must be at least 1 hour.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If this parameter is not specified, the default value is 06:00 (UTC+8), which is 22:00Z in UTC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window. Specify the time in the <i>HH:mm</i>Z format in UTC. For example, to set the start time to 01:00 (UTC+8), specify <c>17:00Z</c>.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the default value is 02:00 (UTC+8), which is 18:00Z in UTC.</para>
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
        /// <item><description><b>MASTER_SLAVE</b>: high availability (dual-replica)</description></item>
        /// <item><description><b>STAND_ALONE</b>: single replica</description></item>
        /// <item><description><b>double</b>: dual-replica</description></item>
        /// <item><description><b>single</b>: single replica<remarks>
        /// <para>For cloud-native instances, set this parameter to <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b>. For classic instances, set this parameter to <b>double</b> or <b>single</b>.</para>
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
        /// <para>The ID of the parameter template. The ID is globally unique.&gt;Notice: This parameter is applicable only to cloud-native instances.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-test**</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The password of the instance. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, special characters, and digits. The following special characters are supported: <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pass!123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The subscription period. Unit: months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>ChargeType</b> is set to <b>PrePaid</b>.</para>
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
        /// <para>The number of read-only nodes in the primary zone. This parameter is applicable only to cloud-native read/write splitting instances.</para>
        /// <list type="bullet">
        /// <item><description>For standard architecture instances, valid values are 1 to 9.</description></item>
        /// <item><description>For cluster architecture instances, valid values are 1 to 4, which specifies the number of read-only nodes per data shard.<remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter together with the SlaveReadOnlyCount parameter to customize the number of read-only nodes in the primary and secondary zones.</para>
        /// <list type="bullet">
        /// <item><description>For standard architecture instances, the sum of this parameter and SlaveReadOnlyCount cannot exceed 9.</description></item>
        /// <item><description>For cluster architecture instances, the sum of this parameter and SlaveReadOnlyCount cannot exceed 4.</description></item>
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
        /// <para>Specifies whether to restore the account, kernel parameter (config), or whitelist information from the original backup set when you create an instance from a specified backup set. For example, to restore account information, set this parameter to <c>account</c>.</para>
        /// <para>The default value is empty, which indicates that the account, kernel parameter, and whitelist information is not restored from the original backup set.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to cloud-native instances, and the original backup set must contain the account, kernel parameter, or whitelist information. You can call <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> to check whether the RecoverConfigMode parameter of the specified backup set contains the preceding information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist,config,account</para>
        /// </summary>
        [NameInMap("RecoverConfigMode")]
        [Validation(Required=false)]
        public string RecoverConfigMode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> to query available regions. Use this parameter to specify the region in which to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the primary zone. This parameter is applicable only to cloud-native cluster multi-replica instances. You can use this parameter to customize the number of replica nodes. Valid values: 1 to 4.</para>
        /// <remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter together with the SlaveReplicaCount parameter to customize the number of replica nodes in the primary and secondary zones. The sum of this parameter and the SlaveReplicaCount parameter cannot exceed 4.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
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
        /// <para>If flashback is enabled for the source instance, you can specify a point in time within the backup retention period. The system uses the backup data of the source instance at the specified point in time to create the instance. Specify the time in the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-19T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The secondary zone ID. You can call <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> to query available zones.</para>
        /// <remarks>
        /// <para>The value of this parameter must be different from the value of ZoneId. You cannot set this parameter to the ID of a multi-zone.</para>
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
        /// <para>The number of shards. This parameter is applicable only to cloud-native instances. You can use this parameter to customize the number of shards.</para>
        /// <list type="bullet">
        /// <item><description>1: creates a non-cluster instance.</description></item>
        /// <item><description>A value greater than 1: creates a cluster instance.</description></item>
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
        /// <para>The number of replica nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>To create an instance from a backup set of an existing instance, specify the instance ID of the source instance in this parameter.</para>
        /// <remarks>
        /// <para>Then use the <b>BackupId</b>, <b>ClusterBackupId</b> (recommended for cloud-native cluster instances), or <b>RestoreTime</b> parameter to specify the backup set or point in time. This parameter must be used together with one of the preceding three parameters. The value is a string, not an array.</para>
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
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><b>N</b> specifies the sequence number of the tag. A maximum of 20 tags can be attached to a single instance. For example, Tag.1.Key specifies the key of the first tag, and Tag.2.Key specifies the key of the second tag.</description></item>
            /// <item><description>If the tag key does not exist, the tag is automatically created.</description></item>
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
            /// <para><b>N</b> specifies the sequence number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. The token value is generated by the client and must be unique among different requests. The token is case-sensitive and cannot exceed 64 ASCII characters in length.</para>
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
        /// <para>The primary zone ID. You can invoke <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> to query active zones. Use this parameter to specify the zone in which to create the instance.</para>
        /// <remarks>
        /// <para>You can also specify the SecondaryZoneId parameter to set the secondary zone. The primary and secondary nodes are deployed in the specified primary and secondary zones respectively, which implements a dual-center primary/secondary architecture in the same city. For example, set ZoneId to &quot;cn-hangzhou-h&quot; and SecondaryZoneId to &quot;cn-hangzhou-g&quot;.</para>
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
