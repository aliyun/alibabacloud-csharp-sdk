// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeLogServiceStatusResponseBody : TeaModel {
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public List<DescribeLogServiceStatusResponseBodyDomainStatus> DomainStatus { get; set; }
        public class DescribeLogServiceStatusResponseBodyDomainStatus : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("SlsLogActive")]
            [Validation(Required=false)]
            public int? SlsLogActive { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
