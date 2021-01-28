// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeQpsDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                public float? Qps { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
