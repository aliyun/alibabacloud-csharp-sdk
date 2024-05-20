// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateSecretRequest : TeaModel {
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
        public CreateSecretRequestSecretData SecretData { get; set; }
        public class CreateSecretRequestSecretData : TeaModel {
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
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

    }

}
