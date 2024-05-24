// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ProjectStatus : TeaModel {
        [NameInMap("latestReleaseDetail")]
        [Validation(Required=false)]
        public ReleaseDetail LatestReleaseDetail { get; set; }

        [NameInMap("observedGeneration")]
        [Validation(Required=false)]
        public long? ObservedGeneration { get; set; }

        [NameInMap("observedTime")]
        [Validation(Required=false)]
        public string ObservedTime { get; set; }

    }

}
