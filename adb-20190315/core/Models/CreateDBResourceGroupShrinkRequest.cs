// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateDBResourceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. The client generates this value to make sure that it is unique among different requests. The token is case-sensitive and cannot exceed 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-t7241****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The mode of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Disable</b> (default): regular mode.</para>
        /// </description></item>
        /// <item><description><para><b>AutoScale</b>: auto-scaling mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoScale</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>The resource specifications of a single cluster, in ACU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16ACU</para>
        /// </summary>
        [NameInMap("ClusterSizeResource")]
        [Validation(Required=false)]
        public string ClusterSizeResource { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all Data Warehouse Edition clusters in the destination region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The engine of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AnalyticDB</b> (default): the AnalyticDB for MySQL engine.</para>
        /// </description></item>
        /// <item><description><para><b>SparkWarehouse</b>: the SparkWarehouse engine.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AnalyticDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The configuration parameters for the Spark application. These parameters apply to all Spark jobs that are executed in the resource group. To configure parameters for a specific Spark job, set the parameters in the code when you submit the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;spark.adb.version\&quot;:\&quot;3.5\&quot;}</para>
        /// </summary>
        [NameInMap("EngineParams")]
        [Validation(Required=false)]
        public string EngineParamsShrink { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <list type="bullet">
        /// <item><description><para>The name can be up to 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name must start with a digit or an uppercase letter.</para>
        /// </description></item>
        /// <item><description><para>The name can contain digits, uppercase letters, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_GROUP</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>interactive</b> (default): interactive query mode.</para>
        /// </description></item>
        /// <item><description><para><b>batch</b>: batch query mode.</para>
        /// </description></item>
        /// <item><description><para><b>Job</b>: offline job mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>interactive</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The maximum number of clusters that can run in the resource group. The maximum value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxClusterCount")]
        [Validation(Required=false)]
        public int? MaxClusterCount { get; set; }

        /// <summary>
        /// <para>The maximum reserved computing resources, in ACU.</para>
        /// <list type="bullet">
        /// <item><description><para>If the resource group type is Interactive, the maximum reserved computing resources are the current unallocated resources of the cluster. The step size is 16 ACU.</para>
        /// </description></item>
        /// <item><description><para>If the resource group type is Job, the maximum reserved computing resources are the current unallocated resources of the cluster. The step size is 8 ACU.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>32ACU</para>
        /// </summary>
        [NameInMap("MaxComputeResource")]
        [Validation(Required=false)]
        public string MaxComputeResource { get; set; }

        /// <summary>
        /// <para>The minimum number of clusters that must run in the resource group. The minimum value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinClusterCount")]
        [Validation(Required=false)]
        public int? MinClusterCount { get; set; }

        /// <summary>
        /// <para>The minimum reserved computing resources, in ACU.</para>
        /// <list type="bullet">
        /// <item><description><para>If the resource group type is Interactive, the minimum reserved computing resources are 16 ACU.</para>
        /// </description></item>
        /// <item><description><para>If the resource group type is Job, the minimum reserved computing resources are 0 ACU.</para>
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
        /// <para>The number of nodes. The default value is 0.</para>
        /// <list type="bullet">
        /// <item><description><para>The resources of one node are 16 cores and 64 GB.</para>
        /// </description></item>
        /// <item><description><para>The number of nodes cannot be too large. The value must meet the following condition: Number of nodes × (16 cores and 64 GB) ≤ Remaining available resources of the cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public int? NodeNum { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
