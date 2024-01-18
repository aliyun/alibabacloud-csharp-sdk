// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UpdateQueueConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The instance type of the node.
        /// 
        /// You can call the [ListPreferredEcsTypes](~~188592~~) operation to query the recommended instance types.
        /// </summary>
        [NameInMap("ComputeInstanceType")]
        [Validation(Required=false)]
        public string ComputeInstanceType { get; set; }

        /// <summary>
        /// The ID of the deployment set. You can obtain the deployment set ID by calling the [DescribeDeploymentSets](~~91313~~) operation. Only the deployment sets that use low latency policy are supported.
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// The communication model of the ENI. Valid values:
        /// 
        /// *   Standard: uses the TCP communication mode.
        /// *   HighPerformance: uses the remote direct memory access (RDMA) communication mode with the Elastic RDMA Interface (ERI) enabled.
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// The name of the queue.
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// The resource group ID.
        /// 
        /// You can call the [ListResourceGroups](~~158855~~) operation to query the IDs of resource groups.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
