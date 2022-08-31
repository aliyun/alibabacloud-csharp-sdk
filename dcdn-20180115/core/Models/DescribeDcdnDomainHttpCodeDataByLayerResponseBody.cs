// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainHttpCodeDataByLayerResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("HttpCodeDataInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval HttpCodeDataInterval { get; set; }
        public class DescribeDcdnDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string TotalValue { get; set; }
                public Dictionary<string, string> Value { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
