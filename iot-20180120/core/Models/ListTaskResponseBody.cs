// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskResponseBodyData Data { get; set; }
        public class ListTaskResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListTaskResponseBodyDataData> Data { get; set; }
            public class ListTaskResponseBodyDataData : TeaModel {
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string TaskId { get; set; }
                public string ProductKey { get; set; }
                public string DeviceName { get; set; }
                public string IotId { get; set; }
                public string Progress { get; set; }
                public string UtcQueueTime { get; set; }
                public string UtcModified { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
