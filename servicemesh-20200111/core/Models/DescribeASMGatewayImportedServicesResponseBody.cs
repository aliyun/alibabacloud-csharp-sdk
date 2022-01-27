// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeASMGatewayImportedServicesResponseBody : TeaModel {
        [NameInMap("ImportedServices")]
        [Validation(Required=false)]
        public List<DescribeASMGatewayImportedServicesResponseBodyImportedServices> ImportedServices { get; set; }
        public class DescribeASMGatewayImportedServicesResponseBodyImportedServices : TeaModel {
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceNamespace")]
            [Validation(Required=false)]
            public string ServiceNamespace { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
