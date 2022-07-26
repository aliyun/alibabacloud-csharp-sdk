// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerUDPListenerAttributeResponseBody : TeaModel {
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EipTransmit")]
        [Validation(Required=false)]
        public string EipTransmit { get; set; }

        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        [NameInMap("HealthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        [NameInMap("HealthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
