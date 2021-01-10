// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealTimeTrafficDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RealTimeTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeLiveDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerInterval RealTimeTrafficDataPerInterval { get; set; }
        public class DescribeLiveDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerIntervalDataModule : TeaModel {
                public string Value { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

    }

}
