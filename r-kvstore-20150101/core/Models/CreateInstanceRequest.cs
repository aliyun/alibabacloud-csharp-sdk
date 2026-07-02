// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable AOF persistence for the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>yes</b> (default): Enables AOF persistence.</para>
        /// </description></item>
        /// <item><description><para><b>no</b>: Disables AOF persistence.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for classic edition instances. AOF persistence cannot be configured for cloud native edition instances at creation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("Appendonly")]
        [Validation(Required=false)]
        public string Appendonly { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disables auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration, in months. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>6</b>, and <b>12</b>.</para>
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
        /// <item><description><para><b>true</b>: Uses a coupon.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Does not use a coupon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The ID of the backup that you want to use to create the new instance. You can obtain backup IDs by calling the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation. If the source instance has a cluster architecture, you must specify the backup IDs of all its shards, separated by commas (for example, &quot;10\<em>\</em>,11\<em>\</em>,15\<em>\</em>&quot;).</para>
        /// <remarks>
        /// <para>If your source instance is a cloud native cluster instance, it is recommended to call <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> to get a cluster backup ID (for example, &quot;cb-xx&quot;) and use the <c>ClusterBackupId</c> parameter instead. This avoids the need to specify the backup ID for each shard.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>111111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The campaign ID or business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance, in MB.</para>
        /// <remarks>
        /// <para>You must specify either the <b>Capacity</b> or the <b>InstanceClass</b> parameter.</para>
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
        /// <item><description><para><b>PrePaid</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b> (default): pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the cluster backup. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation. This parameter is available for some cloud native cluster instances.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is mutually exclusive with <c>BackupId</c>.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not available for your instance, you must specify the backup ID of each shard in the <c>BackupId</c> parameter (for example, &quot;2158\<em>\</em>\<em>\<em>20,2158\</em>\</em>\*\*22&quot;).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cb-hyxdof5x9kqb****</para>
        /// </summary>
        [NameInMap("ClusterBackupId")]
        [Validation(Required=false)]
        public string ClusterBackupId { get; set; }

        /// <summary>
        /// <para>The prefix of the connection string. The prefix must be 8 to 40 characters long, start with a lowercase letter, and contain only lowercase letters and digits.</para>
        /// <remarks>
        /// <para>The full connection string is in the format: \<prefix>.redis.rds.aliyuncs.com.</para>
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
        /// <para>The ID of the dedicated host group. This parameter is required when you create a Redis instance in a dedicated host group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-uv4fnk6r7zff****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Checks the request for validity without creating the instance. The system verifies required parameters, request format, and service limits. If the request is valid, the <c>DryRunOperation</c> error code is returned. If the request is invalid, an error message is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends the request. If the request is valid, the instance is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The Redis engine version. Valid values for <b>classic edition</b> instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2.8</b> (Not recommended. <a href="https://help.aliyun.com/document_detail/2674657.html">Support for this version is scheduled to be discontinued</a>.)</para>
        /// </description></item>
        /// <item><description><para><b>4.0</b> (Not recommended.)</para>
        /// </description></item>
        /// <item><description><para><b>5.0</b></para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for <b>cloud native edition</b> instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>5.0</b></para>
        /// </description></item>
        /// <item><description><para><b>6.0</b> (Recommended)</para>
        /// </description></item>
        /// <item><description><para><b>7.0</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>5.0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to create the new instance as the first child instance of a distributed instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Creates the instance as the first child instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Does not create the instance as the first child instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <b>true</b>, the new instance must be a Tair memory-enhanced instance that runs Redis 5.0.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only in Chinese mainland.</para>
        /// </description></item>
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
        /// <para>The ID of the distributed instance. This parameter is available only in Chinese mainland.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>This parameter is required to add the new instance as a child of a distributed instance. For more information and the console procedure, see <a href="https://help.aliyun.com/document_detail/106885.html">Add a child instance to a distributed instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to associate with the instance. You can specify multiple security group IDs, separated by commas (,). IDs cannot be repeated.</para>
        /// <remarks>
        /// <para>Notice: This parameter is available only for cloud native edition instances. Security groups are not supported for classic edition instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>g-zsldxfiwjmti0kcm****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance type. For example, <c>redis.master.small.default</c> specifies a 1 GB Community Edition (classic edition) instance with a standard, dual-replica architecture. For more information, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance specifications</a>.</para>
        /// <remarks>
        /// <para>You must specify either the <b>Capacity</b> or the <b>InstanceClass</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The connection endpoint type. This parameter is applicable only when you create a dual-zone, read/write splitting instance of the cloud native edition. If this parameter is not specified, <c>AzIndependentEndpoint</c> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AzIndependentEndpoint</b>: (<b>Default</b>) Zone-Independent Endpoint. The primary and secondary zones each provide an independent connection string for zone-local access.</para>
        /// </description></item>
        /// <item><description><para><b>UnifiedEndpoint</b>: Unified Endpoint. Provides a single connection string to access nodes in both zones, which may result in cross-zone access.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is applicable only to dual-zone, read/write splitting instances of the cloud native edition. For other instance types, only zone-independent endpoints are supported, and specifying <c>UnifiedEndpoint</c> has no effect.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The <c>UnifiedEndpoint</c> parameter is currently available only to allowlisted users. API calls will fail if you are not on the allowlist. To be added to the allowlist, submit a ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AzIndependentEndpoint</para>
        /// </summary>
        [NameInMap("InstanceEndpointType")]
        [Validation(Required=false)]
        public string InstanceEndpointType { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 80 characters long, start with a letter (uppercase or lowercase) or a Chinese character, and not contain spaces or the characters <c>@/:=”&lt;&gt;{[]}</c>.</para>
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
        /// <item><description><para><b>Redis</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>Memcache</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window. Specify the time in the <em>HH:mm</em>Z format (UTC). For example, to set the end time to 02:00 (UTC+8), specify <c>18:00Z</c>.</para>
        /// <remarks>
        /// <para>The duration of the maintenance window must be at least one hour.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If this parameter is not specified, the maintenance window ends at 06:00 (UTC+8), which is 22:00 (UTC).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start of the maintenance window. Specify the time in the <em>HH:mm</em>Z format (UTC). For example, to set the start time to 01:00 (UTC+8), specify <c>17:00Z</c>.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the maintenance window starts at 02:00 (UTC+8), which is 18:00 (UTC).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>03:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The network type. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: Deploys the instance in a Virtual Private Cloud. This is the default value.</description></item>
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
        /// <item><description><para><b>MASTER_SLAVE</b>: high-availability (primary-replica)</para>
        /// </description></item>
        /// <item><description><para><b>STAND_ALONE</b>: standalone (single-node)</para>
        /// </description></item>
        /// <item><description><para><b>double</b>: primary-replica</para>
        /// </description></item>
        /// <item><description><para><b>single</b>: standalone (single-node)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Set this parameter to <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b> for cloud native edition instances. Set this parameter to <b>double</b> or <b>single</b> for classic edition instances.</para>
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
        /// <para>The ID of the parameter group. This ID must be globally unique.&gt;Notice:  This parameter is available only for cloud native edition instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-test**</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The password for the instance. The password must be 8 to 32 characters long and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The allowed special characters are <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pass!123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The subscription duration, in months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
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
        /// <para>The service port of the instance. The port number must be between <b>1</b> and <b>65535</b>. The default value is <b>6379</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6379</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The private IP address of the new instance.</para>
        /// <remarks>
        /// <para>The IP address must be within the CIDR block of the specified vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.***</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of read-only replicas in the primary zone. This parameter is available only when creating a read/write splitting instance of the cloud native edition.</para>
        /// <list type="bullet">
        /// <item><description><para>For a standard-architecture instance, the value must be an integer from 1 to 9.</para>
        /// </description></item>
        /// <item><description><para>For a cluster-architecture instance, the value must be an integer from 1 to 4. This specifies the number of read-only replicas for each data shard.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and <c>SlaveReadOnlyCount</c> to customize the number of read-only replicas in the primary and secondary zones.</para>
        /// <list type="bullet">
        /// <item><description><para>The sum of this parameter and <c>SlaveReadOnlyCount</c> cannot exceed 9 for a standard-architecture instance.</para>
        /// </description></item>
        /// <item><description><para>The sum of this parameter and <c>SlaveReadOnlyCount</c> cannot exceed 4 for a cluster-architecture instance.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>Specifies which configurations to restore from the backup when creating an instance. Valid values include <c>account</c>, <c>config</c>, and <c>whitelist</c>. For example, to restore account settings, specify <c>account</c>. To restore multiple configurations, separate them with commas.</para>
        /// <para>By default, this parameter is empty, which means no configurations are restored.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to cloud native edition instances. The source backup must contain the specified configurations. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation and check the <c>RecoverConfigMode</c> field in the response to determine which configurations a backup contains.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist,config,account</para>
        /// </summary>
        [NameInMap("RecoverConfigMode")]
        [Validation(Required=false)]
        public string RecoverConfigMode { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the instance. Call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to get a list of region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of replicas in the primary zone. This parameter is available only for multi-replica cluster instances of the cloud native edition. You can specify a value from 1 to 4.</para>
        /// <remarks>
        /// <para>When creating a multi-zone instance, you can use this parameter and <c>SlaveReplicaCount</c> to customize the number of replicas in the primary and secondary zones. The sum of <c>ReplicaCount</c> and <c>SlaveReplicaCount</c> cannot exceed 4.</para>
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
        /// <para>The point in time to which you want to restore data, specified in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z (UTC) format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-19T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the latest list of zones.</para>
        /// <remarks>
        /// <para>The value of this parameter cannot be the same as the value of the <c>ZoneId</c> parameter, and you cannot specify a multi-zone ID.</para>
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
        /// <para>The number of shards. This parameter is available only for cloud native edition instances.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of <b>1</b> creates an instance with a standard architecture.</para>
        /// </description></item>
        /// <item><description><para>A value greater than <b>1</b> creates an instance with a cluster architecture.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The number of read-only replicas in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of replicas in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>To create an instance from a backup, specify the ID of the source instance.</para>
        /// <remarks>
        /// <para>This parameter must be used in conjunction with one of the following parameters: <b>BackupId</b>, <b>ClusterBackupId</b> (recommended for cloud native, cluster-architecture instances), or <b>RestoreTime</b>.</para>
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
            /// <item><description><para><c>N</c> represents the sequence number of the tag, from 1 to 20. You can add a maximum of 20 tags to an instance.</para>
            /// </description></item>
            /// <item><description><para>If the tag key does not exist, it is automatically created.</para>
            /// </description></item>
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
            /// <para>The value for tag <c>N</c>.</para>
            /// <remarks>
            /// <para>The N in <b>Tag.N.Value</b> specifies the sequence number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
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
        /// <para>A client-generated token to ensure the idempotence of the request. The token must be unique across requests, case-sensitive, and cannot exceed 64 ASCII characters.</para>
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
        /// <para>The ID of the primary zone for the instance. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeZones</a> operation to query available zones.</para>
        /// <remarks>
        /// <para>You can also specify a secondary zone by using the <c>SecondaryZoneId</c> parameter. The primary and replica nodes are then deployed in the specified primary and secondary zones to create a dual-zone architecture for in-city disaster recovery. For example, you can set the <c>ZoneId</c> parameter to &quot;cn-hangzhou-h&quot; and the <c>SecondaryZoneId</c> parameter to &quot;cn-hangzhou-g&quot;.</para>
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
