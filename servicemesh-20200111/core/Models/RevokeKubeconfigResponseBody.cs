// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class RevokeKubeconfigResponseBody : TeaModel {
        /// <summary>
        /// The new kubeconfig file generated.
        /// </summary>
        [NameInMap("Kubeconfig")]
        [Validation(Required=false)]
        public string Kubeconfig { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
