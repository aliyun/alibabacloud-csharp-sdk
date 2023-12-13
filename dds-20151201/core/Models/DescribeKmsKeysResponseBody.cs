// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public List<DescribeKmsKeysResponseBodyKmsKeys> KmsKeys { get; set; }
        public class DescribeKmsKeysResponseBodyKmsKeys : TeaModel {
            [NameInMap("KeyAlias")]
            [Validation(Required=false)]
            public string KeyAlias { get; set; }

            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
