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
                /// <para>The number of insert nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InsertNodeNum")]
                [Validation(Required=false)]
                public string InsertNodeNum { get; set; }

                /// <summary>
                /// <para>The insert node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ACU</para>
                /// </summary>
                [NameInMap("InsertNodeSpec")]
                [Validation(Required=false)]
                public string InsertNodeSpec { get; set; }

                /// <summary>
                /// <para>The cache size of the query node.</para>
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
                /// <para>The disk size of the storage node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("StorageNodeDiskSize")]
                [Validation(Required=false)]
                public string StorageNodeDiskSize { get; set; }

                /// <summary>
                /// <para>The disk type of the storage node.</para>
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
            /// <para>The auto-stop interval. The value is in the format of a number followed by &quot;m&quot;, which indicates minutes. Valid values range from 0m or 5m to 10080m. A value of 0m indicates that the resource group does not automatically stop.</para>
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
            /// <para>The reserved parameter. This parameter is not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            /// <summary>
            /// <para>The reserved parameter. This parameter is not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("ClusterSizeResource")]
            [Validation(Required=false)]
            public string ClusterSizeResource { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created. The time is displayed in UTC in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-29T03:34:30Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The minimum elastic compute resources. Unit: ACU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ElasticMinComputeResource")]
            [Validation(Required=false)]
            public string ElasticMinComputeResource { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the spot instance feature for the resource group. After you enable this feature, the unit price of resources decreases, but the instances may be released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>True</b>: enables the spot instance feature.</description></item>
            /// <item><description><b>False</b>: disables the spot instance feature.</description></item>
            /// </list>
            /// <para>This parameter can be set to True only for Job resource groups.</para>
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
            /// <para>The GPU time-based elastic plan.</para>
            /// </summary>
            [NameInMap("GpuElasticPlan")]
            [Validation(Required=false)]
            public DescribeDBResourceGroupResponseBodyGroupsInfoGpuElasticPlan GpuElasticPlan { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoGpuElasticPlan : TeaModel {
                /// <summary>
                /// <para>Indicates whether the GPU time-based elastic plan is enabled.</para>
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
                    /// <para>The end time in cron expression format. The interval must be no less than 1 hour.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0 3 * * ?</para>
                    /// </summary>
                    [NameInMap("EndCronExpression")]
                    [Validation(Required=false)]
                    public string EndCronExpression { get; set; }

                    /// <summary>
                    /// <para>The start time in cron expression format. The interval must be no less than 1 hour.</para>
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
            /// <para>The name of the resource group.</para>
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
            /// <para>For more information about Data Lakehouse Edition resource groups, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource group overview (Data Lakehouse Edition)</a>.</para>
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
            /// <para>The reserved parameter. This parameter is not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("MaxClusterCount")]
            [Validation(Required=false)]
            public int? MaxClusterCount { get; set; }

            /// <summary>
            /// <para>The maximum reserved compute resources. Unit: ACU.</para>
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
            /// <para>The message of the job delivery rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The reserved parameter. This parameter is not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("MinClusterCount")]
            [Validation(Required=false)]
            public int? MinClusterCount { get; set; }

            /// <summary>
            /// <para>The minimum reserved compute resources. Unit: ACU.</para>
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
                    /// <para>The name of the Ray application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>app01</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The type of the Ray application.</para>
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
                        /// <para>The large language model (LLM).</para>
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
                /// <item><description><para><b>BASIC</b>: the basic type, which is not highly available.</para>
                /// </description></item>
                /// <item><description><para><b>HIGH_AVAILABILITY</b>: the high-availability type.</para>
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
                /// <para>Specifies whether to enable the elastic network interface (ENI).</para>
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
                /// <para>The disk size of the head node.</para>
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
                /// <para>The address of the Ray cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-cluster-address.example.com">http://ray-cluster-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayClusterAddress")]
                [Validation(Required=false)]
                public string RayClusterAddress { get; set; }

                /// <summary>
                /// <para>The address of the Ray dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-dashboard-address.example.com">http://ray-dashboard-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayDashboardAddress")]
                [Validation(Required=false)]
                public string RayDashboardAddress { get; set; }

                /// <summary>
                /// <para>The address of Ray Grafana.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-grafana-address.example.com">http://ray-grafana-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayGrafanaAddress")]
                [Validation(Required=false)]
                public string RayGrafanaAddress { get; set; }

                /// <summary>
                /// <para>The public endpoint of Ray Serve.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.3.4:8100</para>
                /// </summary>
                [NameInMap("RayServePublicAddress")]
                [Validation(Required=false)]
                public string RayServePublicAddress { get; set; }

                /// <summary>
                /// <para>The list of mounted storage.</para>
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

                    /// <summary>
                    /// <para>The name of the mounted storage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>training-data</para>
                    /// </summary>
                    [NameInMap("StorageName")]
                    [Validation(Required=false)]
                    public string StorageName { get; set; }

                }

                /// <summary>
                /// <para>The custom Python dependencies for RayCluster. Specify the content in the requirements.txt format, with one pip dependency per line. A maximum of 200 lines are allowed, and each line cannot exceed 512 characters. Version constraints, extras, PEP 440 direct URLs, and # comments are supported, but shell metacharacters are not supported. This parameter applies only to AI resource groups of the RayCluster type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>numpy==1.24.0</para>
                /// </summary>
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
                    /// <para>The name of the Ray worker group.</para>
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
                    /// <para>The disk size of each worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100G</para>
                    /// </summary>
                    [NameInMap("WorkerDiskCapacity")]
                    [Validation(Required=false)]
                    public string WorkerDiskCapacity { get; set; }

                    /// <summary>
                    /// <para>The specification of the worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>large</para>
                    /// </summary>
                    [NameInMap("WorkerSpecName")]
                    [Validation(Required=false)]
                    public string WorkerSpecName { get; set; }

                    /// <summary>
                    /// <para>The resource type of the Ray worker.</para>
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
            /// <para>The job delivery rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeDBResourceGroupResponseBodyGroupsInfoRules> Rules { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoRules : TeaModel {
                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_default</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The threshold for query execution time. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public string QueryTime { get; set; }

                /// <summary>
                /// <para>The name of the destination resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job</para>
                /// </summary>
                [NameInMap("TargetGroupName")]
                [Validation(Required=false)]
                public string TargetGroupName { get; set; }

            }

            /// <summary>
            /// <para>The reserved parameter. This parameter is not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("RunningClusterCount")]
            [Validation(Required=false)]
            public int? RunningClusterCount { get; set; }

            /// <summary>
            /// <para>The scale-out policy of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AutoScaling: enables the AutoScaling policy.</description></item>
            /// <item><description>Disable: disables auto scaling.</description></item>
            /// <item><description>MultiCluster: enables the MultiCluster policy.</description></item>
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
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: The resource group is being created.</description></item>
            /// <item><description><b>Running</b>: The resource group is running.</description></item>
            /// <item><description><b>Scaling</b>: The resource group is being scaled.</description></item>
            /// <item><description><b>Deleting</b>: The resource group is being deleted.</description></item>
            /// <item><description><b>Deleted</b>: The resource group is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the destination resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TargetResourceGroupName")]
            [Validation(Required=false)]
            public string TargetResourceGroupName { get; set; }

            /// <summary>
            /// <para>The time when the resource group was updated. The time is displayed in UTC in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format.</para>
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
