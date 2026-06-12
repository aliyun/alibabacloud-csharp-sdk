// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetNetworkAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNetworkAvailableZonesResponseBodyData Data { get; set; }
        public class GetNetworkAvailableZonesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of region IDs.</para>
            /// </summary>
            [NameInMap("RegionIdList")]
            [Validation(Required=false)]
            public List<string> RegionIdList { get; set; }

            /// <summary>
            /// <para>The list of zone IDs.</para>
            /// </summary>
            [NameInMap("ZoneIdList")]
            [Validation(Required=false)]
            public List<string> ZoneIdList { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A17F9930-E2DC-5E87-B6D6-B0BCD2B00834</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
