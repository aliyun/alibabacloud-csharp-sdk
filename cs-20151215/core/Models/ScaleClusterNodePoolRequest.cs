// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// The number of worker nodes that you want to add. For example, the current node pool contains two nodes. After the node pool is scaled out, the node pool contains four nodes. Due to the limit of the node quota, you can add at most 500 nodes in each request.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

    }

}
