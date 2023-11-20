// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterRequest : TeaModel {
        /// <summary>
        /// The name of the component. Set the value to `k8s`.
        /// </summary>
        [NameInMap("component_name")]
        [Validation(Required=false)]
        [Obsolete]
        public string ComponentName { get; set; }

        /// <summary>
        /// Specifies whether to update only master nodes. Valid values:
        /// 
        /// *   true: update only master nodes.
        /// *   false: update master and worker nodes.
        /// </summary>
        [NameInMap("master_only")]
        [Validation(Required=false)]
        public bool? MasterOnly { get; set; }

        /// <summary>
        /// The Kubernetes version to which the cluster can be updated.
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// The current Kubernetes version of the cluster. For more information, see [Kubernetes versions](~~185269~~).
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        [Obsolete]
        public string Version { get; set; }

    }

}
