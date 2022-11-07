// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkitemCommentListResponseBody : TeaModel {
        [NameInMap("commentList")]
        [Validation(Required=false)]
        public List<GetWorkitemCommentListResponseBodyCommentList> CommentList { get; set; }
        public class GetWorkitemCommentListResponseBodyCommentList : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("formatType")]
            [Validation(Required=false)]
            public string FormatType { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("isTop")]
            [Validation(Required=false)]
            public bool? IsTop { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("parentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            [NameInMap("targetIdentifier")]
            [Validation(Required=false)]
            public string TargetIdentifier { get; set; }

            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("topTime")]
            [Validation(Required=false)]
            public long? TopTime { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
