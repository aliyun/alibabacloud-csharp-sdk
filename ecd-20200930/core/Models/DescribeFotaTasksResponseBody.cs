// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaTasksResponseBody : TeaModel {
        [NameInMap("FotaTasks")]
        [Validation(Required=false)]
        public List<DescribeFotaTasksResponseBodyFotaTasks> FotaTasks { get; set; }
        public class DescribeFotaTasksResponseBodyFotaTasks : TeaModel {
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            [NameInMap("PendingDesktopCount")]
            [Validation(Required=false)]
            public int? PendingDesktopCount { get; set; }

            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskUid")]
            [Validation(Required=false)]
            public string TaskUid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
