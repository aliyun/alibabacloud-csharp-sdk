// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public List<DescribeUserEncryptionKeyListResponseBodyKmsKeys> KmsKeys { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyKmsKeys : TeaModel {
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

    }

}
