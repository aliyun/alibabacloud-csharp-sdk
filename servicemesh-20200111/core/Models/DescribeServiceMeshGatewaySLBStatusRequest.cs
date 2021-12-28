// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshGatewaySLBStatusRequest : TeaModel {
        [NameInMap("GatewayAddresses")]
        [Validation(Required=false)]
        public string GatewayAddresses { get; set; }

        [NameInMap("GatewayFullName")]
        [Validation(Required=false)]
        public string GatewayFullName { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
