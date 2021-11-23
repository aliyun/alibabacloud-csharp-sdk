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
                public string CreatedTime { get; set; }
                public string ModifiedTime { get; set; }
                public string RegionId { get; set; }
                public string SignatureId { get; set; }
                public string SignatureKey { get; set; }
                public string SignatureName { get; set; }
                public string SignatureSecret { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
