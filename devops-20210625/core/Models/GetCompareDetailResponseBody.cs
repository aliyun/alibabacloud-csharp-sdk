// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetCompareDetailResponseBody : TeaModel {
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
        public GetCompareDetailResponseBodyResult Result { get; set; }
        public class GetCompareDetailResponseBodyResult : TeaModel {
            [NameInMap("commits")]
            [Validation(Required=false)]
            public List<GetCompareDetailResponseBodyResultCommits> Commits { get; set; }
            public class GetCompareDetailResponseBodyResultCommits : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public GetCompareDetailResponseBodyResultCommitsAuthor Author { get; set; }
                public class GetCompareDetailResponseBodyResultCommitsAuthor : TeaModel {
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
                public GetCompareDetailResponseBodyResultCommitsCommitter Committer { get; set; }
                public class GetCompareDetailResponseBodyResultCommitsCommitter : TeaModel {
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

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("diffs")]
            [Validation(Required=false)]
            public List<GetCompareDetailResponseBodyResultDiffs> Diffs { get; set; }
            public class GetCompareDetailResponseBodyResultDiffs : TeaModel {
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

            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<string> Messages { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
