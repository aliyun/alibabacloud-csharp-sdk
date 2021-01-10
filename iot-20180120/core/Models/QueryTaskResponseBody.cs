// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryTaskResponseBody : TeaModel {
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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskResponseBodyData Data { get; set; }
        public class QueryTaskResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryTaskResponseBodyDataData> Data { get; set; }
            public class QueryTaskResponseBodyDataData : TeaModel {
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string TaskId { get; set; }
                public string ProductKey { get; set; }
                public string DeviceName { get; set; }
                public string IotId { get; set; }
                public string Progress { get; set; }
                public string UtcQueueTime { get; set; }
                public string UtcModified { get; set; }
                public string StatusDetail { get; set; }
                public string Status { get; set; }
                public string Message { get; set; }
            }
        };

    }

}
