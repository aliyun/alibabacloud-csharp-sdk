// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchRepositoryResponseBody : TeaModel {
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
        public List<ListSearchRepositoryResponseBodyResult> Result { get; set; }
        public class ListSearchRepositoryResponseBodyResult : TeaModel {
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("highlightTextMap")]
            [Validation(Required=false)]
            public ListSearchRepositoryResponseBodyResultHighlightTextMap HighlightTextMap { get; set; }
            public class ListSearchRepositoryResponseBodyResultHighlightTextMap : TeaModel {
                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("readMe")]
                [Validation(Required=false)]
                public string ReadMe { get; set; }

                [NameInMap("repoNameWithNamespace")]
                [Validation(Required=false)]
                public string RepoNameWithNamespace { get; set; }

                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

            }

            [NameInMap("source")]
            [Validation(Required=false)]
            public ListSearchRepositoryResponseBodyResultSource Source { get; set; }
            public class ListSearchRepositoryResponseBodyResultSource : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("lastActivityTime")]
                [Validation(Required=false)]
                public string LastActivityTime { get; set; }

                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("readMe")]
                [Validation(Required=false)]
                public string ReadMe { get; set; }

                [NameInMap("repoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

                [NameInMap("visibilityLevel")]
                [Validation(Required=false)]
                public int? VisibilityLevel { get; set; }

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
