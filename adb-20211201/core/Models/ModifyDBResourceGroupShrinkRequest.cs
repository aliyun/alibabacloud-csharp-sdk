// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBResourceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The PromQL resource group configuration.</para>
        /// </summary>
        [NameInMap("AtmConfig")]
        [Validation(Required=false)]
        public string AtmConfigShrink { get; set; }

        /// <summary>
        /// <para>The automatic stop interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("AutoStopInterval")]
        [Validation(Required=false)]
        public string AutoStopInterval { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ClusterSizeResource")]
        [Validation(Required=false)]
        public string ClusterSizeResource { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The cluster ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The cluster ID of the Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
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
        /// <para>The engine configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;spark.adb.version\&quot;:\&quot;3.5\&quot;}</para>
        /// </summary>
        [NameInMap("EngineParams")]
        [Validation(Required=false)]
        public string EngineParamsShrink { get; set; }

        /// <summary>
        /// <para>The GPU time-sharing elastic plan.</para>
        /// </summary>
        [NameInMap("GpuElasticPlan")]
        [Validation(Required=false)]
        public string GpuElasticPlanShrink { get; set; }

        /// <summary>
        /// <para>The resource group name.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/459446.html">DescribeDBResourceGroup</a> operation to query the resource group names of a specified cluster.</para>
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
        /// <para>The resource group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Interactive</b></description></item>
        /// <item><description><b>Job</b><remarks>
        /// <para>For more information about Data Lakehouse Edition resource groups, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource group overview</a>.</para>
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
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("MaxClusterCount")]
        [Validation(Required=false)]
        public int? MaxClusterCount { get; set; }

        /// <summary>
        /// <para>The maximum reserved computing resources.</para>
        /// <list type="bullet">
        /// <item><description>If the resource group type is Interactive, the maximum reserved computing resources is the unallocated resources of the cluster, in increments of 16 ACUs.</description></item>
        /// <item><description>If the resource group type is Job, the maximum reserved computing resources is the unallocated resources of the cluster, in increments of 8 ACUs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>48ACU</para>
        /// </summary>
        [NameInMap("MaxComputeResource")]
        [Validation(Required=false)]
        public string MaxComputeResource { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("MaxGpuQuantity")]
        [Validation(Required=false)]
        public int? MaxGpuQuantity { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
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
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("MinGpuQuantity")]
        [Validation(Required=false)]
        public int? MinGpuQuantity { get; set; }

        /// <summary>
        /// <para>The Ray configuration. This parameter is required when the resource group is an AI resource group and the corresponding engine is RayCluster.</para>
        /// </summary>
        [NameInMap("RayConfig")]
        [Validation(Required=false)]
        public string RayConfigShrink { get; set; }

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
        /// <para>The job routing rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        /// <summary>
        /// <para>The resource group status. <b>starting</b> indicates that the resource group is being started. <b>stopping</b> indicates that the resource group is being stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>starting</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A reserved parameter (not applicable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter. Not applicable.</para>
        /// </summary>
        [NameInMap("TargetResourceGroupName")]
        [Validation(Required=false)]
        public string TargetResourceGroupName { get; set; }

    }

}
