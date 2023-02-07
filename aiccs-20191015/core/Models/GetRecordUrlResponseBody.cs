// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetRecordUrlResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRecordUrlResponseBodyData Data { get; set; }
        public class GetRecordUrlResponseBodyData : TeaModel {
            [NameInMap("Acid")]
            [Validation(Required=false)]
            public string Acid { get; set; }

            [NameInMap("OssLink")]
            [Validation(Required=false)]
            public string OssLink { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
