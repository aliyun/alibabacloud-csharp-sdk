// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcPeakChannelCntDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcPeakChannelCntDataResponseBodyData> Data { get; set; }
        public class DescribeMeterRtcPeakChannelCntDataResponseBodyData : TeaModel {
            [NameInMap("ActiveChannelPeak")]
            [Validation(Required=false)]
            public long? ActiveChannelPeak { get; set; }

            [NameInMap("ActiveChannelPeakTime")]
            [Validation(Required=false)]
            public long? ActiveChannelPeakTime { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
