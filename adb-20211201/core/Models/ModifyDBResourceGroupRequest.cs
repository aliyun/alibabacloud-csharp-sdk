// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBResourceGroupRequest : TeaModel {
        [NameInMap("AtmConfig")]
        [Validation(Required=false)]
        public ModifyDBResourceGroupRequestAtmConfig AtmConfig { get; set; }
        public class ModifyDBResourceGroupRequestAtmConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AuthNodeNum")]
            [Validation(Required=false)]
            public int? AuthNodeNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8ACU</para>
            /// </summary>
            [NameInMap("AuthNodeSpec")]
            [Validation(Required=false)]
            public string AuthNodeSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InsertNodeNum")]
            [Validation(Required=false)]
            public int? InsertNodeNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8ACU</para>
            /// </summary>
            [NameInMap("InsertNodeSpec")]
            [Validation(Required=false)]
            public string InsertNodeSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SelectNodeCacheSize")]
            [Validation(Required=false)]
            public int? SelectNodeCacheSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SelectNodeNum")]
            [Validation(Required=false)]
            public int? SelectNodeNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8ACU</para>
            /// </summary>
            [NameInMap("SelectNodeSpec")]
            [Validation(Required=false)]
            public string SelectNodeSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StorageNodeDiskSize")]
            [Validation(Required=false)]
            public int? StorageNodeDiskSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>essd_pl1</para>
            /// </summary>
            [NameInMap("StorageNodeDiskType")]
            [Validation(Required=false)]
            public string StorageNodeDiskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StorageNodeNum")]
            [Validation(Required=false)]
            public int? StorageNodeNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8ACU</para>
            /// </summary>
            [NameInMap("StorageNodeSpec")]
            [Validation(Required=false)]
            public string StorageNodeSpec { get; set; }

        }

        /// <summary>
        /// <para>The idle duration after which the resource group is automatically stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("AutoStopInterval")]
        [Validation(Required=false)]
        public string AutoStopInterval { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ClusterSizeResource")]
        [Validation(Required=false)]
        public string ClusterSizeResource { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Data Lakehouse Edition, Enterprise Edition, or Basic Edition cluster.
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
        /// <para>Specifies whether to enable the spot instance feature for the resource group. This feature provides resources at a lower unit price, but they can be reclaimed at any time. Only <c>Job</c> resource groups support this feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>True</b>: enables the spot instance feature.</para>
        /// </description></item>
        /// <item><description><para><b>False</b>: disables the spot instance feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableSpot")]
        [Validation(Required=false)]
        public bool? EnableSpot { get; set; }

        /// <summary>
        /// <para>The engine configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;spark.adb.version\&quot;:\&quot;3.5\&quot;}</para>
        /// </summary>
        [NameInMap("EngineParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> EngineParams { get; set; }

        /// <summary>
        /// <para>The time-based scaling plan for GPUs.</para>
        /// </summary>
        [NameInMap("GpuElasticPlan")]
        [Validation(Required=false)]
        public ModifyDBResourceGroupRequestGpuElasticPlan GpuElasticPlan { get; set; }
        public class ModifyDBResourceGroupRequestGpuElasticPlan : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the scaling plan immediately upon creation.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The plan is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The plan is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>A list of rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ModifyDBResourceGroupRequestGpuElasticPlanRules> Rules { get; set; }
            public class ModifyDBResourceGroupRequestGpuElasticPlanRules : TeaModel {
                /// <summary>
                /// <para>The end time of the scaling window, specified as a cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 3 * * ?</para>
                /// </summary>
                [NameInMap("EndCronExpression")]
                [Validation(Required=false)]
                public string EndCronExpression { get; set; }

                /// <summary>
                /// <para>The start time of the scaling window, specified as a cron expression. The duration between the start and end times must be at least one hour.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/459446.html">DescribeDBResourceGroup</a> operation to query the resource group name for a specific cluster.</para>
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
        /// <item><description><para><b>Interactive</b></para>
        /// </description></item>
        /// <item><description><para><b>Job</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about resource groups in Data Lakehouse Edition clusters, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource groups</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Interactive</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("MaxClusterCount")]
        [Validation(Required=false)]
        public int? MaxClusterCount { get; set; }

        /// <summary>
        /// <para>The maximum amount of reserved computing resources. The value cannot exceed the unallocated computing resources of the cluster.</para>
        /// <list type="bullet">
        /// <item><description><para>If the resource group type is <c>Interactive</c>, the value is specified in increments of 16 ACU.</para>
        /// </description></item>
        /// <item><description><para>If the resource group type is <c>Job</c>, the value is specified in increments of 8 ACU.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>48ACU</para>
        /// </summary>
        [NameInMap("MaxComputeResource")]
        [Validation(Required=false)]
        public string MaxComputeResource { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("MaxGpuQuantity")]
        [Validation(Required=false)]
        public int? MaxGpuQuantity { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("MinClusterCount")]
        [Validation(Required=false)]
        public int? MinClusterCount { get; set; }

        /// <summary>
        /// <para>The minimum amount of reserved computing resources.</para>
        /// <list type="bullet">
        /// <item><description><para>If the resource group type is <c>Interactive</c>, the minimum amount of reserved computing resources is 16 ACU.</para>
        /// </description></item>
        /// <item><description><para>If the resource group type is <c>Job</c>, the minimum amount of reserved computing resources is 0 ACU.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0ACU</para>
        /// </summary>
        [NameInMap("MinComputeResource")]
        [Validation(Required=false)]
        public string MinComputeResource { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("MinGpuQuantity")]
        [Validation(Required=false)]
        public int? MinGpuQuantity { get; set; }

        /// <summary>
        /// <para>The Ray configuration. This parameter is required if the resource group is an AI group and uses a Ray cluster as its engine.</para>
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
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app01</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The application type.</para>
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
                    /// <para>The image name.</para>
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
            /// <para>The type of the Ray cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BASIC</b>: A basic, non-high-availability cluster.</para>
            /// </description></item>
            /// <item><description><para><b>HIGH_AVAILABILITY</b>: A high-availability cluster.</para>
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
            /// <para>Specifies whether to enable the ENI.</para>
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
            /// <para>The specifications of the head node.</para>
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
            /// <para>A list of storage mounts.</para>
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
                /// <para>The storage ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StorageId")]
                [Validation(Required=false)]
                public long? StorageId { get; set; }

            }

            [NameInMap("UserDefinedRequirements")]
            [Validation(Required=false)]
            public string UserDefinedRequirements { get; set; }

            /// <summary>
            /// <para>A list of configurations for Ray worker groups.</para>
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
                /// <para>The maximum number of worker nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxWorkerQuantity")]
                [Validation(Required=false)]
                public int? MaxWorkerQuantity { get; set; }

                /// <summary>
                /// <para>The minimum number of worker nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinWorkerQuantity")]
                [Validation(Required=false)]
                public int? MinWorkerQuantity { get; set; }

                /// <summary>
                /// <para>The disk size of a worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100G</para>
                /// </summary>
                [NameInMap("WorkerDiskCapacity")]
                [Validation(Required=false)]
                public string WorkerDiskCapacity { get; set; }

                /// <summary>
                /// <para>The specifications of a worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xlarge</para>
                /// </summary>
                [NameInMap("WorkerSpecName")]
                [Validation(Required=false)]
                public string WorkerSpecName { get; set; }

                /// <summary>
                /// <para>The resource type of a worker node.</para>
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
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query available regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The job submission rules.</para>
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
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        /// <summary>
        /// <para>The desired state of the resource group. Specify <b>starting</b> to start the resource group or <b>stopping</b> to stop it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>starting</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("TargetResourceGroupName")]
        [Validation(Required=false)]
        public string TargetResourceGroupName { get; set; }

    }

}
