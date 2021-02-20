// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcPeakUserCntDataResponseBody : TeaModel {
        [NameInMap("PeakUserCntDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcPeakUserCntDataResponseBodyPeakUserCntDataPerInterval PeakUserCntDataPerInterval { get; set; }
        public class DescribeRtcPeakUserCntDataResponseBodyPeakUserCntDataPerInterval : TeaModel {
            [NameInMap("PeakUserCntModule")]
            [Validation(Required=false)]
            public List<DescribeRtcPeakUserCntDataResponseBodyPeakUserCntDataPerIntervalPeakUserCntModule> PeakUserCntModule { get; set; }
            public class DescribeRtcPeakUserCntDataResponseBodyPeakUserCntDataPerIntervalPeakUserCntModule : TeaModel {
                public string ActiveUserPeakTime { get; set; }
                public string TimeStamp { get; set; }
                public long? ActiveUserPeak { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
