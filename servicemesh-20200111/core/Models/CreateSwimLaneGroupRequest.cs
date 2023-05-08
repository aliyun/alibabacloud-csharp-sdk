// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateSwimLaneGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("IngressGatewayName")]
        [Validation(Required=false)]
        public string IngressGatewayName { get; set; }

        [NameInMap("IngressType")]
        [Validation(Required=false)]
        public string IngressType { get; set; }

        /// <summary>
        /// The type of the ingress. Only ingress gateways are supported. Set the value to ASM.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The name of the ingress gateway.
        /// </summary>
        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

    }

}
