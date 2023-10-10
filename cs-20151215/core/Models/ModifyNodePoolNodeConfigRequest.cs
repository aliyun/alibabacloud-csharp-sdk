// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyNodePoolNodeConfigRequest : TeaModel {
        /// <summary>
        /// The kubelet configuration.
        /// </summary>
        [NameInMap("kubelet_config")]
        [Validation(Required=false)]
        public KubeletConfig KubeletConfig { get; set; }

        /// <summary>
        /// The rotation configuration.
        /// </summary>
        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public ModifyNodePoolNodeConfigRequestRollingPolicy RollingPolicy { get; set; }
        public class ModifyNodePoolNodeConfigRequestRollingPolicy : TeaModel {
            /// <summary>
            /// The maximum number of nodes in the Unschedulable state.
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

        }

    }

}
