// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class StopNodesRequest : TeaModel {
        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public List<StopNodesRequestInstance> Instance { get; set; }
        public class StopNodesRequestInstance : TeaModel {
            /// <summary>
            /// The ID of the Nth node that you want to stop. Valid values of N: 1 to 100
            /// 
            /// You can call the [ListNodes](~~87161~~) operation to query the IDs of the compute nodes.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// The role of the node. Valid values:
        /// 
        /// *   Manager: management node
        /// *   Login: logon node
        /// *   Compute: compute node
        /// 
        /// Default value: Compute
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
