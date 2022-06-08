// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ReEncryptResponseBody : TeaModel {
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
