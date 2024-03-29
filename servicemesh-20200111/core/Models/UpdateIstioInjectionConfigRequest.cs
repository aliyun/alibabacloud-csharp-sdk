// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateIstioInjectionConfigRequest : TeaModel {
        /// <summary>
        /// The data plane mode of the namespace. This parameter is valid only when the Ambient Mesh mode is enabled for the current Service Mesh (ASM) instance. Valid values:
        /// 
        /// *   ambient: sets the data plane mode of the namespace to the Ambient Mesh mode.
        /// *   sidecar: sets the data plane mode of the namespace to the Sidecar mode.
        /// </summary>
        [NameInMap("DataPlaneMode")]
        [Validation(Required=false)]
        public string DataPlaneMode { get; set; }

        /// <summary>
        /// Specifies whether to enable Istio automatic sidecar injection.
        /// </summary>
        [NameInMap("EnableIstioInjection")]
        [Validation(Required=false)]
        public bool? EnableIstioInjection { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic sidecar injection by using SidecarSet.
        /// </summary>
        [NameInMap("EnableSidecarSetInjection")]
        [Validation(Required=false)]
        public bool? EnableSidecarSetInjection { get; set; }

        /// <summary>
        /// Specifies the version to be injected into the namespace. This parameter is valid only when the ASM instance performs a canary release. When IstioRev is not empty, you must not specify EnableIstioInjection and EnableSidecarSetInjection.
        /// </summary>
        [NameInMap("IstioRev")]
        [Validation(Required=false)]
        public string IstioRev { get; set; }

        /// <summary>
        /// The namespace for which you want to modify the sidecar injection setting.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
