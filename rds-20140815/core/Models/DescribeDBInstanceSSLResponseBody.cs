// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        [NameInMap("SSLExpireTime")]
        [Validation(Required=false)]
        public string SSLExpireTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequireUpdateReason")]
        [Validation(Required=false)]
        public string RequireUpdateReason { get; set; }

        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        [NameInMap("RequireUpdate")]
        [Validation(Required=false)]
        public string RequireUpdate { get; set; }

    }

}
