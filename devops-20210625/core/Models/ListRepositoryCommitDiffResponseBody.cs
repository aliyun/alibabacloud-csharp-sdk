// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoryCommitDiffResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListRepositoryCommitDiffResponseBodyResult> Result { get; set; }
        public class ListRepositoryCommitDiffResponseBodyResult : TeaModel {
            [NameInMap("aMode")]
            [Validation(Required=false)]
            public string AMode { get; set; }

            [NameInMap("bMode")]
            [Validation(Required=false)]
            public string BMode { get; set; }

            [NameInMap("deletedFile")]
            [Validation(Required=false)]
            public bool? DeletedFile { get; set; }

            [NameInMap("diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }

            [NameInMap("isBinary")]
            [Validation(Required=false)]
            public bool? IsBinary { get; set; }

            [NameInMap("isNewLfs")]
            [Validation(Required=false)]
            public bool? IsNewLfs { get; set; }

            [NameInMap("isOldLfs")]
            [Validation(Required=false)]
            public bool? IsOldLfs { get; set; }

            [NameInMap("newFile")]
            [Validation(Required=false)]
            public bool? NewFile { get; set; }

            [NameInMap("newId")]
            [Validation(Required=false)]
            public string NewId { get; set; }

            [NameInMap("newPath")]
            [Validation(Required=false)]
            public string NewPath { get; set; }

            [NameInMap("oldId")]
            [Validation(Required=false)]
            public string OldId { get; set; }

            [NameInMap("oldPath")]
            [Validation(Required=false)]
            public string OldPath { get; set; }

            [NameInMap("renamedFile")]
            [Validation(Required=false)]
            public bool? RenamedFile { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
