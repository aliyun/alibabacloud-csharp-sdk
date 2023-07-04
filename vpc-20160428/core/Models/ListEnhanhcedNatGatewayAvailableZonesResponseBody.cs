// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListEnhanhcedNatGatewayAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of zones.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<ListEnhanhcedNatGatewayAvailableZonesResponseBodyZones> Zones { get; set; }
        public class ListEnhanhcedNatGatewayAvailableZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// The name of the zone.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The ID of the zone where the instance is deployed.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
