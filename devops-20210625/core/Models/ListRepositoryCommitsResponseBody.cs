// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoryCommitsResponseBody : TeaModel {
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
        public List<ListRepositoryCommitsResponseBodyResult> Result { get; set; }
        public class ListRepositoryCommitsResponseBodyResult : TeaModel {
            [NameInMap("author")]
            [Validation(Required=false)]
            public ListRepositoryCommitsResponseBodyResultAuthor Author { get; set; }
            public class ListRepositoryCommitsResponseBodyResultAuthor : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("websiteUrl")]
                [Validation(Required=false)]
                public string WebsiteUrl { get; set; }

            }

            [NameInMap("authorEmail")]
            [Validation(Required=false)]
            public string AuthorEmail { get; set; }

            [NameInMap("authorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }

            [NameInMap("authoredDate")]
            [Validation(Required=false)]
            public string AuthoredDate { get; set; }

            [NameInMap("commentsCount")]
            [Validation(Required=false)]
            public long? CommentsCount { get; set; }

            [NameInMap("committedDate")]
            [Validation(Required=false)]
            public string CommittedDate { get; set; }

            [NameInMap("committer")]
            [Validation(Required=false)]
            public ListRepositoryCommitsResponseBodyResultCommitter Committer { get; set; }
            public class ListRepositoryCommitsResponseBodyResultCommitter : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("websiteUrl")]
                [Validation(Required=false)]
                public string WebsiteUrl { get; set; }

            }

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
            public ListRepositoryCommitsResponseBodyResultSignature Signature { get; set; }
            public class ListRepositoryCommitsResponseBodyResultSignature : TeaModel {
                [NameInMap("gpgKeyId")]
                [Validation(Required=false)]
                public string GpgKeyId { get; set; }

                [NameInMap("verificationStatus")]
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

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
