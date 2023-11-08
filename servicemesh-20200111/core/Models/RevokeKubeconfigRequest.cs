// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class RevokeKubeconfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the kubeconfig file for private access.
        /// 
        /// *   `true`: returns the kubeconfig file for private access.
        /// *   `false`: returns the kubeconfig file for public access.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        /// <summary>
        /// The ID of the ASM instance for which you want to revoke its kubeconfig file.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
