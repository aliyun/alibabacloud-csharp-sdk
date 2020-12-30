// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainHitRateDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HitRateInterval")]
        [Validation(Required=false)]
        public DescribeDomainHitRateDataResponseBodyHitRateInterval HitRateInterval { get; set; }
        public class DescribeDomainHitRateDataResponseBodyHitRateInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainHitRateDataResponseBodyHitRateIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainHitRateDataResponseBodyHitRateIntervalDataModule : TeaModel {
                public string Value { get; set; }
                public string HttpsValue { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

    }

}
