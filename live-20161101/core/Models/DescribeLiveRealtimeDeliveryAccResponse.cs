// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRealtimeDeliveryAccResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RealTimeDeliveryAccData")]
        [Validation(Required=true)]
        public DescribeLiveRealtimeDeliveryAccResponseRealTimeDeliveryAccData RealTimeDeliveryAccData { get; set; }
        public class DescribeLiveRealtimeDeliveryAccResponseRealTimeDeliveryAccData : TeaModel {
            [NameInMap("AccData")]
            [Validation(Required=true)]
            public List<DescribeLiveRealtimeDeliveryAccResponseRealTimeDeliveryAccDataAccData> AccData { get; set; }
            public class DescribeLiveRealtimeDeliveryAccResponseRealTimeDeliveryAccDataAccData : TeaModel {
                public string TimeStamp { get; set; }
                public int? SuccessNum { get; set; }
                public int? FailedNum { get; set; }
            }
        };

    }

}
