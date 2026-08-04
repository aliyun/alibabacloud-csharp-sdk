// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaNodeStatistics : TeaModel {
        /// <summary>
        /// <para>The guaranteed minimum number of hyper nodes available in the quota.</para>
        /// </summary>
        [NameInMap("ActualMinHyperNodeNum")]
        [Validation(Required=false)]
        public long? ActualMinHyperNodeNum { get; set; }

        /// <summary>
        /// <para>The guaranteed minimum number of nodes available in the quota.</para>
        /// </summary>
        [NameInMap("ActualMinNodeNum")]
        [Validation(Required=false)]
        public long? ActualMinNodeNum { get; set; }

        /// <summary>
        /// <para>The details of an allocated hyper node.</para>
        /// </summary>
        [NameInMap("AllocatedHyperNodeDetails")]
        [Validation(Required=false)]
        public List<AllocatedHyperNodeDetail> AllocatedHyperNodeDetails { get; set; }

        /// <summary>
        /// <para>The number of hyper nodes currently allocated from the quota.</para>
        /// </summary>
        [NameInMap("AllocatedHyperNodeNum")]
        [Validation(Required=false)]
        public long? AllocatedHyperNodeNum { get; set; }

        /// <summary>
        /// <para>The number of nodes currently allocated from the quota.</para>
        /// </summary>
        [NameInMap("AllocatedNodeNum")]
        [Validation(Required=false)]
        public long? AllocatedNodeNum { get; set; }

        /// <summary>
        /// <para>The number of allocated nodes currently idle.</para>
        /// </summary>
        [NameInMap("EmptyNodeNum")]
        [Validation(Required=false)]
        public long? EmptyNodeNum { get; set; }

    }

}
