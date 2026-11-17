// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class AddMemoriesRequest : TeaModel {
        /// <summary>
        /// <para>The write memory request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public AddMemoriesRequestBody Body { get; set; }
        public class AddMemoriesRequestBody : TeaModel {
            /// <summary>
            /// <para>Specifies whether to extract memories. If omitted or set to true, memories are extracted from text or messages. If set to false, memories are directly written.</para>
            /// </summary>
            [NameInMap("extract")]
            [Validation(Required=false)]
            public bool? Extract { get; set; }

            /// <summary>
            /// <para>The list of memories to be directly written when extract is set to false. The list can contain 1 to 100 memories. You cannot provide text, messages, referenceTime, or request-level metadata at the same time.</para>
            /// </summary>
            [NameInMap("memories")]
            [Validation(Required=false)]
            public List<AddMemoriesRequestBodyMemories> Memories { get; set; }
            public class AddMemoriesRequestBodyMemories : TeaModel {
                /// <summary>
                /// <para>The string key-value tags set by the caller. A maximum of 16 tags are supported. A key can be up to 64 Unicode characters in length, and a value can be up to 1,024 Unicode characters in length. Empty strings are allowed. Nested objects or arrays are not supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;topic&quot;:&quot;hiking&quot;}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                /// <summary>
                /// <para>The content of the memory to be directly written. It cannot be empty and can be up to 32,000 UTF-8 bytes in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The user likes hiking</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The content type of the memory. Valid values: semantic for semantic memory, skill for skill, user_profile for user preference, and session_summary for session summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The list of messages. You must provide either text or messages, but not both. The list can contain 1 to 20 messages, and the total length of the content cannot exceed 32,000 UTF-8 bytes.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<AddMemoriesRequestBodyMessages> Messages { get; set; }
            public class AddMemoriesRequestBodyMessages : TeaModel {
                /// <summary>
                /// <para>The content of the message.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The user likes hiking</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The reference time of the message in RFC 3339 format with a time zone. If omitted, the request-level referenceTime is used. If both are omitted, the time of the current request is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-08T13:56:00+08:00</para>
                /// </summary>
                [NameInMap("referenceTime")]
                [Validation(Required=false)]
                public string ReferenceTime { get; set; }

                /// <summary>
                /// <para>The role of the message.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The string key-value metadata. A maximum of 16 keys are supported. A key can be up to 64 characters in length, and a value can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;topic&quot;:&quot;hiking&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }

            /// <summary>
            /// <para>The time reference point for the batch of messages or text. It uses the RFC 3339 format with a time zone and supports fractional seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-08T13:56:00+08:00</para>
            /// </summary>
            [NameInMap("referenceTime")]
            [Validation(Required=false)]
            public string ReferenceTime { get; set; }

            /// <summary>
            /// <para>The write scope. UserId, AgentId, and SessionId are all optional.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public AddMemoriesRequestBodyScope Scope { get; set; }
            public class AddMemoriesRequestBodyScope : TeaModel {
                /// <summary>
                /// <para>The agent ID. The length is limited to 1 to 128 UTF-8 bytes. It cannot contain a forward slash (/) or an asterisk (*).</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-001</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The session ID. The length is limited to 1 to 128 UTF-8 bytes. It cannot contain a forward slash (/) or an asterisk (*).</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The business team ID defined by the caller. It cannot be empty when provided and can be up to 128 UTF-8 bytes in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team-001</para>
                /// </summary>
                [NameInMap("teamId")]
                [Validation(Required=false)]
                public string TeamId { get; set; }

                /// <summary>
                /// <para>The user ID. The length is limited to 1 to 128 UTF-8 bytes. It cannot contain a forward slash (/) or an asterisk (*).</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to synchronously wait for the memory extraction to complete. Default value: true.</para>
            /// </summary>
            [NameInMap("sync")]
            [Validation(Required=false)]
            public bool? Sync { get; set; }

            /// <summary>
            /// <para>The text to be directly written. You must provide either text or messages, but not both. The text cannot exceed 32,000 UTF-8 bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The user likes hiking</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

    }

}
