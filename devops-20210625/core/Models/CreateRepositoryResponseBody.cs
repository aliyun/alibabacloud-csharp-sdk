// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateRepositoryResponseBody : TeaModel {
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
        public CreateRepositoryResponseBodyResult Result { get; set; }
        public class CreateRepositoryResponseBodyResult : TeaModel {
            [NameInMap("Import_from_svn")]
            [Validation(Required=false)]
            public bool? ImportFromSvn { get; set; }

            [NameInMap("archived")]
            [Validation(Required=false)]
            public bool? Archived { get; set; }

            [NameInMap("avatar_url")]
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

            [NameInMap("demoProject")]
            [Validation(Required=false)]
            public bool? DemoProject { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("httpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }

            /// <summary>
            /// id
            /// </summary>
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
            public CreateRepositoryResponseBodyResultNamespace Namespace { get; set; }
            public class CreateRepositoryResponseBodyResultNamespace : TeaModel {
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

                [NameInMap("public")]
                [Validation(Required=false)]
                public bool? Public { get; set; }

                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                [NameInMap("visibilityLevel")]
                [Validation(Required=false)]
                public string VisibilityLevel { get; set; }

            }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("pathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            [NameInMap("sshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }

            [NameInMap("visibilityLevel")]
            [Validation(Required=false)]
            public string VisibilityLevel { get; set; }

            /// <summary>
            /// web url
            /// </summary>
            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
