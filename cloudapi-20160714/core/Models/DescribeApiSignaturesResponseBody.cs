// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiSignaturesResponseBody : TeaModel {
        [NameInMap("ApiSignatures")]
        [Validation(Required=false)]
        public DescribeApiSignaturesResponseBodyApiSignatures ApiSignatures { get; set; }
        public class DescribeApiSignaturesResponseBodyApiSignatures : TeaModel {
            [NameInMap("ApiSignatureItem")]
            [Validation(Required=false)]
            public List<DescribeApiSignaturesResponseBodyApiSignaturesApiSignatureItem> ApiSignatureItem { get; set; }
            public class DescribeApiSignaturesResponseBodyApiSignaturesApiSignatureItem : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
