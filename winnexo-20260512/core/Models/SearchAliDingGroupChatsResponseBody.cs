// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SearchAliDingGroupChatsResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>是否还有下一页</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchAliDingGroupChatsResponseBodyItems> Items { get; set; }
        public class SearchAliDingGroupChatsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>阿里钉群聊 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cid-example</para>
            /// </summary>
            [NameInMap("chatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            /// <summary>
            /// <para>会话类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNAL_GROUP</para>
            /// </summary>
            [NameInMap("conversationType")]
            [Validation(Required=false)]
            public string ConversationType { get; set; }

            /// <summary>
            /// <para>当前用户是否开启免打扰</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("muted")]
            [Validation(Required=false)]
            public bool? Muted { get; set; }

            /// <summary>
            /// <para>群聊标题</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户项目群</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>下一页分页游标，末页为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-id</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
