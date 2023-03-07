// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UpdateQueueConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
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
        /// The name of the queue.
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// You can call the [ListResourceGroups](~~158855~~) operation to query the IDs of resource groups.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
