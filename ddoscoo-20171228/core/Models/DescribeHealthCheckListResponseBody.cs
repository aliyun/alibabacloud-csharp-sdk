// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeHealthCheckListResponseBody : TeaModel {
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckListResponseBodyListeners> Listeners { get; set; }
        public class DescribeHealthCheckListResponseBodyListeners : TeaModel {
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public DescribeHealthCheckListResponseBodyListenersHealthCheck HealthCheck { get; set; }
            public class DescribeHealthCheckListResponseBodyListenersHealthCheck : TeaModel {
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }
                [NameInMap("Up")]
                [Validation(Required=false)]
                public int? Up { get; set; }
                [NameInMap("Down")]
                [Validation(Required=false)]
                public int? Down { get; set; }
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }
            };

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
