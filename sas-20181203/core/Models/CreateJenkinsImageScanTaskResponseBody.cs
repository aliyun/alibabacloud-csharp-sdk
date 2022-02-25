// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageScanTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateJenkinsImageScanTaskResponseBodyData Data { get; set; }
        public class CreateJenkinsImageScanTaskResponseBodyData : TeaModel {
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public long? ImageScanCapacity { get; set; }
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }
            [NameInMap("RepoInstanceId")]
            [Validation(Required=false)]
            public string RepoInstanceId { get; set; }
            [NameInMap("RepoRegionId")]
            [Validation(Required=false)]
            public string RepoRegionId { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
