// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBResourceGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("AutoStopInterval")]
        [Validation(Required=false)]
        public string AutoStopInterval { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("ClusterSizeResource")]
        [Validation(Required=false)]
        public string ClusterSizeResource { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the spot instance feature for the resource group. After you enable the spot instance feature, you are charged for resources at a lower unit price but the resources are probably released. You can enable the spot instance feature only for job resource groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b></description></item>
        /// <item><description><b>False</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSpot")]
        [Validation(Required=false)]
        public bool? EnableSpot { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;spark.adb.version\&quot;:\&quot;3.5\&quot;}</para>
        /// </summary>
        [NameInMap("EngineParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> EngineParams { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/459446.html">DescribeDBResourceGroup</a> operation to query the name of a resource group in a cluster.</para>
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
        /// <item><description><b>Job</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>For information about resource groups of Data Lakehouse Edition, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource groups</a>.</para>
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
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("MaxClusterCount")]
        [Validation(Required=false)]
        public int? MaxClusterCount { get; set; }

        /// <summary>
        /// <para>The maximum amount of reserved computing resources.</para>
        /// <list type="bullet">
        /// <item><description>If GroupType is set to Interactive, the maximum amount of reserved computing resources refers to the amount of resources that are not allocated in the cluster. Set this parameter to a value in increments of 16ACU.</description></item>
        /// <item><description>If GroupType is set to Job, the maximum amount of reserved computing resources refers to the amount of resources that are not allocated in the cluster. Set this parameter to a value in increments of 8ACU.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>48ACU</para>
        /// </summary>
        [NameInMap("MaxComputeResource")]
        [Validation(Required=false)]
        public string MaxComputeResource { get; set; }

        [NameInMap("MaxGpuQuantity")]
        [Validation(Required=false)]
        public int? MaxGpuQuantity { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("MinClusterCount")]
        [Validation(Required=false)]
        public int? MinClusterCount { get; set; }

        /// <summary>
        /// <para>The minimum amount of reserved computing resources.</para>
        /// <list type="bullet">
        /// <item><description>If the GroupType parameter is set to Interactive, set the value to 16ACU.</description></item>
        /// <item><description>If GroupType is set to Job, set the value to 0ACU.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0ACU</para>
        /// </summary>
        [NameInMap("MinComputeResource")]
        [Validation(Required=false)]
        public string MinComputeResource { get; set; }

        [NameInMap("MinGpuQuantity")]
        [Validation(Required=false)]
        public int? MinGpuQuantity { get; set; }

        [NameInMap("RayConfig")]
        [Validation(Required=false)]
        public ModifyDBResourceGroupRequestRayConfig RayConfig { get; set; }
        public class ModifyDBResourceGroupRequestRayConfig : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("EnableUserEni")]
            [Validation(Required=false)]
            public bool? EnableUserEni { get; set; }

            [NameInMap("HeadAllocateUnit")]
            [Validation(Required=false)]
            public string HeadAllocateUnit { get; set; }

            [NameInMap("HeadDiskCapacity")]
            [Validation(Required=false)]
            public string HeadDiskCapacity { get; set; }

            [NameInMap("HeadSpec")]
            [Validation(Required=false)]
            public string HeadSpec { get; set; }

            [NameInMap("HeadSpecType")]
            [Validation(Required=false)]
            public string HeadSpecType { get; set; }

            [NameInMap("WorkerGroups")]
            [Validation(Required=false)]
            public List<ModifyDBResourceGroupRequestRayConfigWorkerGroups> WorkerGroups { get; set; }
            public class ModifyDBResourceGroupRequestRayConfigWorkerGroups : TeaModel {
                [NameInMap("AllocateUnit")]
                [Validation(Required=false)]
                public string AllocateUnit { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("MaxWorkerQuantity")]
                [Validation(Required=false)]
                public int? MaxWorkerQuantity { get; set; }

                [NameInMap("MinWorkerQuantity")]
                [Validation(Required=false)]
                public int? MinWorkerQuantity { get; set; }

                [NameInMap("WorkerDiskCapacity")]
                [Validation(Required=false)]
                public string WorkerDiskCapacity { get; set; }

                [NameInMap("WorkerSpecName")]
                [Validation(Required=false)]
                public string WorkerSpecName { get; set; }

                [NameInMap("WorkerSpecType")]
                [Validation(Required=false)]
                public string WorkerSpecType { get; set; }

            }

        }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The job resubmission rules.</para>
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
            /// <para>The execution duration of the query. Unit: milliseconds.</para>
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

        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>starting</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TargetResourceGroupName")]
        [Validation(Required=false)]
        public string TargetResourceGroupName { get; set; }

    }

}
