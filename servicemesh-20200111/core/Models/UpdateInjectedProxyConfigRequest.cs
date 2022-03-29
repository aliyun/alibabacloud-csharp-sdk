// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateInjectedProxyConfigRequest : TeaModel {
        [NameInMap("DeploymentNames")]
        [Validation(Required=false)]
        public string DeploymentNames { get; set; }

        [NameInMap("GuestCluster")]
        [Validation(Required=false)]
        public string GuestCluster { get; set; }

        [NameInMap("LimitCPUs")]
        [Validation(Required=false)]
        public string LimitCPUs { get; set; }

        [NameInMap("LimitMemories")]
        [Validation(Required=false)]
        public string LimitMemories { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RequestCPUs")]
        [Validation(Required=false)]
        public string RequestCPUs { get; set; }

        [NameInMap("RequestMemories")]
        [Validation(Required=false)]
        public string RequestMemories { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
