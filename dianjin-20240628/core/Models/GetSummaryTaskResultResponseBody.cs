// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetSummaryTaskResultResponseBody : TeaModel {
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSummaryTaskResultResponseBodyData Data { get; set; }
        public class GetSummaryTaskResultResponseBodyData : TeaModel {
            [NameInMap("choices")]
            [Validation(Required=false)]
            public List<GetSummaryTaskResultResponseBodyDataChoices> Choices { get; set; }
            public class GetSummaryTaskResultResponseBodyDataChoices : TeaModel {
                [NameInMap("finishReason")]
                [Validation(Required=false)]
                public string FinishReason { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public GetSummaryTaskResultResponseBodyDataChoicesMessage Message { get; set; }
                public class GetSummaryTaskResultResponseBodyDataChoicesMessage : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    [NameInMap("toolCalls")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> ToolCalls { get; set; }

                }

            }

            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("totalTokens")]
            [Validation(Required=false)]
            public int? TotalTokens { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public GetSummaryTaskResultResponseBodyDataUsage Usage { get; set; }
            public class GetSummaryTaskResultResponseBodyDataUsage : TeaModel {
                [NameInMap("imageCount")]
                [Validation(Required=false)]
                public int? ImageCount { get; set; }

                [NameInMap("imageTokens")]
                [Validation(Required=false)]
                public int? ImageTokens { get; set; }

                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public int? TotalTokens { get; set; }

            }

        }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
