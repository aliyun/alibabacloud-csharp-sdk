// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunKeywordsExtractionGenerationResponseBody : TeaModel {
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunKeywordsExtractionGenerationResponseBodyHeader Header { get; set; }
        public class RunKeywordsExtractionGenerationResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AccessForbid</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-failed</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1a3d7c9f-3a6d-4e49-b176-2d8721a27397</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8d55b429d7c6d321fcff54823e8d317b</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>210bc4e817219607963985396de8bd</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunKeywordsExtractionGenerationResponseBodyPayload Payload { get; set; }
        public class RunKeywordsExtractionGenerationResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunKeywordsExtractionGenerationResponseBodyPayloadOutput Output { get; set; }
            public class RunKeywordsExtractionGenerationResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunKeywordsExtractionGenerationResponseBodyPayloadUsage Usage { get; set; }
            public class RunKeywordsExtractionGenerationResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>419F3FBE-5C8D-5949-AC29-E9615235D15A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
