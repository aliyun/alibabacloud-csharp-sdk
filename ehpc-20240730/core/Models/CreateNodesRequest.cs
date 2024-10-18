// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateNodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The hardware configurations of the compute nodes.</para>
        /// </summary>
        [NameInMap("ComputeNode")]
        [Validation(Required=false)]
        public NodeTemplate ComputeNode { get; set; }

        /// <summary>
        /// <para>The number of compute nodes that you want to add. Valid values: 1 to 99. The MinCount value must be smaller than the Count value.</para>
        /// <list type="bullet">
        /// <item><description>If the number of available Elastic Compute Service (ECS) instances is smaller than the MinCount value, the nodes fail to be added.</description></item>
        /// <item><description>If the number of available ECS instances is larger than the MinCount value but smaller than the Count value, nodes are added based on the MinCount value.</description></item>
        /// <item><description>If the number of available ECS instances is larger than the Count value, nodes are added based on the Count value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The type of the network between compute nodes. Valid values:</para>
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
        /// <para>The hostname prefix of the added compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("HostnamePrefix")]
        [Validation(Required=false)]
        public string HostnamePrefix { get; set; }

        /// <summary>
        /// <para>The hostname suffix of the added compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("HostnameSuffix")]
        [Validation(Required=false)]
        public string HostnameSuffix { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the added compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public string KeepAlive { get; set; }

        /// <summary>
        /// <para>The name of the queue for which you want to create compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) role to be assumed by the added nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForOOSBandwidthScheduler</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to be used by the added nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1lfcjbfb099rrjn****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
