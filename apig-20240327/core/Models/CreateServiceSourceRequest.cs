// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateServiceSourceRequest : TeaModel {
        [NameInMap("k8sServiceSourceConfig")]
        [Validation(Required=false)]
        public CreateServiceSourceRequestK8sServiceSourceConfig K8sServiceSourceConfig { get; set; }
        public class CreateServiceSourceRequestK8sServiceSourceConfig : TeaModel {
            [NameInMap("authorizeSecurityGroupRules")]
            [Validation(Required=false)]
            public List<CreateServiceSourceRequestK8sServiceSourceConfigAuthorizeSecurityGroupRules> AuthorizeSecurityGroupRules { get; set; }
            public class CreateServiceSourceRequestK8sServiceSourceConfigAuthorizeSecurityGroupRules : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("portRanges")]
                [Validation(Required=false)]
                public List<string> PortRanges { get; set; }

                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ingressConfig")]
            [Validation(Required=false)]
            public CreateServiceSourceRequestK8sServiceSourceConfigIngressConfig IngressConfig { get; set; }
            public class CreateServiceSourceRequestK8sServiceSourceConfigIngressConfig : TeaModel {
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

        [NameInMap("nacosServiceSourceConfig")]
        [Validation(Required=false)]
        public CreateServiceSourceRequestNacosServiceSourceConfig NacosServiceSourceConfig { get; set; }
        public class CreateServiceSourceRequestNacosServiceSourceConfig : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
