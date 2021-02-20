// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelCntDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ChannelCntDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcChannelCntDataResponseBodyChannelCntDataPerInterval ChannelCntDataPerInterval { get; set; }
        public class DescribeRtcChannelCntDataResponseBodyChannelCntDataPerInterval : TeaModel {
            [NameInMap("ChannelCntModule")]
            [Validation(Required=false)]
            public List<DescribeRtcChannelCntDataResponseBodyChannelCntDataPerIntervalChannelCntModule> ChannelCntModule { get; set; }
            public class DescribeRtcChannelCntDataResponseBodyChannelCntDataPerIntervalChannelCntModule : TeaModel {
                public long? ActiveChannelCnt { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
