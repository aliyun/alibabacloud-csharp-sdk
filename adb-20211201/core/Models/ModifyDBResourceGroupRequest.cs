// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The PromQL resource group configuration.</para>
        /// </summary>
        [NameInMap("AtmConfig")]
        [Validation(Required=false)]
        public ModifyDBResourceGroupRequestAtmConfig AtmConfig { get; set; }
        public class ModifyDBResourceGroupRequestAtmConfig : TeaModel {
            /// <summary>
            /// <para>The number of authentication nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AuthNodeNum")]
            [Validation(Required=false)]
            public int? AuthNodeNum { get; set; }

            /// <summary>
            /// <para>The authentication node specifications ([0-9+] ACU).</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("InsertNodeNum")]
            [Validation(Required=false)]
            public int? InsertNodeNum { get; set; }

            /// <summary>
            /// <para>The insert node specifications ([0-9+] ACU).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8ACU</para>
            /// </summary>
            [NameInMap("InsertNodeSpec")]
            [Validation(Required=false)]
            public string InsertNodeSpec { get; set; }

            /// <summary>
            /// <para>The query node cache size (GB).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SelectNodeCacheSize")]
            [Validation(Required=false)]
            public int? SelectNodeCacheSize { get; set; }

            /// <summary>
            /// <para>The number of query nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SelectNodeNum")]
            [Validation(Required=false)]
            public int? SelectNodeNum { get; set; }

            /// <summary>
            /// <para>The query node specifications ([0-9+] ACU).</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("StorageNodeDiskSize")]
            [Validation(Required=false)]
            public int? StorageNodeDiskSize { get; set; }

            /// <summary>
            /// <para>The storage node disk type (essd_pl1, essd_pl2).</para>
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
            public int? StorageNodeNum { get; set; }

            /// <summary>
            /// <para>The storage node specifications ([0-9+] ACU).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8ACU</para>
            /// </summary>
            [NameInMap("StorageNodeSpec")]
            [Validation(Required=false)]
            public string StorageNodeSpec { get; set; }

        }

        /// <summary>
        /// <para>The auto-stop time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("AutoStopInterval")]
        [Validation(Required=false)]
        public string AutoStopInterval { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ClusterSizeResource")]
        [Validation(Required=false)]
        public string ClusterSizeResource { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the spot instance feature for the resource group. After you enable this feature, the unit price of resources decreases, but the resources may be released. This feature can be enabled only for Job resource groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Enables the spot instance feature.</description></item>
        /// <item><description><b>False</b>: Disables the spot instance feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableSpot")]
        [Validation(Required=false)]
        public bool? EnableSpot { get; set; }

        /// <summary>
        /// <para>The engine configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;spark.adb.version\&quot;:\&quot;3.5\&quot;}</para>
        /// </summary>
        [NameInMap("EngineParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> EngineParams { get; set; }

        /// <summary>
        /// <para>The GPU time-based elastic plan.</para>
        /// </summary>
        [NameInMap("GpuElasticPlan")]
        [Validation(Required=false)]
        public ModifyDBResourceGroupRequestGpuElasticPlan GpuElasticPlan { get; set; }
        public class ModifyDBResourceGroupRequestGpuElasticPlan : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the elastic plan immediately after creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enables the elastic plan immediately.</description></item>
            /// <item><description><b>false</b>: Does not enable the elastic plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ModifyDBResourceGroupRequestGpuElasticPlanRules> Rules { get; set; }
            public class ModifyDBResourceGroupRequestGpuElasticPlanRules : TeaModel {
                /// <summary>
                /// <para>The end time specified by a cron expression. The interval must be at least 1 hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 3 * * ?</para>
                /// </summary>
                [NameInMap("EndCronExpression")]
                [Validation(Required=false)]
                public string EndCronExpression { get; set; }

                /// <summary>
                /// <para>The start time specified by a cron expression. The interval must be at least 1 hour.</para>
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
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/459446.html">DescribeDBResourceGroup</a> operation to query the name of the resource group for a specified cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Interactive</b></description></item>
        /// <item><description><b>Job</b><remarks>
        /// <para>For more information about Data Lakehouse Edition resource groups, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource groups</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Interactive</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxClusterCount")]
        [Validation(Required=false)]
        public int? MaxClusterCount { get; set; }

        /// <summary>
        /// <para>The maximum reserved computing resources.</para>
        /// <list type="bullet">
        /// <item><description>If the resource group type is Interactive, the maximum reserved computing resources is the currently unallocated resources of the cluster, and the step size is 16 ACUs.</description></item>
        /// <item><description>If the resource group type is Job, the maximum reserved computing resources is the currently unallocated resources of the cluster, and the step size is 8 ACUs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>48ACU</para>
        /// </summary>
        [NameInMap("MaxComputeResource")]
        [Validation(Required=false)]
        public string MaxComputeResource { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("MaxGpuQuantity")]
        [Validation(Required=false)]
        public int? MaxGpuQuantity { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MinClusterCount")]
        [Validation(Required=false)]
        public int? MinClusterCount { get; set; }

        /// <summary>
        /// <para>The minimum reserved computing resources.</para>
        /// <list type="bullet">
        /// <item><description>If the resource group type is Interactive, the minimum reserved computing resources is 16 ACUs.</description></item>
        /// <item><description>If the resource group type is Job, the minimum reserved computing resources is 0 ACUs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0ACU</para>
        /// </summary>
        [NameInMap("MinComputeResource")]
        [Validation(Required=false)]
        public string MinComputeResource { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("MinGpuQuantity")]
        [Validation(Required=false)]
        public int? MinGpuQuantity { get; set; }

        /// <summary>
        /// <para>The Ray configuration information. This parameter is required when the resource group is an AI resource group and the corresponding engine is RayCluster.</para>
        /// </summary>
        [NameInMap("RayConfig")]
        [Validation(Required=false)]
        public ModifyDBResourceGroupRequestRayConfig RayConfig { get; set; }
        public class ModifyDBResourceGroupRequestRayConfig : TeaModel {
            /// <summary>
            /// <para>The Ray application configuration.</para>
            /// </summary>
            [NameInMap("AppConfig")]
            [Validation(Required=false)]
            public ModifyDBResourceGroupRequestRayConfigAppConfig AppConfig { get; set; }
            public class ModifyDBResourceGroupRequestRayConfigAppConfig : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app01</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The type of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IsaacLab</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The image configuration.</para>
                /// </summary>
                [NameInMap("ImageSelector")]
                [Validation(Required=false)]
                public ModifyDBResourceGroupRequestRayConfigAppConfigImageSelector ImageSelector { get; set; }
                public class ModifyDBResourceGroupRequestRayConfigAppConfigImageSelector : TeaModel {
                    /// <summary>
                    /// <para>The name of the image.</para>
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
            /// <para>The type of the Ray cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>BASIC: Basic type, non-high-availability.</para>
            /// </description></item>
            /// <item><description><para>HIGH_AVAILABILITY: High-availability type.</para>
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
            /// <para>Specifies whether to enable ENI.</para>
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
            /// <para>100G</para>
            /// </summary>
            [NameInMap("HeadDiskCapacity")]
            [Validation(Required=false)]
            public string HeadDiskCapacity { get; set; }

            /// <summary>
            /// <para>The node specifications of the head node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlarge</para>
            /// </summary>
            [NameInMap("HeadSpec")]
            [Validation(Required=false)]
            public string HeadSpec { get; set; }

            /// <summary>
            /// <para>The resource type of the head node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("HeadSpecType")]
            [Validation(Required=false)]
            public string HeadSpecType { get; set; }

            /// <summary>
            /// <para>The list of storage mounts.</para>
            /// </summary>
            [NameInMap("StorageMounts")]
            [Validation(Required=false)]
            public List<ModifyDBResourceGroupRequestRayConfigStorageMounts> StorageMounts { get; set; }
            public class ModifyDBResourceGroupRequestRayConfigStorageMounts : TeaModel {
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
                /// <para>The ID of the storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StorageId")]
                [Validation(Required=false)]
                public long? StorageId { get; set; }

                /// <summary>
                /// <para>The name of the storage to mount. You must specify either this parameter or StorageId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>training-data</para>
                /// </summary>
                [NameInMap("StorageName")]
                [Validation(Required=false)]
                public string StorageName { get; set; }

            }

            /// <summary>
            /// <para>The custom Python dependencies for RayCluster. The content must be in the requirements.txt format, with one pip dependency per line. A maximum of 200 lines are allowed, and each line cannot exceed 512 characters. Version constraints, extras, PEP 440 direct URLs, and # comments are supported, but shell metacharacters are not supported. This parameter applies only to AI resource groups of the RayCluster type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>numpy==1.24.0</para>
            /// </summary>
            [NameInMap("UserDefinedRequirements")]
            [Validation(Required=false)]
            public string UserDefinedRequirements { get; set; }

            /// <summary>
            /// <para>The list of Ray worker group configuration information.</para>
            /// </summary>
            [NameInMap("WorkerGroups")]
            [Validation(Required=false)]
            public List<ModifyDBResourceGroupRequestRayConfigWorkerGroups> WorkerGroups { get; set; }
            public class ModifyDBResourceGroupRequestRayConfigWorkerGroups : TeaModel {
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
                /// <para>The name of the worker group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The maximum number of workers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
                /// <para>The disk size of the worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100G</para>
                /// </summary>
                [NameInMap("WorkerDiskCapacity")]
                [Validation(Required=false)]
                public string WorkerDiskCapacity { get; set; }

                /// <summary>
                /// <para>The node specifications of the worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xlarge</para>
                /// </summary>
                [NameInMap("WorkerSpecName")]
                [Validation(Required=false)]
                public string WorkerSpecName { get; set; }

                /// <summary>
                /// <para>The resource type of the worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GPU</para>
                /// </summary>
                [NameInMap("WorkerSpecType")]
                [Validation(Required=false)]
                public string WorkerSpecType { get; set; }

            }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the region ID of a specified cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The job delivery rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ModifyDBResourceGroupRequestRules> Rules { get; set; }
        public class ModifyDBResourceGroupRequestRules : TeaModel {
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
            /// <para>The threshold for query execution time, in milliseconds.</para>
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
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        /// <summary>
        /// <para>The status of the resource group. <b>starting</b> indicates that the resource group is being started. <b>stopping</b> indicates that the resource group is being stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>starting</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("TargetResourceGroupName")]
        [Validation(Required=false)]
        public string TargetResourceGroupName { get; set; }

    }

}
