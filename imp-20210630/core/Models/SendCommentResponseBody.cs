// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class SendCommentResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用发送直播间弹幕的返回结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public SendCommentResponseBodyResult Result { get; set; }
        public class SendCommentResponseBodyResult : TeaModel {
            [NameInMap("CommentVO")]
            [Validation(Required=false)]
            public SendCommentResponseBodyResultCommentVO CommentVO { get; set; }
            public class SendCommentResponseBodyResultCommentVO : TeaModel {
                /// <summary>
                /// 弹幕的唯一ID。
                /// </summary>
                [NameInMap("CommentId")]
                [Validation(Required=false)]
                public string CommentId { get; set; }

                /// <summary>
                /// 弹幕的发送者ID标识。
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                /// <summary>
                /// 弹幕发送者的昵称。
                /// </summary>
                [NameInMap("SenderNick")]
                [Validation(Required=false)]
                public string SenderNick { get; set; }

                /// <summary>
                /// 弹幕的创建时间，Unix时间戳，单位：毫秒。
                /// </summary>
                [NameInMap("CreateAt")]
                [Validation(Required=false)]
                public long? CreateAt { get; set; }

                /// <summary>
                /// 弹幕的内容。
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// 扩展字段。
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

            }
        };

    }

}
