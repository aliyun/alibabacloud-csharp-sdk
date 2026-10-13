// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMemoryResponseBody : TeaModel {
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
        /// <para>The updated memory.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateMemoryResponseBodyData Data { get; set; }
        public class UpdateMemoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The memory content.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public UpdateMemoryResponseBodyDataContent Content { get; set; }
            public class UpdateMemoryResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The memory text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The user enjoys hiking</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
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
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }

            /// <summary>
            /// <para>The memory scope.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public UpdateMemoryResponseBodyDataScope Scope { get; set; }
            public class UpdateMemoryResponseBodyDataScope : TeaModel {
                /// <summary>
                /// <para>The agent ID. The length is limited to 1 to 128 UTF-8 bytes. The ID cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with an agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-001</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The session ID. The length is limited to 1 to 128 UTF-8 bytes. The ID cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with a session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The user ID. The length is limited to 1 to 128 UTF-8 bytes. The ID cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with a user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The last update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

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
