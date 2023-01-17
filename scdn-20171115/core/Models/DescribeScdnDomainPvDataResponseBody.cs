// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainPvDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PvDataInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainPvDataResponseBodyPvDataInterval PvDataInterval { get; set; }
        public class DescribeScdnDomainPvDataResponseBodyPvDataInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainPvDataResponseBodyPvDataIntervalUsageData> UsageData { get; set; }
            public class DescribeScdnDomainPvDataResponseBodyPvDataIntervalUsageData : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

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
