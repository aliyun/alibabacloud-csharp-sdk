// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateServiceSidecarInjectRequest : TeaModel {
        [NameInMap("GuestCluster")]
        [Validation(Required=false)]
        public string GuestCluster { get; set; }

        [NameInMap("Inject")]
        [Validation(Required=false)]
        public bool? Inject { get; set; }

        [NameInMap("LimitCPU")]
        [Validation(Required=false)]
        public string LimitCPU { get; set; }

        [NameInMap("LimitMemory")]
        [Validation(Required=false)]
        public string LimitMemory { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public string RequestCPU { get; set; }

        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
