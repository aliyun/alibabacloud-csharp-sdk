// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRealtimeDeliveryAccResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RealTimeDeliveryAccData")]
        [Validation(Required=false)]
        public DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccData RealTimeDeliveryAccData { get; set; }
        public class DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccData : TeaModel {
            [NameInMap("AccData")]
            [Validation(Required=false)]
            public List<DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccDataAccData> AccData { get; set; }
            public class DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccDataAccData : TeaModel {
                public string TimeStamp { get; set; }
                public int? SuccessNum { get; set; }
                public int? FailedNum { get; set; }
            }
        };

    }

}
