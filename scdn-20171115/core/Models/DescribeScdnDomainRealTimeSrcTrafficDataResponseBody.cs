// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainRealTimeSrcTrafficDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("RealTimeSrcTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainRealTimeSrcTrafficDataResponseBodyRealTimeSrcTrafficDataPerInterval RealTimeSrcTrafficDataPerInterval { get; set; }
        public class DescribeScdnDomainRealTimeSrcTrafficDataResponseBodyRealTimeSrcTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainRealTimeSrcTrafficDataResponseBodyRealTimeSrcTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainRealTimeSrcTrafficDataResponseBodyRealTimeSrcTrafficDataPerIntervalDataModule : TeaModel {
                public string Value { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
