// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ResetNodesRequest : TeaModel {
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
        public List<ResetNodesRequestInstance> Instance { get; set; }
        public class ResetNodesRequestInstance : TeaModel {
            /// <summary>
            /// The ID of the compute node that you want to reset. Valid values of N: 1 to 100
            /// 
            /// You can call the [ListNodes](~~87161~~) operation to query the IDs of the compute nodes.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
