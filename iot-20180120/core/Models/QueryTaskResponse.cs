// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryTaskResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryTaskResponseData Data { get; set; }
        public class QueryTaskResponseData : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=true)]
            public string JobId { get; set; }
            [NameInMap("JobName")]
            [Validation(Required=true)]
            public string JobName { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=true)]
            public string TaskId { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }
            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }
            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=true)]
            public string Progress { get; set; }
            [NameInMap("UtcQueueTime")]
            [Validation(Required=true)]
            public string UtcQueueTime { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=true)]
            public string UtcModified { get; set; }
            [NameInMap("StatusDetail")]
            [Validation(Required=true)]
            public string StatusDetail { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }
        };

    }

}
