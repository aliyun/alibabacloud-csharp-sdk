// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpStatusResponseBody : TeaModel {
        [NameInMap("IpStatus")]
        [Validation(Required=false)]
        public List<DescribeIpStatusResponseBodyIpStatus> IpStatus { get; set; }
        public class DescribeIpStatusResponseBodyIpStatus : TeaModel {
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
