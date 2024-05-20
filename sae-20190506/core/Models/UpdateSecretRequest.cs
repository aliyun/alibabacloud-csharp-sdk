// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateSecretRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public UpdateSecretRequestSecretData SecretData { get; set; }
        public class UpdateSecretRequestSecretData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("SecretData")]
            [Validation(Required=false)]
            public string SecretData { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public long? SecretId { get; set; }

    }

}
