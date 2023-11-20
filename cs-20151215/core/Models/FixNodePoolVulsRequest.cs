// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class FixNodePoolVulsRequest : TeaModel {
        [NameInMap("auto_restart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// The names of the nodes to be patched.
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// The batch patching policy.
        /// </summary>
        [NameInMap("rollout_policy")]
        [Validation(Required=false)]
        public FixNodePoolVulsRequestRolloutPolicy RolloutPolicy { get; set; }
        public class FixNodePoolVulsRequestRolloutPolicy : TeaModel {
            /// <summary>
            /// The maximum number of nodes that can be patched in parallel. The minimum value is 1. The maximum value equals the number of nodes in the node pool.
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

        }

        /// <summary>
        /// The list of vulnerabilities.
        /// </summary>
        [NameInMap("vuls")]
        [Validation(Required=false)]
        public List<string> Vuls { get; set; }

    }

}
