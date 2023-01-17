// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainHitRateDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("HitRatePerInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainHitRateDataResponseBodyHitRatePerInterval HitRatePerInterval { get; set; }
        public class DescribeScdnDomainHitRateDataResponseBodyHitRatePerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainHitRateDataResponseBodyHitRatePerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainHitRateDataResponseBodyHitRatePerIntervalDataModule : TeaModel {
                [NameInMap("ByteHitRate")]
                [Validation(Required=false)]
                public string ByteHitRate { get; set; }

                [NameInMap("ReqHitRate")]
                [Validation(Required=false)]
                public string ReqHitRate { get; set; }

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
