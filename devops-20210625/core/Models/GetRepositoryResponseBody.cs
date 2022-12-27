// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetRepositoryResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("repository")]
        [Validation(Required=false)]
        public GetRepositoryResponseBodyRepository Repository { get; set; }
        public class GetRepositoryResponseBodyRepository : TeaModel {
            [NameInMap("archive")]
            [Validation(Required=false)]
            public bool? Archive { get; set; }

            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            [NameInMap("defaultBranch")]
            [Validation(Required=false)]
            public string DefaultBranch { get; set; }

            [NameInMap("demoProjectStatus")]
            [Validation(Required=false)]
            public bool? DemoProjectStatus { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("httpUrlToRepository")]
            [Validation(Required=false)]
            public string HttpUrlToRepository { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("lastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public GetRepositoryResponseBodyRepositoryNamespace Namespace { get; set; }
            public class GetRepositoryResponseBodyRepositoryNamespace : TeaModel {
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ownerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                [NameInMap("visibilityLevel")]
                [Validation(Required=false)]
                public int? VisibilityLevel { get; set; }

            }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("pathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            [NameInMap("sshUrlToRepository")]
            [Validation(Required=false)]
            public string SshUrlToRepository { get; set; }

            [NameInMap("visibilityLevel")]
            [Validation(Required=false)]
            public int? VisibilityLevel { get; set; }

            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
