// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListMergeRequestCommentsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListMergeRequestCommentsResponseBodyResult> Result { get; set; }
        public class ListMergeRequestCommentsResponseBodyResult : TeaModel {
            [NameInMap("OutDated")]
            [Validation(Required=false)]
            public bool? OutDated { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("RangeContext")]
            [Validation(Required=false)]
            public string RangeContext { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("ParentNoteId")]
            [Validation(Required=false)]
            public long? ParentNoteId { get; set; }

            [NameInMap("IsDraft")]
            [Validation(Required=false)]
            public bool? IsDraft { get; set; }

            [NameInMap("Closed")]
            [Validation(Required=false)]
            public int? Closed { get; set; }

            [NameInMap("Line")]
            [Validation(Required=false)]
            public long? Line { get; set; }

            [NameInMap("Side")]
            [Validation(Required=false)]
            public string Side { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Author")]
            [Validation(Required=false)]
            public ListMergeRequestCommentsResponseBodyResultAuthor Author { get; set; }
            public class ListMergeRequestCommentsResponseBodyResultAuthor : TeaModel {
                [NameInMap("ExternUserId")]
                [Validation(Required=false)]
                public string ExternUserId { get; set; }
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }
            };

        }

    }

}
