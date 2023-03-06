// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetSuggestShrinkableNodesRequest : TeaModel {
        /// <summary>
        /// The number of nodes that you want to remove.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Specifies whether to ignore the instance status. Default value: false.
        /// </summary>
        [NameInMap("ignoreStatus")]
        [Validation(Required=false)]
        public bool? IgnoreStatus { get; set; }

        /// <summary>
        /// The type of removing nodes. WORKER indicates hot node and WORKER_WARM indicates warm node.
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

    }

}
