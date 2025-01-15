// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunScriptRefineResponseBody : TeaModel {
        [NameInMap("end")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        [NameInMap("header")]
        [Validation(Required=false)]
        public RunScriptRefineResponseBodyHeader Header { get; set; }
        public class RunScriptRefineResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pop sign mismatch, please check log.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F8A35034-EDCF-5C50-95A5-1044316F36E3</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17dc8bcd-f34a-46d1-a7a3-0fa3d1ce3824</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>14356391-6c6c-40d5-b80a-8ecd03b69d72</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2150432017236011824686132ecdbc</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunScriptRefineResponseBodyPayload Payload { get; set; }
        public class RunScriptRefineResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunScriptRefineResponseBodyPayloadOutput Output { get; set; }
            public class RunScriptRefineResponseBodyPayloadOutput : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Content { get; set; }

                [NameInMap("outline")]
                [Validation(Required=false)]
                public string Outline { get; set; }

                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunScriptRefineResponseBodyPayloadUsage Usage { get; set; }
            public class RunScriptRefineResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

    }

}
