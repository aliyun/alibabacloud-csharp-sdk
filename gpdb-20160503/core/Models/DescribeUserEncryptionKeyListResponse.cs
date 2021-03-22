// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeUserEncryptionKeyListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("KmsKeys")]
        [Validation(Required=true)]
        public List<DescribeUserEncryptionKeyListResponseKmsKeys> KmsKeys { get; set; }
        public class DescribeUserEncryptionKeyListResponseKmsKeys : TeaModel {
            [NameInMap("KeyId")]
            [Validation(Required=true)]
            public string KeyId { get; set; }

        }

    }

}
