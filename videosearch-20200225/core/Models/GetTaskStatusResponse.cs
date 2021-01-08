// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class GetTaskStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public int? Data { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=true)]
        public GetTaskStatusResponseTaskInfo TaskInfo { get; set; }
        public class GetTaskStatusResponseTaskInfo : TeaModel {
            [NameInMap("AnalysisUseTime")]
            [Validation(Required=true)]
            public long? AnalysisUseTime { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=true)]
            public float? Duration { get; set; }
            [NameInMap("ProcessResultOss")]
            [Validation(Required=true)]
            public string ProcessResultOss { get; set; }
            [NameInMap("Resolution")]
            [Validation(Required=true)]
            public string Resolution { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }
            [NameInMap("SubmitTime")]
            [Validation(Required=true)]
            public long? SubmitTime { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=true)]
            public long? FinishTime { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=true)]
            public long? TaskId { get; set; }
            [NameInMap("ErrorInfo")]
            [Validation(Required=true)]
            public string ErrorInfo { get; set; }
            [NameInMap("StorageInfo")]
            [Validation(Required=true)]
            public int? StorageInfo { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("VideoId")]
            [Validation(Required=true)]
            public string VideoId { get; set; }
            [NameInMap("VideoTags")]
            [Validation(Required=true)]
            public string VideoTags { get; set; }
            [NameInMap("VideoUrl")]
            [Validation(Required=true)]
            public string VideoUrl { get; set; }
            [NameInMap("QueryTags")]
            [Validation(Required=true)]
            public string QueryTags { get; set; }
            [NameInMap("ResourceType")]
            [Validation(Required=true)]
            public string ResourceType { get; set; }
            [NameInMap("ReplaceStorageThreshold")]
            [Validation(Required=true)]
            public string ReplaceStorageThreshold { get; set; }
        };

    }

}
