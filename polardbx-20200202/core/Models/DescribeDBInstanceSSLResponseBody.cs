// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceSSLResponseBodyData Data { get; set; }
        public class DescribeDBInstanceSSLResponseBodyData : TeaModel {
            [NameInMap("SSLEnabled")]
            [Validation(Required=false)]
            public bool? SSLEnabled { get; set; }
            [NameInMap("SSLExpiredTime")]
            [Validation(Required=false)]
            public string SSLExpiredTime { get; set; }
            [NameInMap("CertCommonName")]
            [Validation(Required=false)]
            public string CertCommonName { get; set; }
        };

    }

}
