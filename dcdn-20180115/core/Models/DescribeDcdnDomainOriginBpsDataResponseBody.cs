// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainOriginBpsDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OriginBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval OriginBpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule : TeaModel {
                [NameInMap("DynamicHttpOriginBps")]
                [Validation(Required=false)]
                public float? DynamicHttpOriginBps { get; set; }

                [NameInMap("DynamicHttpsOriginBps")]
                [Validation(Required=false)]
                public float? DynamicHttpsOriginBps { get; set; }

                [NameInMap("OriginBps")]
                [Validation(Required=false)]
                public float? OriginBps { get; set; }

                [NameInMap("StaticHttpOriginBps")]
                [Validation(Required=false)]
                public float? StaticHttpOriginBps { get; set; }

                [NameInMap("StaticHttpsOriginBps")]
                [Validation(Required=false)]
                public float? StaticHttpsOriginBps { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
