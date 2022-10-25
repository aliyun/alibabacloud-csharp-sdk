// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class CreateMergeRequestCommentResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateMergeRequestCommentResponseBodyResult Result { get; set; }
        public class CreateMergeRequestCommentResponseBodyResult : TeaModel {
            [NameInMap("Author")]
            [Validation(Required=false)]
            public CreateMergeRequestCommentResponseBodyResultAuthor Author { get; set; }
            public class CreateMergeRequestCommentResponseBodyResultAuthor : TeaModel {
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("ExternUserId")]
                [Validation(Required=false)]
                public string ExternUserId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Closed")]
            [Validation(Required=false)]
            public int? Closed { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsDraft")]
            [Validation(Required=false)]
            public bool? IsDraft { get; set; }

            [NameInMap("Line")]
            [Validation(Required=false)]
            public long? Line { get; set; }

            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("OutDated")]
            [Validation(Required=false)]
            public bool? OutDated { get; set; }

            [NameInMap("ParentNoteId")]
            [Validation(Required=false)]
            public long? ParentNoteId { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("RangeContext")]
            [Validation(Required=false)]
            public string RangeContext { get; set; }

            [NameInMap("Side")]
            [Validation(Required=false)]
            public string Side { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
