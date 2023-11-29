// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceSSLResponseBody : TeaModel {
        [NameInMap("InstanceSSL")]
        [Validation(Required=false)]
        public DescribeInstanceSSLResponseBodyInstanceSSL InstanceSSL { get; set; }
        public class DescribeInstanceSSLResponseBodyInstanceSSL : TeaModel {
            [NameInMap("CaUrl")]
            [Validation(Required=false)]
            public string CaUrl { get; set; }

            [NameInMap("EnableSSL")]
            [Validation(Required=false)]
            public string EnableSSL { get; set; }

            [NameInMap("ForceSSL")]
            [Validation(Required=false)]
            public string ForceSSL { get; set; }

            [NameInMap("ForceSSLSupport")]
            [Validation(Required=false)]
            public bool? ForceSSLSupport { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ValidPeriod")]
            [Validation(Required=false)]
            public string ValidPeriod { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
