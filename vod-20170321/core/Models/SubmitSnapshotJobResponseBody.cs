// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitSnapshotJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotJob")]
        [Validation(Required=false)]
        public SubmitSnapshotJobResponseBodySnapshotJob SnapshotJob { get; set; }
        public class SubmitSnapshotJobResponseBodySnapshotJob : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
        };

    }

}
