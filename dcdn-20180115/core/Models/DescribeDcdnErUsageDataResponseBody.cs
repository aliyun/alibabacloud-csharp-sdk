// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnErUsageDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ErAccData")]
        [Validation(Required=false)]
        public DescribeDcdnErUsageDataResponseBodyErAccData ErAccData { get; set; }
        public class DescribeDcdnErUsageDataResponseBodyErAccData : TeaModel {
            [NameInMap("ErAccItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnErUsageDataResponseBodyErAccDataErAccItem> ErAccItem { get; set; }
            public class DescribeDcdnErUsageDataResponseBodyErAccDataErAccItem : TeaModel {
                public long? ErAcc { get; set; }
                public string Routine { get; set; }
                public string Spec { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
