// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeWafSourceIpSegmentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IpV6s")]
        [Validation(Required=false)]
        public string IpV6s { get; set; }

        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

    }

}
