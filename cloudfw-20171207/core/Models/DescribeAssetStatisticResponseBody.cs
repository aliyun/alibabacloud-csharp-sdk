// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetStatisticResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>850A84******25g4d2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceSpecStatistic")]
        [Validation(Required=false)]
        public DescribeAssetStatisticResponseBodyResourceSpecStatistic ResourceSpecStatistic { get; set; }
        public class DescribeAssetStatisticResponseBodyResourceSpecStatistic : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IpNumSpec")]
            [Validation(Required=false)]
            public int? IpNumSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("IpNumUsed")]
            [Validation(Required=false)]
            public int? IpNumUsed { get; set; }

            [NameInMap("IsIpNumEnough")]
            [Validation(Required=false)]
            public int? IsIpNumEnough { get; set; }

            [NameInMap("IsRegionNumEnough")]
            [Validation(Required=false)]
            public int? IsRegionNumEnough { get; set; }

            [NameInMap("IsSuggestUpdate")]
            [Validation(Required=false)]
            public int? IsSuggestUpdate { get; set; }

            [NameInMap("RegionNumSpec")]
            [Validation(Required=false)]
            public int? RegionNumSpec { get; set; }

            [NameInMap("RegionNumUsed")]
            [Validation(Required=false)]
            public int? RegionNumUsed { get; set; }

            [NameInMap("SensitiveDataIpNumSpec")]
            [Validation(Required=false)]
            public long? SensitiveDataIpNumSpec { get; set; }

            [NameInMap("SensitiveDataIpNumUsed")]
            [Validation(Required=false)]
            public long? SensitiveDataIpNumUsed { get; set; }

        }

    }

}
