// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteNodesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public List<DeleteNodesRequestInstance> Instance { get; set; }
        public class DeleteNodesRequestInstance : TeaModel {
            /// <summary>
            /// The ID of the compute node that you want to delete. Valid values of N: 1 to 100.
            /// 
            /// You can call the [DescribeCluster](~~87126~~) operation to query the IDs of the nodes in the cluster.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// Specifies whether to release the instances that are created by using E-HPC.
        /// 
        /// Default value: true
        /// </summary>
        [NameInMap("ReleaseInstance")]
        [Validation(Required=false)]
        public bool? ReleaseInstance { get; set; }

        /// <summary>
        /// Specifies whether to directly delete the node. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

    }

}
