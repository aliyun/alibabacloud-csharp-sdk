// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainQpsDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainQpsDataResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeDomainQpsDataResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainQpsDataResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainQpsDataResponseBodyQpsDataIntervalDataModule : TeaModel {
                public string AccValue { get; set; }
                public string AccDomesticValue { get; set; }
                public string AccOverseasValue { get; set; }
                public string HttpsValue { get; set; }
                public string HttpsOverseasValue { get; set; }
                public string DomesticValue { get; set; }
                public string HttpsAccOverseasValue { get; set; }
                public string HttpsDomesticValue { get; set; }
                public string HttpsAccValue { get; set; }
                public string Value { get; set; }
                public string OverseasValue { get; set; }
                public string TimeStamp { get; set; }
                public string HttpsAccDomesticValue { get; set; }
            }
        };

    }

}
