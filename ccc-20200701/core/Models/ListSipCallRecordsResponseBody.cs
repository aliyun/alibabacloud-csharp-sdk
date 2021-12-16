// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListSipCallRecordsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSipCallRecordsResponseBodyData> Data { get; set; }
        public class ListSipCallRecordsResponseBodyData : TeaModel {
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            [NameInMap("Callee")]
            [Validation(Required=false)]
            public string Callee { get; set; }

            [NameInMap("CalleeClusterId")]
            [Validation(Required=false)]
            public string CalleeClusterId { get; set; }

            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            [NameInMap("CallerClusterId")]
            [Validation(Required=false)]
            public string CallerClusterId { get; set; }

            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("EarlyMediaText")]
            [Validation(Required=false)]
            public string EarlyMediaText { get; set; }

            [NameInMap("EarlyMediaUrl")]
            [Validation(Required=false)]
            public string EarlyMediaUrl { get; set; }

            [NameInMap("EstablishedTime")]
            [Validation(Required=false)]
            public long? EstablishedTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InviteTime")]
            [Validation(Required=false)]
            public long? InviteTime { get; set; }

            [NameInMap("LastResponseCode")]
            [Validation(Required=false)]
            public int? LastResponseCode { get; set; }

            [NameInMap("LastResponseText")]
            [Validation(Required=false)]
            public string LastResponseText { get; set; }

            [NameInMap("ReleaseReasonCode")]
            [Validation(Required=false)]
            public int? ReleaseReasonCode { get; set; }

            [NameInMap("ReleasedTime")]
            [Validation(Required=false)]
            public long? ReleasedTime { get; set; }

            [NameInMap("RingTime")]
            [Validation(Required=false)]
            public long? RingTime { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
