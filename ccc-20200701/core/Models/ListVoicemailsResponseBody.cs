// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListVoicemailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVoicemailsResponseBodyData Data { get; set; }
        public class ListVoicemailsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListVoicemailsResponseBodyDataList> List { get; set; }
            public class ListVoicemailsResponseBodyDataList : TeaModel {
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                [NameInMap("CdrStartTime")]
                [Validation(Required=false)]
                public long? CdrStartTime { get; set; }

                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RecordingDuration")]
                [Validation(Required=false)]
                public long? RecordingDuration { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
