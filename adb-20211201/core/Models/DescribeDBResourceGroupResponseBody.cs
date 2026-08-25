// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resource group information.</para>
        /// </summary>
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            /// <summary>
            /// <para>The PromQL resource group configuration.</para>
            /// </summary>
            [NameInMap("AtmConfig")]
            [Validation(Required=false)]
            public DescribeDBResourceGroupResponseBodyGroupsInfoAtmConfig AtmConfig { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoAtmConfig : TeaModel {
                /// <summary>
                /// <para>The number of authentication nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AuthNodeNum")]
                [Validation(Required=false)]
                public string AuthNodeNum { get; set; }

                /// <summary>
                /// <para>The authentication node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ACU</para>
                /// </summary>
                [NameInMap("AuthNodeSpec")]
                [Validation(Required=false)]
                public string AuthNodeSpec { get; set; }

                /// <summary>
                /// <para>The number of write nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InsertNodeNum")]
                [Validation(Required=false)]
                public string InsertNodeNum { get; set; }

                /// <summary>
                /// <para>The write node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ACU</para>
                /// </summary>
                [NameInMap("InsertNodeSpec")]
                [Validation(Required=false)]
                public string InsertNodeSpec { get; set; }

                /// <summary>
                /// <para>The cache size of query nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SelectNodeCacheSize")]
                [Validation(Required=false)]
                public string SelectNodeCacheSize { get; set; }

                /// <summary>
                /// <para>The number of query nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SelectNodeNum")]
                [Validation(Required=false)]
                public string SelectNodeNum { get; set; }

                /// <summary>
                /// <para>The query node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ACU</para>
                /// </summary>
                [NameInMap("SelectNodeSpec")]
                [Validation(Required=false)]
                public string SelectNodeSpec { get; set; }

                /// <summary>
                /// <para>The disk size of storage nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("StorageNodeDiskSize")]
                [Validation(Required=false)]
                public string StorageNodeDiskSize { get; set; }

                /// <summary>
                /// <para>The disk type of storage nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>essd_pl1</para>
                /// </summary>
                [NameInMap("StorageNodeDiskType")]
                [Validation(Required=false)]
                public string StorageNodeDiskType { get; set; }

                /// <summary>
                /// <para>The number of storage nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("StorageNodeNum")]
                [Validation(Required=false)]
                public string StorageNodeNum { get; set; }

                /// <summary>
                /// <para>The storage node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ACU</para>
                /// </summary>
                [NameInMap("StorageNodeSpec")]
                [Validation(Required=false)]
                public string StorageNodeSpec { get; set; }

            }

            /// <summary>
            /// <para>The automatic stop interval, in the format of a number followed by m (minutes). The value ranges from 0m or 5m to 10080m. A value of 0m indicates that automatic stop is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0m</para>
            /// </summary>
            [NameInMap("AutoStopInterval")]
            [Validation(Required=false)]
            public string AutoStopInterval { get; set; }

            /// <summary>
            /// <para>The classification of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SQL</description></item>
            /// <item><description>SparkSQL</description></item>
            /// <item><description>MultiCluster</description></item>
            /// <item><description>AI</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            /// <summary>
            /// <para>A reserved parameter. Not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            /// <summary>
            /// <para>A reserved parameter. Not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("ClusterSizeResource")]
            [Validation(Required=false)]
            public string ClusterSizeResource { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created, in UTC. Format: <i>yyyy-MM-ddTHH:mm:ssZ</i>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-29T03:34:30Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The minimum elastic computing resources, in ACUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ElasticMinComputeResource")]
            [Validation(Required=false)]
            public string ElasticMinComputeResource { get; set; }

            /// <summary>
            /// <para>Indicates whether the spot instance feature is enabled for the resource group. When the spot instance feature is enabled, the unit price of resources is reduced, but instances may be released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>True</b>: The spot instance feature is enabled.</description></item>
            /// <item><description><b>False</b>: The spot instance feature is disabled.</description></item>
            /// </list>
            /// <para>Only Job-type resource groups can be set to True.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("EnableSpot")]
            [Validation(Required=false)]
            public string EnableSpot { get; set; }

            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The engine parameters.</para>
            /// </summary>
            [NameInMap("EngineParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> EngineParams { get; set; }

            /// <summary>
            /// <para>The GPU time-sharing elastic plan.</para>
            /// </summary>
            [NameInMap("GpuElasticPlan")]
            [Validation(Required=false)]
            public DescribeDBResourceGroupResponseBodyGroupsInfoGpuElasticPlan GpuElasticPlan { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoGpuElasticPlan : TeaModel {
                /// <summary>
                /// <para>Indicates whether the plan is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeDBResourceGroupResponseBodyGroupsInfoGpuElasticPlanRules> Rules { get; set; }
                public class DescribeDBResourceGroupResponseBodyGroupsInfoGpuElasticPlanRules : TeaModel {
                    /// <summary>
                    /// <para>The end time in Cron expression format. The interval must be at least 1 hour.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0 3 * * ?</para>
                    /// </summary>
                    [NameInMap("EndCronExpression")]
                    [Validation(Required=false)]
                    public string EndCronExpression { get; set; }

                    /// <summary>
                    /// <para>The start time in Cron expression format. The interval must be at least 1 hour.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0 2 * * ?</para>
                    /// </summary>
                    [NameInMap("StartCronExpression")]
                    [Validation(Required=false)]
                    public string StartCronExpression { get; set; }

                }

            }

            /// <summary>
            /// <para>The resource group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The resource group type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Interactive</b></description></item>
            /// <item><description><b>Job</b><remarks>
            /// <para>For more information about resource groups in Data Lakehouse Edition, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource group introduction (Data Lakehouse Edition)</a>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Job</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The Resource Access Management (RAM) users attached to the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testb,testc</para>
            /// </summary>
            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            /// <summary>
            /// <para>A reserved parameter. Not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("MaxClusterCount")]
            [Validation(Required=false)]
            public int? MaxClusterCount { get; set; }

            /// <summary>
            /// <para>The maximum reserved computing resources, in ACUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512ACU</para>
            /// </summary>
            [NameInMap("MaxComputeResource")]
            [Validation(Required=false)]
            public string MaxComputeResource { get; set; }

            /// <summary>
            /// <para>The maximum number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxGpuQuantity")]
            [Validation(Required=false)]
            public int? MaxGpuQuantity { get; set; }

            /// <summary>
            /// <para>The job routing rule message.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>A reserved parameter. Not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("MinClusterCount")]
            [Validation(Required=false)]
            public int? MinClusterCount { get; set; }

            /// <summary>
            /// <para>The minimum reserved computing resources, in ACUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ACU</para>
            /// </summary>
            [NameInMap("MinComputeResource")]
            [Validation(Required=false)]
            public string MinComputeResource { get; set; }

            /// <summary>
            /// <para>The minimum number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinGpuQuantity")]
            [Validation(Required=false)]
            public int? MinGpuQuantity { get; set; }

            /// <summary>
            /// <para>The Ray configuration information.</para>
            /// </summary>
            [NameInMap("RayConfig")]
            [Validation(Required=false)]
            public DescribeDBResourceGroupResponseBodyGroupsInfoRayConfig RayConfig { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoRayConfig : TeaModel {
                /// <summary>
                /// <para>The Ray application configuration.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("AppConfig")]
                [Validation(Required=false)]
                public DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigAppConfig AppConfig { get; set; }
                public class DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigAppConfig : TeaModel {
                    /// <summary>
                    /// <para>The Ray application name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>app01</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The Ray application type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IsaacLab</para>
                    /// </summary>
                    [NameInMap("AppType")]
                    [Validation(Required=false)]
                    public string AppType { get; set; }

                    /// <summary>
                    /// <para>The image configuration.</para>
                    /// 
                    /// <b>if can be null:</b>
                    /// <c>true</c>
                    /// </summary>
                    [NameInMap("ImageSelector")]
                    [Validation(Required=false)]
                    public DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigAppConfigImageSelector ImageSelector { get; set; }
                    public class DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigAppConfigImageSelector : TeaModel {
                        /// <summary>
                        /// <para>The image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>lab2.10.0-ray2.43.0</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <para>The inference engine.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vLLM</para>
                        /// </summary>
                        [NameInMap("InferenceEngine")]
                        [Validation(Required=false)]
                        public string InferenceEngine { get; set; }

                        /// <summary>
                        /// <para>The LLM model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Deepseek-R1</para>
                        /// </summary>
                        [NameInMap("LlmModel")]
                        [Validation(Required=false)]
                        public string LlmModel { get; set; }

                    }

                }

                /// <summary>
                /// <para>The Ray cluster type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>BASIC: basic type, non-high-availability</para>
                /// </description></item>
                /// <item><description><para>HIGH_AVAILABILITY: high-availability type</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BASIC</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Indicates whether ENI is enabled.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>false</c>
                /// </summary>
                [NameInMap("EnableUserEni")]
                [Validation(Required=false)]
                public bool? EnableUserEni { get; set; }

                /// <summary>
                /// <para>The allocation unit of the head node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HeadAllocateUnit")]
                [Validation(Required=false)]
                public string HeadAllocateUnit { get; set; }

                /// <summary>
                /// <para>The disk capacity of the head node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100Gi</para>
                /// </summary>
                [NameInMap("HeadDiskCapacity")]
                [Validation(Required=false)]
                public string HeadDiskCapacity { get; set; }

                /// <summary>
                /// <para>The node specifications of the head node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADB.MLLarge.2</para>
                /// </summary>
                [NameInMap("HeadSpec")]
                [Validation(Required=false)]
                public string HeadSpec { get; set; }

                /// <summary>
                /// <para>The resource type of the head node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu</para>
                /// </summary>
                [NameInMap("HeadSpecType")]
                [Validation(Required=false)]
                public string HeadSpecType { get; set; }

                /// <summary>
                /// <para>The Ray cluster address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-cluster-address.example.com">http://ray-cluster-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayClusterAddress")]
                [Validation(Required=false)]
                public string RayClusterAddress { get; set; }

                /// <summary>
                /// <para>The Ray Dashboard address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-dashboard-address.example.com">http://ray-dashboard-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayDashboardAddress")]
                [Validation(Required=false)]
                public string RayDashboardAddress { get; set; }

                /// <summary>
                /// <para>The Ray Grafana address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-grafana-address.example.com">http://ray-grafana-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayGrafanaAddress")]
                [Validation(Required=false)]
                public string RayGrafanaAddress { get; set; }

                /// <summary>
                /// <para>The Ray Serve public address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.3.4:8100</para>
                /// </summary>
                [NameInMap("RayServePublicAddress")]
                [Validation(Required=false)]
                public string RayServePublicAddress { get; set; }

                /// <summary>
                /// <para>The list of storage mounts.</para>
                /// </summary>
                [NameInMap("StorageMounts")]
                [Validation(Required=false)]
                public List<DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigStorageMounts> StorageMounts { get; set; }
                public class DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigStorageMounts : TeaModel {
                    /// <summary>
                    /// <para>The mount path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mnt/data01</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The storage ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("StorageId")]
                    [Validation(Required=false)]
                    public long? StorageId { get; set; }

                    [NameInMap("StorageName")]
                    [Validation(Required=false)]
                    public string StorageName { get; set; }

                }

                [NameInMap("UserDefinedRequirements")]
                [Validation(Required=false)]
                public string UserDefinedRequirements { get; set; }

                /// <summary>
                /// <para>The list of Ray worker groups.</para>
                /// </summary>
                [NameInMap("WorkerGroups")]
                [Validation(Required=false)]
                public List<DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigWorkerGroups> WorkerGroups { get; set; }
                public class DescribeDBResourceGroupResponseBodyGroupsInfoRayConfigWorkerGroups : TeaModel {
                    /// <summary>
                    /// <para>The allocation unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AllocateUnit")]
                    [Validation(Required=false)]
                    public string AllocateUnit { get; set; }

                    /// <summary>
                    /// <para>The Ray worker group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g01</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The maximum number of workers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MaxWorkerQuantity")]
                    [Validation(Required=false)]
                    public int? MaxWorkerQuantity { get; set; }

                    /// <summary>
                    /// <para>The minimum number of workers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinWorkerQuantity")]
                    [Validation(Required=false)]
                    public int? MinWorkerQuantity { get; set; }

                    /// <summary>
                    /// <para>The disk capacity per worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100G</para>
                    /// </summary>
                    [NameInMap("WorkerDiskCapacity")]
                    [Validation(Required=false)]
                    public string WorkerDiskCapacity { get; set; }

                    /// <summary>
                    /// <para>The worker specification name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>large</para>
                    /// </summary>
                    [NameInMap("WorkerSpecName")]
                    [Validation(Required=false)]
                    public string WorkerSpecName { get; set; }

                    /// <summary>
                    /// <para>The Ray worker resource type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CPU</para>
                    /// </summary>
                    [NameInMap("WorkerSpecType")]
                    [Validation(Required=false)]
                    public string WorkerSpecType { get; set; }

                }

            }

            /// <summary>
            /// <para>The job routing rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeDBResourceGroupResponseBodyGroupsInfoRules> Rules { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoRules : TeaModel {
                /// <summary>
                /// <para>The resource group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_default</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The query execution time threshold, in milliseconds (ms).</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public string QueryTime { get; set; }

                /// <summary>
                /// <para>The name of the target resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job</para>
                /// </summary>
                [NameInMap("TargetGroupName")]
                [Validation(Required=false)]
                public string TargetGroupName { get; set; }

            }

            /// <summary>
            /// <para>A reserved parameter. Not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("RunningClusterCount")]
            [Validation(Required=false)]
            public int? RunningClusterCount { get; set; }

            /// <summary>
            /// <para>The scaling policy of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AutoScaling: enables the AutoScaling automatic scaling policy.</description></item>
            /// <item><description>Disable: disables automatic scaling.</description></item>
            /// <item><description>MultiCluster: enables the MultiCluster automatic scaling policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoScaling</para>
            /// </summary>
            [NameInMap("ScalePolicy")]
            [Validation(Required=false)]
            public string ScalePolicy { get; set; }

            /// <summary>
            /// <para>The specification name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADB.MLLarge.2</para>
            /// </summary>
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            /// <summary>
            /// <para>The resource group status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>creating</b>: being created</description></item>
            /// <item><description><b>ok</b>: created</description></item>
            /// <item><description><b>pendingdelete</b>: pending deletion</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the target resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TargetResourceGroupName")]
            [Validation(Required=false)]
            public string TargetResourceGroupName { get; set; }

            /// <summary>
            /// <para>The time when the resource group was last updated, in UTC. Format: <i>yyyy-MM-ddTHH:mm:ssZ</i>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31T03:34:30Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A94B6C02-7BD4-5D67-9776-3AC8317E8DD3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
