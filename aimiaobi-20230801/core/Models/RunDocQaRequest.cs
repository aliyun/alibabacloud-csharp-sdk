// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocQaRequest : TeaModel {
        /// <summary>
        /// <para>Array of folder IDs for filtering. This parameter takes effect only when SearchSource is set to fromIndexLib.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// <para>Array of historical context content</para>
        /// </summary>
        [NameInMap("ConversationContexts")]
        [Validation(Required=false)]
        public List<RunDocQaRequestConversationContexts> ConversationContexts { get; set; }
        public class RunDocQaRequestConversationContexts : TeaModel {
            /// <summary>
            /// <para>Q&amp;A pair content</para>
            /// 
            /// <b>Example:</b>
            /// <para>问答内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Role</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>Array of multiple document IDs</para>
        /// </summary>
        [NameInMap("DocIds")]
        [Validation(Required=false)]
        public List<string> DocIds { get; set; }

        /// <summary>
        /// <para>Custom model name defined by the User</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Question</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>苹果16手机什么时候发布</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Associated content actively provided by the questioner</para>
        /// 
        /// <b>Example:</b>
        /// <para>关联内容</para>
        /// </summary>
        [NameInMap("ReferenceContent")]
        [Validation(Required=false)]
        public string ReferenceContent { get; set; }

        /// <summary>
        /// <para>Search source</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fromWeb</para>
        /// </summary>
        [NameInMap("SearchSource")]
        [Validation(Required=false)]
        public string SearchSource { get; set; }

        /// <summary>
        /// <para>Conversation ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f486c4e2-b773-4d65-88f8-2ba540610456</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud Model Studio workspace ID. For details on how to obtain it, see <a href="https://help.aliyun.com/document_detail/2587495.html">How to Use Workspaces</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-dswd4003ny4gh9rw</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
