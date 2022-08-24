// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafUsageDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("WafUsageData")]
        [Validation(Required=false)]
        public DescribeDcdnWafUsageDataResponseBodyWafUsageData WafUsageData { get; set; }
        public class DescribeDcdnWafUsageDataResponseBodyWafUsageData : TeaModel {
            [NameInMap("WafUsageDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafUsageDataResponseBodyWafUsageDataWafUsageDataItem> WafUsageDataItem { get; set; }
            public class DescribeDcdnWafUsageDataResponseBodyWafUsageDataWafUsageDataItem : TeaModel {
                public long? AccessCnt { get; set; }
                public long? BlockCnt { get; set; }
                public string Domain { get; set; }
                public long? ObserveCnt { get; set; }
                public long? SecCu { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
