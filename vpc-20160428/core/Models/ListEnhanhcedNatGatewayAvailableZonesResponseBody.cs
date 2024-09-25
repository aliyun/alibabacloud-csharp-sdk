// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListEnhanhcedNatGatewayAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AE6F367-52EA-535D-9A3D-EF23D70527C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<ListEnhanhcedNatGatewayAvailableZonesResponseBodyZones> Zones { get; set; }
        public class ListEnhanhcedNatGatewayAvailableZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// <para>The name of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dubai Zone A</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>me-east-1a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
