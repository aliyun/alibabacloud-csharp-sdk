// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretVersionIdsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the secret.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of secret versions.
        /// </summary>
        [NameInMap("VersionIds")]
        [Validation(Required=false)]
        public ListSecretVersionIdsResponseBodyVersionIds VersionIds { get; set; }
        public class ListSecretVersionIdsResponseBodyVersionIds : TeaModel {
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public List<ListSecretVersionIdsResponseBodyVersionIdsVersionId> VersionId { get; set; }
            public class ListSecretVersionIdsResponseBodyVersionIdsVersionId : TeaModel {
                /// <summary>
                /// The time when the secret version was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

                /// <summary>
                /// The stage labels that mark the secret version.
                /// </summary>
                [NameInMap("VersionStages")]
                [Validation(Required=false)]
                public ListSecretVersionIdsResponseBodyVersionIdsVersionIdVersionStages VersionStages { get; set; }
                public class ListSecretVersionIdsResponseBodyVersionIdsVersionIdVersionStages : TeaModel {
                    [NameInMap("VersionStage")]
                    [Validation(Required=false)]
                    public List<string> VersionStage { get; set; }

                }

            }

        }

    }

}
