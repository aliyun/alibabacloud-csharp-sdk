// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerTCPListenerRequest : TeaModel {
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EipTransmit")]
        [Validation(Required=false)]
        public string EipTransmit { get; set; }

        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("PersistenceTimeout")]
        [Validation(Required=false)]
        public int? PersistenceTimeout { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
