// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateVpcEndpointResponseBody : TeaModel {
        /// <summary>
        /// The endpoint domain name, which is used to configure the connection.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the endpoint on the service VPC side.
        /// </summary>
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

            /// <summary>
            /// The name of the service VPC-side endpoint.
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

    }

}
