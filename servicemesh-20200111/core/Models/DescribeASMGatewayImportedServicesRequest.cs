// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeASMGatewayImportedServicesRequest : TeaModel {
        /// <summary>
        /// The name of the ASM gateway.
        /// </summary>
        [NameInMap("ASMGatewayName")]
        [Validation(Required=false)]
        public string ASMGatewayName { get; set; }

        /// <summary>
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The namespace in which the service resides.
        /// </summary>
        [NameInMap("ServiceNamespace")]
        [Validation(Required=false)]
        public string ServiceNamespace { get; set; }

    }

}
