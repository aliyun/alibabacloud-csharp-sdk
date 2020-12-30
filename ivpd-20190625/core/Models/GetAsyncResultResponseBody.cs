// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class GetAsyncResultResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsyncResultResponseBodyData Data { get; set; }
        public class GetAsyncResultResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TotalUsedTime")]
            [Validation(Required=false)]
            public long? TotalUsedTime { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public string BatchSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public Dictionary<string, string> Result { get; set; }
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public bool? Finish { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
