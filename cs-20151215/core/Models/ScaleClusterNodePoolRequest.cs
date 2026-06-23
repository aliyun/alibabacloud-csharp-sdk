// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The number of nodes to add. For example, if the node pool currently has 2 nodes and you add 2 more, the node pool will have 4 nodes. Due to the node quota limit of the current cluster, you can add up to 500 nodes in a single operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

    }

}
