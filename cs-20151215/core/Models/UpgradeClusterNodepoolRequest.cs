// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterNodepoolRequest : TeaModel {
        /// <summary>
        /// The ID of the OS image that is used by the nodes.
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The Kubernetes version that is used by the nodes.
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// The runtime type. Valid values: containerd and docker.
        /// </summary>
        [NameInMap("runtime_type")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

        /// <summary>
        /// The version of the container runtime that is used by the nodes.
        /// </summary>
        [NameInMap("runtime_version")]
        [Validation(Required=false)]
        public string RuntimeVersion { get; set; }

        [NameInMap("use_replace")]
        [Validation(Required=false)]
        public bool? UseReplace { get; set; }

    }

}
