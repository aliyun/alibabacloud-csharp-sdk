// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetModelProgressResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetModelProgressResponseBodyResult Result { get; set; }
        public class GetModelProgressResponseBodyResult : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
