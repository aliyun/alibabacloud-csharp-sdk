// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateIstioInjectionConfigRequest : TeaModel {
        [NameInMap("EnableIstioInjection")]
        [Validation(Required=false)]
        public bool? EnableIstioInjection { get; set; }

        [NameInMap("EnableSidecarSetInjection")]
        [Validation(Required=false)]
        public bool? EnableSidecarSetInjection { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
