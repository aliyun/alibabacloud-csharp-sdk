// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddMemoriesRequest : TeaModel {
        /// <summary>
        /// <para>Application agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952730733889060865</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>Application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm_480d961a1b5e4efe84603f4cbc0f</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Asynchronous mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("asyncMode")]
        [Validation(Required=false)]
        public bool? AsyncMode { get; set; }

        /// <summary>
        /// <para>Custom instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Your custom instructions here</para>
        /// </summary>
        [NameInMap("customInstructions")]
        [Validation(Required=false)]
        public string CustomInstructions { get; set; }

        /// <summary>
        /// <para>Infer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("infer")]
        [Validation(Required=false)]
        public bool? Infer { get; set; }

        /// <summary>
        /// <para>Messages.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<AddMemoriesRequestMessages> Messages { get; set; }
        public class AddMemoriesRequestMessages : TeaModel {
            /// <summary>
            /// <para>Content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My name is Zhang San and I live in Hangzhou.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>Metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>Run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jr-80ded1d6953c64ea</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12312314214</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user_001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
