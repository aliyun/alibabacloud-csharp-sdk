// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateASMGatewayImportedServicesRequest : TeaModel {
        /// <summary>
        /// The name of the ASM gateway.
        /// </summary>
        [NameInMap("ASMGatewayName")]
        [Validation(Required=false)]
        public string ASMGatewayName { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The names of the services. Separate multiple service names with commas (,). Example: reviews,sleep.
        /// </summary>
        [NameInMap("ServiceNames")]
        [Validation(Required=false)]
        public string ServiceNames { get; set; }

        /// <summary>
        /// The namespace in which the service resides.
        /// </summary>
        [NameInMap("ServiceNamespace")]
        [Validation(Required=false)]
        public string ServiceNamespace { get; set; }

    }

}
