// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("component_name")]
        [Validation(Required=false)]
        [Obsolete]
        public string ComponentName { get; set; }

        /// <summary>
        /// Specifies whether to update only the master nodes. Valid values:
        /// 
        /// *   true: updates only the master nodes.
        /// *   false: updates the master nodes and worker nodes.
        /// </summary>
        [NameInMap("master_only")]
        [Validation(Required=false)]
        public bool? MasterOnly { get; set; }

        /// <summary>
        /// The Kubernetes version to which you want to update the cluster.
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public UpgradeClusterRequestRollingPolicy RollingPolicy { get; set; }
        public class UpgradeClusterRequestRollingPolicy : TeaModel {
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public int? MaxParallelism { get; set; }

        }

        /// <summary>
        /// This parameter is deprecated. Specify the Kubernetes version by using the next_version parameter.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        [Obsolete]
        public string Version { get; set; }

    }

}
