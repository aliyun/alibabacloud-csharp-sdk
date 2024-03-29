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
                [NameInMap("ActiveChannelPeak")]
                [Validation(Required=false)]
                public long? ActiveChannelPeak { get; set; }

                [NameInMap("ActiveChannelPeakTime")]
                [Validation(Required=false)]
                public string ActiveChannelPeakTime { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
