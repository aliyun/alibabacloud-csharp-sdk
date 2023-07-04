// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskCallInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public TaskCallInfoResponseBodyModel Model { get; set; }
        public class TaskCallInfoResponseBodyModel : TeaModel {
            [NameInMap("FinishTotal")]
            [Validation(Required=false)]
            public long? FinishTotal { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            [NameInMap("UnCallTotal")]
            [Validation(Required=false)]
            public long? UnCallTotal { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
