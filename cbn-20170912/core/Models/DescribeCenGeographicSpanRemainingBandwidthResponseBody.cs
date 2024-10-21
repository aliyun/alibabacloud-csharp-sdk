// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpanRemainingBandwidthResponseBody : TeaModel {
        /// <summary>
        /// <para>The remaining bandwidth of the bandwidth plan. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RemainingBandwidth")]
        [Validation(Required=false)]
        public long? RemainingBandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4B345CD-2CBA-4881-AF6D-E5D9BAE1CA7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
