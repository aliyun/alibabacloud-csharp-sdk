// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainQpsDataByLayerResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainQpsDataByLayerResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeDomainQpsDataByLayerResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainQpsDataByLayerResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainQpsDataByLayerResponseBodyQpsDataIntervalDataModule : TeaModel {
                public string Value { get; set; }
                public string AccValue { get; set; }
                public string AccDomesticValue { get; set; }
                public string OverseasValue { get; set; }
                public string AccOverseasValue { get; set; }
                public string TimeStamp { get; set; }
                public string DomesticValue { get; set; }
            }
        };

    }

}
