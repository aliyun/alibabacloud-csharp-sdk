// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("KeyVersion")]
        [Validation(Required=false)]
        public CreateKeyVersionResponseBodyKeyVersion KeyVersion { get; set; }
        public class CreateKeyVersionResponseBodyKeyVersion : TeaModel {
            [NameInMap("KeyVersionId")]
            [Validation(Required=false)]
            public string KeyVersionId { get; set; }
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }
        };

    }

}
