// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListRepositoryCommitDiffResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListRepositoryCommitDiffResponseBodyResult> Result { get; set; }
        public class ListRepositoryCommitDiffResponseBodyResult : TeaModel {
            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public bool? DeletedFile { get; set; }

            [NameInMap("Diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }

            [NameInMap("OldPath")]
            [Validation(Required=false)]
            public string OldPath { get; set; }

            [NameInMap("OldId")]
            [Validation(Required=false)]
            public string OldId { get; set; }

            [NameInMap("BMode")]
            [Validation(Required=false)]
            public string BMode { get; set; }

            [NameInMap("IsOldLfs")]
            [Validation(Required=false)]
            public bool? IsOldLfs { get; set; }

            [NameInMap("IsNewLfs")]
            [Validation(Required=false)]
            public bool? IsNewLfs { get; set; }

            [NameInMap("RenamedFile")]
            [Validation(Required=false)]
            public bool? RenamedFile { get; set; }

            [NameInMap("NewFile")]
            [Validation(Required=false)]
            public bool? NewFile { get; set; }

            [NameInMap("NewId")]
            [Validation(Required=false)]
            public string NewId { get; set; }

            [NameInMap("IsBinary")]
            [Validation(Required=false)]
            public bool? IsBinary { get; set; }

            [NameInMap("NewPath")]
            [Validation(Required=false)]
            public string NewPath { get; set; }

            [NameInMap("AMode")]
            [Validation(Required=false)]
            public string AMode { get; set; }

        }

    }

}
