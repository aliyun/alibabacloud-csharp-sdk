// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcApproxPeakRateResponseBody : TeaModel {
        [NameInMap("ApproxPeakRate")]
        [Validation(Required=false)]
        public float? ApproxPeakRate { get; set; }

        [NameInMap("ApproxPeakTs")]
        [Validation(Required=false)]
        public long? ApproxPeakTs { get; set; }

        [NameInMap("PeakRateVoList")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcApproxPeakRateResponseBodyPeakRateVoList> PeakRateVoList { get; set; }
        public class DescribeMeterRtcApproxPeakRateResponseBodyPeakRateVoList : TeaModel {
            [NameInMap("PeakRate")]
            [Validation(Required=false)]
            public float? PeakRate { get; set; }

            [NameInMap("PeakTs")]
            [Validation(Required=false)]
            public long? PeakTs { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
