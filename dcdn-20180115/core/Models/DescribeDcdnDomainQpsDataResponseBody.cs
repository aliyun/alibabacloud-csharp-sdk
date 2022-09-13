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
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public float? Acc { get; set; }

                [NameInMap("DynamicHttpAcc")]
                [Validation(Required=false)]
                public float? DynamicHttpAcc { get; set; }

                [NameInMap("DynamicHttpQps")]
                [Validation(Required=false)]
                public float? DynamicHttpQps { get; set; }

                [NameInMap("DynamicHttpsAcc")]
                [Validation(Required=false)]
                public float? DynamicHttpsAcc { get; set; }

                [NameInMap("DynamicHttpsQps")]
                [Validation(Required=false)]
                public float? DynamicHttpsQps { get; set; }

                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                [NameInMap("StaticHttpAcc")]
                [Validation(Required=false)]
                public float? StaticHttpAcc { get; set; }

                [NameInMap("StaticHttpQps")]
                [Validation(Required=false)]
                public float? StaticHttpQps { get; set; }

                [NameInMap("StaticHttpsAcc")]
                [Validation(Required=false)]
                public float? StaticHttpsAcc { get; set; }

                [NameInMap("StaticHttpsQps")]
                [Validation(Required=false)]
                public float? StaticHttpsQps { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

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
