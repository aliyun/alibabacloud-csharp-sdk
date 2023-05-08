// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClusterPrometheusRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster on the data plane.
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// The ID of the region where the cluster on the data plane resides.
        /// </summary>
        [NameInMap("K8sClusterRegionId")]
        [Validation(Required=false)]
        public string K8sClusterRegionId { get; set; }

        /// <summary>
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
