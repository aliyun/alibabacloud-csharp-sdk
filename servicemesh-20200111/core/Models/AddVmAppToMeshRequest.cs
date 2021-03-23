// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class AddVmAppToMeshRequest : TeaModel {
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

        [NameInMap("Ports")]
        [Validation(Required=false)]
        public string Ports { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        [NameInMap("ServiceAccount")]
        [Validation(Required=false)]
        public string ServiceAccount { get; set; }

        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
