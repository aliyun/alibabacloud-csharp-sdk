// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListCommentsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListCommentsResponseBodyResult Result { get; set; }
        public class ListCommentsResponseBodyResult : TeaModel {
            [NameInMap("CommentVOList")]
            [Validation(Required=false)]
            public List<ListCommentsResponseBodyResultCommentVOList> CommentVOList { get; set; }
            public class ListCommentsResponseBodyResultCommentVOList : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("CommentId")]
                [Validation(Required=false)]
                public string CommentId { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreateAt")]
                [Validation(Required=false)]
                public long? CreateAt { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("SenderNick")]
                [Validation(Required=false)]
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

        }

    }

}
