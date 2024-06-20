// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7UsKeepaliveResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RsKeepalive")]
        [Validation(Required=false)]
        public DescribeL7UsKeepaliveResponseBodyRsKeepalive RsKeepalive { get; set; }
        public class DescribeL7UsKeepaliveResponseBodyRsKeepalive : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public long? KeepaliveRequests { get; set; }

            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public long? KeepaliveTimeout { get; set; }

        }

    }

}
