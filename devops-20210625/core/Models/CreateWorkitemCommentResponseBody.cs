// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemCommentResponseBody : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public CreateWorkitemCommentResponseBodyComment Comment { get; set; }
        public class CreateWorkitemCommentResponseBodyComment : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("formatType")]
            [Validation(Required=false)]
            public string FormatType { get; set; }

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

            [NameInMap("user")]
            [Validation(Required=false)]
            public CreateWorkitemCommentResponseBodyCommentUser User { get; set; }
            public class CreateWorkitemCommentResponseBodyCommentUser : TeaModel {
                [NameInMap("account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("realName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

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
