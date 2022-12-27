// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListGroupRepositoriesResponseBody : TeaModel {
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
        public List<ListGroupRepositoriesResponseBodyResult> Result { get; set; }
        public class ListGroupRepositoriesResponseBodyResult : TeaModel {
            [NameInMap("archived")]
            [Validation(Required=false)]
            public bool? Archived { get; set; }

            [NameInMap("commitCount")]
            [Validation(Required=false)]
            public long? CommitCount { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("httpUrl")]
            [Validation(Required=false)]
            public string HttpUrl { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("importUrl")]
            [Validation(Required=false)]
            public string ImportUrl { get; set; }

            [NameInMap("isStared")]
            [Validation(Required=false)]
            public bool? IsStared { get; set; }

            [NameInMap("issuesEnabled")]
            [Validation(Required=false)]
            public bool? IssuesEnabled { get; set; }

            [NameInMap("lastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }

            [NameInMap("mergeRequestsEnabled")]
            [Validation(Required=false)]
            public bool? MergeRequestsEnabled { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public bool? NamespaceId { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("pathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            [NameInMap("privateFlag")]
            [Validation(Required=false)]
            public bool? PrivateFlag { get; set; }

            [NameInMap("snippetsEnabled")]
            [Validation(Required=false)]
            public bool? SnippetsEnabled { get; set; }

            [NameInMap("sshUrl")]
            [Validation(Required=false)]
            public string SshUrl { get; set; }

            [NameInMap("starCount")]
            [Validation(Required=false)]
            public int? StarCount { get; set; }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("visibilityLevel")]
            [Validation(Required=false)]
            public int? VisibilityLevel { get; set; }

            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

            [NameInMap("wikiEnabled")]
            [Validation(Required=false)]
            public bool? WikiEnabled { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
