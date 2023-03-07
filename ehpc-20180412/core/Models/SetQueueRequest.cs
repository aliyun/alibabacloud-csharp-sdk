// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetQueueRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Node")]
        [Validation(Required=false)]
        public List<SetQueueRequestNode> Node { get; set; }
        public class SetQueueRequestNode : TeaModel {
            /// <summary>
            /// The name of the compute node that you want to move. Valid values of N: 1 to 100.
            /// 
            /// You can call the [ListNodes](~~87161~~) operation to query the names of the compute nodes.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The name of the destination queue.
        /// 
        /// You can call the [ListQueues](~~92176~~) operation to query the queue name.
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

    }

}
