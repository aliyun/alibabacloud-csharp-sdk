// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainRealTimeByteHitRateDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScdnDomainRealTimeByteHitRateDataResponseBodyData Data { get; set; }
        public class DescribeScdnDomainRealTimeByteHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ByteHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel> ByteHitRateDataModel { get; set; }
            public class DescribeScdnDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel : TeaModel {
                [NameInMap("ByteHitRate")]
                [Validation(Required=false)]
                public float? ByteHitRate { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
