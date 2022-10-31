// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKFirstFrameCostResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FirstFrameCostData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKFirstFrameCostResponseBodyFirstFrameCostData> FirstFrameCostData { get; set; }
        public class DescribeRTSNativeSDKFirstFrameCostResponseBodyFirstFrameCostData : TeaModel {
            [NameInMap("Connected")]
            [Validation(Required=false)]
            public string Connected { get; set; }

            [NameInMap("FinishGetStreamInfo")]
            [Validation(Required=false)]
            public string FinishGetStreamInfo { get; set; }

            [NameInMap("FirstFrameComplete")]
            [Validation(Required=false)]
            public string FirstFrameComplete { get; set; }

            [NameInMap("FirstPacket")]
            [Validation(Required=false)]
            public string FirstPacket { get; set; }

            [NameInMap("Initialized")]
            [Validation(Required=false)]
            public string Initialized { get; set; }

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
