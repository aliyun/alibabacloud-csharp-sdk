// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainQpsDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("QpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainQpsDataResponseBodyQpsDataPerInterval QpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainQpsDataResponseBodyQpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule : TeaModel {
                public float? Acc { get; set; }
                public float? DynamicHttpAcc { get; set; }
                public float? DynamicHttpQps { get; set; }
                public float? DynamicHttpsAcc { get; set; }
                public float? DynamicHttpsQps { get; set; }
                public float? Qps { get; set; }
                public float? StaticHttpAcc { get; set; }
                public float? StaticHttpQps { get; set; }
                public float? StaticHttpsAcc { get; set; }
                public float? StaticHttpsQps { get; set; }
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
