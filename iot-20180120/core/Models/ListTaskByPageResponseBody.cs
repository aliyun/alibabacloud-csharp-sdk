// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListTaskByPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskByPageResponseBodyData Data { get; set; }
        public class ListTaskByPageResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListTaskByPageResponseBodyDataData> Data { get; set; }
            public class ListTaskByPageResponseBodyDataData : TeaModel {
                public string DeviceName { get; set; }
                public string IotId { get; set; }
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string ProductKey { get; set; }
                public string ProductName { get; set; }
                public int? Progress { get; set; }
                public string Status { get; set; }
                public string StatusDetail { get; set; }
                public string TaskId { get; set; }
                public string UtcModified { get; set; }
                public string UtcQueueTime { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
