// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateDBResourceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The PromQL resource group configuration.</para>
        /// </summary>
        [NameInMap("AtmConfig")]
        [Validation(Required=false)]
        public string AtmConfigShrink { get; set; }

        /// <summary>
        /// <para>The auto-stop interval, in minutes (m).</para>
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
        /// <para>The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.</para>
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
        public string EngineParamsShrink { get; set; }

        /// <summary>
        /// <para>The GPU time-based elastic plan.</para>
        /// </summary>
        [NameInMap("GpuElasticPlan")]
        [Validation(Required=false)]
        public string GpuElasticPlanShrink { get; set; }

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
        /// <para>For more information about Data Lakehouse Edition resource groups, see <a href="https://help.aliyun.com/document_detail/428610.html">Introduction to resource groups (Data Lakehouse Edition)</a>.</para>
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
        /// <para>The maximum reserved computing resources, in ACUs.</para>
        /// <list type="bullet">
        /// <item><description>If the resource group type is Interactive, the maximum reserved computing resources are the unallocated resources of the cluster, in increments of 16 ACUs.</description></item>
        /// <item><description>If the resource group type is Job, the maximum reserved computing resources are the unallocated resources of the cluster, in increments of 8 ACUs.</description></item>
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
        /// <para>The minimum reserved computing resources, in ACUs.</para>
        /// <list type="bullet">
        /// <item><description>If the resource group type is Interactive, the minimum reserved computing resources are 16 ACUs.</description></item>
        /// <item><description>If the resource group type is Job, the minimum reserved computing resources are 0 ACUs.</description></item>
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
        /// <para>The Ray configuration information.</para>
        /// <remarks>
        /// <para>This parameter is required when the resource group is an AI resource group and the corresponding engine is RayCluster.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RayConfig")]
        [Validation(Required=false)]
        public string RayConfigShrink { get; set; }

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
        public string RulesShrink { get; set; }

        /// <summary>
        /// <para>The scaling policy of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoScaling: enables the AutoScaling auto-scaling policy.</description></item>
        /// <item><description>Disable: disables auto-scaling.</description></item>
        /// <item><description>MultiCluster: enables the MultiCluster auto-scaling policy.</description></item>
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
