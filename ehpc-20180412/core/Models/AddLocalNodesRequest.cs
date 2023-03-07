// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddLocalNodesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The information of the local node. A JSON string that contains the HostName, IpAddress, CpuCores, and Memory (Unit: MB) of the local node.
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string Nodes { get; set; }

        /// <summary>
        /// The queue to which to add the local node.
        /// </summary>
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

    }

}
