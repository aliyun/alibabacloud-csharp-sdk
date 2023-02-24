// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class PutSecretValueResponseBody : TeaModel {
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
        /// The new version of the secret value.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// The stage labels that are used to mark the new version.
        /// </summary>
        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public PutSecretValueResponseBodyVersionStages VersionStages { get; set; }
        public class PutSecretValueResponseBodyVersionStages : TeaModel {
            [NameInMap("VersionStage")]
            [Validation(Required=false)]
            public List<string> VersionStage { get; set; }

        }

    }

}
