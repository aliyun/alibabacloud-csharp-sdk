// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainRealTimeReqHitRateDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainRealTimeReqHitRateDataResponseBodyData Data { get; set; }
        public class DescribeDomainRealTimeReqHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ReqHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel> ReqHitRateDataModel { get; set; }
            public class DescribeDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel : TeaModel {
                public float? ReqHitRate { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
