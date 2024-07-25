// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayServiceSource : TeaModel {
        [NameInMap("bound")]
        [Validation(Required=false)]
        public bool? Bound { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("k8sServiceSourceInfo")]
        [Validation(Required=false)]
        public GatewayServiceSourceK8sServiceSourceInfo K8sServiceSourceInfo { get; set; }
        public class GatewayServiceSourceK8sServiceSourceInfo : TeaModel {
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ingressConfig")]
            [Validation(Required=false)]
            public GatewayServiceSourceK8sServiceSourceInfoIngressConfig IngressConfig { get; set; }
            public class GatewayServiceSourceK8sServiceSourceInfoIngressConfig : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("ingressClass")]
                [Validation(Required=false)]
                public string IngressClass { get; set; }

                [NameInMap("overrideIngressIp")]
                [Validation(Required=false)]
                public bool? OverrideIngressIp { get; set; }

                [NameInMap("watchNamespace")]
                [Validation(Required=false)]
                public string WatchNamespace { get; set; }

            }

        }

        [NameInMap("nacosServiceSourceInfo")]
        [Validation(Required=false)]
        public GatewayServiceSourceNacosServiceSourceInfo NacosServiceSourceInfo { get; set; }
        public class GatewayServiceSourceNacosServiceSourceInfo : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("serviceSourceId")]
        [Validation(Required=false)]
        public string ServiceSourceId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
