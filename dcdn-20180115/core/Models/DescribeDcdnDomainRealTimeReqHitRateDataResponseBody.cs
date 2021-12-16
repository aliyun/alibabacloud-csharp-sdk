// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeReqHitRateDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ReqHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel> ReqHitRateDataModel { get; set; }
            public class DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel : TeaModel {
                public float? ReqHitRate { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
