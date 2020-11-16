// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceSSLResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=true)]
        public string DBInstanceId { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=true)]
        public string DBInstanceName { get; set; }

        [NameInMap("CertCommonName")]
        [Validation(Required=true)]
        public string CertCommonName { get; set; }

        [NameInMap("SSLExpiredTime")]
        [Validation(Required=true)]
        public string SSLExpiredTime { get; set; }

        [NameInMap("SSLEnabled")]
        [Validation(Required=true)]
        public bool? SSLEnabled { get; set; }

    }

}
