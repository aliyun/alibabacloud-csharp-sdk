// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretShrinkRequest : TeaModel {
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public UpdateSecretShrinkRequestExtendedConfig ExtendedConfig { get; set; }
        public class UpdateSecretShrinkRequestExtendedConfig : TeaModel {
            /// <summary>
            /// The custom data in the extended configuration of the secret.
            /// 
            /// > *   If this parameter is specified, the existing extended configuration of the secret is updated.
            /// > *   This parameter is unavailable for generic secrets.
            /// </summary>
            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }

        }

        /// <summary>
        /// The description of the secret.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
