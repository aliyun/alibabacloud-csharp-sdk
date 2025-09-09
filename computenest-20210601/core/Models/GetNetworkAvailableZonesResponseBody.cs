// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetNetworkAvailableZonesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNetworkAvailableZonesResponseBodyData Data { get; set; }
        public class GetNetworkAvailableZonesResponseBodyData : TeaModel {
            [NameInMap("RegionIdList")]
            [Validation(Required=false)]
            public List<string> RegionIdList { get; set; }

            [NameInMap("ZoneIdList")]
            [Validation(Required=false)]
            public List<string> ZoneIdList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A17F9930-E2DC-5E87-B6D6-B0BCD2B00834</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
