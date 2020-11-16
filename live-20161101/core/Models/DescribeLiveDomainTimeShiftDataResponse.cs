// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTimeShiftDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TimeShiftData")]
        [Validation(Required=true)]
        public DescribeLiveDomainTimeShiftDataResponseTimeShiftData TimeShiftData { get; set; }
        public class DescribeLiveDomainTimeShiftDataResponseTimeShiftData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainTimeShiftDataResponseTimeShiftDataDataModule> DataModule { get; set; }
            public class DescribeLiveDomainTimeShiftDataResponseTimeShiftDataDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string Size { get; set; }
                public string Type { get; set; }
            }
        };

    }

}
