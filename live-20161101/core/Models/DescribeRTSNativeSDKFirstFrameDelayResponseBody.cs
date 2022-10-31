// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKFirstFrameDelayResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FrameDelayData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKFirstFrameDelayResponseBodyFrameDelayData> FrameDelayData { get; set; }
        public class DescribeRTSNativeSDKFirstFrameDelayResponseBodyFrameDelayData : TeaModel {
            [NameInMap("FrameDelay")]
            [Validation(Required=false)]
            public string FrameDelay { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
