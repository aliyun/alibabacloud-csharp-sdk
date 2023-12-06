// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetMergeRequestChangeTreeResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMergeRequestChangeTreeResponseBodyResult Result { get; set; }
        public class GetMergeRequestChangeTreeResponseBodyResult : TeaModel {
            [NameInMap("changedFilesCount")]
            [Validation(Required=false)]
            public long? ChangedFilesCount { get; set; }

            [NameInMap("changedFilesInfos")]
            [Validation(Required=false)]
            public List<GetMergeRequestChangeTreeResponseBodyResultChangedFilesInfos> ChangedFilesInfos { get; set; }
            public class GetMergeRequestChangeTreeResponseBodyResultChangedFilesInfos : TeaModel {
                [NameInMap("addLines")]
                [Validation(Required=false)]
                public long? AddLines { get; set; }

                [NameInMap("binaryFile")]
                [Validation(Required=false)]
                public bool? BinaryFile { get; set; }

                [NameInMap("delLines")]
                [Validation(Required=false)]
                public long? DelLines { get; set; }

                [NameInMap("deletedFile")]
                [Validation(Required=false)]
                public bool? DeletedFile { get; set; }

                [NameInMap("newFile")]
                [Validation(Required=false)]
                public bool? NewFile { get; set; }

                [NameInMap("newPath")]
                [Validation(Required=false)]
                public string NewPath { get; set; }

                [NameInMap("oldPath")]
                [Validation(Required=false)]
                public string OldPath { get; set; }

                [NameInMap("renamedFile")]
                [Validation(Required=false)]
                public bool? RenamedFile { get; set; }

            }

            [NameInMap("totalAddLines")]
            [Validation(Required=false)]
            public long? TotalAddLines { get; set; }

            [NameInMap("totalDelLines")]
            [Validation(Required=false)]
            public long? TotalDelLines { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
