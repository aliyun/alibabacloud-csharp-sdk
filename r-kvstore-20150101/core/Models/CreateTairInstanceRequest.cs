// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateTairInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Set the value to <b>true</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disable auto-renewal.</para>
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
        /// <para>The auto-renewal duration. Unit: month. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>6</b>, and <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when the <b>AutoRenew</b> parameter is set to <b>true</b>.</para>
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
        /// <item><description><para><b>true</b>: Use a coupon.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Do not use a coupon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The ID of the backup set from the source instance. The system creates a new instance based on the data in this backup set. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query the backup set ID. If the source instance is a cluster instance, you must specify the backup ID for each shard, separated by commas, for example, &quot;10\<em>\</em>,11\<em>\</em>,15\<em>\</em>&quot;.</para>
        /// <remarks>
        /// <para>If your instance is a cloud-native cluster instance, we recommend that you call the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation to query the cluster backup ID, such as <c>cb-xx</c>. Then, specify the cluster backup ID for the <c>ClusterBackupId</c> parameter to clone the cluster instance. This avoids the need to specify the backup ID of each shard.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2158****20</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The business information. This can be the ID of a promotion or a business context.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrePaid</b> (default): The subscription billing method.</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b>: The pay-as-you-go billing method.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The token must be unique among different requests. It is case-sensitive and cannot exceed 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the cluster backup set. Some instances that use the cluster architecture support cluster backup sets. You can call the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation to query for cluster backup set IDs.</para>
        /// <list type="bullet">
        /// <item><description><para>If this feature is supported, you can specify this parameter and leave the <b>BackupId</b> parameter empty.</para>
        /// </description></item>
        /// <item><description><para>If this feature is not supported, you must specify the backup ID of each shard of the source instance for the <c>BackupId</c> parameter. Separate the backup IDs with commas, for example, &quot;2158\<em>\</em>\<em>\<em>20,2158\</em>\</em>\*\*22&quot;.</para>
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
        /// <para>The prefix of the connection string. It must start with a lowercase letter, consist of lowercase letters and digits, and be 8 to 40 characters in length.</para>
        /// <remarks>
        /// <para>The full connection string is in the format of <c>&lt;prefix&gt;-&lt;instance ID&gt;.redis.rds.aliyuncs.com</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a precheck for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a precheck and does not create the instance. The system checks the request parameters, request format, service limits, and available inventory. If the request fails the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request and creates the instance after the request passes the precheck.</para>
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
        /// <para>The database version. Default value: <b>1.0</b>. The valid values depend on the Tair instance series:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tair_rdb</b>: Tair memory-enhanced instances are compatible with Redis 5.0, Redis 6.0, and Redis 7.0. Set the value to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</para>
        /// </description></item>
        /// <item><description><para><b>tair_scm</b>: Tair persistent memory-optimized instances are compatible with Redis 6.0. Set the value to <b>1.0</b>.</para>
        /// </description></item>
        /// <item><description><para><b>tair_essd</b>: Tair disk-based instances (ESSD/SSD) are compatible with Redis 6.0. Set the value to <b>1.0</b> to create an ESSD-based instance or <b>2.0</b> to create an SSD-based instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to create the instance as a child instance in a distributed instance. By using this parameter, you can create a distributed instance.</para>
        /// <list type="bullet">
        /// <item><description><para>To create the first child instance, set this parameter to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>To create the second or third child instance, specify the ID of the distributed instance, such as <c>gr-bp14rkqrhac****</c>.</para>
        /// </description></item>
        /// <item><description><para>If you do not want to create a distributed instance, do not specify this parameter.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To be created as a child instance of a distributed instance, the new instance must be a Tair memory-enhanced instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the global IP whitelist templates for the instance. To specify multiple template IDs, separate them with commas. The IDs cannot be repeated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-zsldxfiwjmti0kcm****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/2527112.html">Memory-enhanced instance types</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/2527110.html">Persistent memory-optimized instance types</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/2527111.html">Disk-based instance types</a></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tair.scm.standard.4m.32d</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The type of connection string to use when creating a cloud-native, dual-zone instance with the read/write splitting architecture. If you do not specify this parameter, the default value <c>AzIndependentEndpoint</c> is used.</para>
        /// <list type="bullet">
        /// <item><description><para><b>AzIndependentEndpoint</b> (<b>default</b>): Zone-specific connection string. The primary and secondary zones each provide an independent connection string, allowing clients to connect to the nearest zone.</para>
        /// </description></item>
        /// <item><description><para><b>UnifiedEndpoint</b>: Unified connection string. A single connection string is provided to access nodes in both the primary and secondary zones, but this may cause cross-zone access.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter applies only to cloud-native, dual-zone instances with the read/write splitting architecture. Other instance types support only zone-specific connection strings.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The <c>UnifiedEndpoint</c> option is available only to users on a whitelist. If a non-whitelisted user specifies this value, the request fails. To request access, submit a ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AzIndependentEndpoint</para>
        /// </summary>
        [NameInMap("InstanceEndpointType")]
        [Validation(Required=false)]
        public string InstanceEndpointType { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must be 2 to 80 characters in length.</para>
        /// </description></item>
        /// <item><description><para>It must start with an uppercase or lowercase letter or a Chinese character. It cannot contain spaces or the following special characters: <c>@/:=”&lt;&gt;{[]}</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The Tair instance series, which determines the storage medium. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tair_rdb</b>: memory-enhanced</para>
        /// </description></item>
        /// <item><description><para><b>tair_scm</b>: persistent memory-optimized</para>
        /// </description></item>
        /// <item><description><para><b>tair_essd</b>: disk-based</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tair_scm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window. Specify the time in the <em>HH:mm</em>Z format (UTC). For example, to end the maintenance at 02:00 (UTC+8), set this parameter to <c>18:00Z</c>.</para>
        /// <remarks>
        /// <para>The maintenance window must be at least one hour long.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If this parameter is not specified, the maintenance window ends at 22:00 UTC (06:00 UTC+8) by default.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window. Specify the time in the <em>HH:mm</em>Z format (UTC). For example, to start the maintenance at 01:00 (UTC+8), set this parameter to <c>17:00Z</c>.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the maintenance window starts at 18:00 UTC (02:00 UTC+8) by default.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the parameter template. The instance is created by using the parameters defined in this template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-50npzjcqb1ua6q6j****</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The password of the instance. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must be 8 to 32 characters in length.</para>
        /// </description></item>
        /// <item><description><para>It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The supported special characters are <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pass!123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The subscription duration, in months. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, <b>5</b>, <b>6</b>, 7, 8, 9, 12, 24, 36, and 60.</para>
        /// <remarks>
        /// <para>This parameter is required only when you set the <c>ChargeType</c> parameter to <c>PrePaid</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The service port of the instance. Valid values: 1 to 65535. Default value: 6379.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6379</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance.</para>
        /// <remarks>
        /// <para>The IP address must be within the CIDR block of the vSwitch to which the instance belongs. You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query the CIDR block information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.88.***</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in the primary zone. This parameter is applicable only to cloud-native instances that use the read/write splitting architecture.</para>
        /// <list type="bullet">
        /// <item><description><para>If the instance uses the standard architecture, the valid values are 1 to 9.</para>
        /// </description></item>
        /// <item><description><para>If the instance uses the cluster architecture, specify the number of read-only nodes per shard. The valid values are 1 to 4.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and the <c>SlaveReadOnlyCount</c> parameter to customize the number of read-only nodes in the primary and secondary zones.</para>
        /// <list type="bullet">
        /// <item><description><para>If the instance uses the standard architecture, the sum of <c>ReadOnlyCount</c> and <c>SlaveReadOnlyCount</c> cannot exceed 9.</para>
        /// </description></item>
        /// <item><description><para>If the instance uses the cluster architecture, the sum of <c>ReadOnlyCount</c> and <c>SlaveReadOnlyCount</c> cannot exceed 4.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>When creating an instance from a backup set, specifies whether to restore configurations such as account information (<c>account</c>), kernel parameters (<c>config</c>), and whitelists (<c>whitelist</c>) from the source backup set. To restore a specific configuration, specify its keyword. To restore multiple configurations, separate the keywords with commas.</para>
        /// <para>If this parameter is not specified, no configurations are restored from the source backup set.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud-native instances, and the source backup set must contain the specified configuration information. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation and check the <c>RecoverConfigMode</c> parameter in the response to check if the backup set contains the information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist,config,account</para>
        /// </summary>
        [NameInMap("RecoverConfigMode")]
        [Validation(Required=false)]
        public string RecoverConfigMode { get; set; }

        /// <summary>
        /// <para>The ID of the region where you want to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the primary zone. This parameter is applicable only to cloud-native, multi-replica cluster instances. You can use this parameter to customize the number of replica nodes. Valid values: 1 to 4.</para>
        /// <remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and the <c>SlaveReplicaCount</c> parameter to customize the number of replica nodes in the primary and secondary zones. The sum of <c>ReplicaCount</c> and <c>SlaveReplicaCount</c> cannot exceed 4.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation or use the Resource Management console to query the IDs of resource groups. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// </description></item>
        /// <item><description><para>Before you change the resource group of an instance, you can call the <a href="https://help.aliyun.com/document_detail/158866.html">ListResources</a> operation to view the current resource group of the instance.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
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
        /// <para>If point-in-time recovery (PITR) is enabled for the source instance, you can specify a point in time within the backup retention period. The system creates a new instance by using the backup data of the source instance at that point in time. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T07:25:57Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query available zones.</para>
        /// <remarks>
        /// <para>The value of this parameter cannot be the same as the value of the <c>ZoneId</c> parameter. You cannot specify a multi-zone ID.</para>
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
        /// <para>The number of shards in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b> (default): Creates a standard architecture instance with a single shard.</para>
        /// </description></item>
        /// <item><description><para>From <b>2</b> to <b>32</b>: Creates a cluster architecture instance with the specified number of shards.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify a value from <b>2</b> to <b>32</b> for this parameter only when you set the <b>InstanceType</b> parameter to <c>tair_rdb</c> or <c>tair_scm</c>. Only memory-enhanced and persistent memory-optimized instances support the cluster architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The architecture type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MASTER_SLAVE</b> (default): The primary/replica architecture, which provides high availability.</para>
        /// </description></item>
        /// <item><description><para><b>STAND_ALONE</b>: single-replica. This architecture uses a single node. If the node fails, data is lost, and the system automatically creates a new, empty instance. This architecture is supported only for <b>single-zone</b> deployments and does not support cluster or read/write splitting architectures.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("ShardType")]
        [Validation(Required=false)]
        public string ShardType { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>To create an instance from a backup set of an existing instance, specify the ID of the source instance.</para>
        /// <remarks>
        /// <para>You must also specify the backup data by using one of the following parameters: <b>BackupId</b>, <b>ClusterBackupId</b>, or <b>RestoreTime</b>. We recommend that you use <c>ClusterBackupId</c> for cloud-native instances that use a cluster architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage space of the disk-based instance. The valid values of this parameter vary based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/2527111.html">Disk-based instance types</a>.</para>
        /// <remarks>
        /// <para>This parameter is required only when you set the <b>InstanceType</b> parameter to <c>tair_essd</c> to create a Tair instance that uses an ESSD. For Tair instances that use standard <c>SSD</c>s, the storage capacity is determined by the instance type and you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values: <b>essd_pl1</b>, <b>essd_pl2</b>, and <b>essd_pl3</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when you set the <b>InstanceType</b> parameter to <c>tair_essd</c> to create a Tair instance that uses an Enhanced SSD (ESSD).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>essd_pl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTairInstanceRequestTag> Tag { get; set; }
        public class CreateTairInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <para>A single request can contain up to five key-value pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>key1_test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <remarks>
            /// <para><b>N</b> specifies the Nth tag in the request. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>value1_test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch in the specified VPC. You can call the VPC API operation <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVSwitches</a> to obtain the vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the Virtual Private Cloud (VPC) where you want to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query available VPCs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone where you want to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query available zones.</para>
        /// <remarks>
        /// <para>You can also specify a secondary zone by using the <c>SecondaryZoneId</c> parameter. This deploys the primary and replica nodes in different zones within the same region for a high-availability primary/replica architecture. For example, you can set <c>ZoneId</c> to <c>cn-hangzhou-h</c> and <c>SecondaryZoneId</c> to <c>cn-hangzhou-g</c>.</para>
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
