// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateEndpointResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateEndpointResponseBodyResult Result { get; set; }
        public class UpdateEndpointResponseBodyResult : TeaModel {
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

    }

}
