// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBgpTrafficDataResponseBody : TeaModel {
        [NameInMap("BgpDataInterval")]
        [Validation(Required=false)]
        public List<DescribeDcdnBgpTrafficDataResponseBodyBgpDataInterval> BgpDataInterval { get; set; }
        public class DescribeDcdnBgpTrafficDataResponseBodyBgpDataInterval : TeaModel {
            [NameInMap("In")]
            [Validation(Required=false)]
            public long? In { get; set; }

            [NameInMap("Out")]
            [Validation(Required=false)]
            public long? Out { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
