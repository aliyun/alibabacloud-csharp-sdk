// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListKeyPairsResponseBody : TeaModel {
        [NameInMap("KeyPairs")]
        [Validation(Required=false)]
        public ListKeyPairsResponseBodyKeyPairs KeyPairs { get; set; }
        public class ListKeyPairsResponseBodyKeyPairs : TeaModel {
            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public List<ListKeyPairsResponseBodyKeyPairsKeyPair> KeyPair { get; set; }
            public class ListKeyPairsResponseBodyKeyPairsKeyPair : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("KeyPairFingerPrint")]
                [Validation(Required=false)]
                public string KeyPairFingerPrint { get; set; }

                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
