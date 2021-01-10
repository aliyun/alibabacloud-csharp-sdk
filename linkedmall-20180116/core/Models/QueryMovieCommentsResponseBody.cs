// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryMovieCommentsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("CommentList")]
        [Validation(Required=false)]
        public QueryMovieCommentsResponseBodyCommentList CommentList { get; set; }
        public class QueryMovieCommentsResponseBodyCommentList : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public List<QueryMovieCommentsResponseBodyCommentListComment> Comment { get; set; }
            public class QueryMovieCommentsResponseBodyCommentListComment : TeaModel {
                public long? Remark { get; set; }
                public long? FavorCount { get; set; }
                public string Subject { get; set; }
                public long? MovieId { get; set; }
                public string NickName { get; set; }
                public string Content { get; set; }
                public long? Id { get; set; }
                public string CommentTime { get; set; }
            }
        };

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
