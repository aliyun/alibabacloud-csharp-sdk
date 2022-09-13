// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTrafficDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                [NameInMap("DynamicHttpTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpTraffic { get; set; }

                [NameInMap("DynamicHttpsTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpsTraffic { get; set; }

                [NameInMap("StaticHttpTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpTraffic { get; set; }

                [NameInMap("StaticHttpsTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpsTraffic { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public float? Traffic { get; set; }

            }

        }

    }

}
