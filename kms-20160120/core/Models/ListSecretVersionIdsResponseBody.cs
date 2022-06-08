// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretVersionIdsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VersionIds")]
        [Validation(Required=false)]
        public ListSecretVersionIdsResponseBodyVersionIds VersionIds { get; set; }
        public class ListSecretVersionIdsResponseBodyVersionIds : TeaModel {
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public List<ListSecretVersionIdsResponseBodyVersionIdsVersionId> VersionId { get; set; }
            public class ListSecretVersionIdsResponseBodyVersionIdsVersionId : TeaModel {
                public string CreateTime { get; set; }
                public string VersionId { get; set; }
                public ListSecretVersionIdsResponseBodyVersionIdsVersionIdVersionStages VersionStages { get; set; }
                public class ListSecretVersionIdsResponseBodyVersionIdsVersionIdVersionStages : TeaModel {
                    [NameInMap("VersionStage")]
                    [Validation(Required=false)]
                    public List<string> VersionStage { get; set; }

                }
            }
        };

    }

}
