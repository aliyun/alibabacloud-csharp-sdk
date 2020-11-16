// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectPornDataRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

        [NameInMap("Fee")]
        [Validation(Required=false)]
        public string Fee { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

    }

}
