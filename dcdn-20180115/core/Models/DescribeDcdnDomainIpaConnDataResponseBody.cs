// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainIpaConnDataResponseBody : TeaModel {
        [NameInMap("ConnectionDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerInterval ConnectionDataPerInterval { get; set; }
        public class DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerIntervalDataModule : TeaModel {
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
