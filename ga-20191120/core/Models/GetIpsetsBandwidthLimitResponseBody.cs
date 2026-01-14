// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetIpsetsBandwidthLimitResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the bandwidth that is allocated.</para>
        /// <list type="bullet">
        /// <item><description><b>ShareBandwidth:</b> shared bandwidth.</description></item>
        /// <item><description><b>ExclusiveBandwidth:</b> dedicated bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ShareBandwidth</para>
        /// </summary>
        [NameInMap("BandwidthAllocationType")]
        [Validation(Required=false)]
        public string BandwidthAllocationType { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the acceleration area. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public long? BandwidthLimit { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
