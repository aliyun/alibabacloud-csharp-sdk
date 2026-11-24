// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The number of nodes to add. For example, if the node pool currently has two nodes and you add two more, the total number of nodes becomes four. You can add a maximum of 500 nodes in a single operation due to the node quota limit of the current cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

    }

}
