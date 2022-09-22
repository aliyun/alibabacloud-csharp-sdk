// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeLinkedKMSKeysResponseBody : TeaModel {
        [NameInMap("KMSKeys")]
        [Validation(Required=false)]
        public DescribeLinkedKMSKeysResponseBodyKMSKeys KMSKeys { get; set; }
        public class DescribeLinkedKMSKeysResponseBodyKMSKeys : TeaModel {
            [NameInMap("KMSKey")]
            [Validation(Required=false)]
            public List<DescribeLinkedKMSKeysResponseBodyKMSKeysKMSKey> KMSKey { get; set; }
            public class DescribeLinkedKMSKeysResponseBodyKMSKeysKMSKey : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
