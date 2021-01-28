// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTrafficDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                public float? StaticHttpTraffic { get; set; }
                public float? DynamicHttpsTraffic { get; set; }
                public float? Traffic { get; set; }
                public float? DynamicHttpTraffic { get; set; }
                public string TimeStamp { get; set; }
                public float? StaticHttpsTraffic { get; set; }
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
