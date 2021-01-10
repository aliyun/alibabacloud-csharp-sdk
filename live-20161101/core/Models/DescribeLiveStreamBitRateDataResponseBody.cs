// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamBitRateDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FrameRateAndBitRateInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfos FrameRateAndBitRateInfos { get; set; }
        public class DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfos : TeaModel {
            [NameInMap("FrameRateAndBitRateInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfosFrameRateAndBitRateInfo> FrameRateAndBitRateInfo { get; set; }
            public class DescribeLiveStreamBitRateDataResponseBodyFrameRateAndBitRateInfosFrameRateAndBitRateInfo : TeaModel {
                public string Time { get; set; }
                public float? AudioFrameRate { get; set; }
                public float? VideoFrameRate { get; set; }
                public string StreamUrl { get; set; }
                public float? BitRate { get; set; }
            }
        };

    }

}
