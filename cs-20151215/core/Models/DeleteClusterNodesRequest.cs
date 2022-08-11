// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodesRequest : TeaModel {
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
