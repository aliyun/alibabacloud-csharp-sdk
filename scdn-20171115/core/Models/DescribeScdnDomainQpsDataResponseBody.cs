// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainQpsDataResponseBody : TeaModel {
        [NameInMap("QpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainQpsDataResponseBodyQpsDataPerInterval QpsDataPerInterval { get; set; }
        public class DescribeScdnDomainQpsDataResponseBodyQpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule : TeaModel {
                public string HttpsAccValue { get; set; }
                public string QpsValue { get; set; }
                public string AccValue { get; set; }
                public string HttpQpsValue { get; set; }
                public string TimeStamp { get; set; }
                public string HttpsQpsValue { get; set; }
                public string HttpAccValue { get; set; }
            }
        };

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

    }

}
