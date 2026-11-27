// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetMemoryHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3B311FD9-A60B-55E0-A896-A0C73*********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<GetMemoryHistoryResponseBodyResults> Results { get; set; }
        public class GetMemoryHistoryResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1764556182850</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADD</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The memory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b25d6ad7-306f-4040-9890-4dddd2505a2e</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The original message.</para>
            /// </summary>
            [NameInMap("input")]
            [Validation(Required=false)]
            public List<GetMemoryHistoryResponseBodyResultsInput> Input { get; set; }
            public class GetMemoryHistoryResponseBodyResultsInput : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>My name is Zhang San and I live in Hangzhou.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role of the message sender.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The memory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>019cacf6-7b39-7f61-8314-548f07ca449a</para>
            /// </summary>
            [NameInMap("memoryId")]
            [Validation(Required=false)]
            public string MemoryId { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The new memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I really like Python.</para>
            /// </summary>
            [NameInMap("newMemory")]
            [Validation(Required=false)]
            public string NewMemory { get; set; }

            /// <summary>
            /// <para>The old memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I really don&quot;t like Python at all.</para>
            /// </summary>
            [NameInMap("oldMemory")]
            [Validation(Required=false)]
            public string OldMemory { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1771036123785</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
