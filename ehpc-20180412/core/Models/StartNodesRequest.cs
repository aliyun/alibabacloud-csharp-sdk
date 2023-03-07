// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class StartNodesRequest : TeaModel {
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
        public List<StartNodesRequestInstance> Instance { get; set; }
        public class StartNodesRequestInstance : TeaModel {
            /// <summary>
            /// The ID of the Nth node. Valid values of N: 1 to 100.
            /// 
            /// Make sure that the node is in the Stopped state. You can call the [ListNodes](~~87161~~) operation to query the status of the node.
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
