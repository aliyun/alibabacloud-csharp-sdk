// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricVerifyResponseBody : TeaModel {
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public bool? Value { get; set; }

    }

}
