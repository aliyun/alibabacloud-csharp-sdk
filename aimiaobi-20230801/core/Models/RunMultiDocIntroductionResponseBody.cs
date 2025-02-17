// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunMultiDocIntroductionResponseBody : TeaModel {
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunMultiDocIntroductionResponseBodyHeader Header { get; set; }
        public class RunMultiDocIntroductionResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Message does not exist.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>92e16ccb-92b6-4894-abbf-fc6e2929a0df</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b057f2fa-2277-477b-babf-cbc062307828</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>46e5c2b5-0877-4f09-bd91-ab0cf314e48b</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunMultiDocIntroductionResponseBodyPayload Payload { get; set; }
        public class RunMultiDocIntroductionResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunMultiDocIntroductionResponseBodyPayloadOutput Output { get; set; }
            public class RunMultiDocIntroductionResponseBodyPayloadOutput : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RunMultiDocIntroductionResponseBodyPayloadOutputKeyPoints> KeyPoints { get; set; }
                public class RunMultiDocIntroductionResponseBodyPayloadOutputKeyPoints : TeaModel {
                    [NameInMap("KeyPoint")]
                    [Validation(Required=false)]
                    public string KeyPoint { get; set; }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunMultiDocIntroductionResponseBodyPayloadUsage Usage { get; set; }
            public class RunMultiDocIntroductionResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>65</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>165</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
