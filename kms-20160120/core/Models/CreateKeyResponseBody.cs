// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyResponseBody : TeaModel {
        [NameInMap("KeyMetadata")]
        [Validation(Required=false)]
        public CreateKeyResponseBodyKeyMetadata KeyMetadata { get; set; }
        public class CreateKeyResponseBodyKeyMetadata : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }
            [NameInMap("AutomaticRotation")]
            [Validation(Required=false)]
            public string AutomaticRotation { get; set; }
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }
            [NameInMap("KeySpec")]
            [Validation(Required=false)]
            public string KeySpec { get; set; }
            [NameInMap("KeyState")]
            [Validation(Required=false)]
            public string KeyState { get; set; }
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }
            [NameInMap("LastRotationDate")]
            [Validation(Required=false)]
            public string LastRotationDate { get; set; }
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }
            [NameInMap("NextRotationDate")]
            [Validation(Required=false)]
            public string NextRotationDate { get; set; }
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }
            [NameInMap("PrimaryKeyVersion")]
            [Validation(Required=false)]
            public string PrimaryKeyVersion { get; set; }
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }
            [NameInMap("RotationInterval")]
            [Validation(Required=false)]
            public string RotationInterval { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
