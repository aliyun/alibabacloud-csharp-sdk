// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListAccessKeysResponseBody : TeaModel {
        [NameInMap("AccessKeys")]
        [Validation(Required=false)]
        public ListAccessKeysResponseBodyAccessKeys AccessKeys { get; set; }
        public class ListAccessKeysResponseBodyAccessKeys : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public List<ListAccessKeysResponseBodyAccessKeysAccessKey> AccessKey { get; set; }
            public class ListAccessKeysResponseBodyAccessKeysAccessKey : TeaModel {
                public string AccessKeyId { get; set; }
                public string CreateDate { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
