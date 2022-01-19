// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeLogStoreKeysResponseBody : TeaModel {
        [NameInMap("LogStoreKeys")]
        [Validation(Required=false)]
        public DescribeLogStoreKeysResponseBodyLogStoreKeys LogStoreKeys { get; set; }
        public class DescribeLogStoreKeysResponseBodyLogStoreKeys : TeaModel {
            [NameInMap("LogStoreKey")]
            [Validation(Required=false)]
            public List<string> LogStoreKey { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
