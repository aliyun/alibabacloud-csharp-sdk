// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealTimeTrafficDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public string EndTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=true)]
        public string DataInterval { get; set; }

        [NameInMap("RealTimeTrafficDataPerInterval")]
        [Validation(Required=true)]
        public DescribeLiveDomainRealTimeTrafficDataResponseRealTimeTrafficDataPerInterval RealTimeTrafficDataPerInterval { get; set; }
        public class DescribeLiveDomainRealTimeTrafficDataResponseRealTimeTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainRealTimeTrafficDataResponseRealTimeTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainRealTimeTrafficDataResponseRealTimeTrafficDataPerIntervalDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
