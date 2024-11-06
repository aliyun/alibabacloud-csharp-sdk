// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcPeakChannelCntDataResponseBody : TeaModel {
        [NameInMap("PeakChannelCntDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcPeakChannelCntDataResponseBodyPeakChannelCntDataPerInterval PeakChannelCntDataPerInterval { get; set; }
        public class DescribeRtcPeakChannelCntDataResponseBodyPeakChannelCntDataPerInterval : TeaModel {
            [NameInMap("PeakChannelCntModule")]
            [Validation(Required=false)]
            public List<DescribeRtcPeakChannelCntDataResponseBodyPeakChannelCntDataPerIntervalPeakChannelCntModule> PeakChannelCntModule { get; set; }
            public class DescribeRtcPeakChannelCntDataResponseBodyPeakChannelCntDataPerIntervalPeakChannelCntModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ActiveChannelPeak")]
                [Validation(Required=false)]
                public long? ActiveChannelPeak { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-01-29T00:01:00Z</para>
                /// </summary>
                [NameInMap("ActiveChannelPeakTime")]
                [Validation(Required=false)]
                public string ActiveChannelPeakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-01-29T00:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
