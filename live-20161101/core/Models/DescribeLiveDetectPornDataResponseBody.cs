// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectPornDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DetectPornData")]
        [Validation(Required=false)]
        public DescribeLiveDetectPornDataResponseBodyDetectPornData DetectPornData { get; set; }
        public class DescribeLiveDetectPornDataResponseBodyDetectPornData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDetectPornDataResponseBodyDetectPornDataDataModule> DataModule { get; set; }
            public class DescribeLiveDetectPornDataResponseBodyDetectPornDataDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string App { get; set; }
                public string Domain { get; set; }
                public string Stream { get; set; }
                public string Fee { get; set; }
                public string Scene { get; set; }
                public string Region { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}
