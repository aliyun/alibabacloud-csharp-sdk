// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainOriginBpsDataResponseBody : TeaModel {
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
        public DescribeScdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval OriginBpsDataPerInterval { get; set; }
        public class DescribeScdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule : TeaModel {
                public string HttpOriginBpsValue { get; set; }
                public string TimeStamp { get; set; }
                public string HttpsOriginBpsValue { get; set; }
                public string OriginBpsValue { get; set; }
            }
        };

    }

}
