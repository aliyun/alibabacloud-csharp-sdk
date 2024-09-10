// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCustomHotTopicViewPointAnalysisResponseBody : TeaModel {
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunCustomHotTopicViewPointAnalysisResponseBodyHeader Header { get; set; }
        public class RunCustomHotTopicViewPointAnalysisResponseBodyHeader : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunCustomHotTopicViewPointAnalysisResponseBodyPayload Payload { get; set; }
        public class RunCustomHotTopicViewPointAnalysisResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutput Output { get; set; }
            public class RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutput : TeaModel {
                [NameInMap("AskUser")]
                [Validation(Required=false)]
                public List<string> AskUser { get; set; }

                [NameInMap("AsyncTaskId")]
                [Validation(Required=false)]
                public string AsyncTaskId { get; set; }

                [NameInMap("Attitude")]
                [Validation(Required=false)]
                public string Attitude { get; set; }

                [NameInMap("CustomViewPointId")]
                [Validation(Required=false)]
                public string CustomViewPointId { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunCustomHotTopicViewPointAnalysisResponseBodyPayloadUsage Usage { get; set; }
            public class RunCustomHotTopicViewPointAnalysisResponseBodyPayloadUsage : TeaModel {
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
