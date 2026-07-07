// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateNodesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> to query the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The hardware configuration of the compute nodes.</para>
        /// </summary>
        [NameInMap("ComputeNode")]
        [Validation(Required=false)]
        public NodeTemplate ComputeNode { get; set; }

        /// <summary>
        /// <para>The number of compute nodes to add. Valid values: 1 to 99. The value must be greater than MinCount.</para>
        /// <list type="bullet">
        /// <item><description><para>If the available ECS inventory is less than MinCount, the node creation fails.</para>
        /// </description></item>
        /// <item><description><para>If the available ECS inventory is greater than or equal to MinCount but less than Count, nodes are added based on the number specified by MinCount.</para>
        /// </description></item>
        /// <item><description><para>If the available ECS inventory is greater than or equal to Count, nodes are added based on the number specified by Count.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set.
        /// You can call <a href="https://help.aliyun.com/document_detail/91313.html">DescribeDeploymentSets</a> to query the deployment set ID. Only deployment sets that use the low network latency strategy are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp1frxuzdg87zh4pzq****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The network type for communication between compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc</description></item>
        /// <item><description>eRDMA</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("HPCInterConnect")]
        [Validation(Required=false)]
        public string HPCInterConnect { get; set; }

        /// <summary>
        /// <para>The hostname prefix of the compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("HostnamePrefix")]
        [Validation(Required=false)]
        public string HostnamePrefix { get; set; }

        /// <summary>
        /// <para>The hostname suffix of the compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("HostnameSuffix")]
        [Validation(Required=false)]
        public string HostnameSuffix { get; set; }

        [NameInMap("Hostnames")]
        [Validation(Required=false)]
        public List<string> Hostnames { get; set; }

        /// <summary>
        /// <para>Specifies whether deletion protection is enabled for the compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public string KeepAlive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinCount")]
        [Validation(Required=false)]
        public int? MinCount { get; set; }

        /// <summary>
        /// <para>The name of the queue to which the compute nodes belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The name of the RAM role attached to the compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForOOSBandwidthScheduler</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The ID of the reserved node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rnp-756vlp7a</para>
        /// </summary>
        [NameInMap("ReservedNodePoolId")]
        [Validation(Required=false)]
        public string ReservedNodePoolId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1lfcjbfb099rrjn****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
