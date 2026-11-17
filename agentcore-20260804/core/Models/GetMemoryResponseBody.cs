// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetMemoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The long-term memory details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMemoryResponseBodyData Data { get; set; }
        public class GetMemoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The memory content.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public GetMemoryResponseBodyDataContent Content { get; set; }
            public class GetMemoryResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The memory text.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The user likes hiking</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The time is in RFC 3339 format. The Z at the end of the example indicates the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The long-term memory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mem-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("memoryId")]
            [Validation(Required=false)]
            public string MemoryId { get; set; }

            /// <summary>
            /// <para>The memory metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;topic&quot;:&quot;hiking&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }

            /// <summary>
            /// <para>The memory scope.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public GetMemoryResponseBodyDataScope Scope { get; set; }
            public class GetMemoryResponseBodyDataScope : TeaModel {
                /// <summary>
                /// <para>The agent ID. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with an agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-001</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The session ID. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with a session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The business team ID defined by the caller. The value cannot be empty when provided and can be up to 128 UTF-8 bytes in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team-001</para>
                /// </summary>
                [NameInMap("teamId")]
                [Validation(Required=false)]
                public string TeamId { get; set; }

                /// <summary>
                /// <para>The user ID. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with a user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The memory source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>session_extraction: extracted from session events</description></item>
            /// <item><description>content_extraction: extracted from text or messages</description></item>
            /// <item><description>direct: written directly</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>session_extraction</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The memory content type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>semantic: semantic memory</description></item>
            /// <item><description>skill: skill</description></item>
            /// <item><description>user_profile: user preference</description></item>
            /// <item><description>session_summary: session summary</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>semantic</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The last updated time. The time is in RFC 3339 format. The Z at the end of the example indicates the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether the memory is valid. A value of false indicates that the memory is revoked and is not included in valid memory retrieval.</para>
            /// </summary>
            [NameInMap("valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
