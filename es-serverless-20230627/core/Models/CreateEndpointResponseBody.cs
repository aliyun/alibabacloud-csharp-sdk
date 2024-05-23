// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class CreateEndpointResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateEndpointResponseBodyResult Result { get; set; }
        public class CreateEndpointResponseBodyResult : TeaModel {
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

    }

}
