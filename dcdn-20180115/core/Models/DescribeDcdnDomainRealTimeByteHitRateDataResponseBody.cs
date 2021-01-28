// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeByteHitRateDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeByteHitRateDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeByteHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ByteHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel> ByteHitRateDataModel { get; set; }
            public class DescribeDcdnDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel : TeaModel {
                public float? ByteHitRate { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
