// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateDialogAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// <para>A list of analysis nodes. If you leave this parameter empty, all nodes are analyzed. You can specify one or more nodes.</para>
        /// </summary>
        [NameInMap("analysisNodes")]
        [Validation(Required=false)]
        public List<string> AnalysisNodes { get; set; }

        /// <summary>
        /// <para>The session content. You can specify multiple sessions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("conversationList")]
        [Validation(Required=false)]
        public List<CreateDialogAnalysisTaskRequestConversationList> ConversationList { get; set; }
        public class CreateDialogAnalysisTaskRequestConversationList : TeaModel {
            /// <summary>
            /// <para>A list of dialogues.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dialogueList")]
            [Validation(Required=false)]
            public List<CreateDialogAnalysisTaskRequestConversationListDialogueList> DialogueList { get; set; }
            public class CreateDialogAnalysisTaskRequestConversationListDialogueList : TeaModel {
                /// <summary>
                /// <para>The content of the dialogue.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>您好，我是2001，很高兴为您服务！</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

        }

        /// <summary>
        /// <para>The metadata. This includes business-related properties that are used during session analysis. The business system passes these properties in real time when it initiates the analysis task.</para>
        /// <pre><c>{
        ///   &quot;labels&quot;: &quot;XXX&quot;,  // Tags
        ///   &quot;summaryConstraints&quot;: &quot;XXX&quot;,   // Summary dimensions
        ///   &quot;sopInfo&quot;: &quot;XXX&quot;  // SOP information
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;labels&quot;: &quot;XXX&quot;,
        /// &quot;summaryConstraints&quot;: &quot;XXX&quot;,
        /// &quot;sopInfo&quot;: &quot;XXX&quot;
        /// }</para>
        /// </summary>
        [NameInMap("metaData")]
        [Validation(Required=false)]
        public Dictionary<string, object> MetaData { get; set; }

        /// <summary>
        /// <para>The session scenario code, which is associated with the session analysis configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("playCode")]
        [Validation(Required=false)]
        public string PlayCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FC6636E-380A-5369-AE01-D1C15BB9B254</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
