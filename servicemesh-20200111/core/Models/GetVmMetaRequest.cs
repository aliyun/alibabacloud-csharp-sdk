// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetVmMetaRequest : TeaModel {
        /// <summary>
        /// The namespace. This parameter is valid only after you set the Namespace and the ServiceAccount parameters.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The service account. This parameter is valid only after you set the Namespace and the ServiceAccount parameters.
        /// </summary>
        [NameInMap("ServiceAccount")]
        [Validation(Required=false)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The trusted domain. Default value: cluster.local. This parameter is valid only after you set the Namespace and the ServiceAccount parameters.
        /// </summary>
        [NameInMap("TrustDomain")]
        [Validation(Required=false)]
        public string TrustDomain { get; set; }

    }

}
