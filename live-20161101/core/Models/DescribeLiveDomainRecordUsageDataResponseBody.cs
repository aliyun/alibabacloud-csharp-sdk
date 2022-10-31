// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRecordUsageDataResponseBody : TeaModel {
        [NameInMap("RecordUsageData")]
        [Validation(Required=false)]
        public DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageData RecordUsageData { get; set; }
        public class DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageDataDataModule> DataModule { get; set; }
            public class DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageDataDataModule : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
