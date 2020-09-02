// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnRouteEntryRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("VpnGatewayId")]
        [Validation(Required=true)]
        public string VpnGatewayId { get; set; }

        [NameInMap("RouteDest")]
        [Validation(Required=true)]
        public string RouteDest { get; set; }

        [NameInMap("NextHop")]
        [Validation(Required=true)]
        public string NextHop { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=true)]
        public int? Weight { get; set; }

        [NameInMap("PublishVpc")]
        [Validation(Required=true)]
        public bool? PublishVpc { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OverlayMode")]
        [Validation(Required=false)]
        public string OverlayMode { get; set; }

    }

}
