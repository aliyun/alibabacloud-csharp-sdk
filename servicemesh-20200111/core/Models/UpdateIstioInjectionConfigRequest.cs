// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateIstioInjectionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The data plane mode of the namespace. This parameter is valid only when the Ambient Mesh mode is enabled for the current Service Mesh (ASM) instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ambient: sets the data plane mode of the namespace to the Ambient Mesh mode.</description></item>
        /// <item><description>sidecar: sets the data plane mode of the namespace to the Sidecar mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ambient</para>
        /// </summary>
        [NameInMap("DataPlaneMode")]
        [Validation(Required=false)]
        public string DataPlaneMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Istio automatic sidecar injection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIstioInjection")]
        [Validation(Required=false)]
        public bool? EnableIstioInjection { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic sidecar injection by using SidecarSet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSidecarSetInjection")]
        [Validation(Required=false)]
        public bool? EnableSidecarSetInjection { get; set; }

        /// <summary>
        /// <para>Specifies the version to be injected into the namespace. This parameter is valid only when the ASM instance performs a canary release. When IstioRev is not empty, you must not specify EnableIstioInjection and EnableSidecarSetInjection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>canary</para>
        /// </summary>
        [NameInMap("IstioRev")]
        [Validation(Required=false)]
        public string IstioRev { get; set; }

        /// <summary>
        /// <para>The namespace for which you want to modify the sidecar injection setting.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce2cdbb9d013f447180cf5ca8bb******</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
