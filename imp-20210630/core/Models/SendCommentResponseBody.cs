// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class SendCommentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public SendCommentResponseBodyResult Result { get; set; }
        public class SendCommentResponseBodyResult : TeaModel {
            [NameInMap("CommentVO")]
            [Validation(Required=false)]
            public SendCommentResponseBodyResultCommentVO CommentVO { get; set; }
            public class SendCommentResponseBodyResultCommentVO : TeaModel {
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

                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("SenderNick")]
                [Validation(Required=false)]
                public string SenderNick { get; set; }

            }

        }

    }

}
