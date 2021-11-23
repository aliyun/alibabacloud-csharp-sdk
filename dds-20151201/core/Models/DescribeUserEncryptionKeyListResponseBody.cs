// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        [NameInMap("KeyIds")]
        [Validation(Required=false)]
        public DescribeUserEncryptionKeyListResponseBodyKeyIds KeyIds { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyKeyIds : TeaModel {
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public List<string> KeyId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
