// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateVpcEndpointResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateVpcEndpointResponseBodyResult Result { get; set; }
        public class CreateVpcEndpointResponseBodyResult : TeaModel {
            [NameInMap("endpointDomain")]
            [Validation(Required=false)]
            public string EndpointDomain { get; set; }

            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

    }

}
