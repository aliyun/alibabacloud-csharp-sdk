// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainUvDataResponseBody : TeaModel {
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

        [NameInMap("UvDataInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainUvDataResponseBodyUvDataInterval UvDataInterval { get; set; }
        public class DescribeScdnDomainUvDataResponseBodyUvDataInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainUvDataResponseBodyUvDataIntervalUsageData> UsageData { get; set; }
            public class DescribeScdnDomainUvDataResponseBodyUvDataIntervalUsageData : TeaModel {
                public string TimeStamp { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
