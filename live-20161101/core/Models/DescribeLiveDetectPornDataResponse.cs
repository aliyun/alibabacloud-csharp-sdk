// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectPornDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DetectPornData")]
        [Validation(Required=true)]
        public DescribeLiveDetectPornDataResponseDetectPornData DetectPornData { get; set; }
        public class DescribeLiveDetectPornDataResponseDetectPornData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=true)]
            public List<DescribeLiveDetectPornDataResponseDetectPornDataDataModule> DataModule { get; set; }
            public class DescribeLiveDetectPornDataResponseDetectPornDataDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string App { get; set; }
                public string Domain { get; set; }
                public string Stream { get; set; }
                public string Fee { get; set; }
                public string Scene { get; set; }
                public string Region { get; set; }
                public long Count { get; set; }
            }
        };

    }

}
