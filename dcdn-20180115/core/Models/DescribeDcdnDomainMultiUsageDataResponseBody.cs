// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainMultiUsageDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerInterval RequestPerInterval { get; set; }
        public class DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerInterval : TeaModel {
            [NameInMap("RequestDataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule> RequestDataModule { get; set; }
            public class DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule : TeaModel {
                public string Type { get; set; }
                public string Domain { get; set; }
                public string TimeStamp { get; set; }
                public long? Request { get; set; }
            }
        };

        [NameInMap("TrafficPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerInterval TrafficPerInterval { get; set; }
        public class DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerInterval : TeaModel {
            [NameInMap("TrafficDataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule> TrafficDataModule { get; set; }
            public class DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule : TeaModel {
                public string Type { get; set; }
                public string Domain { get; set; }
                public string TimeStamp { get; set; }
                public string Area { get; set; }
                public float? Bps { get; set; }
            }
        };

    }

}
