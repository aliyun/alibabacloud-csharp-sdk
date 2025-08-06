// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListBucketRedundancyTransitionResponseBody : TeaModel {
        [NameInMap("RedundancyTransitionInfo")]
        [Validation(Required=false)]
        public ListBucketRedundancyTransitionResponseBodyRedundancyTransitionInfo RedundancyTransitionInfo { get; set; }
        public class ListBucketRedundancyTransitionResponseBodyRedundancyTransitionInfo : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EstimatedRemainingTime")]
            [Validation(Required=false)]
            public string EstimatedRemainingTime { get; set; }

            [NameInMap("ProcessPercentage")]
            [Validation(Required=false)]
            public string ProcessPercentage { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageRedundancyType")]
        [Validation(Required=false)]
        public string StorageRedundancyType { get; set; }

    }

}
