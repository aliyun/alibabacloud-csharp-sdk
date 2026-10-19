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
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal. This is the default value.</description></item>
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
        /// <para>This parameter is required when the <b>AutoRenew</b> parameter is set to <b>true</b>.</para>
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
        /// <item><description><b>false</b>: does not use a voucher. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The ID of the backup set of the source instance. The system uses the data in the specified backup set to create the instance. You can invoke the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query the backup set ID. If the source instance is a cluster instance, you must enter the backup set IDs of all shards in the source instance and separate them with commas, such as &quot;10**,11**,15**&quot;.</para>
        /// <remarks>
        /// <para>If your instance is a cloud-native architecture instance, we recommend that you invoke the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation to query the cluster backup set ID, such as &quot;cb-xx&quot;, and then specify the ClusterBackupId request parameter to clone the cluster instance. This saves you the trouble of entering the backup set ID of each shard.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2158****20</para>
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
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription. This is the default value.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the cluster backup set. Some new cluster architectures support cluster backup set IDs. You can call the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation to obtain the ID.</para>
        /// <list type="bullet">
        /// <item><description>If the cluster architecture supports cluster backup sets, you can enter the specified cluster backup set ID. You do not need to specify the <b>BackupId</b> parameter.</description></item>
        /// <item><description>If the cluster architecture does not support cluster backup sets, enter the backup set IDs of all shards in the source instance in the BackupId parameter and separate them with commas, such as &quot;2158\<em>\</em>\<em>\<em>20,2158\</em>\</em>\*\*22&quot;.</description></item>
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
        /// <para>The endpoint is in the following format: <Prefix-Instance ID>.redis.rds.aliyuncs.com.</para>
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
        /// <para>Specifies whether to perform a dry run before you create the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the instance. The system checks the request parameters, request format, service limits, and available resources. If the request fails the dry run, the system returns an error. If the request passes the dry run, the system returns the <c>DryRunOperation</c> error code.</description></item>
        /// <item><description><b>false</b>: sends the request. If the request passes the check, the instance is created. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The database engine version. Default value: <b>1.0</b>. The value varies based on the Tair instance type:</para>
        /// <list type="bullet">
        /// <item><description>Tair_rdb: Tair memory-enhanced instances are compatible with Redis 5.0, Redis 6.0, and Redis 7.0 protocols. Set the value to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>Tair_scm: Tair persistent memory-optimized instances are compatible with the Redis 6.0 protocol. Set the value to <b>1.0</b>.</description></item>
        /// <item><description>Tair_essd: Tair disk-based (ESSD/SSD) instances are compatible with the Redis 6.0 protocol. Set the value to <b>1.0</b> for ESSD-based instances and <b>2.0</b> for SSD-based instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the new instance as a child instance in a distributed instance. You can use this parameter to create a distributed instance.</para>
        /// <list type="bullet">
        /// <item><description>To use the new instance as the first child instance, set the value to <b>true</b>.</description></item>
        /// <item><description>To use the new instance as the second or third child instance, set the value to the ID of the distributed instance, such as gr-bp14rkqrhac****.</description></item>
        /// <item><description>If you do not want to use the new instance as a child instance in a distributed instance, leave this parameter empty.<remarks>
        /// <para>The new instance must be a Tair memory-enhanced instance if you want to use it as a child instance in a distributed instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// <para>The global IP address whitelist templates of the instance. Separate multiple whitelist templates with commas (,). Each template must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-zsldxfiwjmti0kcm****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/2527112.html">Memory-enhanced instance types</a>.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2527110.html">Persistent memory-optimized instance types</a>.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2527111.html">Disk-based instance types</a>.</description></item>
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
        /// <para>The endpoint type used when you create a cloud-native Dual-active-zone deployment read/write splitting instance. If you do not specify this parameter, the default value is AzIndependentEndpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>AzIndependentEndpoint</b>: active zone-independent endpoint. This is the <b>default value</b>. Independent endpoints are provided for the primary and secondary active zones. You can use different endpoints to achieve nearest access.</description></item>
        /// <item><description><b>UnifiedEndpoint</b>: unified endpoint. A unified endpoint is provided to access nodes in both the primary and secondary active zones. However, cross-active-zone access may occur.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: This parameter applies only to cloud-native Dual-active-zone deployment read/write splitting instances. For other types of instances, only active zone-independent endpoints are supported. Even if you specify UnifiedEndpoint, it does not take effect.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: The UnifiedEndpoint parameter is currently available only to whitelisted users. If you are not a whitelisted user and specify this parameter, an invoke error is returned. To request access, commit a ticket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AzIndependentEndpoint</para>
        /// </summary>
        [NameInMap("InstanceEndpointType")]
        [Validation(Required=false)]
        public string InstanceEndpointType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 80 characters in length.</description></item>
        /// <item><description>The name must start with a letter or a Chinese character. It cannot contain spaces or the following special characters: <c>@/:=”&lt;&gt;{[]}</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The storage medium. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tair_rdb</b>: memory-enhanced.</description></item>
        /// <item><description><b>tair_scm</b>: persistent memory-optimized.</description></item>
        /// <item><description><b>tair_essd</b>: disk-based.</description></item>
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
        /// <para>The end time of the maintenance window. Specify the time in the <i>HH:mm</i>Z format. The time must be in UTC. For example, if you want the maintenance window to end at 02:00 (UTC+8), set the value to <c>18:00Z</c>.</para>
        /// <remarks>
        /// <para>The interval between the start time and the end time must be at least 1 hour.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is 22:00 (UTC), which is 06:00 (UTC+8).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window. Specify the time in the <i>HH:mm</i>Z format. The time must be in UTC. For example, if you want the maintenance window to start at 01:00 (UTC+8), set the value to <c>17:00Z</c>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is 18:00 (UTC), which is 02:00 (UTC+8).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>17:00Z</para>
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
        /// <para>The ID of the parameter template. The instance is created based on the parameters in the specified template. Each template ID must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-50npzjcqb1ua6q6j****</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The instance password. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, special characters, and digits. Supported special characters are <c>!@#$%^&amp;*()_+-=</c>.</description></item>
        /// </list>
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
        /// <para>This parameter is required when the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
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
        /// <para>The internal IP address of the instance.</para>
        /// <remarks>
        /// <para>The IP address must fall within the CIDR block of the vSwitch to which the instance belongs. You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation of the VPC API to query the CIDR block information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.88.***</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in the primary zone. This parameter applies only when you create a cloud-native read/write splitting instance.</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses the standard architecture, valid values are 1 to 9.</description></item>
        /// <item><description>If the instance uses the cluster architecture, valid values are 1 to 4, which indicate the number of read-only nodes per data shard.<remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and the SlaveReadOnlyCount parameter to specify the number of read-only nodes in the primary and secondary zones.</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses the standard architecture, the sum of the values of this parameter and the SlaveReadOnlyCount parameter cannot exceed 9.</description></item>
        /// <item><description>If the instance uses the cluster architecture, the sum of the values of this parameter and the SlaveReadOnlyCount parameter cannot exceed 4.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore the account, kernel parameters, and whitelist from the original backup set when you create an instance by using a specified backup set. For example, to restore the account information, set the value to account.</para>
        /// <para>Default value: empty. An empty value indicates that the account, kernel parameters, and whitelist are not restored from the original backup set.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud-native instances and requires that the original backup set contains the account, kernel parameters, and whitelist information. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query whether the RecoverConfigMode parameter of a specified backup set contains the preceding information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist,config,account</para>
        /// </summary>
        [NameInMap("RecoverConfigMode")]
        [Validation(Required=false)]
        public string RecoverConfigMode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent region list. Use this parameter to specify the region where you want to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of secondary nodes in the primary zone. This parameter applies only when you create a cloud-native cluster instance with multiple replicas. You can use this parameter to specify the number of secondary nodes. Valid values: 1 to 4.</para>
        /// <remarks>
        /// <para>If you create a multi-zone instance, you can use this parameter and the SlaveReplicaCount parameter to specify the number of secondary nodes in the primary and secondary zones. The sum of the values of this parameter and the SlaveReplicaCount parameter cannot exceed 4.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// <para>The ID of the destination resource group.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can invoke the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation or use the console to obtain the resource group ID list. For related operations, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</description></item>
        /// <item><description>Before you change the resource group to which the instance belongs, you can invoke the <a href="https://help.aliyun.com/document_detail/158866.html">ListResources</a> operation to view the current resource group of the instance.</description></item>
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
        /// <para>The point in time to which you want to restore the source instance. If the data flashback feature is enabled for the source instance, you can specify a point in time within the backup retention period of the source instance. The system uses the backup data of the source instance at the specified point in time to create the instance. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T07:25:57Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The secondary zone ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent zone list.</para>
        /// <remarks>
        /// <para>The value of this parameter cannot be the same as the value of the ZoneId parameter, and you cannot specify the ID of a multi-zone deployment.</para>
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
        /// <para>The number of data nodes in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: creates a <a href="https://help.aliyun.com/document_detail/52228.html">standard instance</a> that has only one data node. This is the default value.</description></item>
        /// <item><description><b>2</b> to <b>32</b>: creates a <a href="https://help.aliyun.com/document_detail/52228.html">cluster instance</a> that has the specified number of data nodes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can set this parameter to a value from <b>2</b> to <b>32</b> only when the <b>InstanceType</b> parameter is set to <b>tair_rdb</b> or <b>tair_scm</b>. This means that only memory-enhanced and persistent memory-optimized instances support the cluster architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MASTER_SLAVE</b>: High-availability Edition. This edition uses a primary/secondary architecture to ensure high availability. This is the default value.</description></item>
        /// <item><description><b>STAND_ALONE</b>: Standalone Edition. This edition uses a single-node architecture. If a node fails, data is lost and the system automatically creates a new empty instance. This edition is supported only in <b>single-zone</b> deployments and does not support cluster or read/write splitting architectures.</description></item>
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
        /// <para>The number of secondary nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>Instance ID of the source instance. If you want to create an instance based on the backup set of an existing instance, specify instance ID of the source instance in this parameter.</para>
        /// <remarks>
        /// <para>Then, specify the backup set or point in time by using the <b>BackupId</b>, <b>ClusterBackupId</b> (recommended for cloud-native cluster architectures), or <b>RestoreTime</b> parameter. This parameter must be used in combination with one of the preceding three parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage capacity of the disk-based instance. The valid values vary based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/2527111.html">Disk-based instance types</a>.</para>
        /// <remarks>
        /// <para>This parameter is required only when the <b>InstanceType</b> parameter is set to <b>tair_essd</b> and you create an ESSD-based instance. If you create a Tair disk-based <b>SSD</b> instance, the capacity field is defined as a fixed value based on the instance type, and you do not need to specify this field.</para>
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
        /// <para>This parameter is required only when the <b>InstanceType</b> parameter is set to <b>tair_essd</b> and you create an ESSD-based instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>essd_pl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The tag information of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTairInstanceRequestTag> Tag { get; set; }
        public class CreateTairInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. A tag key and a tag value form a key-value pair.</para>
            /// <remarks>
            /// <para>You can specify up to 5 tag key-value pairs at a time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>key1_test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <remarks>
            /// <para><b>N</b> indicates the sequence number of the tag. For example, <b>Tag.1.Value</b> indicates the value of the first tag, and <b>Tag.2.Value</b> indicates the value of the second tag.</para>
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
        /// <para>The ID of the vSwitch in the VPC. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation of the VPC API to obtain the vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation of the VPC API to query the VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The primary active zone ID. You can invoke the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent active zone list. Use this parameter to specify the active zone where you want to create the instance.</para>
        /// <remarks>
        /// <para>You can also specify the SecondaryZoneId parameter to set the secondary active zone. The primary and secondary nodes will be placed in the specified primary and secondary active zones to implement a dual-active-zone primary/secondary architecture deployment. For example, set the ZoneId parameter to &quot;cn-hangzhou-h&quot; and the SecondaryZoneId parameter to &quot;cn-hangzhou-g&quot;.</para>
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
