// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetJob : TeaModel {
        [NameInMap("CompletedFileCount")]
        [Validation(Required=false)]
        public long? CompletedFileCount { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DatasetJobId")]
        [Validation(Required=false)]
        public string DatasetJobId { get; set; }

        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FailedFileCount")]
        [Validation(Required=false)]
        public long? FailedFileCount { get; set; }

        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        [NameInMap("JobMode")]
        [Validation(Required=false)]
        public string JobMode { get; set; }

        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public string JobSpec { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<string> Logs { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TotalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
