// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHealthCheckStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckStatusResponseBodyHealthCheckStatus> HealthCheckStatus { get; set; }
        public class DescribeHealthCheckStatusResponseBodyHealthCheckStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RealServerStatusList")]
            [Validation(Required=false)]
            public List<DescribeHealthCheckStatusResponseBodyHealthCheckStatusRealServerStatusList> RealServerStatusList { get; set; }
            public class DescribeHealthCheckStatusResponseBodyHealthCheckStatusRealServerStatusList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

            }

        }

    }

}
