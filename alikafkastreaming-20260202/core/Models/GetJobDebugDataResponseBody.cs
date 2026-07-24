// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class GetJobDebugDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobDebugDataResponseBodyData Data { get; set; }
        public class GetJobDebugDataResponseBodyData : TeaModel {
            [NameInMap("DataRows")]
            [Validation(Required=false)]
            public List<GetJobDebugDataResponseBodyDataDataRows> DataRows { get; set; }
            public class GetJobDebugDataResponseBodyDataDataRows : TeaModel {
                [NameInMap("FlinkInstanceId")]
                [Validation(Required=false)]
                public string FlinkInstanceId { get; set; }

                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                [NameInMap("Offset")]
                [Validation(Required=false)]
                public long? Offset { get; set; }

                [NameInMap("Partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

                [NameInMap("ProcessedValue")]
                [Validation(Required=false)]
                public string ProcessedValue { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("DebugField")]
            [Validation(Required=false)]
            public string DebugField { get; set; }

            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("Limit")]
            [Validation(Required=false)]
            public string Limit { get; set; }

            [NameInMap("NextCursor")]
            [Validation(Required=false)]
            public string NextCursor { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
