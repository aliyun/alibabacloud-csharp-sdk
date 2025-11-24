// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateASMNamespaceFromGuestClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Kubernetes cluster whose namespace information you want to synchronize to ASM. The Kubernetes cluster is added to the ASM instance that is specified by the ServiceMeshId parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6f6d46583def494ba1f2e2937c8*****</para>
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbf9ca9e6d5dc4c87a3ecd0ebf1e*****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
