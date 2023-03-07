// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetHybridClusterConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the on-premises compute node. You can call this operation to query the configurations of the on-premises compute node.
        /// 
        /// By default, the operation queries the configurations of a cluster.
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public string Node { get; set; }

    }

}
