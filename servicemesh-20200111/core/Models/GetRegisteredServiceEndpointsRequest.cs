// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServiceEndpointsRequest : TeaModel {
        /// <summary>
        /// The name of the registered service.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

        /// <summary>
        /// The type of the registered service. Valid values:
        /// 
        /// *   `ServiceEntry`: indicates that the service is registered by creating a service entry.
        /// *   `Kubernetes`: indicates that the service is registered on a Kubernetes cluster on the data plane.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The IDs of clusters in the ASM instance. Separate multiple cluster IDs with commas (,).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The endpoints of the registered service.
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
