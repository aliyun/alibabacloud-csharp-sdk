// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetUserSubmissionStatisticInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserSubmissionList")]
        [Validation(Required=false)]
        public GetUserSubmissionStatisticInfoResponseBodyUserSubmissionList UserSubmissionList { get; set; }
        public class GetUserSubmissionStatisticInfoResponseBodyUserSubmissionList : TeaModel {
            [NameInMap("ClusterStatUserSubmission")]
            [Validation(Required=false)]
            public List<GetUserSubmissionStatisticInfoResponseBodyUserSubmissionListClusterStatUserSubmission> ClusterStatUserSubmission { get; set; }
            public class GetUserSubmissionStatisticInfoResponseBodyUserSubmissionListClusterStatUserSubmission : TeaModel {
                public long? Submission { get; set; }
                public string User { get; set; }
            }
        };

    }

}
