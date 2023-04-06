// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetIpsetsBandwidthLimitResponseBody : TeaModel {
        /// <summary>
        /// The type of the bandwidth that is allocated.
        /// 
        /// *   **ShareBandwidth:** shared bandwidth.
        /// *   **ExclusiveBandwidth:** dedicated bandwidth.
        /// </summary>
        [NameInMap("BandwidthAllocationType")]
        [Validation(Required=false)]
        public string BandwidthAllocationType { get; set; }

        /// <summary>
        /// The maximum bandwidth of the acceleration area. Unit: Mbit/s.
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public long? BandwidthLimit { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
