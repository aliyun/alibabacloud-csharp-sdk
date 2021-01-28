// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeBpsDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeBpsDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeBpsDataResponseBodyData : TeaModel {
            [NameInMap("BpsModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeBpsDataResponseBodyDataBpsModel> BpsModel { get; set; }
            public class DescribeDcdnDomainRealTimeBpsDataResponseBodyDataBpsModel : TeaModel {
                public string TimeStamp { get; set; }
                public float? Bps { get; set; }
            }
        };

    }

}
