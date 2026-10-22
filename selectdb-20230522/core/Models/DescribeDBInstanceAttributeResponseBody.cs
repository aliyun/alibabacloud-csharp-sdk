// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The community versions corresponding to the upgradable versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;4.1.10-20260922&quot;:&quot;Apache Doris 3.1.4&quot;</para>
        /// </summary>
        [NameInMap("CanUpgradeVersionCommunityMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> CanUpgradeVersionCommunityMap { get; set; }

        /// <summary>
        /// <para>The list of upgradable versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;4.1.10-20260922&quot;</para>
        /// </summary>
        [NameInMap("CanUpgradeVersions")]
        [Validation(Required=false)]
        public List<string> CanUpgradeVersions { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
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
        /// <para>The community version corresponding to the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apache Doris 4.0.8</para>
        /// </summary>
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
        /// <para>The creation time in ISO 8601 format with time zone information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-14T03:00:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The list of clusters to which the instance belongs.</para>
        /// </summary>
        [NameInMap("DBClusterList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyDBClusterList> DBClusterList { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBClusterList : TeaModel {
            /// <summary>
            /// <para>The cache storage size. Unit: GB.</para>
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
            /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para><b>Prepaid</b>: subscription.</para>
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
            /// <para>The bound target cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv****-be</para>
            /// </summary>
            [NameInMap("ClusterBinding")]
            [Validation(Required=false)]
            public string ClusterBinding { get; set; }

            /// <summary>
            /// <para>The number of nodes in the cluster. This parameter takes effect only in serverless mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClusterNodeCount")]
            [Validation(Required=false)]
            public int? ClusterNodeCount { get; set; }

            /// <summary>
            /// <para>The node type of the cluster. This parameter takes effect only in serverless mode.</para>
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
            /// <para>The creation time of the cluster in ISO 8601 format with time zone information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14T09:24:13Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cluster specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>selectdb.xlarge</b>: 4 cores and 16 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.2xlarge</b>: 8 cores and 32 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.4xlarge</b>: 16 cores and 64 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.8xlarge</b>: 32 cores and 128 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.16xlarge</b>: 64 cores and 256 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.24xlarge</b>: 96 cores and 384 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.32xlarge</b>: 128 cores and 512 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.g.xlarge</b>: 4 cores and 16 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.g.2xlarge</b>: 8 cores and 32 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.g.4xlarge</b>: 16 cores and 64 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.g.8xlarge</b>: 32 cores and 128 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.g.16xlarge</b>: 64 cores and 256 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.g.24xlarge</b>: 96 cores and 384 GB memory</para>
            /// </description></item>
            /// <item><description><para><b>selectdb.g.32xlarge</b>: 128 cores and 512 GB memory</para>
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
            /// <para>Test instance</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The modification time in ISO 8601 format with time zone information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-02T16:35:44+08:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The performance level (PL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The maximum number of RDS Capacity Units (RCUs) for auto-scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public double? ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum number of RDS Capacity Units (RCUs) for auto-scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public double? ScaleMin { get; set; }

            /// <summary>
            /// <para>Specifies whether the time-based elastic policy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ScalingRulesEnable")]
            [Validation(Required=false)]
            public bool? ScalingRulesEnable { get; set; }

            /// <summary>
            /// <para>The start time of the cluster in ISO 8601 format with time zone information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14T09:24:13Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CREATING</b>: The cluster is being created.</para>
            /// </description></item>
            /// <item><description><para><b>ACTIVATION</b>: The cluster is running.</para>
            /// </description></item>
            /// <item><description><para><b>RESOURCE_CHANGING</b>: The cluster specifications are being changed.</para>
            /// </description></item>
            /// <item><description><para><b>ORDER_PREPARING</b>: The order is being confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>READONLY_RESOURCE_CHANGING</b>: The cluster resources are being changed and the instance is locked for writes.</para>
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
            /// <para>Reserved parameter, not returned</para>
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
        /// <para>The deployment mode of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>multi_az</para>
        /// </summary>
        [NameInMap("DeployScheme")]
        [Validation(Required=false)]
        public string DeployScheme { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
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
        /// <para>The database version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The time when the instance expires, in ISO 8601 format with time zone information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-17T00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The list of FE clusters.</para>
        /// </summary>
        [NameInMap("FEClusterList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyFEClusterList> FEClusterList { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyFEClusterList : TeaModel {
            /// <summary>
            /// <para>The name of the FE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv****-fe</para>
            /// </summary>
            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <para>The number of nodes in the FE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores per node in the FE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("SingleNodeCpuCores")]
            [Validation(Required=false)]
            public long? SingleNodeCpuCores { get; set; }

            /// <summary>
            /// <para>The memory size per node in the FE cluster. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("SingleNodeMemoryInGB")]
            [Validation(Required=false)]
            public long? SingleNodeMemoryInGB { get; set; }

            /// <summary>
            /// <para>The status of the FE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The time when the instance was modified, such as restart or public network application. The time is in the yyyy-MM-ddTHH:mmZ format (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-17T09:58Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The list of Langfuse instance IDs associated with the SelectDB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;lfu-xxkshuf23sdj&quot;]</para>
        /// </summary>
        [NameInMap("LangfuseInstanceIds")]
        [Validation(Required=false)]
        public List<string> LangfuseInstanceIds { get; set; }

        /// <summary>
        /// <para>The lock mode of the instance. A value of <b>lock</b> indicates that the instance is locked due to expiration or overdue payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public long? LockMode { get; set; }

        /// <summary>
        /// <para>The reason why the instance is locked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nolock</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The service status of the MCP Server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not_enabled</para>
        /// </summary>
        [NameInMap("MCPServerServiceStatus")]
        [Validation(Required=false)]
        public string MCPServerServiceStatus { get; set; }

        /// <summary>
        /// <para>Reserved parameter. This parameter is not returned and does not apply to the time format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter, not currently returned</para>
        /// </summary>
        [NameInMap("MaintainEndtime")]
        [Validation(Required=false)]
        public string MaintainEndtime { get; set; }

        /// <summary>
        /// <para>Reserved parameter. This parameter is not returned and does not apply to the time format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter, not currently returned</para>
        /// </summary>
        [NameInMap("MaintainStarttime")]
        [Validation(Required=false)]
        public string MaintainStarttime { get; set; }

        /// <summary>
        /// <para>The multi-zone configuration.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is valid when DeployScheme is set to multi_az.</description></item>
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
            /// <para>The CIDR block information of the prefix list entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113.88.14.211/32</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs.</para>
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

        /// <summary>
        /// <para>The OTel collector bearer token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nDVkJstxQEwyXIae8cRBzK33Hev68len</para>
        /// </summary>
        [NameInMap("OTelBearerToken")]
        [Validation(Required=false)]
        public string OTelBearerToken { get; set; }

        /// <summary>
        /// <para>The service status of the OTel collector and Grafana.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not_enabled</para>
        /// </summary>
        [NameInMap("OTelGrafanaServiceStatus")]
        [Validation(Required=false)]
        public string OTelGrafanaServiceStatus { get; set; }

        /// <summary>
        /// <para>The storage space.</para>
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
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzbck4asz3dsa</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the port direct connection feature is enabled for the VPC where the current instance resides.</para>
        /// <list type="bullet">
        /// <item><description>A value of true indicates that the feature is enabled.</description></item>
        /// <item><description>A value of false indicates that the feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SecGroupConnValid")]
        [Validation(Required=false)]
        public string SecGroupConnValid { get; set; }

        /// <summary>
        /// <para>Indicates whether the serverless feature is enabled for the current instance.</para>
        /// <list type="bullet">
        /// <item><description>A value of true indicates that the feature is enabled.</description></item>
        /// <item><description>A value of false indicates that the feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Serverless")]
        [Validation(Required=false)]
        public bool? Serverless { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>ACTIVE</b>: The instance is running.</para>
        /// </description></item>
        /// <item><description><para><b>RESOURCE_CHANGING</b>: The instance specifications are being changed.</para>
        /// </description></item>
        /// <item><description><para><b>ORDER_PREPARING</b>: The order is being confirmed.</para>
        /// </description></item>
        /// <item><description><para><b>READONLY_RESOURCE_CHANGING</b>: The resources are being changed and the instance is locked for writes.</para>
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
        /// <para>The size of the storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h-aliyun</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>The instance label list information.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
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
        /// <para>The algorithm used for TDE on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES256</para>
        /// </summary>
        [NameInMap("TdeAlgorithm")]
        [Validation(Required=false)]
        public string TdeAlgorithm { get; set; }

        /// <summary>
        /// <para>Indicates whether TDE is enabled for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TdeEnabled")]
        [Validation(Required=false)]
        public bool? TdeEnabled { get; set; }

        /// <summary>
        /// <para>The TDE mode of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MANAGED</para>
        /// </summary>
        [NameInMap("TdeMode")]
        [Validation(Required=false)]
        public string TdeMode { get; set; }

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
        /// <para>The list of virtual clusters.</para>
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
            /// <para>The creation time in ISO 8601 format with time zone information.</para>
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
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATING</b>: The instance is being created.</description></item>
            /// <item><description><b>RUNNING</b>: The instance is running.</description></item>
            /// <item><description><b>DELETING</b>: The instance is being deleted.</description></item>
            /// <item><description><b>UPDATING</b>: The instance is being updated.</description></item>
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
