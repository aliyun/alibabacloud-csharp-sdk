// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListCommentsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用查询弹幕消息列表的返回结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListCommentsResponseBodyResult Result { get; set; }
        public class ListCommentsResponseBodyResult : TeaModel {
            [NameInMap("CommentVOList")]
            [Validation(Required=false)]
            public List<ListCommentsResponseBodyResultCommentVOList> CommentVOList { get; set; }
            public class ListCommentsResponseBodyResultCommentVOList : TeaModel {
                public string AppId { get; set; }
                public string CommentId { get; set; }
                public string Content { get; set; }
                public long? CreateAt { get; set; }
                public Dictionary<string, string> Extension { get; set; }
                public string RoomId { get; set; }
                public string SenderId { get; set; }
                public string SenderNick { get; set; }
            }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
