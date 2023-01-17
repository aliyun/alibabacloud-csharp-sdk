// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainBpsDataResponseBody : TeaModel {
        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeScdnDomainBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                [NameInMap("BpsValue")]
                [Validation(Required=false)]
                public string BpsValue { get; set; }

                [NameInMap("HttpBpsValue")]
                [Validation(Required=false)]
                public string HttpBpsValue { get; set; }

                [NameInMap("HttpsBpsValue")]
                [Validation(Required=false)]
                public string HttpsBpsValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

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

    }

}
