// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        /// <summary>
        /// The KMS keys.
        /// </summary>
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public List<DescribeKmsKeysResponseBodyKmsKeys> KmsKeys { get; set; }
        public class DescribeKmsKeysResponseBodyKmsKeys : TeaModel {
            /// <summary>
            /// The alias of the key.
            /// </summary>
            [NameInMap("KeyAlias")]
            [Validation(Required=false)]
            public string KeyAlias { get; set; }

            /// <summary>
            /// The key ID.
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
