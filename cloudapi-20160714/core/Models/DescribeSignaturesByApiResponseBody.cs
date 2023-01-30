// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSignaturesByApiResponseBody : TeaModel {
        /// <summary>
        /// The returned signature key information. It is an array consisting of SignatureItem data.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the key was bound.
        /// </summary>
        [NameInMap("Signatures")]
        [Validation(Required=false)]
        public DescribeSignaturesByApiResponseBodySignatures Signatures { get; set; }
        public class DescribeSignaturesByApiResponseBodySignatures : TeaModel {
            [NameInMap("SignatureItem")]
            [Validation(Required=false)]
            public List<DescribeSignaturesByApiResponseBodySignaturesSignatureItem> SignatureItem { get; set; }
            public class DescribeSignaturesByApiResponseBodySignaturesSignatureItem : TeaModel {
                /// <summary>
                /// The ID of the backend signature key.
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// The name of the backend signature key.
                /// </summary>
                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                /// <summary>
                /// *   This API is intended for API providers.
                /// </summary>
                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

            }

        }

    }

}
