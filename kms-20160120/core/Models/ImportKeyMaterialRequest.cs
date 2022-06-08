// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ImportKeyMaterialRequest : TeaModel {
        [NameInMap("EncryptedKeyMaterial")]
        [Validation(Required=false)]
        public string EncryptedKeyMaterial { get; set; }

        [NameInMap("ImportToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("KeyMaterialExpireUnix")]
        [Validation(Required=false)]
        public long? KeyMaterialExpireUnix { get; set; }

    }

}
