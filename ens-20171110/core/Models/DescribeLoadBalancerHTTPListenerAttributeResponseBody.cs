// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerHTTPListenerAttributeResponseBody : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ForwardPort")]
        [Validation(Required=false)]
        public int? ForwardPort { get; set; }

        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        [NameInMap("ListenerForward")]
        [Validation(Required=false)]
        public string ListenerForward { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
