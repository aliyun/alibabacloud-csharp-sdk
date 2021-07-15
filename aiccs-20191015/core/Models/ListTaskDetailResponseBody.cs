// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskDetailResponseBodyData Data { get; set; }
        public class ListTaskDetailResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<ListTaskDetailResponseBodyDataRecord> Record { get; set; }
            public class ListTaskDetailResponseBodyDataRecord : TeaModel {
                public string Status { get; set; }
                public int? RetryCurTimes { get; set; }
                public string Called { get; set; }
                public string Caller { get; set; }
                public int? Duration { get; set; }
                public long? Id { get; set; }
                public string StatusCode { get; set; }
                public string StatusCodeDesc { get; set; }
                public int? RetryTimes { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public string Direction { get; set; }
                public string Tags { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
