// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunBookIntroductionResponseBody : TeaModel {
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunBookIntroductionResponseBodyHeader Header { get; set; }
        public class RunBookIntroductionResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
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
            /// <para>411c4dfa-2168-4379-a902-675d67f453f8</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
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
        public RunBookIntroductionResponseBodyPayload Payload { get; set; }
        public class RunBookIntroductionResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunBookIntroductionResponseBodyPayloadOutput Output { get; set; }
            public class RunBookIntroductionResponseBodyPayloadOutput : TeaModel {
                [NameInMap("KeyPoint")]
                [Validation(Required=false)]
                public string KeyPoint { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunBookIntroductionResponseBodyPayloadUsage Usage { get; set; }
            public class RunBookIntroductionResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
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
                /// <para>200</para>
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
