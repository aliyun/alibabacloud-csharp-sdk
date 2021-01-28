// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainHitRateDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("HitRatePerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainHitRateDataResponseBodyHitRatePerInterval HitRatePerInterval { get; set; }
        public class DescribeDcdnDomainHitRateDataResponseBodyHitRatePerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainHitRateDataResponseBodyHitRatePerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainHitRateDataResponseBodyHitRatePerIntervalDataModule : TeaModel {
                public float? ByteHitRate { get; set; }
                public float? ReqHitRate { get; set; }
                public string TimeStamp { get; set; }
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
