// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetQueueSubmissionStatisticInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QueueSubmissionList")]
        [Validation(Required=false)]
        public GetQueueSubmissionStatisticInfoResponseBodyQueueSubmissionList QueueSubmissionList { get; set; }
        public class GetQueueSubmissionStatisticInfoResponseBodyQueueSubmissionList : TeaModel {
            [NameInMap("ClusterStatQueueSubmission")]
            [Validation(Required=false)]
            public List<GetQueueSubmissionStatisticInfoResponseBodyQueueSubmissionListClusterStatQueueSubmission> ClusterStatQueueSubmission { get; set; }
            public class GetQueueSubmissionStatisticInfoResponseBodyQueueSubmissionListClusterStatQueueSubmission : TeaModel {
                public long? Submission { get; set; }
                public string Queue { get; set; }
            }
        };

    }

}
