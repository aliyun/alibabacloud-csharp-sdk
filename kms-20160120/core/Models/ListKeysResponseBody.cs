// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeysResponseBody : TeaModel {
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public ListKeysResponseBodyKeys Keys { get; set; }
        public class ListKeysResponseBodyKeys : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public List<ListKeysResponseBodyKeysKey> Key { get; set; }
            public class ListKeysResponseBodyKeysKey : TeaModel {
                public string KeyArn { get; set; }
                public string KeyId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
