// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RepairClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// Specifies whether to restart the instance of the node.
        /// </summary>
        [NameInMap("auto_restart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// The list of nodes. If you do not specify nodes, all nodes in the node pool are selected.
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<RepairClusterNodePoolRequestOperations> Operations { get; set; }
        public class RepairClusterNodePoolRequestOperations : TeaModel {
            [NameInMap("args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            [NameInMap("operation_id")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

        }

    }

}
