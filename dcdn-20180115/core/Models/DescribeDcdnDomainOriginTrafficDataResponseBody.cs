// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainOriginTrafficDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OriginTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerInterval OriginTrafficDataPerInterval { get; set; }
        public class DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerIntervalDataModule : TeaModel {
                [NameInMap("DynamicHttpOriginTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpOriginTraffic { get; set; }

                [NameInMap("DynamicHttpsOriginTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpsOriginTraffic { get; set; }

                [NameInMap("OriginTraffic")]
                [Validation(Required=false)]
                public float? OriginTraffic { get; set; }

                [NameInMap("StaticHttpOriginTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpOriginTraffic { get; set; }

                [NameInMap("StaticHttpsOriginTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpsOriginTraffic { get; set; }

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
