// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaNodeStatistics : TeaModel {
        [NameInMap("ActualMinHyperNodeNum")]
        [Validation(Required=false)]
        public long? ActualMinHyperNodeNum { get; set; }

        [NameInMap("ActualMinNodeNum")]
        [Validation(Required=false)]
        public long? ActualMinNodeNum { get; set; }

        [NameInMap("AllocatedHyperNodeDetails")]
        [Validation(Required=false)]
        public List<AllocatedHyperNodeDetail> AllocatedHyperNodeDetails { get; set; }

        [NameInMap("AllocatedHyperNodeNum")]
        [Validation(Required=false)]
        public long? AllocatedHyperNodeNum { get; set; }

        [NameInMap("AllocatedNodeNum")]
        [Validation(Required=false)]
        public long? AllocatedNodeNum { get; set; }

        [NameInMap("EmptyNodeNum")]
        [Validation(Required=false)]
        public long? EmptyNodeNum { get; set; }

    }

}
