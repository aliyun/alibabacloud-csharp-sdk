// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class TransferRepositoryResponseBody : TeaModel {
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
        public TransferRepositoryResponseBodyResult Result { get; set; }
        public class TransferRepositoryResponseBodyResult : TeaModel {
            [NameInMap("accessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }

            [NameInMap("archived")]
            [Validation(Required=false)]
            public bool? Archived { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            [NameInMap("demoProject")]
            [Validation(Required=false)]
            public bool? DemoProject { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

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

            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public long? NamespaceId { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("pathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            [NameInMap("starCount")]
            [Validation(Required=false)]
            public long? StarCount { get; set; }

            [NameInMap("starred")]
            [Validation(Required=false)]
            public bool? Starred { get; set; }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("visibilityLevel")]
            [Validation(Required=false)]
            public int? VisibilityLevel { get; set; }

            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
