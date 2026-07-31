// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateDBResourceGroupRequest : TeaModel {
        [NameInMap("AtmConfig")]
        [Validation(Required=false)]
        public CreateDBResourceGroupRequestAtmConfig AtmConfig { get; set; }
        public class CreateDBResourceGroupRequestAtmConfig : TeaModel {
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
        /// <para>The automatic stop interval. Unit: minutes (m).</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
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
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClusterSizeResource")]
        [Validation(Required=false)]
        public string ClusterSizeResource { get; set; }

        /// <summary>
        /// <para>The ID of the Dedicated Edition, Basic Edition, or Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the spot instance feature for the resource group. After the spot instance feature is enabled, the unit price of resources is reduced, but the resources may be released. Only Job resource groups support this feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: enables the spot instance feature.</description></item>
        /// <item><description><b>False</b>: disables the spot instance feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableSpot")]
        [Validation(Required=false)]
        public bool? EnableSpot { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB</b> (default): the AnalyticDB for MySQL engine.</description></item>
        /// <item><description><b>SparkWarehouse</b>: the SparkWarehouse engine.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SparkWarehouse</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

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
        /// <para>The GPU time-sharing elastic plan.</para>
        /// </summary>
        [NameInMap("GpuElasticPlan")]
        [Validation(Required=false)]
        public CreateDBResourceGroupRequestGpuElasticPlan GpuElasticPlan { get; set; }
        public class CreateDBResourceGroupRequestGpuElasticPlan : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the elastic plan immediately after creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the elastic plan immediately.</description></item>
            /// <item><description>false: does not enable the elastic plan.</description></item>
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
            public List<CreateDBResourceGroupRequestGpuElasticPlanRules> Rules { get; set; }
            public class CreateDBResourceGroupRequestGpuElasticPlanRules : TeaModel {
                /// <summary>
                /// <para>The end time as a cron expression. The interval must be at least 1 hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 3 * * ?</para>
                /// </summary>
                [NameInMap("EndCronExpression")]
                [Validation(Required=false)]
                public string EndCronExpression { get; set; }

                /// <summary>
                /// <para>The start time as a cron expression. The interval must be at least 1 hour.</para>
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
        /// <list type="bullet">
        /// <item><description>The name can be up to 255 characters in length.</description></item>
        /// <item><description>The name must start with a digit, an uppercase letter, or a lowercase letter.</description></item>
        /// <item><description>The name can contain digits, uppercase letters, lowercase letters, hyphens (-), and underscores (_).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Interactive</b></description></item>
        /// <item><description><b>Job</b><remarks>
        /// <para>For more information about Data Lakehouse Edition resource groups, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource group overview (Data Lakehouse Edition)</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("MaxClusterCount")]
        [Validation(Required=false)]
        public int? MaxClusterCount { get; set; }

        /// <summary>
        /// <para>The maximum amount of reserved computing resources. Unit: ACUs.</para>
        /// <list type="bullet">
        /// <item><description>If the resource group type is Interactive, the maximum reserved computing resources is the current unallocated resources of the cluster, in increments of 16 ACUs.</description></item>
        /// <item><description>If the resource group type is Job, the maximum reserved computing resources is the current unallocated resources of the cluster, in increments of 8 ACUs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>48ACU</para>
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
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("MinClusterCount")]
        [Validation(Required=false)]
        public int? MinClusterCount { get; set; }

        /// <summary>
        /// <para>The minimum amount of reserved computing resources. Unit: ACUs.</para>
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
        /// <para>The minimum number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinGpuQuantity")]
        [Validation(Required=false)]
        public int? MinGpuQuantity { get; set; }

        /// <summary>
        /// <para>The Ray configuration.</para>
        /// <remarks>
        /// <para>This parameter is required when the resource group is an AI resource group and the corresponding engine is RayCluster.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RayConfig")]
        [Validation(Required=false)]
        public CreateDBResourceGroupRequestRayConfig RayConfig { get; set; }
        public class CreateDBResourceGroupRequestRayConfig : TeaModel {
            /// <summary>
            /// <para>The Ray cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASIC: basic type, non-high-availability</description></item>
            /// <item><description>HIGH_AVAILABILITY: high-availability type</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable user ENI connectivity.</para>
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

            [NameInMap("UserDefinedRequirements")]
            [Validation(Required=false)]
            public string UserDefinedRequirements { get; set; }

            /// <summary>
            /// <para>The list of Ray worker group configurations.</para>
            /// </summary>
            [NameInMap("WorkerGroups")]
            [Validation(Required=false)]
            public List<CreateDBResourceGroupRequestRayConfigWorkerGroups> WorkerGroups { get; set; }
            public class CreateDBResourceGroupRequestRayConfigWorkerGroups : TeaModel {
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612393.html">DescribeRegions</a> operation to query the region IDs of AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The job routing rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateDBResourceGroupRequestRules> Rules { get; set; }
        public class CreateDBResourceGroupRequestRules : TeaModel {
            /// <summary>
            /// <para>The name of the resource group.</para>
            /// <list type="bullet">
            /// <item><description>The name can be up to 255 characters in length.</description></item>
            /// <item><description>The name must start with a digit, an uppercase letter, or a lowercase letter.</description></item>
            /// <item><description>The name can contain digits, uppercase letters, lowercase letters, hyphens (-), and underscores (_).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test_group</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The query execution time threshold. Unit: milliseconds (ms).</para>
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
        /// <para>The name of the destination resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TargetResourceGroupName")]
        [Validation(Required=false)]
        public string TargetResourceGroupName { get; set; }

    }

}
