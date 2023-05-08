// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshUpgradeStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("AllIstioGatewayFullNames")]
        [Validation(Required=false)]
        public string AllIstioGatewayFullNames { get; set; }

        /// <summary>
        /// The fully qualified names of ingress gateways in the ASM instance. Separate multiple names with commas (,).
        /// </summary>
        [NameInMap("GuestClusterIds")]
        [Validation(Required=false)]
        public string GuestClusterIds { get; set; }

        /// <summary>
        /// The IDs of the clusters on the data plane of the ASM instance. Separate multiple clusters with commas (,).
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
