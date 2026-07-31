// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBResourceGroupShrinkRequest : TeaModel {
        [NameInMap("AtmConfig")]
        [Validation(Required=false)]
        public string AtmConfigShrink { get; set; }

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
        public string EngineParamsShrink { get; set; }

        /// <summary>
        /// <para>The time-based scaling plan for GPUs.</para>
        /// </summary>
        [NameInMap("GpuElasticPlan")]
        [Validation(Required=false)]
        public string GpuElasticPlanShrink { get; set; }

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
        public string RayConfigShrink { get; set; }

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
        public string RulesShrink { get; set; }

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
