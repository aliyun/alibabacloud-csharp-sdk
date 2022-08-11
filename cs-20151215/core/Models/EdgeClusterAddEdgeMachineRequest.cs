// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class EdgeClusterAddEdgeMachineRequest : TeaModel {
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

    }

}
