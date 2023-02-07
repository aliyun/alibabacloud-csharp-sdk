// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListTaskDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<ListTaskDetailResponseBodyDataRecord> Record { get; set; }
            public class ListTaskDetailResponseBodyDataRecord : TeaModel {
                [NameInMap("Called")]
                [Validation(Required=false)]
                public string Called { get; set; }

                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("RetryCurTimes")]
                [Validation(Required=false)]
                public int? RetryCurTimes { get; set; }

                [NameInMap("RetryTimes")]
                [Validation(Required=false)]
                public int? RetryTimes { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                [NameInMap("StatusCodeDesc")]
                [Validation(Required=false)]
                public string StatusCodeDesc { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
