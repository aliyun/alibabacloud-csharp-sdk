// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ModelTask : TeaModel {
        [NameInMap("currentBytes")]
        [Validation(Required=false)]
        public string CurrentBytes { get; set; }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public object Extra { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        [Obsolete]
        public double? FileSize { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        [Obsolete]
        public double? FinishTime { get; set; }

        [NameInMap("finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        [NameInMap("finishedTime")]
        [Validation(Required=false)]
        public double? FinishedTime { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public object Result { get; set; }

        [NameInMap("speed")]
        [Validation(Required=false)]
        public string Speed { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("total")]
        [Validation(Required=false)]
        [Obsolete]
        public float? Total { get; set; }

        [NameInMap("totalBytes")]
        [Validation(Required=false)]
        public string TotalBytes { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public double? UpdateTime { get; set; }

    }

}
