// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetBucketDeleteTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public GetBucketDeleteTaskResponseBodyTaskInfo TaskInfo { get; set; }
        public class GetBucketDeleteTaskResponseBodyTaskInfo : TeaModel {
            [NameInMap("AttachedMediaRemain")]
            [Validation(Required=false)]
            public long? AttachedMediaRemain { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DeleteFiles")]
            [Validation(Required=false)]
            public bool? DeleteFiles { get; set; }

            [NameInMap("ImageRemain")]
            [Validation(Required=false)]
            public long? ImageRemain { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

            [NameInMap("VideoRemain")]
            [Validation(Required=false)]
            public long? VideoRemain { get; set; }

        }

    }

}
