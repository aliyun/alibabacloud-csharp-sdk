// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSignaturesByApiResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Signatures")]
        [Validation(Required=false)]
        public DescribeSignaturesByApiResponseBodySignatures Signatures { get; set; }
        public class DescribeSignaturesByApiResponseBodySignatures : TeaModel {
            [NameInMap("SignatureItem")]
            [Validation(Required=false)]
            public List<DescribeSignaturesByApiResponseBodySignaturesSignatureItem> SignatureItem { get; set; }
            public class DescribeSignaturesByApiResponseBodySignaturesSignatureItem : TeaModel {
                public string BoundTime { get; set; }
                public string SignatureId { get; set; }
                public string SignatureName { get; set; }
            }
        };

    }

}
