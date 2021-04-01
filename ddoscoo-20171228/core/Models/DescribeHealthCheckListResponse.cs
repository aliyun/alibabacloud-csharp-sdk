// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeHealthCheckListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Listeners")]
        [Validation(Required=true)]
        public List<DescribeHealthCheckListResponseListeners> Listeners { get; set; }
        public class DescribeHealthCheckListResponseListeners : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=true)]
            public string Protocol { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=true)]
            public int? FrontendPort { get; set; }

            [NameInMap("HealthCheck")]
            [Validation(Required=true)]
            public DescribeHealthCheckListResponseListenersHealthCheck HealthCheck { get; set; }
            public class DescribeHealthCheckListResponseListenersHealthCheck : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=true)]
                public string Type { get; set; }
                [NameInMap("Domain")]
                [Validation(Required=true)]
                public string Domain { get; set; }
                [NameInMap("Uri")]
                [Validation(Required=true)]
                public string Uri { get; set; }
                [NameInMap("Down")]
                [Validation(Required=true)]
                public int? Down { get; set; }
                [NameInMap("Interval")]
                [Validation(Required=true)]
                public int? Interval { get; set; }
                [NameInMap("Port")]
                [Validation(Required=true)]
                public int? Port { get; set; }
                [NameInMap("Timeout")]
                [Validation(Required=true)]
                public int? Timeout { get; set; }
                [NameInMap("Up")]
                [Validation(Required=true)]
                public int? Up { get; set; }
            };

        }

    }

}
