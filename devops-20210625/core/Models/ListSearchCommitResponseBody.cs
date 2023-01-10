// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchCommitResponseBody : TeaModel {
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
        public List<ListSearchCommitResponseBodyResult> Result { get; set; }
        public class ListSearchCommitResponseBodyResult : TeaModel {
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("highlightTextMap")]
            [Validation(Required=false)]
            public ListSearchCommitResponseBodyResultHighlightTextMap HighlightTextMap { get; set; }
            public class ListSearchCommitResponseBodyResultHighlightTextMap : TeaModel {
                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("commitMessage")]
                [Validation(Required=false)]
                public string CommitMessage { get; set; }

                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("source")]
            [Validation(Required=false)]
            public ListSearchCommitResponseBodyResultSource Source { get; set; }
            public class ListSearchCommitResponseBodyResultSource : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public ListSearchCommitResponseBodyResultSourceAuthor Author { get; set; }
                public class ListSearchCommitResponseBodyResultSourceAuthor : TeaModel {
                    [NameInMap("email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("authorTime")]
                [Validation(Required=false)]
                public string AuthorTime { get; set; }

                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("commitMessage")]
                [Validation(Required=false)]
                public string CommitMessage { get; set; }

                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
