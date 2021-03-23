// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class InvokeFunctionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public InvokeFunctionResponseBodyResult Result { get; set; }
        public class InvokeFunctionResponseBodyResult : TeaModel {
            [NameInMap("BackEndRequestId")]
            [Validation(Required=false)]
            public string BackEndRequestId { get; set; }
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }
        };

    }

}
