// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNatGatewayResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ForwardTableIds")]
        [Validation(Required=false)]
        public List<string> ForwardTableIds { get; set; }

        [NameInMap("BandwidthPackageIds")]
        [Validation(Required=false)]
        public List<string> BandwidthPackageIds { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

    }

}
