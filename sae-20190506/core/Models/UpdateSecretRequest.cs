// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateSecretRequest : TeaModel {
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public UpdateSecretRequestSecretData SecretData { get; set; }
        public class UpdateSecretRequestSecretData : TeaModel {
            [NameInMap("SecretData")]
            [Validation(Required=false)]
            public string SecretData { get; set; }

        }

        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public long? SecretId { get; set; }

    }

}
