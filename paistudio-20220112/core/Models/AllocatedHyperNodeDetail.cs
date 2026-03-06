// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class AllocatedHyperNodeDetail : TeaModel {
        [NameInMap("AllocatedNodeNum")]
        [Validation(Required=false)]
        public long? AllocatedNodeNum { get; set; }

        [NameInMap("EmptyNodeNum")]
        [Validation(Required=false)]
        public long? EmptyNodeNum { get; set; }

        [NameInMap("HyperNodeName")]
        [Validation(Required=false)]
        public string HyperNodeName { get; set; }

        [NameInMap("TotalNodeNum")]
        [Validation(Required=false)]
        public long? TotalNodeNum { get; set; }

    }

}
