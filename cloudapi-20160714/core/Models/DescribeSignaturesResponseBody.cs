// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSignaturesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SignatureInfos")]
        [Validation(Required=false)]
        public DescribeSignaturesResponseBodySignatureInfos SignatureInfos { get; set; }
        public class DescribeSignaturesResponseBodySignatureInfos : TeaModel {
            [NameInMap("SignatureInfo")]
            [Validation(Required=false)]
            public List<DescribeSignaturesResponseBodySignatureInfosSignatureInfo> SignatureInfo { get; set; }
            public class DescribeSignaturesResponseBodySignatureInfosSignatureInfo : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                [NameInMap("SignatureKey")]
                [Validation(Required=false)]
                public string SignatureKey { get; set; }

                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

                [NameInMap("SignatureSecret")]
                [Validation(Required=false)]
                public string SignatureSecret { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
