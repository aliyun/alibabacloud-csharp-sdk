// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeDomainUsageDataResponseBody : TeaModel {
        [NameInMap("UsageDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainUsageDataResponseBodyUsageDataPerInterval UsageDataPerInterval { get; set; }
        public class DescribeDomainUsageDataResponseBodyUsageDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainUsageDataResponseBodyUsageDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainUsageDataResponseBodyUsageDataPerIntervalDataModule : TeaModel {
                public string Value { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

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

    }

}
