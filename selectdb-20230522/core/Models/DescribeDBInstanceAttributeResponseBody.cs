// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        [NameInMap("CanUpgradeVersionCommunityMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> CanUpgradeVersionCommunityMap { get; set; }

        /// <summary>
        /// <para>The engine versions to which the instance can be upgraded.</para>
        /// </summary>
        [NameInMap("CanUpgradeVersions")]
        [Validation(Required=false)]
        public List<string> CanUpgradeVersions { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("CommunityVersion")]
        [Validation(Required=false)]
        public string CommunityVersion { get; set; }

        /// <summary>
        /// <para>The configuration template applied to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("ConfigPatternType")]
        [Validation(Required=false)]
        public string ConfigPatternType { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-14T03:00:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>A list of clusters in the instance.</para>
        /// </summary>
        [NameInMap("DBClusterList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyDBClusterList> DBClusterList { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBClusterList : TeaModel {
            /// <summary>
            /// <para>The cache storage size, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("CacheStorageSizeGB")]
            [Validation(Required=false)]
            public string CacheStorageSizeGB { get; set; }

            /// <summary>
            /// <para>The cache storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("CacheStorageType")]
            [Validation(Required=false)]
            public string CacheStorageType { get; set; }

            /// <summary>
            /// <para>The billing method of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Postpaid</b>: pay-as-you-go</para>
            /// </description></item>
            /// <item><description><para><b>Prepaid</b>: subscription</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The ID of the target cluster to which this cluster is bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv****-be</para>
            /// </summary>
            [NameInMap("ClusterBinding")]
            [Validation(Required=false)]
            public string ClusterBinding { get; set; }

            /// <summary>
            /// <para>The number of nodes in the cluster. This parameter applies only to serverless instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClusterNodeCount")]
            [Validation(Required=false)]
            public int? ClusterNodeCount { get; set; }

            /// <summary>
            /// <para>The cluster node type. This parameter applies only to serverless instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>base</para>
            /// </summary>
            [NameInMap("ClusterNodeType")]
            [Validation(Required=false)]
            public string ClusterNodeType { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public long? CpuCores { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14T09:24:13Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cluster class. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>selectdb.xlarge</b>: 4 CPU cores, 16 GB of memory.</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.2xlarge</b>: 8 CPU cores, 32 GB of memory.</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.4xlarge</b>: 16 CPU cores, 64 GB of memory.</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.8xlarge</b>: 32 CPU cores, 128 GB of memory.</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.16xlarge</b>: 64 CPU cores, 256 GB of memory.</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.24xlarge</b>: 96 CPU cores, 384 GB of memory.</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.32xlarge</b>: 128 CPU cores, 512 GB of memory.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb.2xlarge</para>
            /// </summary>
            [NameInMap("DbClusterClass")]
            [Validation(Required=false)]
            public string DbClusterClass { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-h033cjs****-be</para>
            /// </summary>
            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("DbClusterName")]
            [Validation(Required=false)]
            public string DbClusterName { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance test</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            /// <summary>
            /// <para>The memory size, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The time when the cluster was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-02T16:35:44+08:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The performance level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The maximum value of the auto-scaling range for the cluster\&quot;s RDS Capacity Units (RCUs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public double? ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum value of the auto-scaling range for the cluster\&quot;s RDS Capacity Units (RCUs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public double? ScaleMin { get; set; }

            /// <summary>
            /// <para>Indicates whether a scheduled scaling policy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ScalingRulesEnable")]
            [Validation(Required=false)]
            public bool? ScalingRulesEnable { get; set; }

            /// <summary>
            /// <para>The time when the cluster was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14T09:24:13Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CREATING</b>: The cluster is being created.</para>
            /// </description></item>
            /// <item><description><para><b>ACTIVATION</b>: The cluster is running.</para>
            /// </description></item>
            /// <item><description><para><b>RESOURCE_CHANGING</b>: The cluster configuration is being changed.</para>
            /// </description></item>
            /// <item><description><para><b>ORDER_PREPARING</b>: The order is being confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>READONLY_RESOURCE_CHANGING</b>: The cluster configuration is being changed, and the cluster is write-locked.</para>
            /// </description></item>
            /// <item><description><para><b>DELETING</b>: The cluster is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subdomain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>预留参数，暂不返回。</para>
            /// </summary>
            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-t4n8x7jcc8rknon85tqoa</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance deployment mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>multi_az</para>
        /// </summary>
        [NameInMap("DeployScheme")]
        [Validation(Required=false)]
        public string DeployScheme { get; set; }

        /// <summary>
        /// <para>The instance description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The minor engine version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0.1</para>
        /// </summary>
        [NameInMap("EngineMinorVersion")]
        [Validation(Required=false)]
        public string EngineMinorVersion { get; set; }

        /// <summary>
        /// <para>The database engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The expiration time of the subscription instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-17T00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The time when the instance was last modified. The time is in <c>yyyy-MM-ddTHH:mmZ</c> format and is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-17T09:58Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("LangfuseInstanceIds")]
        [Validation(Required=false)]
        public List<string> LangfuseInstanceIds { get; set; }

        /// <summary>
        /// <para>The lock mode of the instance. A value of <b>lock</b> indicates that the instance was automatically locked due to an expired subscription or an overdue payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public long? LockMode { get; set; }

        /// <summary>
        /// <para>The reason the instance is locked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nolock</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>not_enabled</para>
        /// </summary>
        [NameInMap("MCPServerServiceStatus")]
        [Validation(Required=false)]
        public string MCPServerServiceStatus { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter.</para>
        /// </summary>
        [NameInMap("MaintainEndtime")]
        [Validation(Required=false)]
        public string MaintainEndtime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter.</para>
        /// </summary>
        [NameInMap("MaintainStarttime")]
        [Validation(Required=false)]
        public string MaintainStarttime { get; set; }

        /// <summary>
        /// <para>The multi-zone configuration.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is returned only if the <c>DeployScheme</c> parameter is set to <c>multi_az</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MultiZone")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyMultiZone> MultiZone { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyMultiZone : TeaModel {
            /// <summary>
            /// <para>The number of available IP addresses in the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("AvailableIpCount")]
            [Validation(Required=false)]
            public long? AvailableIpCount { get; set; }

            /// <summary>
            /// <para>The CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113.88.14.211/32</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>A list of vSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("OTelBearerToken")]
        [Validation(Required=false)]
        public string OTelBearerToken { get; set; }

        [NameInMap("OTelGrafanaServiceStatus")]
        [Validation(Required=false)]
        public string OTelGrafanaServiceStatus { get; set; }

        /// <summary>
        /// <para>The object storage space, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ObjectStoreSize")]
        [Validation(Required=false)]
        public long? ObjectStoreSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06758CAB-1204-5852-A471-29C87D5C1D0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ResourceCpu")]
        [Validation(Required=false)]
        public long? ResourceCpu { get; set; }

        /// <summary>
        /// <para>The ID of the instance\&quot;s resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzbck4asz3dsa</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the direct port connection feature is enabled for the instance\&quot;s VPC.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SecGroupConnValid")]
        [Validation(Required=false)]
        public string SecGroupConnValid { get; set; }

        /// <summary>
        /// <para>Indicates whether the serverless feature is enabled for the instance.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Serverless")]
        [Validation(Required=false)]
        public bool? Serverless { get; set; }

        /// <summary>
        /// <para>The state of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>ACTIVE</b>: The instance is running.</para>
        /// </description></item>
        /// <item><description><para><b>RESOURCE_CHANGING</b>: The instance configuration is being changed.</para>
        /// </description></item>
        /// <item><description><para><b>ORDER_PREPARING</b>: The order is being confirmed.</para>
        /// </description></item>
        /// <item><description><para><b>READONLY_RESOURCE_CHANGING</b>: The instance configuration is being changed, and the instance is write-locked.</para>
        /// </description></item>
        /// <item><description><para><b>DELETING</b>: The instance is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage space, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The subdomain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter.</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>A list of tags attached to the instance.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp18iztwqrs8qj2nc6nyu</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>A list of virtual clusters.</para>
        /// </summary>
        [NameInMap("VirtualClusterList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyVirtualClusterList> VirtualClusterList { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyVirtualClusterList : TeaModel {
            /// <summary>
            /// <para>The ID of the primary cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-xx78***-be</para>
            /// </summary>
            [NameInMap("ActiveClusterId")]
            [Validation(Required=false)]
            public string ActiveClusterId { get; set; }

            /// <summary>
            /// <para>The name of the primary cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("ActiveClusterName")]
            [Validation(Required=false)]
            public string ActiveClusterName { get; set; }

            /// <summary>
            /// <para>The time when the virtual cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-31T21:01:09Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-vcg-33cjs****-be</para>
            /// </summary>
            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vgcdemo</para>
            /// </summary>
            [NameInMap("DbClusterName")]
            [Validation(Required=false)]
            public string DbClusterName { get; set; }

            /// <summary>
            /// <para>The ID of the standby cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-x6u7***-be</para>
            /// </summary>
            [NameInMap("StandbyClusterId")]
            [Validation(Required=false)]
            public string StandbyClusterId { get; set; }

            /// <summary>
            /// <para>The name of the standby cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2</para>
            /// </summary>
            [NameInMap("StandbyClusterName")]
            [Validation(Required=false)]
            public string StandbyClusterName { get; set; }

            /// <summary>
            /// <para>The state of the virtual cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CREATING</b>: The virtual cluster is being created.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: The virtual cluster is running.</para>
            /// </description></item>
            /// <item><description><para><b>DELETING</b>: The virtual cluster is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>UPDATING</b>: The virtual cluster is being updated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp175iuvg8nxqraf2****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
