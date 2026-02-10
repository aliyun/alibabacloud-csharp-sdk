// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class RunCompletionResponseBody : TeaModel {
        [NameInMap("FinishReason")]
        [Validation(Required=false)]
        public string FinishReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("inputTokens")]
        [Validation(Required=false)]
        public string InputTokens { get; set; }

        [NameInMap("outputTokens")]
        [Validation(Required=false)]
        public string OutputTokens { get; set; }

        [NameInMap("ragStatus")]
        [Validation(Required=false)]
        public string RagStatus { get; set; }

        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public string TotalTokens { get; set; }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public RunCompletionResponseBodyUsage Usage { get; set; }
        public class RunCompletionResponseBodyUsage : TeaModel {
            [NameInMap("rag")]
            [Validation(Required=false)]
            public RunCompletionResponseBodyUsageRag Rag { get; set; }
            public class RunCompletionResponseBodyUsageRag : TeaModel {
                [NameInMap("adaptive")]
                [Validation(Required=false)]
                public RunCompletionResponseBodyUsageRagAdaptive Adaptive { get; set; }
                public class RunCompletionResponseBodyUsageRagAdaptive : TeaModel {
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public int? InputTokens { get; set; }

                    [NameInMap("invokeCount")]
                    [Validation(Required=false)]
                    public int? InvokeCount { get; set; }

                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public int? OutputTokens { get; set; }

                }

                [NameInMap("dialogSummary")]
                [Validation(Required=false)]
                public RunCompletionResponseBodyUsageRagDialogSummary DialogSummary { get; set; }
                public class RunCompletionResponseBodyUsageRagDialogSummary : TeaModel {
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public int? InputTokens { get; set; }

                    [NameInMap("invokeCount")]
                    [Validation(Required=false)]
                    public int? InvokeCount { get; set; }

                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public int? OutputTokens { get; set; }

                }

            }

        }

    }

}
