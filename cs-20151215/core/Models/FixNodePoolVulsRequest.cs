// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class FixNodePoolVulsRequest : TeaModel {
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        [NameInMap("rollout_policy")]
        [Validation(Required=false)]
        public FixNodePoolVulsRequestRolloutPolicy RolloutPolicy { get; set; }
        public class FixNodePoolVulsRequestRolloutPolicy : TeaModel {
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

        }

        [NameInMap("vuls")]
        [Validation(Required=false)]
        public List<string> Vuls { get; set; }

    }

}
