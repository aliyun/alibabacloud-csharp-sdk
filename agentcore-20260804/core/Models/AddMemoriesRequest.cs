// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class AddMemoriesRequest : TeaModel {
        /// <summary>
        /// <para>The request body for writing to memory.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public AddMemoriesRequestBody Body { get; set; }
        public class AddMemoriesRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of messages. You must provide either this parameter or Text, but not both. The list must contain 1 to 20 messages, and the total size of the content must not exceed 32,000 UTF-8 bytes.</para>
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
            /// <para>The string key-value metadata. You can specify up to 16 keys. The maximum length of a key is 64 characters, and the maximum length of a value is 1,024 characters.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }

            /// <summary>
            /// <para>The time reference point for the batch of messages or text. The value must be in RFC 3339 format with a time zone and support fractional seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-08T13:56:00+08:00</para>
            /// </summary>
            [NameInMap("referenceTime")]
            [Validation(Required=false)]
            public string ReferenceTime { get; set; }

            /// <summary>
            /// <para>The scope of the write operation. UserId, AgentId, and SessionId are all optional.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public AddMemoriesRequestBodyScope Scope { get; set; }
            public class AddMemoriesRequestBodyScope : TeaModel {
                /// <summary>
                /// <para>The ID of the agent. The length is limited to 1 to 128 UTF-8 bytes. The ID cannot contain a forward slash (/) or an asterisk (*).</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-001</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The ID of the session. The length is limited to 1 to 128 UTF-8 bytes. The ID cannot contain a forward slash (/) or an asterisk (*).</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The ID of the user. The length is limited to 1 to 128 UTF-8 bytes. The ID cannot contain a forward slash (/) or an asterisk (*).</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to synchronously wait for memory extraction to complete. Default value: true.</para>
            /// </summary>
            [NameInMap("sync")]
            [Validation(Required=false)]
            public bool? Sync { get; set; }

            /// <summary>
            /// <para>The text to be written directly. You must provide either this parameter or Messages, but not both. The size of the text must not exceed 32,000 UTF-8 bytes.</para>
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
