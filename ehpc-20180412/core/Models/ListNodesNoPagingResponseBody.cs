// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesNoPagingResponseBody : TeaModel {
        /// <summary>
        /// The list of nodes.
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesNoPagingResponseBodyNodes Nodes { get; set; }
        public class ListNodesNoPagingResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesNoPagingResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesNoPagingResponseBodyNodesNodeInfo : TeaModel {
                /// <summary>
                /// The node name.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The image ID.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The node type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   uninit: The node is being installed.
                /// *   exception: An exception occurred on the node.
                /// *   running: The node is running.
                /// *   initing: The node is being initialized.
                /// *   releasing: The node is being released.
                /// *   untracking: The node is not added to the cluster.
                /// *   stopped: The node is stopped.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
