// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainFrameRateAndBitRateDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("FrameRateAndBitRateInfos")]
        [Validation(Required=true)]
        public DescribeLiveDomainFrameRateAndBitRateDataResponseFrameRateAndBitRateInfos FrameRateAndBitRateInfos { get; set; }
        public class DescribeLiveDomainFrameRateAndBitRateDataResponseFrameRateAndBitRateInfos : TeaModel {
            [NameInMap("FrameRateAndBitRateInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainFrameRateAndBitRateDataResponseFrameRateAndBitRateInfosFrameRateAndBitRateInfo> FrameRateAndBitRateInfo { get; set; }
            public class DescribeLiveDomainFrameRateAndBitRateDataResponseFrameRateAndBitRateInfosFrameRateAndBitRateInfo : TeaModel {
                public float? AudioFrameRate { get; set; }
                public float? BitRate { get; set; }
                public float? VideoFrameRate { get; set; }
                public string StreamUrl { get; set; }
            }
        };

    }

}
