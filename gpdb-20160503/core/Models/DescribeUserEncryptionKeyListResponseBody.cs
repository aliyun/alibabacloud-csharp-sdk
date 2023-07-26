// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        /// <summary>
        /// Details about the KMS keys.
        /// </summary>
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public List<DescribeUserEncryptionKeyListResponseBodyKmsKeys> KmsKeys { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyKmsKeys : TeaModel {
            /// <summary>
            /// The ID of the KMS key.
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
