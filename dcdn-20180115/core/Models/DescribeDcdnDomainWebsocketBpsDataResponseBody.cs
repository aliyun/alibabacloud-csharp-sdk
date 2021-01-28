// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainWebsocketBpsDataResponseBody : TeaModel {
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

        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainWebsocketBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainWebsocketBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainWebsocketBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainWebsocketBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                public float? WebsocketBps { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
