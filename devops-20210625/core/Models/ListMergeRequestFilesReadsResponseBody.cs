// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestFilesReadsResponseBody : TeaModel {
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
        public List<ListMergeRequestFilesReadsResponseBodyResult> Result { get; set; }
        public class ListMergeRequestFilesReadsResponseBodyResult : TeaModel {
            [NameInMap("deletedFile")]
            [Validation(Required=false)]
            public string DeletedFile { get; set; }

            [NameInMap("newFile")]
            [Validation(Required=false)]
            public bool? NewFile { get; set; }

            [NameInMap("newFilePath")]
            [Validation(Required=false)]
            public string NewFilePath { get; set; }

            [NameInMap("oldFilePath")]
            [Validation(Required=false)]
            public string OldFilePath { get; set; }

            [NameInMap("readUsers")]
            [Validation(Required=false)]
            public List<ListMergeRequestFilesReadsResponseBodyResultReadUsers> ReadUsers { get; set; }
            public class ListMergeRequestFilesReadsResponseBodyResultReadUsers : TeaModel {
                [NameInMap("aliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("renamedFile")]
            [Validation(Required=false)]
            public string RenamedFile { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
