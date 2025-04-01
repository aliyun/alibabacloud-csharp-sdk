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
        /// <para>The subscription duration that is supported by auto-renewal. Unit: month. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>6</b>, and <b>12</b>.</para>
        /// <remarks>
        /// <para> This parameter is required if the <b>AutoRenew</b> parameter is set to <b>true</b>.</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>You can set the BackupId parameter to the backup set ID of the source instance. The system uses the data stored in the backup set to create an instance. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query the backup set ID. If the source instance is a cluster instance, set the BackupId parameter to the backup set IDs of all shards of the source instance, separated by commas (,). Example: &quot;10\<em>\</em>,11\<em>\</em>,15\<em>\</em>&quot;.</para>
        /// <remarks>
        /// <para> If your instance is a cloud-native cluster instance, we recommend that you use <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> to query the backup set ID of the cluster instance, such as cb-xx. Then, set the ClusterBackupId request parameter to the backup set ID to clone the cluster instance. This eliminates the need to specify the backup set ID of each shard.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The ID of the promotional event or the business information.</para>
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
        /// <item><description><b>PrePaid</b> (default): subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests and is case-sensitive. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is supported for specific new cluster instances. You can query the backup set ID by calling the <a href="https://help.aliyun.com/document_detail/2679168.html">DescribeClusterBackupList</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is supported, you can specify the backup set ID. In this case, you do not need to specify the <b>BackupId</b> parameter.</description></item>
        /// <item><description>If this parameter is not supported, set the BackupId parameter to the IDs of backup sets in all shards of the source instance, separated by commas (,). Example: &quot;2158\<em>\</em>\<em>\<em>20,2158\</em>\</em>\*\*22&quot;.</description></item>
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
        /// <para> The endpoint must be in the \<prefix>.redis.rds.aliyuncs.com format.</para>
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
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not create the instance. The system prechecks the request parameters, request format, service limits, and available resources. If the request fails the dry run, an error code is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (false): performs a dry run and performs the actual request. If the request passes the dry run, the instance is directly created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The database engine version. Default value: <b>1.0</b>. The parameter value varies based on the Tair instance series.</para>
        /// <list type="bullet">
        /// <item><description>To create a Tair DRAM-based instance (Tair_rdb) that is compatible with Redis 5.0, 6.0, or 7.0, set this parameter to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>To create a Tair persistent memory-optimized instance (tair_scm) that is compatible with Redis 6.0, set this parameter to <b>1.0</b>.</description></item>
        /// <item><description>To create a Tair ESSD-based instance (tair_essd) that is compatible with Redis 6.0, set this parameter to <b>1.0</b>. To create a Tair SSD-based instance that is compatible with Redis 6.0, set this parameter to <b>2.0</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the created instance as a child instance of a distributed instance.</para>
        /// <list type="bullet">
        /// <item><description>If you want the created instance to be used as the first child instance, enter <b>true</b>.</description></item>
        /// <item><description>If you want the created instance to be used as the second or third child instance, enter the ID of the distributed instance, such as gr-bp14rkqrhac\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>If you do not want the created instance to be used as a distributed instance, leave the parameter empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you want the created instance to be used as a distributed instance, the created instance must be a Tair DRAM-based instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// <para>The global IP whitelist templates of the instance. Separate multiple IP whitelist templates with commas (,). Each IP whitelist template must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-zsldxfiwjmti0kcm****</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance series. For more information, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/2527112.html">DRAM-based instances</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2527110.html">Persistent memory-optimized instances</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2527111.html">ESSD/SSD-based instances</a></description></item>
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
        /// <para>The name of the instance. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 80 characters in length.</description></item>
        /// <item><description>The name must start with a letter and cannot contain spaces or special characters. Special characters include <c>@ / : = &quot; &lt; &gt; { [ ] }</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance series. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tair_rdb</b>: Tair DRAM-based instance</description></item>
        /// <item><description><b>tair_scm</b>: Tair persistent memory-optimized instance</description></item>
        /// <item><description><b>tair_essd</b>: Tair ESSD/SSD-based instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tair_scm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the parameter template. The instance is created based on the parameters in the parameter template. The ID must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-50npzjcqb1ua6q6j****</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The password that is used to connect to the instance. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include <c>! @ # $ % ^ &amp; * ( ) _ + - =</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pass!123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values: <b>1</b>, 2, 3, 4, 5, 6, 7, 8, <b>9</b>, <b>12</b>, <b>24</b>,<b>36</b>, and <b>60</b>. Unit: month.</para>
        /// <remarks>
        /// <para> This parameter is required only if the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The service port number of the instance. Valid values: 1024 to 65535. Default value: 6379.</para>
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
        /// <para> The IP address must be within the CIDR block of the vSwitch to which you want the instance to connect. You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation of VPC to query the CIDR block information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.88.***</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the primary zone. This parameter applies only to cloud-native read/write splitting instances. Valid values: 1 to 9.</para>
        /// <remarks>
        /// <para> The sum of the values of this parameter and the SlaveReadOnlyCount parameter cannot exceed 9.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore the account, kernel parameter, and whitelist information from the original backup set when you create an instance from the specified backup set. For example, if you want to restore the account information, set the parameter to <c>{&quot;account&quot;:true}</c>.</para>
        /// <para>This parameter is empty by default, which indicates that the account, kernel parameter, and whitelist information is not restored from the original backup set.</para>
        /// <remarks>
        /// <para> This parameter applies only to cloud-native cluster instances. The account, kernel parameter, and whitelist information must be stored in the original backup set. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to check whether the RecoverConfigMode configurations in the specified backup set contain the preceding information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;whitelist&quot;:true,&quot;config&quot;:true,&quot;account&quot;:true}</para>
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
        /// <para>The number of replica nodes in the primary zone. This parameter applies only to cloud-native multi-replica cluster instances. Valid values: 1 to 4.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The sum of the values of this parameter and the SlaveReplicaCount parameter cannot exceed 4.</para>
        /// </description></item>
        /// <item><description><para>You can specify only one of the ReplicaCount and ReadOnlyCount parameters.</para>
        /// </description></item>
        /// <item><description><para>Master-replica instances do not support multiple replicas.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// <para>The ID of the resource group that you want to manage.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can query resource group IDs in the console or by calling the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information about a resource group</a>.</para>
        /// </description></item>
        /// <item><description><para>Before you modify the resource group to which an instance belongs, you can call the <a href="https://help.aliyun.com/document_detail/158866.html">ListResources</a> operation to view the current resource group of the instance.</para>
        /// </description></item>
        /// </list>
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
        /// <para>If data flashback is enabled for the source instance, you can use this parameter to specify a point in time within the backup retention period of the source instance. The system uses the backup data of the source instance at the point in time to create an instance. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T07:25:57Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the ID of the secondary zone.</para>
        /// <remarks>
        /// <para> You cannot specify multiple zone IDs or set this parameter to a value that is the same as that of the ZoneId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
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
        /// <item><description><b>1</b> (default): You can create a <a href="https://help.aliyun.com/document_detail/52228.html">standard instance</a> that contains only one data node.</description></item>
        /// <item><description><b>2</b> to <b>32</b>: You can create a <a href="https://help.aliyun.com/document_detail/52228.html">cluster instance</a> that contains the specified number of data nodes.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When the <b>InstanceType</b> parameter is set to <b>tair_rdb</b> or <b>tair_scm</b>, this parameter can be set to a value in the range of <b>2</b> to <b>32</b>. Only DRAM-based and persistent memory-optimized instances support the cluster architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The shard type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MASTER_SLAVE</b> (default): runs in a master-replica architecture that provides high availability.</description></item>
        /// <item><description><b>STAND_ALONE</b>: runs in a standalone architecture. If the only node fails, the system creates a new instance and switches the workloads to the new instance. This may cause data loss. You can set the ShardType parameter to this value only if the instance uses the <b>single-zone</b> deployment mode. If you set the ShardType parameter to this value, you cannot create cluster or read/write splitting instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("ShardType")]
        [Validation(Required=false)]
        public string ShardType { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the secondary zone when you create a multi-zone read/write splitting instance. The sum of the values of this parameter and the ReadOnlyCount parameter cannot exceed 9.</para>
        /// <remarks>
        /// <para>When you create a multi-zone read/write splitting instance, you must specify both SlaveReadOnlyCount and SecondaryZoneId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the secondary zone when you create a cloud-native multi-replica cluster instance deployed across multiple zones. The sum of the values of this parameter and the ReplicaCount parameter cannot exceed 4.</para>
        /// <remarks>
        /// <para> When you create a cloud-native multi-replica cluster instance deployed across multiple zones, you must specify both SlaveReplicaCount and SecondaryZoneId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
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
        /// <para>The storage capacity of the ESSD/SSD-based instance. The valid values vary based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/2527111.html">ESSD/SSD-based instances</a>.</para>
        /// <remarks>
        /// <para> This parameter is required only when you set the <b>InstanceType</b> parameter to <b>tair_essd</b> to create an ESSD-based instance. If you create a Tair <b>SSD</b>-based instance, the Storage parameter is automatically specified based on predefined specifications. You do not need to specify this parameter.</para>
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
        /// <para> This parameter is required only when you set the <b>InstanceType</b> parameter to <b>tair_essd</b> to create an ESSD-based instance.</para>
        /// </remarks>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>essd_pl0</description></item>
        /// <item><description>essd_pl1</description></item>
        /// <item><description>essd_pl2</description></item>
        /// <item><description>essd_pl3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>essd_pl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>Details of the tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTairInstanceRequestTag> Tag { get; set; }
        public class CreateTairInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. A tag is a key-value pair.</para>
            /// <remarks>
            /// <para> A maximum of five key-value pairs can be specified at a time.</para>
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
            /// <para> <b>N</b> specifies the value of the nth tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
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
        /// <para>The ID of the vSwitch that belongs to the VPC. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query vSwitch IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query VPC IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent zone list.</para>
        /// <remarks>
        /// <para> You can also set the SecondaryZoneId parameter to specify the secondary zone. The primary and secondary nodes will then be deployed in the specified primary and secondary zones to implement the master-replica zone-disaster recovery architecture. For example, you can set the ZoneId parameter to cn-hangzhou-h and the SecondaryZoneId parameter to cn-hangzhou-g.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
