// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeKeyPairsResponseBody : TeaModel {
        /// <summary>
        /// Details about the key pairs.
        /// </summary>
        [NameInMap("KeyPairs")]
        [Validation(Required=false)]
        public DescribeKeyPairsResponseBodyKeyPairs KeyPairs { get; set; }
        public class DescribeKeyPairsResponseBodyKeyPairs : TeaModel {
            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public List<DescribeKeyPairsResponseBodyKeyPairsKeyPair> KeyPair { get; set; }
            public class DescribeKeyPairsResponseBodyKeyPairsKeyPair : TeaModel {
                /// <summary>
                /// The time when the key pair was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The fingerprint of the key pair.
                /// </summary>
                [NameInMap("KeyPairFingerPrint")]
                [Validation(Required=false)]
                public string KeyPairFingerPrint { get; set; }

                /// <summary>
                /// The ID of the key pair.
                /// </summary>
                [NameInMap("KeyPairId")]
                [Validation(Required=false)]
                public string KeyPairId { get; set; }

                /// <summary>
                /// The name of the SSH key pair.
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of key pairs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
