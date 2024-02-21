// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListKeyPairsResponseBody : TeaModel {
        /// <summary>
        /// The key pairs that are returned.
        /// </summary>
        [NameInMap("KeyPairs")]
        [Validation(Required=false)]
        public ListKeyPairsResponseBodyKeyPairs KeyPairs { get; set; }
        public class ListKeyPairsResponseBodyKeyPairs : TeaModel {
            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public List<ListKeyPairsResponseBodyKeyPairsKeyPair> KeyPair { get; set; }
            public class ListKeyPairsResponseBodyKeyPairsKeyPair : TeaModel {
                /// <summary>
                /// The time when the key pair was created.
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
                /// The name of the SSH key pair.
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of entries per page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
