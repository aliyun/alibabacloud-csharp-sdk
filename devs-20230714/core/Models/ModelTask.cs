// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ModelTask : TeaModel {
        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public double? FileSize { get; set; }

        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public double? FinishTime { get; set; }

        [NameInMap("finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public float? Total { get; set; }

    }

}
