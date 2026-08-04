// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class AllocatedHyperNodeDetail : TeaModel {
        /// <summary>
        /// <para>The number of allocated nodes in the hyper node.</para>
        /// </summary>
        [NameInMap("AllocatedNodeNum")]
        [Validation(Required=false)]
        public long? AllocatedNodeNum { get; set; }

        /// <summary>
        /// <para>The number of idle nodes in the hyper node.</para>
        /// </summary>
        [NameInMap("EmptyNodeNum")]
        [Validation(Required=false)]
        public long? EmptyNodeNum { get; set; }

        /// <summary>
        /// <para>The name of the hyper node.</para>
        /// </summary>
        [NameInMap("HyperNodeName")]
        [Validation(Required=false)]
        public string HyperNodeName { get; set; }

        /// <summary>
        /// <para>The total number of nodes in the hyper node.</para>
        /// </summary>
        [NameInMap("TotalNodeNum")]
        [Validation(Required=false)]
        public long? TotalNodeNum { get; set; }

    }

}
