// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByLayerResponseBody : TeaModel {
        [NameInMap("BpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainBpsDataByLayerResponseBodyBpsDataInterval BpsDataInterval { get; set; }
        public class DescribeDomainBpsDataByLayerResponseBodyBpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string TrafficValue { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
