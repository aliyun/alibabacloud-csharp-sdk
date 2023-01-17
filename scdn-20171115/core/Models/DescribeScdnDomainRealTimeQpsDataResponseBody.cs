// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainRealTimeQpsDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScdnDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeScdnDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeScdnDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
