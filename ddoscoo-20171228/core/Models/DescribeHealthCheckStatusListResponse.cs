// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeHealthCheckStatusListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("HealthCheckStatusList")]
        [Validation(Required=true)]
        public List<DescribeHealthCheckStatusListResponseHealthCheckStatusList> HealthCheckStatusList { get; set; }
        public class DescribeHealthCheckStatusListResponseHealthCheckStatusList : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=true)]
            public string Protocol { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=true)]
            public int? FrontendPort { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("RealServerStatusList")]
            [Validation(Required=true)]
            public List<DescribeHealthCheckStatusListResponseHealthCheckStatusListRealServerStatusList> RealServerStatusList { get; set; }
            public class DescribeHealthCheckStatusListResponseHealthCheckStatusListRealServerStatusList : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=true)]
                public string Address { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

            }

        }

    }

}
