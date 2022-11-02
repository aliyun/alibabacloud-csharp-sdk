// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeVisitTopIpResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TopIp")]
        [Validation(Required=false)]
        public List<DescribeVisitTopIpResponseBodyTopIp> TopIp { get; set; }
        public class DescribeVisitTopIpResponseBodyTopIp : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

        }

    }

}
