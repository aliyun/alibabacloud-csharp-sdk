// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public string EndTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=true)]
        public string DataInterval { get; set; }

        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=true)]
        public DescribeLiveDomainBpsDataResponseBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeLiveDomainBpsDataResponseBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainBpsDataResponseBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainBpsDataResponseBpsDataPerIntervalDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string BpsValue { get; set; }
                public string HttpBpsValue { get; set; }
                public string HttpsBpsValue { get; set; }
            }
        };

    }

}
