// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DeleteIstioGatewayDomainsRequest : TeaModel {
        /// <summary>
        /// The domain names of the one or more hosts that are exposed by the ASM gateway. Separate multiple domain names with commas (,).
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public string Hosts { get; set; }

        /// <summary>
        /// The name of the ASM gateway.
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// The maximum number of ASM gateways to query.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// The namespace in which the ASM gateway resides.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The name of the port.
        /// </summary>
        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        /// <summary>
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
