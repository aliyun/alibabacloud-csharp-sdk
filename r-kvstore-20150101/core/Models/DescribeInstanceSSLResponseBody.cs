// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceSSLResponseBody : TeaModel {
        [NameInMap("CertCommonName")]
        [Validation(Required=false)]
        public string CertCommonName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

        [NameInMap("SSLExpiredTime")]
        [Validation(Required=false)]
        public string SSLExpiredTime { get; set; }

    }

}
