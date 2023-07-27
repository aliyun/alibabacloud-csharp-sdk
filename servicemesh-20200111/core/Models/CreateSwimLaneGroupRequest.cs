// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateSwimLaneGroupRequest : TeaModel {
        /// <summary>
        /// The name of the lane group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The name of the ingress gateway.
        /// </summary>
        [NameInMap("IngressGatewayName")]
        [Validation(Required=false)]
        public string IngressGatewayName { get; set; }

        /// <summary>
        /// The type of the gateway for ingress traffic. Only ASM ingress gateways are supported.
        /// </summary>
        [NameInMap("IngressType")]
        [Validation(Required=false)]
        public string IngressType { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud Service Mesh (ASM) instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// A list of services associated with the lane group. The value is a JSON array. The format of a service is `$Cluster name/$Cluster ID/$Namespace/$Service name`.
        /// </summary>
        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

    }

}
