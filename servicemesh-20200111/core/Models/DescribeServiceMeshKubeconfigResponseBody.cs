// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshKubeconfigResponseBody : TeaModel {
        /// <summary>
        /// The expiration time of the kubeconfig certificate. The format is: YYYY-MM-DD hh: mm: ss.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// The content of the kubeconfig file of the cluster.
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
