// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainHttpCodeDataByLayerResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("HttpCodeDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval HttpCodeDataInterval { get; set; }
        public class DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string TotalValue { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
