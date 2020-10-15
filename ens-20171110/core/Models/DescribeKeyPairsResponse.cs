// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeKeyPairsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("KeyPairs")]
        [Validation(Required=true)]
        public DescribeKeyPairsResponseKeyPairs KeyPairs { get; set; }
        public class DescribeKeyPairsResponseKeyPairs : TeaModel {
            [NameInMap("KeyPair")]
            [Validation(Required=true)]
            public List<DescribeKeyPairsResponseKeyPairsKeyPair> KeyPair { get; set; }
            public class DescribeKeyPairsResponseKeyPairsKeyPair : TeaModel {
                public string CreationTime { get; set; }
                public string KeyPairName { get; set; }
                public string KeyPairFingerPrint { get; set; }
            }
        };

    }

}
