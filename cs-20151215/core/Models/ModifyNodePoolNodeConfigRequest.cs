// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyNodePoolNodeConfigRequest : TeaModel {
        /// <summary>
        /// The parameter settings of the kubelet.
        /// </summary>
        [NameInMap("kubelet_config")]
        [Validation(Required=false)]
        public KubeletConfig KubeletConfig { get; set; }

        [NameInMap("os_config")]
        [Validation(Required=false)]
        public ModifyNodePoolNodeConfigRequestOsConfig OsConfig { get; set; }
        public class ModifyNodePoolNodeConfigRequestOsConfig : TeaModel {
            [NameInMap("sysctl")]
            [Validation(Required=false)]
            public Dictionary<string, object> Sysctl { get; set; }

        }

        /// <summary>
        /// The rotation configurations.
        /// </summary>
        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public ModifyNodePoolNodeConfigRequestRollingPolicy RollingPolicy { get; set; }
        public class ModifyNodePoolNodeConfigRequestRollingPolicy : TeaModel {
            /// <summary>
            /// The maximum number of unavailable nodes.
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

        }

    }

}
