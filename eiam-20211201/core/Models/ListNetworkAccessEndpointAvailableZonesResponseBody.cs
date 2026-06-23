// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessEndpointAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of zones that support network endpoints in the current region.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<ListNetworkAccessEndpointAvailableZonesResponseBodyZones> Zones { get; set; }
        public class ListNetworkAccessEndpointAvailableZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// <para>The zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou) Zone J</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
