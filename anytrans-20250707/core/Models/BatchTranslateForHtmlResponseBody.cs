// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class BatchTranslateForHtmlResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchTranslateForHtmlResponseBodyData Data { get; set; }
        public class BatchTranslateForHtmlResponseBodyData : TeaModel {
            [NameInMap("translationList")]
            [Validation(Required=false)]
            public List<BatchTranslateForHtmlResponseBodyDataTranslationList> TranslationList { get; set; }
            public class BatchTranslateForHtmlResponseBodyDataTranslationList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public long? Code { get; set; }

                [NameInMap("detectedLang")]
                [Validation(Required=false)]
                public string DetectedLang { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("translation")]
                [Validation(Required=false)]
                public string Translation { get; set; }

                [NameInMap("usage")]
                [Validation(Required=false)]
                public BatchTranslateForHtmlResponseBodyDataTranslationListUsage Usage { get; set; }
                public class BatchTranslateForHtmlResponseBodyDataTranslationListUsage : TeaModel {
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public long? InputTokens { get; set; }

                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public long? OutputTokens { get; set; }

                    [NameInMap("totalTokens")]
                    [Validation(Required=false)]
                    public long? TotalTokens { get; set; }

                }

            }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
