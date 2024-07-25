// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateServiceSourceRequest : TeaModel {
        [NameInMap("k8sServiceSourceConfig")]
        [Validation(Required=false)]
        public UpdateServiceSourceRequestK8sServiceSourceConfig K8sServiceSourceConfig { get; set; }
        public class UpdateServiceSourceRequestK8sServiceSourceConfig : TeaModel {
            [NameInMap("ingressConfig")]
            [Validation(Required=false)]
            public UpdateServiceSourceRequestK8sServiceSourceConfigIngressConfig IngressConfig { get; set; }
            public class UpdateServiceSourceRequestK8sServiceSourceConfigIngressConfig : TeaModel {
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

    }

}
