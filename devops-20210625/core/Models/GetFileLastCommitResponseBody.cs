// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetFileLastCommitResponseBody : TeaModel {
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
        public GetFileLastCommitResponseBodyResult Result { get; set; }
        public class GetFileLastCommitResponseBodyResult : TeaModel {
            [NameInMap("authorDate")]
            [Validation(Required=false)]
            public string AuthorDate { get; set; }

            [NameInMap("authorEmail")]
            [Validation(Required=false)]
            public string AuthorEmail { get; set; }

            [NameInMap("authorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }

            [NameInMap("committedDate")]
            [Validation(Required=false)]
            public string CommittedDate { get; set; }

            [NameInMap("committerEmail")]
            [Validation(Required=false)]
            public string CommitterEmail { get; set; }

            [NameInMap("committerName")]
            [Validation(Required=false)]
            public string CommitterName { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("parentIds")]
            [Validation(Required=false)]
            public List<string> ParentIds { get; set; }

            [NameInMap("shortId")]
            [Validation(Required=false)]
            public string ShortId { get; set; }

            [NameInMap("signature")]
            [Validation(Required=false)]
            public GetFileLastCommitResponseBodyResultSignature Signature { get; set; }
            public class GetFileLastCommitResponseBodyResultSignature : TeaModel {
                [NameInMap("GpgKeyId")]
                [Validation(Required=false)]
                public string GpgKeyId { get; set; }

                [NameInMap("VerificationStatus")]
                [Validation(Required=false)]
                public string VerificationStatus { get; set; }

            }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
