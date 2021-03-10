// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListTaskResponse : TeaModel {
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

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListTaskResponseData Data { get; set; }
        public class ListTaskResponseData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=true)]
            public List<ListTaskResponseDataData> Data { get; set; }
            public class ListTaskResponseDataData : TeaModel {
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
