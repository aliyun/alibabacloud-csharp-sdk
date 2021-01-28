// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainPvDataResponseBody : TeaModel {
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

        [NameInMap("PvDataInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainPvDataResponseBodyPvDataInterval PvDataInterval { get; set; }
        public class DescribeDcdnDomainPvDataResponseBodyPvDataInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainPvDataResponseBodyPvDataIntervalUsageData> UsageData { get; set; }
            public class DescribeDcdnDomainPvDataResponseBodyPvDataIntervalUsageData : TeaModel {
                public string Value { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
