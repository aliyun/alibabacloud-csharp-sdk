// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeImportedServicesDetailRequest : TeaModel {
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
        /// The namespace in which the services reside.
        /// </summary>
        [NameInMap("ServiceNamespace")]
        [Validation(Required=false)]
        public string ServiceNamespace { get; set; }

    }

}
