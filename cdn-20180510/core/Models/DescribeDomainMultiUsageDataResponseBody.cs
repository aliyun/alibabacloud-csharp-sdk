// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMultiUsageDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainMultiUsageDataResponseBodyRequestPerInterval RequestPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyRequestPerInterval : TeaModel {
            [NameInMap("RequestDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule> RequestDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule : TeaModel {
                public string Domain { get; set; }
                public long? Request { get; set; }
                public string TimeStamp { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TrafficPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval TrafficPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval : TeaModel {
            [NameInMap("TrafficDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule> TrafficDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule : TeaModel {
                public string Area { get; set; }
                public float? Bps { get; set; }
                public string Domain { get; set; }
                public string TimeStamp { get; set; }
                public string Type { get; set; }
            }
        };

    }

}
