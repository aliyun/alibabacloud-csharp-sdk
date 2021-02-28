// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainRealTimeReqHitRateDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScdnDomainRealTimeReqHitRateDataResponseBodyData Data { get; set; }
        public class DescribeScdnDomainRealTimeReqHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ReqHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel> ReqHitRateDataModel { get; set; }
            public class DescribeScdnDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel : TeaModel {
                public float? ReqHitRate { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
