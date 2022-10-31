// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKPlayTimeResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PlayTimeData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKPlayTimeResponseBodyPlayTimeData> PlayTimeData { get; set; }
        public class DescribeRTSNativeSDKPlayTimeResponseBodyPlayTimeData : TeaModel {
            [NameInMap("PlayTime")]
            [Validation(Required=false)]
            public string PlayTime { get; set; }

            [NameInMap("StallTime")]
            [Validation(Required=false)]
            public string StallTime { get; set; }

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
