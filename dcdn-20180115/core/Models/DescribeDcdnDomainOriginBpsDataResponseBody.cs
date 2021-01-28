// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainOriginBpsDataResponseBody : TeaModel {
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

        [NameInMap("OriginBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval OriginBpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule : TeaModel {
                public float? DynamicHttpOriginBps { get; set; }
                public float? StaticHttpOriginBps { get; set; }
                public string TimeStamp { get; set; }
                public float? StaticHttpsOriginBps { get; set; }
                public float? OriginBps { get; set; }
                public float? DynamicHttpsOriginBps { get; set; }
            }
        };

    }

}
