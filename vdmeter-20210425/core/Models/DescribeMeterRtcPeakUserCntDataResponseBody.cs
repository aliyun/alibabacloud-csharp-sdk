// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcPeakUserCntDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcPeakUserCntDataResponseBodyData> Data { get; set; }
        public class DescribeMeterRtcPeakUserCntDataResponseBodyData : TeaModel {
            [NameInMap("ActiveUserPeak")]
            [Validation(Required=false)]
            public long? ActiveUserPeak { get; set; }

            [NameInMap("ActiveUserPeakTime")]
            [Validation(Required=false)]
            public long? ActiveUserPeakTime { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
