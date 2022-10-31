// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTimeShiftDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeShiftData")]
        [Validation(Required=false)]
        public DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftData TimeShiftData { get; set; }
        public class DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftDataDataModule> DataModule { get; set; }
            public class DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftDataDataModule : TeaModel {
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
