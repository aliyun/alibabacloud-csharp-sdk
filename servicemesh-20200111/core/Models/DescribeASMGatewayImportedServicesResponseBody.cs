// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeASMGatewayImportedServicesResponseBody : TeaModel {
        /// <summary>
        /// The list of the imported services.
        /// </summary>
        [NameInMap("ImportedServices")]
        [Validation(Required=false)]
        public List<DescribeASMGatewayImportedServicesResponseBodyImportedServices> ImportedServices { get; set; }
        public class DescribeASMGatewayImportedServicesResponseBodyImportedServices : TeaModel {
            /// <summary>
            /// The name of a service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The namespace in which the service resides.
            /// </summary>
            [NameInMap("ServiceNamespace")]
            [Validation(Required=false)]
            public string ServiceNamespace { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
