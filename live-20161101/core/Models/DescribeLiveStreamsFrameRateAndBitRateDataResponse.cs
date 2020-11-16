// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsFrameRateAndBitRateDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("FrameRateAndBitRateInfos")]
        [Validation(Required=true)]
        public DescribeLiveStreamsFrameRateAndBitRateDataResponseFrameRateAndBitRateInfos FrameRateAndBitRateInfos { get; set; }
        public class DescribeLiveStreamsFrameRateAndBitRateDataResponseFrameRateAndBitRateInfos : TeaModel {
            [NameInMap("FrameRateAndBitRateInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamsFrameRateAndBitRateDataResponseFrameRateAndBitRateInfosFrameRateAndBitRateInfo> FrameRateAndBitRateInfo { get; set; }
            public class DescribeLiveStreamsFrameRateAndBitRateDataResponseFrameRateAndBitRateInfosFrameRateAndBitRateInfo : TeaModel {
                public string StreamUrl { get; set; }
                public float? VideoFrameRate { get; set; }
                public float? AudioFrameRate { get; set; }
                public float? BitRate { get; set; }
                public string Time { get; set; }
            }
        };

    }

}
