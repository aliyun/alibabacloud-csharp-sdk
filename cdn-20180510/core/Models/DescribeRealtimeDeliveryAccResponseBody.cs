// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRealtimeDeliveryAccResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReatTimeDeliveryAccData")]
        [Validation(Required=false)]
        public DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccData ReatTimeDeliveryAccData { get; set; }
        public class DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccData : TeaModel {
            [NameInMap("AccData")]
            [Validation(Required=false)]
            public List<DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccDataAccData> AccData { get; set; }
            public class DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccDataAccData : TeaModel {
                public string TimeStamp { get; set; }
                public int? FailedNum { get; set; }
                public int? SuccessNum { get; set; }
            }
        };

    }

}
