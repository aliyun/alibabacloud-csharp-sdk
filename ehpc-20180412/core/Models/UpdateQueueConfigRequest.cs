// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UpdateQueueConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the E-HPC cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The instance type of the node.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188592.html">ListPreferredEcsTypes</a> operation to query the recommended instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.n1.tiny</para>
        /// </summary>
        [NameInMap("ComputeInstanceType")]
        [Validation(Required=false)]
        public string ComputeInstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set. You can obtain the deployment set ID by calling the <a href="https://help.aliyun.com/document_detail/91313.html">DescribeDeploymentSets</a> operation. Only the deployment sets that use low latency policy are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp1frxuzdg87zh4pzq****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The communication mode of the elastic network interface (ENI). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: uses the TCP communication mode.</description></item>
        /// <item><description>HighPerformance: uses the remote direct memory access (RDMA) communication mode with Elastic RDMA Interface (ERI) enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// <para>The name of the queue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workq</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the IDs of resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
