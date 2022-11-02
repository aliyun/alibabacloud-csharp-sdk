// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeWafSourceIpSegmentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WafSourceIp")]
        [Validation(Required=false)]
        public DescribeWafSourceIpSegmentResponseBodyWafSourceIp WafSourceIp { get; set; }
        public class DescribeWafSourceIpSegmentResponseBodyWafSourceIp : TeaModel {
            [NameInMap("IPv4")]
            [Validation(Required=false)]
            public List<string> IPv4 { get; set; }

            [NameInMap("IPv6")]
            [Validation(Required=false)]
            public List<string> IPv6 { get; set; }

        }

    }

}
