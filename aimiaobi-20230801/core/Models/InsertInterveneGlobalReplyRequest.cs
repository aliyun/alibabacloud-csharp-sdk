// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class InsertInterveneGlobalReplyRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier of the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>List of reply content</para>
        /// </summary>
        [NameInMap("ReplyMessagList")]
        [Validation(Required=false)]
        public List<InsertInterveneGlobalReplyRequestReplyMessagList> ReplyMessagList { get; set; }
        public class InsertInterveneGlobalReplyRequestReplyMessagList : TeaModel {
            /// <summary>
            /// <para>Reply content</para>
            /// 
            /// <b>Example:</b>
            /// <para>抱歉，问题我无法回答</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Reply type</para>
            /// 
            /// <b>Example:</b>
            /// <para>全局回复的类型</para>
            /// </summary>
            [NameInMap("ReplyType")]
            [Validation(Required=false)]
            public string ReplyType { get; set; }

        }

    }

}
