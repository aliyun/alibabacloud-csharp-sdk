// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeManagedServicesResponseBody : TeaModel {
        [NameInMap("ManagedServiceInfo")]
        [Validation(Required=false)]
        public List<DescribeManagedServicesResponseBodyManagedServiceInfo> ManagedServiceInfo { get; set; }
        public class DescribeManagedServicesResponseBodyManagedServiceInfo : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeploymentInstances")]
            [Validation(Required=false)]
            public List<DescribeManagedServicesResponseBodyManagedServiceInfoDeploymentInstances> DeploymentInstances { get; set; }
            public class DescribeManagedServicesResponseBodyManagedServiceInfoDeploymentInstances : TeaModel {
                [NameInMap("ReadyReplicas")]
                [Validation(Required=false)]
                public int? ReadyReplicas { get; set; }

                [NameInMap("Replicas")]
                [Validation(Required=false)]
                public int? Replicas { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Selector")]
            [Validation(Required=false)]
            public Dictionary<string, string> Selector { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("SidecarInjectStatus")]
            [Validation(Required=false)]
            public string SidecarInjectStatus { get; set; }

        }

        [NameInMap("Mark")]
        [Validation(Required=false)]
        public string Mark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
