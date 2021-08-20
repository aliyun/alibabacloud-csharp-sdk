// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetRepositoryInfoResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRepositoryInfoResponseBodyResult Result { get; set; }
        public class GetRepositoryInfoResponseBodyResult : TeaModel {
            [NameInMap("LastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }
            [NameInMap("DefaultBranch")]
            [Validation(Required=false)]
            public string DefaultBranch { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("Archive")]
            [Validation(Required=false)]
            public bool? Archive { get; set; }
            [NameInMap("ImportUrl")]
            [Validation(Required=false)]
            public string ImportUrl { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("DemoProjectStatus")]
            [Validation(Required=false)]
            public bool? DemoProjectStatus { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }
            [NameInMap("ImportStatus")]
            [Validation(Required=false)]
            public string ImportStatus { get; set; }
            [NameInMap("HttpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }
            [NameInMap("Public")]
            [Validation(Required=false)]
            public bool? Public { get; set; }
            [NameInMap("PathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public string VisibilityLevel { get; set; }
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }
            [NameInMap("ImportFromSubversion")]
            [Validation(Required=false)]
            public bool? ImportFromSubversion { get; set; }
            [NameInMap("SshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public GetRepositoryInfoResponseBodyResultNamespace Namespace { get; set; }
            public class GetRepositoryInfoResponseBodyResultNamespace : TeaModel {
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Public")]
                [Validation(Required=false)]
                public bool? Public { get; set; }

                [NameInMap("VisibilityLevel")]
                [Validation(Required=false)]
                public string VisibilityLevel { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }
            [NameInMap("Permissions")]
            [Validation(Required=false)]
            public GetRepositoryInfoResponseBodyResultPermissions Permissions { get; set; }
            public class GetRepositoryInfoResponseBodyResultPermissions : TeaModel {
                [NameInMap("ProjectAccess")]
                [Validation(Required=false)]
                public GetRepositoryInfoResponseBodyResultPermissionsProjectAccess ProjectAccess { get; set; }
                public class GetRepositoryInfoResponseBodyResultPermissionsProjectAccess : TeaModel {
                    [NameInMap("AccessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }
                };

                [NameInMap("GroupAccess")]
                [Validation(Required=false)]
                public GetRepositoryInfoResponseBodyResultPermissionsGroupAccess GroupAccess { get; set; }
                public class GetRepositoryInfoResponseBodyResultPermissionsGroupAccess : TeaModel {
                    [NameInMap("AccessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }
                };

            }
        };

    }

}
