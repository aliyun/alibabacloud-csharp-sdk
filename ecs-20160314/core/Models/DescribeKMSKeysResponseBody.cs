// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeKMSKeysResponseBody : TeaModel {
        [NameInMap("KMSKeyIds")]
        [Validation(Required=false)]
        public DescribeKMSKeysResponseBodyKMSKeyIds KMSKeyIds { get; set; }
        public class DescribeKMSKeysResponseBodyKMSKeyIds : TeaModel {
            [NameInMap("kmsKeyId")]
            [Validation(Required=false)]
            public List<string> KmsKeyId { get; set; }

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
