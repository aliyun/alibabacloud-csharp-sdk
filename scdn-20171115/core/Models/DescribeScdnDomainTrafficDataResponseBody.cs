// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainTrafficDataResponseBody : TeaModel {
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
        public DescribeScdnDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeScdnDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                [NameInMap("HttpTrafficValue")]
                [Validation(Required=false)]
                public string HttpTrafficValue { get; set; }

                [NameInMap("HttpsTrafficValue")]
                [Validation(Required=false)]
                public string HttpsTrafficValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TrafficValue")]
                [Validation(Required=false)]
                public string TrafficValue { get; set; }

            }

        }

    }

}
