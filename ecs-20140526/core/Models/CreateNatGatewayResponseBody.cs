// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNatGatewayResponseBody : TeaModel {
        [NameInMap("BandwidthPackageIds")]
        [Validation(Required=false)]
        public CreateNatGatewayResponseBodyBandwidthPackageIds BandwidthPackageIds { get; set; }
        public class CreateNatGatewayResponseBodyBandwidthPackageIds : TeaModel {
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public List<string> BandwidthPackageId { get; set; }
        };

        [NameInMap("ForwardTableIds")]
        [Validation(Required=false)]
        public CreateNatGatewayResponseBodyForwardTableIds ForwardTableIds { get; set; }
        public class CreateNatGatewayResponseBodyForwardTableIds : TeaModel {
            [NameInMap("ForwardTableId")]
            [Validation(Required=false)]
            public List<string> ForwardTableId { get; set; }
        };

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
