// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmGetShowCommentsResponseBody : TeaModel {
        [NameInMap("CommentList")]
        [Validation(Required=false)]
        public List<TaobaoFilmGetShowCommentsResponseBodyCommentList> CommentList { get; set; }
        public class TaobaoFilmGetShowCommentsResponseBodyCommentList : TeaModel {
            [NameInMap("CommentTime")]
            [Validation(Required=false)]
            public string CommentTime { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("FavorCount")]
            [Validation(Required=false)]
            public long? FavorCount { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public long? Remark { get; set; }

            [NameInMap("ShowId")]
            [Validation(Required=false)]
            public long? ShowId { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMsg")]
        [Validation(Required=false)]
        public string SubMsg { get; set; }

    }

}
