// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiOperationResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateHttpApiOperationResponseBodyData Data { get; set; }
        public class CreateHttpApiOperationResponseBodyData : TeaModel {
            [NameInMap("operations")]
            [Validation(Required=false)]
            public List<CreateHttpApiOperationResponseBodyDataOperations> Operations { get; set; }
            public class CreateHttpApiOperationResponseBodyDataOperations : TeaModel {
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
