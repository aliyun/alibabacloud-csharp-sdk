// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UpdateNodesRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The information about the compute nodes that you want to update.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<UpdateNodesRequestInstances> Instances { get; set; }
        public class UpdateNodesRequestInstances : TeaModel {
            /// <summary>
            /// The instance ID of the compute node.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Specifies whether to enable deletion protection for the compute node.
            /// </summary>
            [NameInMap("KeepAlive")]
            [Validation(Required=false)]
            public bool? KeepAlive { get; set; }

        }

    }

}
