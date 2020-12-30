// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeHealthCheckStatusListResponseBody : TeaModel {
        [NameInMap("HealthCheckStatusList")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckStatusListResponseBodyHealthCheckStatusList> HealthCheckStatusList { get; set; }
        public class DescribeHealthCheckStatusListResponseBodyHealthCheckStatusList : TeaModel {
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
            public List<DescribeHealthCheckStatusListResponseBodyHealthCheckStatusListRealServerStatusList> RealServerStatusList { get; set; }
            public class DescribeHealthCheckStatusListResponseBodyHealthCheckStatusListRealServerStatusList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
