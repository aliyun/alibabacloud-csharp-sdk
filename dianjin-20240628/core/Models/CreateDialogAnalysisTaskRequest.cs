// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateDialogAnalysisTaskRequest : TeaModel {
        [NameInMap("analysisNodes")]
        [Validation(Required=false)]
        public List<string> AnalysisNodes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("conversationList")]
        [Validation(Required=false)]
        public List<CreateDialogAnalysisTaskRequestConversationList> ConversationList { get; set; }
        public class CreateDialogAnalysisTaskRequestConversationList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dialogueList")]
            [Validation(Required=false)]
            public List<CreateDialogAnalysisTaskRequestConversationListDialogueList> DialogueList { get; set; }
            public class CreateDialogAnalysisTaskRequestConversationListDialogueList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("playCode")]
        [Validation(Required=false)]
        public string PlayCode { get; set; }

        /// <summary>
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
