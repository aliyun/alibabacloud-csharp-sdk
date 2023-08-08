// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20220930.Models
{
    public class GetFileTransResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileTransResponseBodyData Data { get; set; }
        public class GetFileTransResponseBodyData : TeaModel {
            [NameInMap("TransId")]
            [Validation(Required=false)]
            public string TransId { get; set; }

            [NameInMap("TransKey")]
            [Validation(Required=false)]
            public string TransKey { get; set; }

            [NameInMap("TransStatus")]
            [Validation(Required=false)]
            public string TransStatus { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
