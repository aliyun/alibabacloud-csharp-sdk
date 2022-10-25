// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class UpdateRepositoryResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateRepositoryResponseBodyResult Result { get; set; }
        public class UpdateRepositoryResponseBodyResult : TeaModel {
            [NameInMap("Archive")]
            [Validation(Required=false)]
            public bool? Archive { get; set; }

            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            [NameInMap("DefaultBranch")]
            [Validation(Required=false)]
            public string DefaultBranch { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HttpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public UpdateRepositoryResponseBodyResultNamespace Namespace { get; set; }
            public class UpdateRepositoryResponseBodyResultNamespace : TeaModel {
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Public")]
                [Validation(Required=false)]
                public bool? Public { get; set; }

                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                [NameInMap("VisibilityLevel")]
                [Validation(Required=false)]
                public string VisibilityLevel { get; set; }

            }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("PathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            [NameInMap("SshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }

            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public string VisibilityLevel { get; set; }

            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
